Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Public Class checkout

    Dim strFood, strDrink, strSide As String
    Dim dblTotal As Double
    Dim startupPath As String = Application.StartupPath
    Dim directoryInfo As New DirectoryInfo(startupPath)
    Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent
    Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        MessageBox.Show("You will be using cash", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
        strFood = lblFood.Text
        strDrink = lblDrinks.Text
        strSide = lblSides.Text
        Dim totalText As String = lblTotal.Text.Replace("RM", "").Replace(",", "").Trim()
        Dim dblTotal As Double
        If Double.TryParse(totalText, dblTotal) Then
            CheckoutToDB(strFood, strDrink, strSide, dblTotal)
        Else
            MessageBox.Show("Total price format is incorrect. Please check the value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckoutToPayment("Cash")
        Dim result As Integer
        result = MessageBox.Show("Do you want to save your receipt ?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            SaveReceipt()
        End If
        clearModule()
        Me.Close()
        home.Show()
    End Sub

    Private Sub btnFPX_Click(sender As Object, e As EventArgs) Handles btnFPX.Click
        MessageBox.Show("You will be using FPX", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
        strFood = lblFood.Text
        strDrink = lblDrinks.Text
        strSide = lblSides.Text

        Dim totalText As String = lblTotal.Text.Replace("RM", "").Replace(",", "").Trim()
        Dim dblTotal As Double
        If Double.TryParse(totalText, dblTotal) Then
            CheckoutToDB(strFood, strDrink, strSide, dblTotal)
        Else
            MessageBox.Show("Total price format is incorrect. Please check the value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckoutToPayment("FPX")
        Dim result As Integer
        result = MessageBox.Show("Do you want to save your receipt ?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            SaveReceipt()
        End If
        clearModule()
        Me.Close()
        home.Show()

    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        MessageBox.Show("You will be using card", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
        strFood = lblFood.Text
        strDrink = lblDrinks.Text
        strSide = lblSides.Text

        Dim totalText As String = lblTotal.Text.Replace("RM", "").Replace(",", "").Trim()
        Dim dblTotal As Double
        If Double.TryParse(totalText, dblTotal) Then
            CheckoutToDB(strFood, strDrink, strSide, dblTotal)
        Else
            MessageBox.Show("Total price format is incorrect. Please check the value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CheckoutToPayment("Card")
        Dim result As Integer
        result = MessageBox.Show("Do you want to save your receipt ?", "Receipt", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            SaveReceipt()
        End If
        clearModule()
        Me.Close()
        home.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFood.Text = String.Join(", ", Module1.SelectedFood)
        lblDrinks.Text = String.Join(", ", Module1.SelectedDrink)
        lblSides.Text = String.Join(", ", Module1.SelectedSides)
        lblTotal.Text = "RM" + String.Join(", ", Module1.SelectedTotal)
        Me.BackgroundImage = Module1.bg.First()
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub


    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        clearModule()
        Me.Close()
        OrderMenu.Show()
    End Sub

    Private Sub clearModule()
        lblDrinks.Text = String.Empty
        lblFood.Text = String.Empty
        lblSides.Text = String.Empty
        lblTotal.Text = String.Empty

        Module1.SelectedTotal.Clear()
        Module1.SelectedFood.Clear()
        Module1.SelectedDrink.Clear()
        Module1.SelectedSides.Clear()
    End Sub

    Private Sub CheckoutToDB(food As String, drinks As String, sides As String, totalprice As Double)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("INSERT INTO Receipt(CurrentDate, FoodName, DrinksName, SidesName, TotalPrice) VALUES(@da, @f, @d, @s, @t)", connection)
            command.Parameters.AddWithValue("@da", DateTime.Now.ToString("dd/MM/yyyy"))
            command.Parameters.AddWithValue("@f", food)
            command.Parameters.AddWithValue("@d", drinks)
            command.Parameters.AddWithValue("@s", sides)
            command.Parameters.AddWithValue("@t", totalprice)
            command.ExecuteNonQuery()

            Dim command1 As New OleDbCommand("SELECT TOP 1 RECEIPT_ID FROM RECEIPT ORDER BY RECEIPT_ID DESC", connection)
            Module1.RECEIPTID.Clear()
            Module1.RECEIPTID.Add(command1.ExecuteScalar())
            connection.Close()
        End Using
    End Sub

    Private Sub CheckoutToPayment(method As String)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim command As New OleDbCommand("INSERT INTO Payment(CUST_ID, RECEIPT_ID, PaymentMethod) VALUES(@c, @r, @pm)", connection)
            command.Parameters.AddWithValue("@c", Module1.CUSTID.First())
            command.Parameters.AddWithValue("@r", Module1.RECEIPTID.First())
            command.Parameters.AddWithValue("@pm", method)
            command.ExecuteNonQuery()
            connection.Close()
        End Using
    End Sub

    Private Sub SaveReceipt()
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        SaveFileDialog1.Title = "Save Receipt"
        SaveFileDialog1.FileName = "Receipt.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                SaveReceiptToFile(SaveFileDialog1.FileName)
                MessageBox.Show("Receipt saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving receipt: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SaveReceiptToFile(filePath As String)
        Dim receiptText As String = GenerateReceiptText()
        ' Save the receipt text to the specified file path
        File.WriteAllText(filePath, receiptText)
    End Sub

    Private Function GenerateReceiptText() As String
        ' Generate receipt text from labels
        Dim receiptBuilder As New StringBuilder()
        receiptBuilder.AppendLine("********** Receipt **********")
        receiptBuilder.AppendLine("FoodCheetah, Your Food Ordering Buddy!")
        receiptBuilder.AppendLine("Date: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
        receiptBuilder.AppendLine("-----------------------------")
        receiptBuilder.AppendLine("Order Summary:")
        receiptBuilder.AppendLine("Food: " & lblFood.Text)
        receiptBuilder.AppendLine("Drinks: " & lblDrinks.Text)
        receiptBuilder.AppendLine("Sides: " & lblSides.Text)
        receiptBuilder.AppendLine("-----------------------------")
        receiptBuilder.AppendLine("Total payment: " & lblTotal.Text)
        receiptBuilder.AppendLine("-----------------------------")
        receiptBuilder.AppendLine("Thank you for your purchase!")
        receiptBuilder.AppendLine("*****************************")
        Return receiptBuilder.ToString()
    End Function

End Class
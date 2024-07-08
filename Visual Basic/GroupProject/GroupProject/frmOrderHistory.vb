Imports System.Data.OleDb
Imports System.IO
Public Class frmOrderHistory
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub frmOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim startupPath As String = Application.StartupPath
        Dim directoryInfo As New DirectoryInfo(startupPath)
        Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent
        Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile

        Dim commandText As String = "SELECT R.Receipt_ID, R.TotalPrice, R.DrinksName, R.SidesName, R.FoodName, R.CurrentDate, P.PaymentMethod " &
                            "FROM Receipt AS R " &
                            "INNER JOIN (SELECT Receipt_ID, PaymentMethod FROM Payment WHERE Cust_ID = ?) AS P " &
                            "ON R.Receipt_ID = P.Receipt_ID;"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(commandText, connection)
                command.Parameters.AddWithValue("CustIDParam", Module1.CUSTID.First())
                connection.Open()

                ' Execute the query and process the results
                Dim reader As OleDbDataReader = command.ExecuteReader()

                Do While reader.Read()
                    ' Process each row here
                    Dim receiptId As Integer = reader.GetInt32(reader.GetOrdinal("Receipt_ID"))
                    Dim totalPrice As Decimal = reader.GetDecimal(reader.GetOrdinal("TotalPrice"))
                    Dim drinksName As String = reader.GetString(reader.GetOrdinal("DrinksName"))
                    Dim sidesName As String = reader.GetString(reader.GetOrdinal("SidesName"))
                    Dim foodName As String = reader.GetString(reader.GetOrdinal("FoodName"))
                    Dim currentDate As Date = reader.GetDateTime(reader.GetOrdinal("CurrentDate"))
                    Dim paymentMethod As String = reader.GetString(reader.GetOrdinal("PaymentMethod"))

                    ' Add row to the DataGridView
                    DataGridView1.Rows.Add(receiptId, totalPrice, drinksName, sidesName, foodName, currentDate, paymentMethod)
                Loop
            End Using
        End Using
    End Sub

End Class

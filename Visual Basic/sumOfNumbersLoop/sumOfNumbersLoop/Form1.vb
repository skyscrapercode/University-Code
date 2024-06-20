Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Dim strNumberEntered As String
        Dim intNumberEntered, intResult As Integer
        strNumberEntered = InputBox("Enter a positive integer number", "Input Needed", 10)

        Integer.TryParse(strNumberEntered, intNumberEntered)

        For intNumber As Integer = 1 To intNumberEntered
            intResult += intNumber
        Next

        MsgBox("The sum of the numbers 1 through " & intNumberEntered.ToString() & " is " & intResult.ToString(),, "Sum of Numbers")
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        Const intNUM_DAYS As Integer = 5 ' number of days
        Dim intCount As Integer = 1 'loop counter
        Dim decSales As Decimal = 0 'hold daily sales
        Dim strInput As String 'To Hold The String Input
        Dim decTotal As Decimal = 0
        Do While intCount <= intNUM_DAYS
            strInput = InputBox("Enter sales for Day " & intCount.ToString)
            Decimal.TryParse(strInput, decSales)

            lstOutput.Items.Add("Day " & intCount.ToString() & ":" & decSales.ToString("C2"))
            lstOutput.Items.Add(vbNewLine)

            decTotal += decSales

            intCount += 1
        Loop

        lstOutput.Items.Add("Total sales: " & decTotal.ToString("C2"))

    End Sub
End Class

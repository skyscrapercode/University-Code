Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intMonth As Integer

        Integer.TryParse(txtInputMonth.Text, intMonth)

        If intMonth = 0 Then
            lblMessage.Text = "Please insert an integer value only"
        Else
            lblMessage.Text = "The month is " & intMonth
        End If
    End Sub
End Class

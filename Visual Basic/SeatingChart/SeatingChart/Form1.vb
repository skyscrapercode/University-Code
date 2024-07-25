Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        Dim intRow, intCol As Integer

        Dim decPrice(,) As Decimal = {{450D, 450D, 450D, 450D},
                                        {425D, 425D, 425D, 425D},
                                        {400D, 400D, 400D, 400D},
                                        {375D, 375D, 375D, 375D},
                                        {370D, 370D, 370D, 370D},
                                        {360D, 360D, 360D, 360D}}

        Integer.TryParse(txtRowInput.Text, intRow)
        Integer.TryParse(txtColumnInput.Text, intCol)

        'Make sure row and column are within range
        If intRow >= 0 And intCol <= 5 Then
            If intCol >= 0 And intCol <= 3 Then
                lblBestPrice.Text = decPrice(intRow, intCol).ToString("C2")

            Else
                MsgBox("Column must be 0 through 3", 0 Or 16, "Error Message")
            End If
        Else
            MsgBox("Row must be 0 through 5", 0 Or 16, "Error Message")
        End If

    End Sub
End Class

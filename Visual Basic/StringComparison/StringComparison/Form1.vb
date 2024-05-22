Public Class Form1
    Private Sub txtExit_Click(sender As Object, e As EventArgs) Handles txtExit.Click
        Me.Close()
    End Sub

    Private Sub txtOK_Click(sender As Object, e As EventArgs) Handles txtOK.Click
        'Compare the input entered with the secret word

        If txtSecretWord.Text.Trim.ToUpper() = "ADAM" Then
            lblResult.ForeColor = Color.Blue
            lblResult.BackColor = Color.LightBlue
            lblResult.Text = txtSecretWord.Text.ToUpper()
        Else
            MessageBox.Show("WRONG PASSWORD")
            ' lblResult.Text = "WRONG PASSWORD"
        End If


        ' lblResult.Text = word.ToUpper()
    End Sub
End Class

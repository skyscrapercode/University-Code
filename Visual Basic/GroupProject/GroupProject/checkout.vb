Public Class Form1
    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        MessageBox.Show("You will be using cash", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnFPX_Click(sender As Object, e As EventArgs) Handles btnFPX.Click
        MessageBox.Show("You will be using FPX", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        MessageBox.Show("You will be using card", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class

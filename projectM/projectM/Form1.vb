Public Class Form1
    Private Sub btnMemory_Click(sender As Object, e As EventArgs) Handles btnMemory.Click
        Dim memories1 As New nexrPage
        memories1.Show()
    End Sub

    Private Sub btnMemory2_Click(sender As Object, e As EventArgs) Handles btnMemory2.Click
        Dim memories2 As New Memories2
        memories2.ShowDialog()
    End Sub

    Private Sub btnMemory3_Click(sender As Object, e As EventArgs) Handles btnMemory3.Click
        Dim memories3 As New Memories3
        memories3.ShowDialog()
    End Sub

    Private Sub btnBirthdaySong_Click(sender As Object, e As EventArgs) Handles btnBirthdaySong.Click
        Dim birthdaySong As New BirthdaySong
        birthdaySong.ShowDialog()
    End Sub

    Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnBackgroundColor.Click
        If cdColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.BackColor = cdColor.Color()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

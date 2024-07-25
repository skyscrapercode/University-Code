Public Class home
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.bg.Add(My.Resources.greenBG)
        RoundButton(btnOrder)
        RoundButton(btnHistory)
    End Sub

    Private Sub RoundButton(btn As Button)
        With btn
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .BackColor = Color.ForestGreen
            .ForeColor = Color.White
            .Cursor = Cursors.Hand
            .Font = New Font("Century Gothic", 14)
        End With
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'left top corner
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, btn.Width - 20, 0)

        'right top corner
        radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        'right corner bottom
        radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        'left corner bottom
        radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()
        btn.Region = New Region(radius)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As Integer
        result = MessageBox.Show("Do you want to log out ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            MsgBox("Thank you, see you next time!", 0, "Logging out")
            Me.Hide()
            login.Show()
            Module1.CUSTID.Clear()
        End If
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Me.Hide()
        OrderMenu.Show()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Me.Hide()
        frmOrderHistory.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        FrmAbout.Show()
    End Sub

    Private Sub AccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem1.Click
        Me.Hide()
        formAccInterface.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result As Integer
        result = MessageBox.Show("Do you want to log out ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            MsgBox("Thank you, see you next time!", 0, "Logging out")
            Me.Hide()
            login.Show()
            Module1.CUSTID.Clear()
        End If
    End Sub
End Class
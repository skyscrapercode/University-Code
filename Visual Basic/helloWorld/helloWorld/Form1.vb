Public Class Form1
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuColorRed_Click(sender As Object, e As EventArgs) Handles mnuColorRed.Click
        lblHelloWorld.ForeColor = Color.Red
    End Sub

    Private Sub mnuColorGreen_Click(sender As Object, e As EventArgs) Handles mnuColorGreen.Click
        lblHelloWorld.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(sender As Object, e As EventArgs) Handles mnuColorBlue.Click
        lblHelloWorld.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(sender As Object, e As EventArgs) Handles mnuColorBlack.Click
        lblHelloWorld.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisible_Click(sender As Object, e As EventArgs) Handles mnuColorVisible.Click
        'make the label visible or invisible

        If mnuColorVisible.Checked Then
            lblHelloWorld.Visible = True
        Else
            lblHelloWorld.Visible = False
        End If

    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MsgBox("A simple menu system Demo",, "About")
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        'Configure open file dialog and display it

        With ofdOpen
            'Filter that specifies type of files visible in dialog box
            .Filter = "All Files (*.*) | *.*"
            'Display current directory
            .InitialDirectory = "C:\"
            'Title properties of the dialog box
            .Title = "Select a File To Open"
            'Input validation - determine whether the user has selected a file
            If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                MsgBox(ofdOpen.FileName)
            Else
                MsgBox("You have selected no file!")
            End If
        End With


    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim strLocation As String
        'Example without End With statement
        sfdSave.ShowDialog()
        sfdSave.Title = ("Save File As ")
        strLocation = sfdSave.FileName ' Save current doc under new file name
        'Write all text to text file
        My.Computer.FileSystem.WriteAllText(strLocation & ".txt", "" & txtInput.text, True)


    End Sub

    Private Sub mnuEditSelectcolor_Click(sender As Object, e As EventArgs) Handles mnuEditSelectcolor.Click
        If cdColor.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtInput.BackColor = cdColor.Color()
        End If
    End Sub

    Private Sub mnuEditSelectfont_Click(sender As Object, e As EventArgs) Handles mnuEditSelectfont.Click
        fdFont.ShowColor = True ' Display dialog box with color choice

        If fdFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtInput.Font = fdFont.Font
            txtInput.ForeColor = fdFont.Color()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Clear()
        txtInput.BackColor = Color.White
        txtInput.Focus()
    End Sub
End Class

Imports System.IO

Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Read names from file and display them
        Dim inFile As StreamReader
        Dim strName As String
        Dim strFileName As String

        strFileName = InputBox("Enter file name to be read", "Get file name")

        'Determine whether the file exists
        If File.Exists(strFileName) Then
            'Open the file
            inFile = File.OpenText(strFileName)

            'Read file and display in listbox
            Do Until inFile.EndOfStream
                'Read data from file
                strName = inFile.ReadLine()

                'Display in list box
                lstContestants.Items.Add(strName)
            Loop
        Else

            MsgBox("Cannot find the file", MessageBoxButtons.OK & MessageBoxIcon.Information, "Game Show")

        End If

    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'Writes a name to sequential access file

        'Declare StreamWriter variable
        Dim outFile As StreamWriter

        'Open file for append
        outFile = File.AppendText("Contestants.txt")

        'Write name on seperate line in file
        outFile.WriteLine(txtNameInput.Text.Trim())

        'Close the file
        outFile.Close()

        'Clear the text box and set focus
        txtNameInput.Text = String.Empty
        txtNameInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

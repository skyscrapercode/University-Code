Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim strInput As String 'To hold month and year

        If lstOutput.SelectedIndex = -1 Then
            MsgBox("Select a month", 1 Or 16, "Error")
        ElseIf lstOutput2.SelectedIndex = -1 Then
            MsgBox("Select a year", 1 Or 16, "Error")
        Else
            strInput = lstOutput.SelectedItem.ToString() & " " & lstOutput2.SelectedItem.ToString()
            MsgBox("You selected: " & strInput, 1 Or 32, "Display")
        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstOutput.SelectedIndex = -1
        lstOutput2.SelectedIndex = -1
        lstOutput.Items.RemoveAt(4)
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUserInput As String
        strUserInput = InputBox("Enter month's name: ", "User Input")

        lstOutput.Items.Add(strUserInput)
    End Sub
End Class

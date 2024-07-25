Public Class Form1

    Dim intNumbers() As Integer = {7, 5, 9, 8, 23, 15}

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strSubject As String 'Control variable for each loop

        For Each strSubject In listSubject.Items
            If strSubject = txtInput.Text Then
                lblOutput.Text = "Your subject was found!"
            End If
        Next
    End Sub

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click
        lstSort.Items.Clear()
        Array.Sort(intNumbers)
        lstSort.Items.Add("Sort in ascending order")
        lstSort.Items.Add(vbNewLine)

        For intA As Integer = 0 To intNumbers.Length - 1
            lstSort.Items.Add(intNumbers(intA).ToString())
        Next
    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        lstSort.Items.Clear()
        Array.Sort(intNumbers)
        Array.Reverse(intNumbers)
        lstSort.Items.Add("Sort in descending order")
        lstSort.Items.Add(vbNewLine)

        For intA As Integer = 0 To intNumbers.Length - 1
            lstSort.Items.Add(intNumbers(intA).ToString())
        Next
    End Sub
End Class

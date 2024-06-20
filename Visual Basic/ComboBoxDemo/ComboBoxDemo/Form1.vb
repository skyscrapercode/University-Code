Public Class Form1
    Private Sub btnSelection_Click(sender As Object, e As EventArgs) Handles btnSelection.Click
        'Display the combo box selection
        lblCountry.Text = cboCountries.Text
        lblPlay.Text = cboPlays.Text
        lblArtist.Text = cboArtist.Text

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset combo boxes
        cboCountries.SelectedIndex = -1
        cboCountries.Text = String.Empty
        cboPlays.SelectedIndex = -1
        cboPlays.Text = String.Empty
        cboArtist.SelectedIndex = -1 'Note cboArtist.Text is read only

        'Reset labels
        lblCountry.Text = String.Empty
        lblPlay.Text = String.Empty
        lblArtist.Text = String.Empty
    End Sub
End Class

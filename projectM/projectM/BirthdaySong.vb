Public Class BirthdaySong
    Private Sub AxWindowsMediaPlayer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim videoFolderPath As String = IO.Path.Combine(Application.StartupPath, "Resources")
        Dim videoFilePath As String = IO.Path.Combine(videoFolderPath, "happy_birthday.mp4")
        AxWindowsMediaPlayer1.URL = videoFilePath

        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Me.Close()
    End Sub

    Private Sub BirthdaySong_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

End Class
Imports System.Data.OleDb
Imports System.IO

Public Class formAccInterface
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        home.Show()
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.CustomerTableAdapter.Update(Me.DatabasegpDataSet.Customer)
        Me.Close()
    End Sub


    Private Sub chkDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDarkMode.CheckedChanged
        If chkDarkMode.Checked = False Then
            Me.BackgroundImage = My.Resources.greenBGLight
            Me.BackgroundImageLayout = ImageLayout.Stretch
            home.BackgroundImage = My.Resources.greenBGLight
            home.BackgroundImageLayout = ImageLayout.Stretch
            login.BackgroundImage = My.Resources.greenBGLight
            login.BackgroundImageLayout = ImageLayout.Stretch
            FrmAbout.BackgroundImage = My.Resources.greenBGLight
            FrmAbout.BackgroundImageLayout = ImageLayout.Stretch
            frmOrderHistory.BackgroundImage = My.Resources.greenBGLight
            frmOrderHistory.BackgroundImageLayout = ImageLayout.Stretch
            OrderMenu.BackgroundImage = My.Resources.greenBGLight
            OrderMenu.BackgroundImageLayout = ImageLayout.Stretch
            Module1.bg.Clear()
            Module1.bg.Add(My.Resources.greenBGLight)

        Else
            Me.BackgroundImage = My.Resources.greenBG
            Me.BackgroundImageLayout = ImageLayout.Stretch
            home.BackgroundImage = My.Resources.greenBG
            home.BackgroundImageLayout = ImageLayout.Stretch
            login.BackgroundImage = My.Resources.greenBG
            login.BackgroundImageLayout = ImageLayout.Stretch
            FrmAbout.BackgroundImage = My.Resources.greenBG
            FrmAbout.BackgroundImageLayout = ImageLayout.Stretch
            frmOrderHistory.BackgroundImage = My.Resources.greenBG
            frmOrderHistory.BackgroundImageLayout = ImageLayout.Stretch
            OrderMenu.BackgroundImage = My.Resources.greenBG
            OrderMenu.BackgroundImageLayout = ImageLayout.Stretch
            Module1.bg.Clear()
            Module1.bg.Add(My.Resources.greenBG)
        End If
    End Sub

    Private Sub formAccInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasegpDataSet.Customer' table. You can move, or remove it, as needed.

        Dim startupPath As String = Application.StartupPath
        Dim directoryInfo As New DirectoryInfo(startupPath)
        Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent

        Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile

        Dim connection As New OleDbConnection(connectionString)
        Me.CustomerTableAdapter.Connection = connection

        Try
            connection.Open()

            Me.CustomerTableAdapter.FillByCUSTID(Me.DatabasegpDataSet.Customer, Module1.CUSTID.First())

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

End Class

Imports System.Data.OleDb
Imports System.IO

Public Class frmOrderHistory
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub frmOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim startupPath As String = Application.StartupPath
        Dim directoryInfo As New DirectoryInfo(startupPath)
        Dim parentDirectory As DirectoryInfo = directoryInfo.Parent.Parent.Parent

        Dim databaseFile As String = IO.Path.Combine(parentDirectory.FullName, "databasegp.mdb")
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & databaseFile

        Dim connection As New OleDbConnection(connectionString)
        Me.ReceiptTableAdapter.Connection = connection

        Me.PaymentTableAdapter.Connection = connection
        'TODO: This line of code loads data into the 'DatabasegpDataSet.Payment' table. You can move, or remove it, as needed.
        Me.PaymentTableAdapter.Fill(Me.DatabasegpDataSet.Payment)

        'TODO: This line of code loads data into the 'DatabasegpDataSet.Receipt' table. You can move, or remove it, as needed.
        Me.ReceiptTableAdapter.Fill(Me.DatabasegpDataSet.Receipt)
    End Sub
End Class

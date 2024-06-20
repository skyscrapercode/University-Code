Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MemberDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MemberDataSet.Members)

    End Sub

    Private Sub InsertPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertPaymentToolStripMenuItem.Click
        Dim frmPaymentFrom As New paymentForm
        frmPaymentFrom.ShowDialog()
    End Sub
End Class

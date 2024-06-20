Public Class paymentForm
    Private Sub paymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PaymentsDataSet.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.PaymentsDataSet.Payments)

        txtDate.Text = Today.ToString("d")

    End Sub

    Private Sub btnInsertPayment_Click(sender As Object, e As EventArgs) Handles btnInsertPayment.Click
        Me.PaymentsTableAdapter.Insert(CInt(txtMemberID.Text), CDate(txtDate.Text), CDec(txtAmount.Text))
        Me.PaymentsTableAdapter.Fill(PaymentsDataSet.Payments)
    End Sub
End Class
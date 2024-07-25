Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSales.Text = String.Empty
        txtAdvancePay.Text = String.Empty
        lblCommission.Text = String.Empty
        lblCommissionRate.Text = String.Empty
        lblNetPay.Text = String.Empty
        txtSales.Focus()
        btnClear.Enabled = False

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decSalesAmt, decAdvPayment, decCommRate, decCommAmt, decNetPay As Double

        Decimal.TryParse(txtSales.Text, decSalesAmt)
        Decimal.TryParse(txtAdvancePay.Text, decAdvPayment)

        'Determine the commission rate
        Select Case decSalesAmt
            Case Is < 10000
                decCommRate = 0.05D
            Case 10000 To 14999
                decCommRate = 0.1D
            Case 15000 To 17999
                decCommRate = 0.12D
            Case 18000 To 21999
                decCommRate = 0.14D
            Case Is > 22000
                decCommRate = 0.15D
        End Select

        'Calculate commission and net pay
        decCommAmt = decSalesAmt * decCommRate
        decNetPay = decCommAmt - decAdvPayment

        'Display commission rate, commission and Net Pay
        lblCommissionRate.Text = decCommRate.ToString("p")
        lblCommission.Text = decCommAmt.ToString("c")
        lblNetPay.Text = decNetPay.ToString("c")

        btnClear.Enabled = True

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class

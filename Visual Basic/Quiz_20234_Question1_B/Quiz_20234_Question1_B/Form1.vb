Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Answer question i.
        Dim dblCostPrice, dblSellingPriceBeforeTax, dblSellingPrice As Double
        Dim decMarkup As Decimal

        ' Answer question ii.
        Const taxRate As Double = 0.06D

        ' Answer question iii.
        Double.TryParse(txtCostPrice.Text, dblCostPrice)
        Decimal.TryParse(txtMarkup.Text, decMarkup)

        ' Answer question iv.

        dblSellingPriceBeforeTax = dblCostPrice + (dblCostPrice * (decMarkup / 100))
        dblSellingPrice = dblSellingPriceBeforeTax + (dblSellingPriceBeforeTax * taxRate)

        ' Answer question v.

        lblSellingPriceBeforeTax.Text = dblSellingPriceBeforeTax.ToString("C2")
        lblSellingPrice.Text = dblSellingPrice.ToString("C2")

    End Sub
End Class

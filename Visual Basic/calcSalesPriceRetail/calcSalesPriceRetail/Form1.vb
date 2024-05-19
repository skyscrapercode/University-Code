Public Class Form1
    Dim dblSalePrice, dblRetailPrice As Double
    Dim decDiscountPercentage As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If ValidateInput() Then
            dblSalePrice = CalculateSalePrice(dblRetailPrice, decDiscountPercentage)
            DisplayOutput(dblSalePrice)
        Else
            MsgBox("Please Input Correct Values", 0 Or 16, "Error")
        End If



    End Sub

    Private Function ValidateInput() As Boolean
        If Not Double.TryParse(txtRetailPrice.Text, dblRetailPrice) Then ' Another way is you can make TryParse = 0 to check if it's right or wrong
            lblMessage.Text = "Retail price must be numeric"
            Return False
        End If

        If Not Decimal.TryParse(txtDiscountPercent.Text, decDiscountPercentage) Then
            lblMessage.Text = "Discount Percentage must be numeric"
            Return False
        End If

        Return True
    End Function

    Private Function CalculateSalePrice(ByVal dblRetailPrice As Double, ByVal decDiscountPercentage As Decimal) As Double
        Dim dblSalePrice As Double

        dblSalePrice = dblRetailPrice - (dblRetailPrice * decDiscountPercentage)

        Return dblSalePrice
    End Function

    Private Sub DisplayOutput(ByVal dblSalePrice As Double)
        lblSalePrice.Text = dblSalePrice.ToString("C2")
    End Sub
End Class

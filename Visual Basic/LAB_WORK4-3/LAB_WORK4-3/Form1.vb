Public Class Form1
    Private Sub btnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        Dim numOfSpoolEntered, numOfSpoolReadyToShip, numOfSpoolBackOrdered As Integer
        Dim shippingCharge, totalDue As Double
        Dim delivery As Double = 0
        Const costPerCopperWire As Double = 100
        Dim numSpoolInStock As Integer = 0
        If chkRushDelivery.Checked = True Then
            delivery = 15
        Else
            delivery = 10
        End If

        numOfSpoolEntered = GetInStock(numSpoolInStock)

        If numOfSpoolEntered > 0 Then
            numOfSpoolReadyToShip = ReadyToShip(numSpoolInStock, numOfSpoolEntered)
            numOfSpoolBackOrdered = BackOrdered(numSpoolInStock, numOfSpoolEntered)
            shippingCharge = ShippingCharges(numOfSpoolReadyToShip, delivery)

            lblReadyToShip.Text = numOfSpoolReadyToShip.ToString()
            lblBackOrder.Text = numOfSpoolBackOrdered.ToString()
            lblShipping.Text = shippingCharge.ToString("C2")
            totalDue = (numOfSpoolReadyToShip * costPerCopperWire) + shippingCharge
            lblTotalDue.Text = totalDue.ToString("C2")
        Else
            MsgBox("Please Input a value more than 0", 1 Or 16, "Error")
        End If

    End Sub

    Private Function GetInStock(ByRef numSpoolInStock As Integer) As Integer
        Dim numOfSpoolEntered As Integer
        Integer.TryParse(txtSpoolInStock.Text, numSpoolInStock)
        Integer.TryParse(txtSpoolInput.Text, numOfSpoolEntered)
        Return numOfSpoolEntered
    End Function

    Private Function ReadyToShip(ByVal numSpoolInStock As Integer, ByVal numOfSpoolOrdered As Integer) As Integer

        If numOfSpoolOrdered < numSpoolInStock Then
            Return numOfSpoolOrdered
        Else
            Return numSpoolInStock
        End If

    End Function

    Private Function BackOrdered(ByVal numSpoolInStock As Integer, ByVal numOfSpoolOrdered As Integer) As Integer
        Dim backOrderedAmt As Integer = 0

        backOrderedAmt = numOfSpoolOrdered - numSpoolInStock
        If backOrderedAmt > 0 Then
            Return backOrderedAmt
        Else
            Return 0
        End If
    End Function

    Private Function ShippingCharges(ByVal numReadyToShip As Integer, ByVal shippingChargePerStool As Double) As Double
        Dim shippingCharge As Double
        shippingCharge = numReadyToShip * shippingChargePerStool
        Return shippingCharge
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetSpools()
        ResetDelivery()
        txtSpoolInput.Focus()
    End Sub

    Private Sub ResetSpools()
        txtSpoolInput.Clear()
        chkRushDelivery.Checked = False
    End Sub

    Private Sub ResetDelivery()
        lblReadyToShip.Text = String.Empty
        lblBackOrder.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

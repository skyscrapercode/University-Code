Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblFloorAreaSize, dblFloorTypePrice, dblTotalCost, dblTotalFloorCost, dblTotalCostBeforeLabor As Double
        Dim intTypeOfFlooring, intBuyerStatus As Integer
        Dim dblLaborCost As Double = 0

        Double.TryParse(txtFloorSizeInput.Text, dblFloorAreaSize)

        If dblFloorAreaSize <= 0 Then
            MsgBox("Please Input A Positive Number", 0 Or 16, "Error")
        Else
            If radLaminate.Checked = True Then
                intTypeOfFlooring = 1
            ElseIf radVinly.Checked = True Then
                intTypeOfFlooring = 2
            Else
                intTypeOfFlooring = 3
            End If

            dblFloorTypePrice = floorTypePrice(intTypeOfFlooring)
            dblTotalCostBeforeLabor = calculateFloorCost(dblFloorTypePrice, dblFloorAreaSize, dblLaborCost)

            dblTotalCost = dblTotalCostBeforeLabor + dblLaborCost

            If chkMembership.Checked = True Then
                intBuyerStatus = 1
            Else
                intBuyerStatus = 0
            End If

            dblTotalFloorCost = totalFloorCost(dblTotalCost, intBuyerStatus)

            displayFloorBill(dblTotalCostBeforeLabor, dblLaborCost, dblTotalFloorCost)
        End If


    End Sub

    Private Function floorTypePrice(ByVal floorType As Integer) As Double
        Dim flooringPricePerMeter As Double

        If floorType = 1 Then
            flooringPricePerMeter = 20
        ElseIf floorType = 2 Then
            flooringPricePerMeter = 15
        Else
            flooringPricePerMeter = 25
        End If

        Return flooringPricePerMeter
    End Function

    Private Function calculateFloorCost(ByVal dblFloorPricePerMeter As Double, ByVal dblFloorAreaSize As Double, ByRef dblLaborCost As Double) As Double
        Dim dblTotalCost As Double

        dblTotalCost = dblFloorAreaSize * dblFloorPricePerMeter
        dblLaborCost = dblFloorAreaSize * 5

        Return dblTotalCost
    End Function

    Private Function totalFloorCost(ByVal dblTotalCost As Double, ByVal intBuyerStatus As Integer) As Double
        Dim dblTotalFloorCost, dblCostAfterDiscount As Double

        If intBuyerStatus = 1 Then
            dblCostAfterDiscount = dblTotalCost - (dblTotalCost * 0.07)
            dblTotalFloorCost = dblCostAfterDiscount + (dblCostAfterDiscount * 0.09)
        Else
            dblTotalFloorCost = dblTotalCost + (dblTotalCost * 9 / 100)
        End If

        Return dblTotalFloorCost
    End Function

    Private Sub displayFloorBill(ByVal dblTotalCost As Double, ByVal dblLaborCost As Double, ByVal dblFinalPrice As Double)
        lblFlooringCost.Text = dblTotalCost.ToString("C2")
        lblLaborCost.Text = dblLaborCost.ToString("C2")
        lblFinalPrice.Text = dblFinalPrice.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFloorSizeInput.Text = String.Empty
        lblFinalPrice.Text = String.Empty
        lblFlooringCost.Text = String.Empty
        lblLaborCost.Text = String.Empty
        chkMembership.Checked = False
        txtFloorSizeInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

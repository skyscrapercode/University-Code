Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcRevenue_Click(sender As Object, e As EventArgs) Handles btnCalcRevenue.Click
        Dim dblClassA, dblClassB, dblClassC, dblTotalClassA, dblTotalClassB, dblTotalClassC, dblTotalAllClass As Double

        Double.TryParse(txtInputClassA.Text, dblClassA)
        Double.TryParse(txtInputClassB.Text, dblClassB)
        Double.TryParse(txtInputClassC.Text, dblClassC)

        dblTotalClassA = dblClassA * 15
        dblTotalClassB = dblClassB * 12
        dblTotalClassC = dblClassC * 9

        dblTotalAllClass = dblTotalClassA + dblTotalClassB + dblTotalClassC

        txtOutputClassA.Text = dblTotalClassA.ToString("C2")
        txtOutputClassB.Text = dblTotalClassB.ToString("C2")
        txtOutputClassC.Text = dblTotalClassC.ToString("C2")

        txtOutputTotal.Text = dblTotalAllClass.ToString("C2")

        txtOutputClassA.Enabled = True
        txtOutputClassB.Enabled = True
        txtOutputClassC.Enabled = True
        txtOutputTotal.Enabled = True
        btnClear.Enabled = True
        btnCalcRevenue.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInputClassA.Clear()
        txtInputClassB.Clear()
        txtInputClassC.Clear()
        txtOutputClassA.Clear()
        txtOutputClassB.Clear()
        txtOutputClassC.Clear()
        txtOutputTotal.Clear()

        txtInputClassA.Focus()
        txtOutputClassA.Enabled = False
        txtOutputClassB.Enabled = False
        txtOutputClassC.Enabled = False
        txtOutputTotal.Enabled = False
        btnClear.Enabled = False
        btnCalcRevenue.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

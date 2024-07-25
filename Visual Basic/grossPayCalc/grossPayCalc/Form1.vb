Public Class Form1

    'Independant sub procedure
    Private Sub DisplayWeekly(ByVal intWeekly As Integer)
        'display weekly gross pay

        Dim dblPay As Double
        dblPay = intWeekly / 52
        lblGrossPay.Text = dblPay.ToString("C2")
    End Sub

    Private Sub DisplayTwicePerMonth(ByVal intTwicePerMonth As Integer)
        Dim dblPay As Double
        dblPay = intTwicePerMonth / 24
        lblGrossPay.Text = dblPay.ToString("C2")
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intSalary As Integer

        Integer.TryParse(txtSalary.Text, intSalary)

        If radWeekly.Checked Then
            DisplayWeekly(intSalary)
        ElseIf radTwicePerMonth Then
            DisplayTwicePerMonth(intSalary)
        Else
            MsgBox("")
        End If


    End Sub
End Class

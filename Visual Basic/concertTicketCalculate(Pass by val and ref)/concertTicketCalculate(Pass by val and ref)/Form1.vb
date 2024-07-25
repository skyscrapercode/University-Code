Public Class Form1

    Private Sub CalcDiscount(ByVal intNum As Integer, ByVal dblBeforeDisc As Double, ByRef dblDisc As Double)

        Select Case intNum
            Case Is >= 10
                dblDisc = dblBeforeDisc * 0.1
            Case Is >= 5
                dblDisc = dblBeforeDisc * 0.05
            Case Else
                dblDisc = 0
        End Select

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intTix As Integer
        Dim dblSubTotal, dblDiscount, dblTotalDue As Double
        dblTotalDue = 0.0


        Double.TryParse(txtTickets.Text, intTix)

        If radStandard.Checked Then
            dblSubTotal = intTix * 228
        Else
            dblSubTotal = intTix * 778
        End If

        CalcDiscount(intTix, dblSubTotal, dblDiscount) 'Procedure Call

        lblSubTotal.Text = dblSubTotal.ToString("C2")
        lblDiscount.Text = dblDiscount.ToString("C2")

        dblTotalDue = dblSubTotal - dblDiscount

        lblTotalDue.Text = dblTotalDue.ToString("C2")

    End Sub
End Class

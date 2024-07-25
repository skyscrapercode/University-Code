Public Class Form1
    Private Sub btnToppings_Click(sender As Object, e As EventArgs) Handles btnToppings.Click
        Dim totalPrice As Double

        If chkChocolateSyrup.Checked = True Then
            totalPrice += 2
        End If

        If chkSprinkles.Checked = True Then
            totalPrice += 1
        End If

        If chkMarshmellow.Checked = True Then
            totalPrice += 1.5
        End If

        MsgBox("Your total for toppings is " & totalPrice.ToString("C2"), 0, "Total")

    End Sub
End Class

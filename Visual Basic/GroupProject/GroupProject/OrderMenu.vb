Public Class OrderMenu

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decFood As Decimal = 0
        Dim decDrinks As Decimal = 0
        Dim decSides As Decimal = 0

        If chkNasi.Checked = True Then
            decFood += 6
        End If

        If chkRoti.Checked = True Then
            decFood += 7.5
        End If

        If chkLemon.Checked = True Then
            decDrinks += 2.5
        End If

        If chkCoke.Checked = True Then
            decDrinks += 3
        End If

        If chkFries.Checked = True Then
            decSides += 4.5
        End If

        If chkWedges.Checked = True Then
            decSides += 5
        End If


    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        home.Show()
    End Sub
End Class

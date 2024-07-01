Public Class OrderMenu
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Double = 0.0

        Module1.SelectedFood.Add("Nasi Kerabu")
        Module1.SelectedFood.Add("Roti John")
        Module1.SelectedDrink.Add("Ice Lemon Tea")
        Module1.SelectedDrink.Add("Coke")
        Module1.SelectedSides.Add("Fries")
        Module1.SelectedSides.Add("Wedges")

        If chkNasi.Checked = True Then
            total += 6.0
        Else
            Module1.SelectedFood.Remove("Nasi Kerabu")
        End If
        If chkRoti.Checked = True Then
            total += 7.5
        Else
            Module1.SelectedFood.Remove("Roti John")
        End If
        If chkLemon.Checked = True Then
            total += 2.5
        Else
            Module1.SelectedDrink.Remove("Ice Lemon Tea")

        End If
        If chkCoke.Checked = True Then
            total += 3.0
        Else
            Module1.SelectedDrink.Remove("Coke")
        End If
        If chkFries.Checked = True Then
            total += 4.5
        Else
            Module1.SelectedSides.Remove("Fries")
        End If
        If chkWedges.Checked = True Then
            total += 5.0
        Else
            Module1.SelectedSides.Remove("Wedges")
        End If

        Module1.SelectedTotal.Add(total)

        checkout.Show()
        Me.Hide()
        chkNasi.Enabled = False
        chkRoti.Enabled = False
        chkLemon.Enabled = False
        chkCoke.Enabled = False
        chkFries.Enabled = False
        chkWedges.Enabled = False

    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        home.Show()
        chkNasi.Enabled = False
        chkRoti.Enabled = False
        chkLemon.Enabled = False
        chkCoke.Enabled = False
        chkFries.Enabled = False
        chkWedges.Enabled = False
    End Sub


End Class

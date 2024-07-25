Public Class OrderMenu


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Double = 0.0
        Dim intNasi As Integer
        Dim intRoti As Integer
        Dim intLemon As Integer
        Dim intCoke As Integer
        Dim intFries As Integer
        Dim intWedges As Integer

        Integer.TryParse(txtNasiQuan.Text, intNasi)
        Integer.TryParse(txtRotiQuan.Text, intRoti)
        Integer.TryParse(txtLemonQuan.Text, intLemon)
        Integer.TryParse(txtCokeQuan.Text, intCoke)
        Integer.TryParse(txtFriesQuan.Text, intFries)
        Integer.TryParse(txtWedgesQuan.Text, intWedges)

        If checkBox() = True Then
            Module1.SelectedFood.Add("Nasi Kerabu")
            Module1.SelectedFood.Add("Roti John")
            Module1.SelectedDrink.Add("Ice Lemon Tea")
            Module1.SelectedDrink.Add("Coke")
            Module1.SelectedSides.Add("Fries")
            Module1.SelectedSides.Add("Wedges")

            If chkNasi.Checked = True Then
                If intNasi = 0 Then
                    intNasi = 1
                End If
                total += 6.0 * intNasi
            Else
                Module1.SelectedFood.Remove("Nasi Kerabu")
            End If
            If chkRoti.Checked = True Then
                If intRoti = 0 Then
                    intRoti = 1
                End If
                total += 7.5 * intRoti
            Else
                Module1.SelectedFood.Remove("Roti John")
            End If
            If chkLemon.Checked = True Then
                If intLemon = 0 Then
                    intLemon = 1
                End If
                total += 2.5 * intLemon
            Else
                Module1.SelectedDrink.Remove("Ice Lemon Tea")

            End If
            If chkCoke.Checked = True Then
                If intCoke = 0 Then
                    intCoke = 1
                End If
                total += 3.0 * intCoke
            Else
                Module1.SelectedDrink.Remove("Coke")
            End If
            If chkFries.Checked = True Then
                If intFries = 0 Then
                    intFries = 1
                End If
                total += 4.5 * intFries
            Else
                Module1.SelectedSides.Remove("Fries")
            End If
            If chkWedges.Checked = True Then
                If intWedges = 0 Then
                    intWedges = 1
                End If
                total += 5.0 * intWedges
            Else
                Module1.SelectedSides.Remove("Wedges")
            End If
            Module1.SelectedTotal.Add(total)

            If total = 0 Then
                MsgBox("Please choose at least one item ", 0 Or 16, "Error")
                Module1.SelectedSides.Clear()
                Module1.SelectedDrink.Clear()
                Module1.SelectedFood.Clear()
                Module1.SelectedTotal.Clear()
            Else
                Me.Hide()
                checkout.Show()
            End If


        End If

        chkNasi.Checked = False
        chkRoti.Checked = False
        chkLemon.Checked = False
        chkCoke.Checked = False
        chkFries.Checked = False
        chkWedges.Checked = False
        txtCokeQuan.Clear()
        txtFriesQuan.Clear()
        txtLemonQuan.Clear()
        txtNasiQuan.Clear()
        txtWedgesQuan.Clear()
        txtRotiQuan.Clear()

    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        home.Show()
        chkNasi.Checked = False
        chkRoti.Checked = False
        chkLemon.Checked = False
        chkCoke.Checked = False
        chkFries.Checked = False
        chkWedges.Checked = False
    End Sub

    Private Function checkBox() As Boolean
        Dim nasi As String = txtNasiQuan.Text
        Dim roti As String = txtRotiQuan.Text
        Dim lemon As String = txtLemonQuan.Text
        Dim coke As String = txtCokeQuan.Text
        Dim fries As String = txtFriesQuan.Text
        Dim wedges As String = txtWedgesQuan.Text
        Dim key1, key2, key3, key4, key5, key6 As Boolean

        Dim nasiq, rotiq, lemonq, cokeq, friesq, wedgesq As Integer
        If Integer.TryParse(nasi, nasiq) Or txtNasiQuan.TextLength = 0 Then
            key1 = True
        End If
        If Integer.TryParse(roti, rotiq) Or txtRotiQuan.TextLength = 0 Then
            key2 = True
        End If
        If Integer.TryParse(coke, cokeq) Or txtCokeQuan.TextLength = 0 Then
            key3 = True
            txtCokeQuan.Clear()
        End If
        If Integer.TryParse(lemon, lemonq) Or txtLemonQuan.TextLength = 0 Then
            key4 = True
            txtLemonQuan.Clear()
        End If
        If Integer.TryParse(fries, friesq) Or txtFriesQuan.TextLength = 0 Then
            key5 = True
            txtFriesQuan.Clear()
        End If
        If Integer.TryParse(wedges, wedgesq) Or txtWedgesQuan.TextLength = 0 Then
            key6 = True
            txtWedgesQuan.Clear()
        End If

        If key1 = True And key2 = True And key3 = True And key4 = True And key5 = True And key6 = True Then
            Return True
        Else
            MessageBox.Show("Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
    End Function
End Class

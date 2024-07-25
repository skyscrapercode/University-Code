Public Class MainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplayFoodFact_Click(sender As Object, e As EventArgs) Handles btnDisplayFoodFact.Click
        Dim frmNutrition As New NutritionForm

        If radBanana.Checked = True Then
            frmNutrition.lblFood.Text = "1 Banana"
            frmNutrition.lblCalories.Text = "100"
            frmNutrition.lblFatGrams.Text = "0.4"
            frmNutrition.lblCarbGrams.Text = "27"
        ElseIf radPopcorn.Checked = True Then
            frmNutrition.lblFood.Text = "1 cup air-popped popcorn"
            frmNutrition.lblCalories.Text = "31"
            frmNutrition.lblFatGrams.Text = "0.4"
            frmNutrition.lblCarbGrams.Text = "6"
        Else
            frmNutrition.lblFood.Text = "1 large blurberry muffin"
            frmNutrition.lblCalories.Text = "386"
            frmNutrition.lblFatGrams.Text = "9"
            frmNutrition.lblCarbGrams.Text = "67"
        End If
        frmNutrition.ShowDialog()

    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim frmAbout As New AboutForm
        Me.Hide()
        frmAbout.ShowDialog()
    End Sub
End Class

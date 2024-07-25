Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get today's date and time from the system and display it
        lblDate.Text = Now.ToString("D")
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblFootage As Double
        Dim decCost As Decimal
        Const DISC As Double = 0.1

        'Did user enter numeric number or not
        If IsNumeric(txtFootage.Text) Then
            Double.TryParse(txtFootage.Text, dblFootage)
            'Is square footage > 0
            If dblFootage > 0 Then
                'Calculate Cost
                If radLumbar.Checked Then
                    decCost = dblFootage * 2.35D
                ElseIf radRedwood.Checked Then
                    decCost = dblFootage * 7.75D
                ElseIf radComposite.Checked Then
                    decCost = dblFootage * 8.5D
                End If

                'Calculate for check box
                If chkMember.Checked Then
                    decCost = decCost - (decCost * DISC)
                End If


                lblCostEstimate.Text = decCost.ToString("C2")
            Else
                'Display error message id if user enter -ve number
                MsgBox("You've entered " + txtFootage.ToString + ". Enter a positive number",, "Input Error")
                txtFootage.Clear()
                txtFootage.Focus()
            End If

        Else
            'Display error message if user entered non-numeric value
            MsgBox("Enter the square footage of decking", MsgBoxStyle.OkCancel Or MsgBoxStyle.Exclamation, "Input Error")
            txtFootage.Clear()
            txtFootage.Focus()
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFootage.Clear()
        lblCostEstimate.Text = String.Empty
        radLumbar.Checked = False
        radRedwood.Checked = False
        radComposite.Checked = False
        chkMember.Checked = False
        txtFootage.Focus()

    End Sub
End Class

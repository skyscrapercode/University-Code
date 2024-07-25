Public Class Form1
    Const UPPERBOUND As Integer = 11
    Dim dblRainFall(UPPERBOUND) As Double
    Dim strMonths() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim strInput As String

        'Read and store data inside of array dblRainFall
        For intCount As Integer = 0 To UPPERBOUND
            strInput = InputBox("Enter the volume of rainfall for " & strMonths(intCount))
            Double.TryParse(strInput, dblRainFall(intCount))
        Next

        lstDisplay.Items.Add("Monthly Rainfall Input")
        lstDisplay.Items.Add("=========================================")
        lstDisplay.Items.Add(vbNewLine)

        'Display the contents of array dblRainfall
        For intCount As Integer = 0 To (dblRainFall.Length - 1)
            lstDisplay.Items.Add("Rainfall for " & strMonths(intCount) & " = " & dblRainFall(intCount).ToString())
        Next

    End Sub

    Private Sub btnStat_Click(sender As Object, e As EventArgs) Handles btnStat.Click
        Dim intCount As Integer
        Dim dblTotal As Double = 0
        Dim dblAverage As Double
        Dim dblMin, dblMax As Double
        Dim indexMin, indexMax As Integer

        For intCount = 0 To UPPERBOUND
            dblTotal += dblRainFall(intCount)
        Next

        lblTotal.Text = "The total annual rainfall was " & dblTotal.ToString()

        dblAverage = dblTotal / dblRainFall.Length

        lblAverage.Text = "The average monthly rainfall was " & dblAverage.ToString("N2")

        dblMin = dblRainFall(0)
        dblMax = dblRainFall(0)

        For intCount = 0 To UPPERBOUND

            If (dblMin > dblRainFall(intCount)) Then
                dblMin = dblRainFall(intCount)
                indexMin = intCount
            End If

            If (dblMax < dblRainFall(intCount)) Then
                dblMax = dblRainFall(intCount)
                indexMax = intCount
            End If
        Next

        lblMinimum.Text = "The minimum monthly rain fall was " & dblMin.ToString() & " (" & strMonths(indexMin) & ")"
        lblMaximum.Text = "The maximum monthly rain fall was " & dblMax.ToString() & " (" & strMonths(indexMax) & ")"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
        lblTotal.Text = String.Empty
        lblAverage.Text = String.Empty
        lblMaximum.Text = String.Empty
        lblMinimum.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

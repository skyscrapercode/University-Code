<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.radWeekly = New System.Windows.Forms.RadioButton()
        Me.radTwicePerMonth = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salary:"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(168, 111)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 22)
        Me.txtSalary.TabIndex = 1
        '
        'radWeekly
        '
        Me.radWeekly.AutoSize = True
        Me.radWeekly.Location = New System.Drawing.Point(363, 91)
        Me.radWeekly.Name = "radWeekly"
        Me.radWeekly.Size = New System.Drawing.Size(75, 21)
        Me.radWeekly.TabIndex = 2
        Me.radWeekly.TabStop = True
        Me.radWeekly.Text = "Weekly"
        Me.radWeekly.UseVisualStyleBackColor = True
        '
        'radTwicePerMonth
        '
        Me.radTwicePerMonth.AutoSize = True
        Me.radTwicePerMonth.Location = New System.Drawing.Point(363, 134)
        Me.radTwicePerMonth.Name = "radTwicePerMonth"
        Me.radTwicePerMonth.Size = New System.Drawing.Size(133, 21)
        Me.radTwicePerMonth.TabIndex = 3
        Me.radTwicePerMonth.TabStop = True
        Me.radTwicePerMonth.Text = "Twice per month"
        Me.radTwicePerMonth.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gross pay:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(148, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 120)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(363, 201)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(92, 42)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossPay.Location = New System.Drawing.Point(165, 220)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(103, 23)
        Me.lblGrossPay.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.radTwicePerMonth)
        Me.Controls.Add(Me.radWeekly)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Gross Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents radWeekly As RadioButton
    Friend WithEvents radTwicePerMonth As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblGrossPay As Label
End Class

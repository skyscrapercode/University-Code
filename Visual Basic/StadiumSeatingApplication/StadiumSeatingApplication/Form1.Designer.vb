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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtInputClassC = New System.Windows.Forms.TextBox()
        Me.txtInputClassB = New System.Windows.Forms.TextBox()
        Me.txtInputClassA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOutputTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOutputClassC = New System.Windows.Forms.TextBox()
        Me.txtOutputClassB = New System.Windows.Forms.TextBox()
        Me.txtOutputClassA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the number of tickets sold" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for each class of seats"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInputClassC)
        Me.GroupBox1.Controls.Add(Me.txtInputClassB)
        Me.GroupBox1.Controls.Add(Me.txtInputClassA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 224)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tickets Sold"
        '
        'txtInputClassC
        '
        Me.txtInputClassC.Location = New System.Drawing.Point(123, 155)
        Me.txtInputClassC.Name = "txtInputClassC"
        Me.txtInputClassC.Size = New System.Drawing.Size(132, 22)
        Me.txtInputClassC.TabIndex = 5
        '
        'txtInputClassB
        '
        Me.txtInputClassB.Location = New System.Drawing.Point(123, 124)
        Me.txtInputClassB.Name = "txtInputClassB"
        Me.txtInputClassB.Size = New System.Drawing.Size(132, 22)
        Me.txtInputClassB.TabIndex = 4
        '
        'txtInputClassA
        '
        Me.txtInputClassA.Location = New System.Drawing.Point(123, 90)
        Me.txtInputClassA.Name = "txtInputClassA"
        Me.txtInputClassA.Size = New System.Drawing.Size(132, 22)
        Me.txtInputClassA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Class A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Class B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Class C:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOutputTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtOutputClassC)
        Me.GroupBox2.Controls.Add(Me.txtOutputClassB)
        Me.GroupBox2.Controls.Add(Me.txtOutputClassA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 224)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Revenue Generated"
        '
        'txtOutputTotal
        '
        Me.txtOutputTotal.Enabled = False
        Me.txtOutputTotal.Location = New System.Drawing.Point(143, 152)
        Me.txtOutputTotal.Name = "txtOutputTotal"
        Me.txtOutputTotal.Size = New System.Drawing.Size(132, 22)
        Me.txtOutputTotal.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Total Revenue:"
        '
        'txtOutputClassC
        '
        Me.txtOutputClassC.Enabled = False
        Me.txtOutputClassC.Location = New System.Drawing.Point(143, 95)
        Me.txtOutputClassC.Name = "txtOutputClassC"
        Me.txtOutputClassC.Size = New System.Drawing.Size(132, 22)
        Me.txtOutputClassC.TabIndex = 11
        '
        'txtOutputClassB
        '
        Me.txtOutputClassB.Enabled = False
        Me.txtOutputClassB.Location = New System.Drawing.Point(143, 64)
        Me.txtOutputClassB.Name = "txtOutputClassB"
        Me.txtOutputClassB.Size = New System.Drawing.Size(132, 22)
        Me.txtOutputClassB.TabIndex = 10
        '
        'txtOutputClassA
        '
        Me.txtOutputClassA.Enabled = False
        Me.txtOutputClassA.Location = New System.Drawing.Point(143, 34)
        Me.txtOutputClassA.Name = "txtOutputClassA"
        Me.txtOutputClassA.Size = New System.Drawing.Size(132, 22)
        Me.txtOutputClassA.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Class C:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Class B:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Class A:"
        '
        'btnCalcRevenue
        '
        Me.btnCalcRevenue.Location = New System.Drawing.Point(62, 307)
        Me.btnCalcRevenue.Name = "btnCalcRevenue"
        Me.btnCalcRevenue.Size = New System.Drawing.Size(180, 69)
        Me.btnCalcRevenue.TabIndex = 3
        Me.btnCalcRevenue.Text = "Calculate Revenue"
        Me.btnCalcRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(310, 307)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(180, 69)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(560, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 69)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcRevenue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Stadium Seating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtInputClassC As TextBox
    Friend WithEvents txtInputClassB As TextBox
    Friend WithEvents txtInputClassA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOutputClassC As TextBox
    Friend WithEvents txtOutputClassB As TextBox
    Friend WithEvents txtOutputClassA As TextBox
    Friend WithEvents txtOutputTotal As TextBox
    Friend WithEvents btnCalcRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

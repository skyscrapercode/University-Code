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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radHardwood = New System.Windows.Forms.RadioButton()
        Me.radVinly = New System.Windows.Forms.RadioButton()
        Me.radLaminate = New System.Windows.Forms.RadioButton()
        Me.chkMembership = New System.Windows.Forms.CheckBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFlooringCost = New System.Windows.Forms.Label()
        Me.lblLaborCost = New System.Windows.Forms.Label()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFloorSizeInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radHardwood)
        Me.GroupBox1.Controls.Add(Me.radVinly)
        Me.GroupBox1.Controls.Add(Me.radLaminate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type of flooring"
        '
        'radHardwood
        '
        Me.radHardwood.AutoSize = True
        Me.radHardwood.Location = New System.Drawing.Point(32, 103)
        Me.radHardwood.Name = "radHardwood"
        Me.radHardwood.Size = New System.Drawing.Size(93, 21)
        Me.radHardwood.TabIndex = 2
        Me.radHardwood.TabStop = True
        Me.radHardwood.Text = "Hardwood"
        Me.radHardwood.UseVisualStyleBackColor = True
        '
        'radVinly
        '
        Me.radVinly.AutoSize = True
        Me.radVinly.Location = New System.Drawing.Point(32, 76)
        Me.radVinly.Name = "radVinly"
        Me.radVinly.Size = New System.Drawing.Size(59, 21)
        Me.radVinly.TabIndex = 1
        Me.radVinly.TabStop = True
        Me.radVinly.Text = "Vinyl"
        Me.radVinly.UseVisualStyleBackColor = True
        '
        'radLaminate
        '
        Me.radLaminate.AutoSize = True
        Me.radLaminate.Location = New System.Drawing.Point(32, 49)
        Me.radLaminate.Name = "radLaminate"
        Me.radLaminate.Size = New System.Drawing.Size(87, 21)
        Me.radLaminate.TabIndex = 0
        Me.radLaminate.TabStop = True
        Me.radLaminate.Text = "Laminate"
        Me.radLaminate.UseVisualStyleBackColor = True
        '
        'chkMembership
        '
        Me.chkMembership.AutoSize = True
        Me.chkMembership.Location = New System.Drawing.Point(44, 170)
        Me.chkMembership.Name = "chkMembership"
        Me.chkMembership.Size = New System.Drawing.Size(107, 21)
        Me.chkMembership.TabIndex = 3
        Me.chkMembership.Text = "Membership"
        Me.chkMembership.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 322)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(105, 50)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(143, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 50)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(263, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 50)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Flooring Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Labor Cost:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Final Price After Discount(if applicable) and tax:"
        '
        'lblFlooringCost
        '
        Me.lblFlooringCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFlooringCost.Location = New System.Drawing.Point(113, 208)
        Me.lblFlooringCost.Name = "lblFlooringCost"
        Me.lblFlooringCost.Size = New System.Drawing.Size(100, 23)
        Me.lblFlooringCost.TabIndex = 10
        '
        'lblLaborCost
        '
        Me.lblLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLaborCost.Location = New System.Drawing.Point(113, 238)
        Me.lblLaborCost.Name = "lblLaborCost"
        Me.lblLaborCost.Size = New System.Drawing.Size(100, 23)
        Me.lblLaborCost.TabIndex = 11
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalPrice.Location = New System.Drawing.Point(321, 266)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblFinalPrice.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Floor Area Size:"
        '
        'txtFloorSizeInput
        '
        Me.txtFloorSizeInput.Location = New System.Drawing.Point(333, 60)
        Me.txtFloorSizeInput.Name = "txtFloorSizeInput"
        Me.txtFloorSizeInput.Size = New System.Drawing.Size(100, 22)
        Me.txtFloorSizeInput.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 450)
        Me.Controls.Add(Me.txtFloorSizeInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFinalPrice)
        Me.Controls.Add(Me.lblLaborCost)
        Me.Controls.Add(Me.lblFlooringCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.chkMembership)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "FloorMaster Inc."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radHardwood As RadioButton
    Friend WithEvents radVinly As RadioButton
    Friend WithEvents radLaminate As RadioButton
    Friend WithEvents chkMembership As CheckBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFlooringCost As Label
    Friend WithEvents lblLaborCost As Label
    Friend WithEvents lblFinalPrice As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFloorSizeInput As TextBox
End Class

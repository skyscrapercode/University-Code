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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFootage = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radComposite = New System.Windows.Forms.RadioButton()
        Me.radRedwood = New System.Windows.Forms.RadioButton()
        Me.radLumbar = New System.Windows.Forms.RadioButton()
        Me.chkMember = New System.Windows.Forms.CheckBox()
        Me.lblEst = New System.Windows.Forms.Label()
        Me.lblCostEstimate = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Decking Cost Calculator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Square Footage:"
        '
        'txtFootage
        '
        Me.txtFootage.Location = New System.Drawing.Point(184, 120)
        Me.txtFootage.Name = "txtFootage"
        Me.txtFootage.Size = New System.Drawing.Size(148, 22)
        Me.txtFootage.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.radComposite)
        Me.GroupBox1.Controls.Add(Me.radRedwood)
        Me.GroupBox1.Controls.Add(Me.radLumbar)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 182)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Decking Type"
        '
        'radComposite
        '
        Me.radComposite.AutoSize = True
        Me.radComposite.Location = New System.Drawing.Point(6, 116)
        Me.radComposite.Name = "radComposite"
        Me.radComposite.Size = New System.Drawing.Size(95, 21)
        Me.radComposite.TabIndex = 2
        Me.radComposite.TabStop = True
        Me.radComposite.Text = "Composite"
        Me.radComposite.UseVisualStyleBackColor = True
        '
        'radRedwood
        '
        Me.radRedwood.AutoSize = True
        Me.radRedwood.Location = New System.Drawing.Point(6, 72)
        Me.radRedwood.Name = "radRedwood"
        Me.radRedwood.Size = New System.Drawing.Size(88, 21)
        Me.radRedwood.TabIndex = 1
        Me.radRedwood.TabStop = True
        Me.radRedwood.Text = "Redwood"
        Me.radRedwood.UseVisualStyleBackColor = True
        '
        'radLumbar
        '
        Me.radLumbar.AutoSize = True
        Me.radLumbar.Location = New System.Drawing.Point(6, 32)
        Me.radLumbar.Name = "radLumbar"
        Me.radLumbar.Size = New System.Drawing.Size(193, 21)
        Me.radLumbar.TabIndex = 0
        Me.radLumbar.TabStop = True
        Me.radLumbar.Text = "Pressure-Treated Lumbar"
        Me.radLumbar.UseVisualStyleBackColor = True
        '
        'chkMember
        '
        Me.chkMember.AutoSize = True
        Me.chkMember.Location = New System.Drawing.Point(67, 367)
        Me.chkMember.Name = "chkMember"
        Me.chkMember.Size = New System.Drawing.Size(154, 21)
        Me.chkMember.TabIndex = 3
        Me.chkMember.Text = "Are you a member?"
        Me.chkMember.UseVisualStyleBackColor = True
        '
        'lblEst
        '
        Me.lblEst.AutoSize = True
        Me.lblEst.Location = New System.Drawing.Point(64, 405)
        Me.lblEst.Name = "lblEst"
        Me.lblEst.Size = New System.Drawing.Size(98, 17)
        Me.lblEst.TabIndex = 4
        Me.lblEst.Text = "Cost Estimate:"
        '
        'lblCostEstimate
        '
        Me.lblCostEstimate.AutoSize = True
        Me.lblCostEstimate.Location = New System.Drawing.Point(168, 405)
        Me.lblCostEstimate.Name = "lblCostEstimate"
        Me.lblCostEstimate.Size = New System.Drawing.Size(81, 17)
        Me.lblCostEstimate.TabIndex = 5
        Me.lblCostEstimate.Text = "RM0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(313, 368)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 50)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(469, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 50)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(625, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabWork3_2.My.Resources.Resources.nhhcbfjf
        Me.PictureBox1.Location = New System.Drawing.Point(380, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 336)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(111, 38)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(138, 17)
        Me.lblDate.TabIndex = 11
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(111, 68)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(138, 17)
        Me.lblTime.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Time:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostEstimate)
        Me.Controls.Add(Me.lblEst)
        Me.Controls.Add(Me.chkMember)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFootage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Decking Cost Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFootage As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radComposite As RadioButton
    Friend WithEvents radRedwood As RadioButton
    Friend WithEvents radLumbar As RadioButton
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents lblEst As Label
    Friend WithEvents lblCostEstimate As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Label5 As Label
End Class

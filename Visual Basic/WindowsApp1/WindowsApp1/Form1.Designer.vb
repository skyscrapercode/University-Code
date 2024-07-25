<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCoral
        Me.Label1.Location = New System.Drawing.Point(272, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Latte Selection"
        '
        'picMocha
        '
        Me.picMocha.Image = Global.WindowsApp1.My.Resources.Resources.l_intro_1639399281
        Me.picMocha.Location = New System.Drawing.Point(429, 52)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(300, 250)
        Me.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMocha.TabIndex = 2
        Me.picMocha.TabStop = False
        Me.picMocha.Visible = False
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = Global.WindowsApp1.My.Resources.Resources.Starbucks_Grande_Iced_Pumpkin_Spice_Latte
        Me.picPumpkin.Location = New System.Drawing.Point(66, 52)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPumpkin.TabIndex = 0
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'btnPumpkin
        '
        Me.btnPumpkin.Location = New System.Drawing.Point(66, 308)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(200, 50)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Enabled = False
        Me.btnSelect.Location = New System.Drawing.Point(300, 308)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(200, 50)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Latte"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnMocha
        '
        Me.btnMocha.Location = New System.Drawing.Point(529, 308)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(200, 50)
        Me.btnMocha.TabIndex = 5
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(173, 361)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(454, 20)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a latte flavour and then click the Select Latte button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(325, 381)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(142, 20)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enjoy your drinks!"
        Me.lblConfirmation.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(300, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPumpkin)
        Me.Name = "Form1"
        Me.Text = "Latte Selection"
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class

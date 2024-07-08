<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.groupBoxLogin = New System.Windows.Forms.GroupBox()
        Me.txtEmailLogin = New System.Windows.Forms.TextBox()
        Me.txtPasswordLogin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnterLogin = New System.Windows.Forms.Button()
        Me.groupBoxRegister = New System.Windows.Forms.GroupBox()
        Me.btnEnterRegister = New System.Windows.Forms.Button()
        Me.txtEmailRegister = New System.Windows.Forms.TextBox()
        Me.txtPasswordRegister = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAccount = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBoxLogin.SuspendLayout()
        Me.groupBoxRegister.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 154)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblLogin
        '
        Me.lblLogin.BackColor = System.Drawing.Color.Green
        Me.lblLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogin.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(241, 206)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(344, 39)
        Me.lblLogin.TabIndex = 5
        Me.lblLogin.Text = "Log In"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRegister
        '
        Me.lblRegister.BackColor = System.Drawing.Color.Green
        Me.lblRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegister.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(500, 206)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(344, 39)
        Me.lblRegister.TabIndex = 7
        Me.lblRegister.Text = "Register"
        Me.lblRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRegister.Visible = False
        '
        'groupBoxLogin
        '
        Me.groupBoxLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.groupBoxLogin.Controls.Add(Me.txtEmailLogin)
        Me.groupBoxLogin.Controls.Add(Me.txtPasswordLogin)
        Me.groupBoxLogin.Controls.Add(Me.Label2)
        Me.groupBoxLogin.Controls.Add(Me.Label4)
        Me.groupBoxLogin.Controls.Add(Me.btnEnterLogin)
        Me.groupBoxLogin.Location = New System.Drawing.Point(241, 249)
        Me.groupBoxLogin.Name = "groupBoxLogin"
        Me.groupBoxLogin.Size = New System.Drawing.Size(344, 191)
        Me.groupBoxLogin.TabIndex = 12
        Me.groupBoxLogin.TabStop = False
        '
        'txtEmailLogin
        '
        Me.txtEmailLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.txtEmailLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailLogin.Location = New System.Drawing.Point(110, 19)
        Me.txtEmailLogin.Name = "txtEmailLogin"
        Me.txtEmailLogin.Size = New System.Drawing.Size(195, 35)
        Me.txtEmailLogin.TabIndex = 13
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.BackColor = System.Drawing.Color.YellowGreen
        Me.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordLogin.Location = New System.Drawing.Point(110, 76)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.Size = New System.Drawing.Size(195, 35)
        Me.txtPasswordLogin.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password:"
        '
        'btnEnterLogin
        '
        Me.btnEnterLogin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnEnterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterLogin.Location = New System.Drawing.Point(10, 131)
        Me.btnEnterLogin.Name = "btnEnterLogin"
        Me.btnEnterLogin.Size = New System.Drawing.Size(101, 40)
        Me.btnEnterLogin.TabIndex = 12
        Me.btnEnterLogin.Text = "Enter"
        Me.btnEnterLogin.UseVisualStyleBackColor = False
        '
        'groupBoxRegister
        '
        Me.groupBoxRegister.BackColor = System.Drawing.Color.YellowGreen
        Me.groupBoxRegister.Controls.Add(Me.btnEnterRegister)
        Me.groupBoxRegister.Controls.Add(Me.txtEmailRegister)
        Me.groupBoxRegister.Controls.Add(Me.txtPasswordRegister)
        Me.groupBoxRegister.Controls.Add(Me.Label8)
        Me.groupBoxRegister.Controls.Add(Me.Label9)
        Me.groupBoxRegister.Location = New System.Drawing.Point(500, 244)
        Me.groupBoxRegister.Name = "groupBoxRegister"
        Me.groupBoxRegister.Size = New System.Drawing.Size(344, 196)
        Me.groupBoxRegister.TabIndex = 13
        Me.groupBoxRegister.TabStop = False
        Me.groupBoxRegister.Visible = False
        '
        'btnEnterRegister
        '
        Me.btnEnterRegister.BackColor = System.Drawing.Color.ForestGreen
        Me.btnEnterRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterRegister.Location = New System.Drawing.Point(9, 136)
        Me.btnEnterRegister.Name = "btnEnterRegister"
        Me.btnEnterRegister.Size = New System.Drawing.Size(101, 40)
        Me.btnEnterRegister.TabIndex = 13
        Me.btnEnterRegister.Text = "Enter"
        Me.btnEnterRegister.UseVisualStyleBackColor = False
        '
        'txtEmailRegister
        '
        Me.txtEmailRegister.BackColor = System.Drawing.Color.YellowGreen
        Me.txtEmailRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailRegister.Location = New System.Drawing.Point(109, 22)
        Me.txtEmailRegister.Name = "txtEmailRegister"
        Me.txtEmailRegister.Size = New System.Drawing.Size(195, 35)
        Me.txtEmailRegister.TabIndex = 8
        '
        'txtPasswordRegister
        '
        Me.txtPasswordRegister.BackColor = System.Drawing.Color.YellowGreen
        Me.txtPasswordRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordRegister.Location = New System.Drawing.Point(109, 79)
        Me.txtPasswordRegister.Name = "txtPasswordRegister"
        Me.txtPasswordRegister.Size = New System.Drawing.Size(195, 35)
        Me.txtPasswordRegister.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Password:"
        '
        'btnAccount
        '
        Me.btnAccount.BackColor = System.Drawing.Color.ForestGreen
        Me.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccount.Location = New System.Drawing.Point(243, 474)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(314, 57)
        Me.btnAccount.TabIndex = 15
        Me.btnAccount.Text = "Create account"
        Me.btnAccount.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(146, -29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(692, 169)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(282, 452)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Don't have an account yet?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(145, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 34)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Welcome to FoodCheetah, Your food ordering buddy!"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox9.Image = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox9.Location = New System.Drawing.Point(754, 466)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 18
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 536)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnAccount)
        Me.Controls.Add(Me.groupBoxRegister)
        Me.Controls.Add(Me.groupBoxLogin)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FoodCheetah"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBoxLogin.ResumeLayout(False)
        Me.groupBoxLogin.PerformLayout()
        Me.groupBoxRegister.ResumeLayout(False)
        Me.groupBoxRegister.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents txtLoginEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents groupBoxLogin As GroupBox
    Friend WithEvents groupBoxRegister As GroupBox
    Friend WithEvents txtEmailRegister As TextBox
    Friend WithEvents txtPasswordRegister As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAccount As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnterLogin As Button
    Friend WithEvents btnEnterRegister As Button
    Friend WithEvents txtEmailLogin As TextBox
    Friend WithEvents txtPasswordLogin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox9 As PictureBox
End Class

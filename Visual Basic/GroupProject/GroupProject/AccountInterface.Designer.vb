<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAccInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAccInterface))
        Me.lblUserNickname = New System.Windows.Forms.Label()
        Me.wordChangeEmail = New System.Windows.Forms.Label()
        Me.wordChangePassword = New System.Windows.Forms.Label()
        Me.linkAboutUser = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFavouriteFood = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkDarkMode = New System.Windows.Forms.CheckBox()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserNickname
        '
        Me.lblUserNickname.AutoSize = True
        Me.lblUserNickname.BackColor = System.Drawing.Color.Transparent
        Me.lblUserNickname.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserNickname.Location = New System.Drawing.Point(160, 340)
        Me.lblUserNickname.Name = "lblUserNickname"
        Me.lblUserNickname.Size = New System.Drawing.Size(145, 22)
        Me.lblUserNickname.TabIndex = 2
        Me.lblUserNickname.Text = "User Nickname"
        '
        'wordChangeEmail
        '
        Me.wordChangeEmail.AutoSize = True
        Me.wordChangeEmail.BackColor = System.Drawing.Color.Transparent
        Me.wordChangeEmail.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordChangeEmail.Location = New System.Drawing.Point(449, 245)
        Me.wordChangeEmail.Name = "wordChangeEmail"
        Me.wordChangeEmail.Size = New System.Drawing.Size(138, 22)
        Me.wordChangeEmail.TabIndex = 3
        Me.wordChangeEmail.Text = "Change Email"
        '
        'wordChangePassword
        '
        Me.wordChangePassword.AutoSize = True
        Me.wordChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.wordChangePassword.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordChangePassword.Location = New System.Drawing.Point(449, 295)
        Me.wordChangePassword.Name = "wordChangePassword"
        Me.wordChangePassword.Size = New System.Drawing.Size(177, 22)
        Me.wordChangePassword.TabIndex = 4
        Me.wordChangePassword.Text = "Change Password"
        '
        'linkAboutUser
        '
        Me.linkAboutUser.AutoSize = True
        Me.linkAboutUser.BackColor = System.Drawing.Color.Transparent
        Me.linkAboutUser.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkAboutUser.Location = New System.Drawing.Point(449, 66)
        Me.linkAboutUser.Name = "linkAboutUser"
        Me.linkAboutUser.Size = New System.Drawing.Size(111, 22)
        Me.linkAboutUser.TabIndex = 7
        Me.linkAboutUser.Text = "About User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(449, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Favourite Food:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Age:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(449, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Location:"
        '
        'lblFavouriteFood
        '
        Me.lblFavouriteFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFavouriteFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFavouriteFood.Location = New System.Drawing.Point(543, 111)
        Me.lblFavouriteFood.Name = "lblFavouriteFood"
        Me.lblFavouriteFood.Size = New System.Drawing.Size(145, 21)
        Me.lblFavouriteFood.TabIndex = 12
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Honeydew
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(419, 45)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(10, 347)
        Me.lblAge.TabIndex = 13
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.Color.Honeydew
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(419, 215)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(265, 10)
        Me.lblLocation.TabIndex = 14
        '
        'pbUser
        '
        Me.pbUser.BackColor = System.Drawing.Color.Transparent
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(107, 66)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(255, 263)
        Me.pbUser.TabIndex = 1
        Me.pbUser.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.BackgroundImage = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(719, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 71)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'chkDarkMode
        '
        Me.chkDarkMode.AutoSize = True
        Me.chkDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.chkDarkMode.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDarkMode.Location = New System.Drawing.Point(453, 340)
        Me.chkDarkMode.Name = "chkDarkMode"
        Me.chkDarkMode.Size = New System.Drawing.Size(164, 32)
        Me.chkDarkMode.TabIndex = 18
        Me.chkDarkMode.Text = "Dark Mode"
        Me.chkDarkMode.UseVisualStyleBackColor = False
        '
        'formAccInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.ClientSize = New System.Drawing.Size(831, 504)
        Me.Controls.Add(Me.chkDarkMode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblFavouriteFood)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.linkAboutUser)
        Me.Controls.Add(Me.wordChangePassword)
        Me.Controls.Add(Me.wordChangeEmail)
        Me.Controls.Add(Me.lblUserNickname)
        Me.Controls.Add(Me.pbUser)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "formAccInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Interface"
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents lblUserNickname As Label
    Friend WithEvents wordChangeEmail As Label
    Friend WithEvents wordChangePassword As Label
    Friend WithEvents linkAboutUser As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFavouriteFood As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkDarkMode As CheckBox
End Class

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
        Me.components = New System.ComponentModel.Container()
        Dim Favourite_FoodLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAccInterface))
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.wordChangeEmail = New System.Windows.Forms.Label()
        Me.wordChangePassword = New System.Windows.Forms.Label()
        Me.lblAccountDetails = New System.Windows.Forms.Label()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasegpDataSet = New GroupProject.databasegpDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chkDarkMode = New System.Windows.Forms.CheckBox()
        Me.Favourite_FoodTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTableAdapter = New GroupProject.databasegpDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New GroupProject.databasegpDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Favourite_FoodLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Favourite_FoodLabel
        '
        Favourite_FoodLabel.AutoSize = True
        Favourite_FoodLabel.BackColor = System.Drawing.Color.Transparent
        Favourite_FoodLabel.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Favourite_FoodLabel.Location = New System.Drawing.Point(505, 134)
        Favourite_FoodLabel.Name = "Favourite_FoodLabel"
        Favourite_FoodLabel.Size = New System.Drawing.Size(177, 25)
        Favourite_FoodLabel.TabIndex = 18
        Favourite_FoodLabel.Text = "Favourite Food:"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblUserEmail.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(133, 425)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(125, 25)
        Me.lblUserEmail.TabIndex = 2
        Me.lblUserEmail.Text = "Welcome!"
        '
        'wordChangeEmail
        '
        Me.wordChangeEmail.AutoSize = True
        Me.wordChangeEmail.BackColor = System.Drawing.Color.Transparent
        Me.wordChangeEmail.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordChangeEmail.Location = New System.Drawing.Point(505, 306)
        Me.wordChangeEmail.Name = "wordChangeEmail"
        Me.wordChangeEmail.Size = New System.Drawing.Size(171, 25)
        Me.wordChangeEmail.TabIndex = 3
        Me.wordChangeEmail.Text = "Change Email:"
        '
        'wordChangePassword
        '
        Me.wordChangePassword.AutoSize = True
        Me.wordChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.wordChangePassword.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wordChangePassword.Location = New System.Drawing.Point(505, 369)
        Me.wordChangePassword.Name = "wordChangePassword"
        Me.wordChangePassword.Size = New System.Drawing.Size(214, 25)
        Me.wordChangePassword.TabIndex = 4
        Me.wordChangePassword.Text = "Change Password:"
        '
        'lblAccountDetails
        '
        Me.lblAccountDetails.AutoSize = True
        Me.lblAccountDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblAccountDetails.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountDetails.Location = New System.Drawing.Point(504, 28)
        Me.lblAccountDetails.Name = "lblAccountDetails"
        Me.lblAccountDetails.Size = New System.Drawing.Size(234, 25)
        Me.lblAccountDetails.TabIndex = 7
        Me.lblAccountDetails.Text = "Edit Account Details:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.DatabasegpDataSet
        '
        'DatabasegpDataSet
        '
        Me.DatabasegpDataSet.DataSetName = "databasegpDataSet"
        Me.DatabasegpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Location:"
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Honeydew
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(471, 56)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(11, 434)
        Me.lblAge.TabIndex = 13
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.Color.Honeydew
        Me.lblLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(471, 269)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(450, 12)
        Me.lblLocation.TabIndex = 14
        '
        'pbUser
        '
        Me.pbUser.BackColor = System.Drawing.Color.Transparent
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUser.Image = CType(resources.GetObject("pbUser.Image"), System.Drawing.Image)
        Me.pbUser.Location = New System.Drawing.Point(120, 82)
        Me.pbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(287, 329)
        Me.pbUser.TabIndex = 1
        Me.pbUser.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.BackgroundImage = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(809, 511)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 89)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'chkDarkMode
        '
        Me.chkDarkMode.AutoSize = True
        Me.chkDarkMode.BackColor = System.Drawing.Color.Transparent
        Me.chkDarkMode.Checked = True
        Me.chkDarkMode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDarkMode.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDarkMode.Location = New System.Drawing.Point(510, 425)
        Me.chkDarkMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkDarkMode.Name = "chkDarkMode"
        Me.chkDarkMode.Size = New System.Drawing.Size(191, 38)
        Me.chkDarkMode.TabIndex = 18
        Me.chkDarkMode.Text = "Dark Mode"
        Me.chkDarkMode.UseVisualStyleBackColor = False
        '
        'Favourite_FoodTextBox
        '
        Me.Favourite_FoodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Favourite_Food", True))
        Me.Favourite_FoodTextBox.Location = New System.Drawing.Point(684, 134)
        Me.Favourite_FoodTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Favourite_FoodTextBox.Name = "Favourite_FoodTextBox"
        Me.Favourite_FoodTextBox.Size = New System.Drawing.Size(237, 26)
        Me.Favourite_FoodTextBox.TabIndex = 19
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(619, 180)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(112, 26)
        Me.AgeTextBox.TabIndex = 20
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Location", True))
        Me.LocationTextBox.Location = New System.Drawing.Point(619, 224)
        Me.LocationTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(302, 26)
        Me.LocationTextBox.TabIndex = 21
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(673, 306)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(248, 26)
        Me.EmailTextBox.TabIndex = 22
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(717, 369)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(204, 26)
        Me.PasswordTextBox.TabIndex = 23
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ReceiptTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GroupProject.databasegpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(631, 88)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(112, 26)
        Me.UsernameTextBox.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(505, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Username:"
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Username", True))
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(252, 424)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(112, 29)
        Me.lblUsername.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(505, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Age:"
        '
        'formAccInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.ClientSize = New System.Drawing.Size(1034, 630)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Favourite_FoodLabel)
        Me.Controls.Add(Me.Favourite_FoodTextBox)
        Me.Controls.Add(Me.chkDarkMode)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAccountDetails)
        Me.Controls.Add(Me.wordChangePassword)
        Me.Controls.Add(Me.wordChangeEmail)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.pbUser)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "formAccInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Interface"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents lblUserEmail As Label
    Friend WithEvents wordChangeEmail As Label
    Friend WithEvents wordChangePassword As Label
    Friend WithEvents lblAccountDetails As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chkDarkMode As CheckBox
    Friend WithEvents DatabasegpDataSet As databasegpDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As databasegpDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As databasegpDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Favourite_FoodTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label2 As Label
End Class

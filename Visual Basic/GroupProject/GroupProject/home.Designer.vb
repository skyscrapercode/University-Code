<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.ForestGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(831, 33)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem1, Me.LogOutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(61, 29)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AccountToolStripMenuItem1
        '
        Me.AccountToolStripMenuItem1.Name = "AccountToolStripMenuItem1"
        Me.AccountToolStripMenuItem1.Size = New System.Drawing.Size(221, 30)
        Me.AccountToolStripMenuItem1.Text = "Account"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(221, 30)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(74, 29)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(177, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(744, 34)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Welcome to FoodCheetah, Your food ordering buddy!"
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.ForestGreen
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(13, 364)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(330, 127)
        Me.btnHistory.TabIndex = 18
        Me.btnHistory.Text = "Order History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(394, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 204)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "What's New?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-----------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UPDATED USER INTERFACE!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NEW FO" &
    "OD ADDED!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NEW DARK MODE THEME ADDED!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CELEBRATE HARI RAYA WITH US!"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(369, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 277)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Label2"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(182, 32)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(649, 136)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.BackgroundImage = Global.GroupProject.My.Resources.Resources.logoutbtn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(723, 429)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.ForestGreen
        Me.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.Black
        Me.btnOrder.Location = New System.Drawing.Point(13, 222)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(330, 127)
        Me.btnOrder.TabIndex = 7
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(162, 136)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(831, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnHistory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AccountToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
End Class

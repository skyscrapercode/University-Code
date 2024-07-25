<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDisplayFoodFact = New System.Windows.Forms.Button()
        Me.radBlueberry = New System.Windows.Forms.RadioButton()
        Me.radPopcorn = New System.Windows.Forms.RadioButton()
        Me.radBanana = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnDisplayFoodFact)
        Me.GroupBox1.Controls.Add(Me.radBlueberry)
        Me.GroupBox1.Controls.Add(Me.radPopcorn)
        Me.GroupBox1.Controls.Add(Me.radBanana)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 219)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Food"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(145, 145)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 49)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDisplayFoodFact
        '
        Me.btnDisplayFoodFact.Location = New System.Drawing.Point(11, 145)
        Me.btnDisplayFoodFact.Name = "btnDisplayFoodFact"
        Me.btnDisplayFoodFact.Size = New System.Drawing.Size(101, 49)
        Me.btnDisplayFoodFact.TabIndex = 3
        Me.btnDisplayFoodFact.Text = "Display Food Facts"
        Me.btnDisplayFoodFact.UseVisualStyleBackColor = True
        '
        'radBlueberry
        '
        Me.radBlueberry.AutoSize = True
        Me.radBlueberry.Location = New System.Drawing.Point(11, 94)
        Me.radBlueberry.Name = "radBlueberry"
        Me.radBlueberry.Size = New System.Drawing.Size(179, 21)
        Me.radBlueberry.TabIndex = 2
        Me.radBlueberry.TabStop = True
        Me.radBlueberry.Text = "1 large blueberry muffin"
        Me.radBlueberry.UseVisualStyleBackColor = True
        '
        'radPopcorn
        '
        Me.radPopcorn.AutoSize = True
        Me.radPopcorn.Location = New System.Drawing.Point(11, 67)
        Me.radPopcorn.Name = "radPopcorn"
        Me.radPopcorn.Size = New System.Drawing.Size(209, 21)
        Me.radPopcorn.TabIndex = 1
        Me.radPopcorn.TabStop = True
        Me.radPopcorn.Text = "1 cup of air-popped popcorn"
        Me.radPopcorn.UseVisualStyleBackColor = True
        '
        'radBanana
        '
        Me.radBanana.AutoSize = True
        Me.radBanana.Location = New System.Drawing.Point(11, 40)
        Me.radBanana.Name = "radBanana"
        Me.radBanana.Size = New System.Drawing.Size(90, 21)
        Me.radBanana.TabIndex = 0
        Me.radBanana.TabStop = True
        Me.radBanana.Text = "1 Banana"
        Me.radBanana.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(399, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(216, 26)
        Me.mnuHelpAbout.Text = "About"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDisplayFoodFact As Button
    Friend WithEvents radBlueberry As RadioButton
    Friend WithEvents radPopcorn As RadioButton
    Friend WithEvents radBanana As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class

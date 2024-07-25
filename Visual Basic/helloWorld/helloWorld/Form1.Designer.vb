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
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.mnuForm = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectcolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSelectfont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.ofdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSave = New System.Windows.Forms.SaveFileDialog()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.fdFont = New System.Windows.Forms.FontDialog()
        Me.mnuForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelloWorld.Location = New System.Drawing.Point(136, 234)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(470, 91)
        Me.lblHelloWorld.TabIndex = 0
        Me.lblHelloWorld.Text = "Hello World!"
        '
        'mnuForm
        '
        Me.mnuForm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuColor, Me.mnuHelp})
        Me.mnuForm.Location = New System.Drawing.Point(0, 0)
        Me.mnuForm.Name = "mnuForm"
        Me.mnuForm.Size = New System.Drawing.Size(800, 28)
        Me.mnuForm.TabIndex = 1
        Me.mnuForm.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.ToolStripSeparator2, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(216, 26)
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(216, 26)
        Me.mnuFileSave.Text = "Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(213, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(216, 26)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditSelectcolor, Me.mnuEditSelectfont})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditSelectcolor
        '
        Me.mnuEditSelectcolor.Name = "mnuEditSelectcolor"
        Me.mnuEditSelectcolor.Size = New System.Drawing.Size(216, 26)
        Me.mnuEditSelectcolor.Text = "Select Color"
        '
        'mnuEditSelectfont
        '
        Me.mnuEditSelectfont.Name = "mnuEditSelectfont"
        Me.mnuEditSelectfont.Size = New System.Drawing.Size(216, 26)
        Me.mnuEditSelectfont.Text = "Select Font"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorRed, Me.mnuColorGreen, Me.mnuColorBlue, Me.mnuColorBlack, Me.ToolStripSeparator1, Me.mnuColorVisible})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(57, 24)
        Me.mnuColor.Text = "Color"
        '
        'mnuColorRed
        '
        Me.mnuColorRed.Name = "mnuColorRed"
        Me.mnuColorRed.Size = New System.Drawing.Size(128, 26)
        Me.mnuColorRed.Text = "Red"
        '
        'mnuColorGreen
        '
        Me.mnuColorGreen.Name = "mnuColorGreen"
        Me.mnuColorGreen.Size = New System.Drawing.Size(128, 26)
        Me.mnuColorGreen.Text = "Green"
        '
        'mnuColorBlue
        '
        Me.mnuColorBlue.Name = "mnuColorBlue"
        Me.mnuColorBlue.Size = New System.Drawing.Size(128, 26)
        Me.mnuColorBlue.Text = "Blue"
        '
        'mnuColorBlack
        '
        Me.mnuColorBlack.Name = "mnuColorBlack"
        Me.mnuColorBlack.Size = New System.Drawing.Size(128, 26)
        Me.mnuColorBlack.Text = "Black"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(125, 6)
        '
        'mnuColorVisible
        '
        Me.mnuColorVisible.Checked = True
        Me.mnuColorVisible.CheckOnClick = True
        Me.mnuColorVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuColorVisible.Name = "mnuColorVisible"
        Me.mnuColorVisible.Size = New System.Drawing.Size(128, 26)
        Me.mnuColorVisible.Text = "Visible"
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
        Me.mnuHelpAbout.Size = New System.Drawing.Size(125, 26)
        Me.mnuHelpAbout.Text = "About"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(152, 61)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(437, 145)
        Me.txtInput.TabIndex = 2
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(626, 99)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(141, 60)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ofdOpen
        '
        Me.ofdOpen.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.mnuForm)
        Me.MainMenuStrip = Me.mnuForm
        Me.Name = "Form1"
        Me.Text = "Menu Demo"
        Me.mnuForm.ResumeLayout(False)
        Me.mnuForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHelloWorld As Label
    Friend WithEvents mnuForm As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuColorRed As ToolStripMenuItem
    Friend WithEvents mnuColorGreen As ToolStripMenuItem
    Friend WithEvents mnuColorBlue As ToolStripMenuItem
    Friend WithEvents mnuColorBlack As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuColorVisible As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditSelectcolor As ToolStripMenuItem
    Friend WithEvents mnuEditSelectfont As ToolStripMenuItem
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents ofdOpen As OpenFileDialog
    Friend WithEvents sfdSave As SaveFileDialog
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents fdFont As FontDialog
End Class

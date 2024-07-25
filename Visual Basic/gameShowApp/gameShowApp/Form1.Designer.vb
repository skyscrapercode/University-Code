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
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstContestants = New System.Windows.Forms.ListBox()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'txtNameInput
        '
        Me.txtNameInput.Location = New System.Drawing.Point(67, 21)
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(320, 22)
        Me.txtNameInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contestants:"
        '
        'lstContestants
        '
        Me.lstContestants.FormattingEnabled = True
        Me.lstContestants.ItemHeight = 16
        Me.lstContestants.Location = New System.Drawing.Point(15, 98)
        Me.lstContestants.Name = "lstContestants"
        Me.lstContestants.Size = New System.Drawing.Size(372, 196)
        Me.lstContestants.TabIndex = 3
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(15, 316)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(121, 39)
        Me.btnWrite.TabIndex = 4
        Me.btnWrite.Text = "Write to file"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(142, 316)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(121, 39)
        Me.btnRead.TabIndex = 5
        Me.btnRead.Text = "Read from file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(269, 317)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.lstContestants)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNameInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Game Show"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNameInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstContestants As ListBox
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents btnExit As Button
End Class

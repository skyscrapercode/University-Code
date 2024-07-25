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
        Me.btnMemory = New System.Windows.Forms.Button()
        Me.btnMemory2 = New System.Windows.Forms.Button()
        Me.btnMemory3 = New System.Windows.Forms.Button()
        Me.btnBirthdaySong = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBackgroundColor = New System.Windows.Forms.Button()
        Me.cdColor = New System.Windows.Forms.ColorDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1254, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INSERT TEXT HERE"
        '
        'btnMemory
        '
        Me.btnMemory.Location = New System.Drawing.Point(1254, 195)
        Me.btnMemory.Name = "btnMemory"
        Me.btnMemory.Size = New System.Drawing.Size(200, 100)
        Me.btnMemory.TabIndex = 2
        Me.btnMemory.Text = "Memories1"
        Me.btnMemory.UseVisualStyleBackColor = True
        '
        'btnMemory2
        '
        Me.btnMemory2.Location = New System.Drawing.Point(1465, 195)
        Me.btnMemory2.Name = "btnMemory2"
        Me.btnMemory2.Size = New System.Drawing.Size(200, 100)
        Me.btnMemory2.TabIndex = 3
        Me.btnMemory2.Text = "Memories2"
        Me.btnMemory2.UseVisualStyleBackColor = True
        '
        'btnMemory3
        '
        Me.btnMemory3.Location = New System.Drawing.Point(1465, 301)
        Me.btnMemory3.Name = "btnMemory3"
        Me.btnMemory3.Size = New System.Drawing.Size(200, 100)
        Me.btnMemory3.TabIndex = 4
        Me.btnMemory3.Text = "Memories3"
        Me.btnMemory3.UseVisualStyleBackColor = True
        '
        'btnBirthdaySong
        '
        Me.btnBirthdaySong.Location = New System.Drawing.Point(1254, 301)
        Me.btnBirthdaySong.Name = "btnBirthdaySong"
        Me.btnBirthdaySong.Size = New System.Drawing.Size(200, 100)
        Me.btnBirthdaySong.TabIndex = 5
        Me.btnBirthdaySong.Text = "Birthday Song"
        Me.btnBirthdaySong.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1465, 407)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 100)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBackgroundColor
        '
        Me.btnBackgroundColor.Location = New System.Drawing.Point(1254, 407)
        Me.btnBackgroundColor.Name = "btnBackgroundColor"
        Me.btnBackgroundColor.Size = New System.Drawing.Size(200, 100)
        Me.btnBackgroundColor.TabIndex = 9
        Me.btnBackgroundColor.Text = "Change Background Color"
        Me.btnBackgroundColor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1254, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "INSERT TEXT HERE"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBackgroundColor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBirthdaySong)
        Me.Controls.Add(Me.btnMemory3)
        Me.Controls.Add(Me.btnMemory2)
        Me.Controls.Add(Me.btnMemory)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Happy Birthday Maa!"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnMemory As Button
    Friend WithEvents btnMemory2 As Button
    Friend WithEvents btnMemory3 As Button
    Friend WithEvents btnBirthdaySong As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBackgroundColor As Button
    Friend WithEvents cdColor As ColorDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

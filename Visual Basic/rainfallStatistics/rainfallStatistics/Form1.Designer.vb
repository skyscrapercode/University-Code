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
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnStat = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 16
        Me.lstDisplay.Location = New System.Drawing.Point(12, 12)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(312, 388)
        Me.lstDisplay.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monthly Rainfall Statistics"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(351, 62)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(377, 23)
        Me.lblTotal.TabIndex = 2
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(351, 100)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(377, 23)
        Me.lblAverage.TabIndex = 3
        '
        'lblMinimum
        '
        Me.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinimum.Location = New System.Drawing.Point(351, 139)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(377, 23)
        Me.lblMinimum.TabIndex = 4
        '
        'lblMaximum
        '
        Me.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaximum.Location = New System.Drawing.Point(351, 187)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(377, 23)
        Me.lblMaximum.TabIndex = 5
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(330, 377)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(196, 37)
        Me.btnInput.TabIndex = 6
        Me.btnInput.Text = "Input Monthly Rainfall"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnStat
        '
        Me.btnStat.Location = New System.Drawing.Point(532, 377)
        Me.btnStat.Name = "btnStat"
        Me.btnStat.Size = New System.Drawing.Size(115, 37)
        Me.btnStat.TabIndex = 7
        Me.btnStat.Text = "Display Stat"
        Me.btnStat.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(653, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 37)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(734, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 37)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStat)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lblMaximum)
        Me.Controls.Add(Me.lblMinimum)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstDisplay)
        Me.Name = "Form1"
        Me.Text = "Rainfall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMinimum As Label
    Friend WithEvents lblMaximum As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents btnStat As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

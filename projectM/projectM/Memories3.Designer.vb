<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Memories3
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INSERT TEXT HERE"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(359, 384)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(167, 54)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Memories3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Memories3"
        Me.Text = "Memories3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
End Class

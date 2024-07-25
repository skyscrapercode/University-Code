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
        Me.txtSecretWord = New System.Windows.Forms.TextBox()
        Me.txtOK = New System.Windows.Forms.Button()
        Me.txtExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the secret word:"
        '
        'txtSecretWord
        '
        Me.txtSecretWord.Location = New System.Drawing.Point(165, 34)
        Me.txtSecretWord.Name = "txtSecretWord"
        Me.txtSecretWord.Size = New System.Drawing.Size(220, 22)
        Me.txtSecretWord.TabIndex = 1
        '
        'txtOK
        '
        Me.txtOK.Location = New System.Drawing.Point(42, 170)
        Me.txtOK.Name = "txtOK"
        Me.txtOK.Size = New System.Drawing.Size(83, 29)
        Me.txtOK.TabIndex = 3
        Me.txtOK.Text = "Ok"
        Me.txtOK.UseVisualStyleBackColor = True
        '
        'txtExit
        '
        Me.txtExit.Location = New System.Drawing.Point(275, 167)
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(98, 35)
        Me.txtExit.TabIndex = 4
        Me.txtExit.Text = "Exit"
        Me.txtExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 71)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(373, 87)
        Me.lblResult.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 218)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtExit)
        Me.Controls.Add(Me.txtOK)
        Me.Controls.Add(Me.txtSecretWord)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Secret Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSecretWord As TextBox
    Friend WithEvents txtOK As Button
    Friend WithEvents txtExit As Button
    Friend WithEvents lblResult As Label
End Class

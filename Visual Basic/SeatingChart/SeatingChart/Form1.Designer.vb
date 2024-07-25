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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColumnInput = New System.Windows.Forms.TextBox()
        Me.txtRowInput = New System.Windows.Forms.TextBox()
        Me.lblBestPrice = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Row:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter a Column:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Best Price:"
        '
        'txtColumnInput
        '
        Me.txtColumnInput.Location = New System.Drawing.Point(116, 47)
        Me.txtColumnInput.Name = "txtColumnInput"
        Me.txtColumnInput.Size = New System.Drawing.Size(100, 22)
        Me.txtColumnInput.TabIndex = 3
        '
        'txtRowInput
        '
        Me.txtRowInput.Location = New System.Drawing.Point(116, 16)
        Me.txtRowInput.Name = "txtRowInput"
        Me.txtRowInput.Size = New System.Drawing.Size(100, 22)
        Me.txtRowInput.TabIndex = 4
        '
        'lblBestPrice
        '
        Me.lblBestPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBestPrice.Location = New System.Drawing.Point(322, 19)
        Me.lblBestPrice.Name = "lblBestPrice"
        Me.lblBestPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblBestPrice.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SeatingChart.My.Resources.Resources.photo_6302825702306723904_x
        Me.PictureBox1.Location = New System.Drawing.Point(46, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 297)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(46, 378)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(139, 50)
        Me.btnPrice.TabIndex = 7
        Me.btnPrice.Text = "DIsplay Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(243, 378)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 50)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblBestPrice)
        Me.Controls.Add(Me.txtRowInput)
        Me.Controls.Add(Me.txtColumnInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Seating Chart"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColumnInput As TextBox
    Friend WithEvents txtRowInput As TextBox
    Friend WithEvents lblBestPrice As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPrice As Button
    Friend WithEvents btnExit As Button
End Class

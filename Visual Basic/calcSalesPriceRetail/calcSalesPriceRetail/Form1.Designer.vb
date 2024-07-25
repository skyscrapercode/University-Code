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
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Retail Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Discount Percentage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(160, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sale Price:"
        '
        'lblSalePrice
        '
        Me.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalePrice.Location = New System.Drawing.Point(241, 74)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(100, 23)
        Me.lblSalePrice.TabIndex = 3
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(241, 9)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtRetailPrice.TabIndex = 4
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(241, 40)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.Size = New System.Drawing.Size(100, 22)
        Me.txtDiscountPercent.TabIndex = 5
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(12, 116)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(530, 150)
        Me.lblMessage.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(62, 289)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 74)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(297, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 74)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtDiscountPercent)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(Me.lblSalePrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sale Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSalePrice As Label
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents txtDiscountPercent As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
End Class

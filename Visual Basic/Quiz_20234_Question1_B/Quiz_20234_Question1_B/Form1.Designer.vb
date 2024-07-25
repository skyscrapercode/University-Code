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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSellingPriceBeforeTax = New System.Windows.Forms.Label()
        Me.lblSellingPrice = New System.Windows.Forms.Label()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtMarkup = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Markup Percentage (%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Selling Price Before Tax"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Selling Price"
        '
        'lblSellingPriceBeforeTax
        '
        Me.lblSellingPriceBeforeTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSellingPriceBeforeTax.Location = New System.Drawing.Point(399, 174)
        Me.lblSellingPriceBeforeTax.Name = "lblSellingPriceBeforeTax"
        Me.lblSellingPriceBeforeTax.Size = New System.Drawing.Size(100, 23)
        Me.lblSellingPriceBeforeTax.TabIndex = 4
        '
        'lblSellingPrice
        '
        Me.lblSellingPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSellingPrice.Location = New System.Drawing.Point(399, 206)
        Me.lblSellingPrice.Name = "lblSellingPrice"
        Me.lblSellingPrice.Size = New System.Drawing.Size(100, 23)
        Me.lblSellingPrice.TabIndex = 5
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(399, 112)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtCostPrice.TabIndex = 6
        '
        'txtMarkup
        '
        Me.txtMarkup.Location = New System.Drawing.Point(399, 140)
        Me.txtMarkup.Name = "txtMarkup"
        Me.txtMarkup.Size = New System.Drawing.Size(100, 22)
        Me.txtMarkup.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(304, 255)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(86, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMarkup)
        Me.Controls.Add(Me.txtCostPrice)
        Me.Controls.Add(Me.lblSellingPrice)
        Me.Controls.Add(Me.lblSellingPriceBeforeTax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Selling Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSellingPriceBeforeTax As Label
    Friend WithEvents lblSellingPrice As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents txtMarkup As TextBox
    Friend WithEvents btnCalculate As Button
End Class

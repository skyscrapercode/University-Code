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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.lblCommissionRate = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtAdvancePay = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales for the month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Advance pay awarded:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Commission Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Commission:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Net Pay:"
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Location = New System.Drawing.Point(216, 155)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(126, 23)
        Me.lblNetPay.TabIndex = 7
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommission.Location = New System.Drawing.Point(216, 125)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(126, 23)
        Me.lblCommission.TabIndex = 8
        '
        'lblCommissionRate
        '
        Me.lblCommissionRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCommissionRate.Location = New System.Drawing.Point(216, 96)
        Me.lblCommissionRate.Name = "lblCommissionRate"
        Me.lblCommissionRate.Size = New System.Drawing.Size(126, 23)
        Me.lblCommissionRate.TabIndex = 9
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(216, 7)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(126, 22)
        Me.txtSales.TabIndex = 10
        '
        'txtAdvancePay
        '
        Me.txtAdvancePay.Location = New System.Drawing.Point(216, 39)
        Me.txtAdvancePay.Name = "txtAdvancePay"
        Me.txtAdvancePay.Size = New System.Drawing.Size(126, 22)
        Me.txtAdvancePay.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(16, 211)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 50)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(174, 211)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 50)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(315, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtAdvancePay)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.lblCommissionRate)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Commission Calculate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents lblCommissionRate As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtAdvancePay As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class

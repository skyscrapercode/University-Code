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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radVIP = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radVIP)
        Me.GroupBox1.Controls.Add(Me.radStandard)
        Me.GroupBox1.Controls.Add(Me.txtTickets)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'radVIP
        '
        Me.radVIP.AutoSize = True
        Me.radVIP.Location = New System.Drawing.Point(191, 88)
        Me.radVIP.Name = "radVIP"
        Me.radVIP.Size = New System.Drawing.Size(50, 21)
        Me.radVIP.TabIndex = 4
        Me.radVIP.TabStop = True
        Me.radVIP.Text = "VIP"
        Me.radVIP.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(191, 54)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(87, 21)
        Me.radStandard.TabIndex = 3
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'txtTickets
        '
        Me.txtTickets.Location = New System.Drawing.Point(35, 54)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(100, 22)
        Me.txtTickets.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tickets:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(507, 83)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 53)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subtotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Discount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total due:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(197, 240)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 9
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(197, 291)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 10
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDue.Location = New System.Drawing.Point(197, 347)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDue.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Concert Tickets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radVIP As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotalDue As Label
End Class

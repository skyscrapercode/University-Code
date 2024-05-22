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
        Me.chkChocolateSyrup = New System.Windows.Forms.CheckBox()
        Me.chkSprinkles = New System.Windows.Forms.CheckBox()
        Me.chkMarshmellow = New System.Windows.Forms.CheckBox()
        Me.btnToppings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What would you like as toppings for your ice cream"
        '
        'chkChocolateSyrup
        '
        Me.chkChocolateSyrup.AutoSize = True
        Me.chkChocolateSyrup.Location = New System.Drawing.Point(210, 49)
        Me.chkChocolateSyrup.Name = "chkChocolateSyrup"
        Me.chkChocolateSyrup.Size = New System.Drawing.Size(167, 21)
        Me.chkChocolateSyrup.TabIndex = 1
        Me.chkChocolateSyrup.Text = "Chocolate Syrup RM2"
        Me.chkChocolateSyrup.UseVisualStyleBackColor = True
        '
        'chkSprinkles
        '
        Me.chkSprinkles.AutoSize = True
        Me.chkSprinkles.Location = New System.Drawing.Point(210, 76)
        Me.chkSprinkles.Name = "chkSprinkles"
        Me.chkSprinkles.Size = New System.Drawing.Size(121, 21)
        Me.chkSprinkles.TabIndex = 2
        Me.chkSprinkles.Text = "Sprinkles RM1"
        Me.chkSprinkles.UseVisualStyleBackColor = True
        '
        'chkMarshmellow
        '
        Me.chkMarshmellow.AutoSize = True
        Me.chkMarshmellow.Location = New System.Drawing.Point(210, 103)
        Me.chkMarshmellow.Name = "chkMarshmellow"
        Me.chkMarshmellow.Size = New System.Drawing.Size(164, 21)
        Me.chkMarshmellow.TabIndex = 3
        Me.chkMarshmellow.Text = "Marshmellow RM1.50"
        Me.chkMarshmellow.UseVisualStyleBackColor = True
        '
        'btnToppings
        '
        Me.btnToppings.Location = New System.Drawing.Point(210, 130)
        Me.btnToppings.Name = "btnToppings"
        Me.btnToppings.Size = New System.Drawing.Size(121, 34)
        Me.btnToppings.TabIndex = 4
        Me.btnToppings.Text = "Add my toppings"
        Me.btnToppings.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnToppings)
        Me.Controls.Add(Me.chkMarshmellow)
        Me.Controls.Add(Me.chkSprinkles)
        Me.Controls.Add(Me.chkChocolateSyrup)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkChocolateSyrup As CheckBox
    Friend WithEvents chkSprinkles As CheckBox
    Friend WithEvents chkMarshmellow As CheckBox
    Friend WithEvents btnToppings As Button
End Class

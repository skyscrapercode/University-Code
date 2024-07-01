<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkout
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
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblDrinks = New System.Windows.Forms.Label()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnFPX = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(309, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 70)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Checkout"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(99, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order Summary: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(108, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 34)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Food"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(108, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 34)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Drinks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(108, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sides"
        '
        'lblFood
        '
        Me.lblFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFood.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFood.Location = New System.Drawing.Point(213, 174)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(250, 36)
        Me.lblFood.TabIndex = 5
        '
        'lblDrinks
        '
        Me.lblDrinks.BackColor = System.Drawing.Color.Transparent
        Me.lblDrinks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDrinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinks.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDrinks.Location = New System.Drawing.Point(213, 222)
        Me.lblDrinks.Name = "lblDrinks"
        Me.lblDrinks.Size = New System.Drawing.Size(250, 36)
        Me.lblDrinks.TabIndex = 11
        '
        'lblSides
        '
        Me.lblSides.BackColor = System.Drawing.Color.Transparent
        Me.lblSides.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSides.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSides.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSides.Location = New System.Drawing.Point(213, 271)
        Me.lblSides.Name = "lblSides"
        Me.lblSides.Size = New System.Drawing.Size(250, 36)
        Me.lblSides.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(226, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(504, 45)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "How would you like to pay?"
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Green
        Me.btnCash.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.Location = New System.Drawing.Point(164, 408)
        Me.btnCash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(166, 102)
        Me.btnCash.TabIndex = 14
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnFPX
        '
        Me.btnFPX.BackColor = System.Drawing.Color.Green
        Me.btnFPX.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFPX.Location = New System.Drawing.Point(364, 408)
        Me.btnFPX.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFPX.Name = "btnFPX"
        Me.btnFPX.Size = New System.Drawing.Size(166, 102)
        Me.btnFPX.TabIndex = 15
        Me.btnFPX.Text = "FPX"
        Me.btnFPX.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.BackColor = System.Drawing.Color.Green
        Me.btnCard.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.Location = New System.Drawing.Point(570, 408)
        Me.btnCard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(166, 102)
        Me.btnCard.TabIndex = 16
        Me.btnCard.Text = "Card"
        Me.btnCard.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(532, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 34)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total payment:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.Location = New System.Drawing.Point(538, 246)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(248, 36)
        Me.lblTotal.TabIndex = 18
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox2.BackgroundImage = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(796, 527)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(935, 630)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnFPX)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblSides)
        Me.Controls.Add(Me.lblDrinks)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblFood As Label
    Friend WithEvents lblDrinks As Label
    Friend WithEvents lblSides As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCash As Button
    Friend WithEvents btnFPX As Button
    Friend WithEvents btnCard As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class

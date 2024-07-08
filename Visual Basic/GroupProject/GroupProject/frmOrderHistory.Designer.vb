<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrderHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrderHistory))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Receipt_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrinksName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SidesName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasegpDataSet = New GroupProject.databasegpDataSet()
        Me.ReceiptTableAdapter = New GroupProject.databasegpDataSetTableAdapters.ReceiptTableAdapter()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New GroupProject.databasegpDataSetTableAdapters.PaymentTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox1.Location = New System.Drawing.Point(861, 505)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(475, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 87)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order History"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Receipt_ID, Me.TotalPrice, Me.DrinksName, Me.SidesName, Me.FoodName, Me.CurrentDate, Me.PaymentMethod})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 96)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(840, 482)
        Me.DataGridView1.TabIndex = 2
        '
        'Receipt_ID
        '
        Me.Receipt_ID.HeaderText = "Receipt_ID"
        Me.Receipt_ID.Name = "Receipt_ID"
        Me.Receipt_ID.ReadOnly = True
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "TotalPrice"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        '
        'DrinksName
        '
        Me.DrinksName.HeaderText = "DrinksName"
        Me.DrinksName.Name = "DrinksName"
        Me.DrinksName.ReadOnly = True
        '
        'SidesName
        '
        Me.SidesName.HeaderText = "SidesName"
        Me.SidesName.Name = "SidesName"
        Me.SidesName.ReadOnly = True
        '
        'FoodName
        '
        Me.FoodName.HeaderText = "FoodName"
        Me.FoodName.Name = "FoodName"
        Me.FoodName.ReadOnly = True
        '
        'CurrentDate
        '
        Me.CurrentDate.HeaderText = "CurrentDate"
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.ReadOnly = True
        '
        'PaymentMethod
        '
        Me.PaymentMethod.HeaderText = "PaymentMethod"
        Me.PaymentMethod.Name = "PaymentMethod"
        Me.PaymentMethod.ReadOnly = True
        Me.PaymentMethod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'ReceiptBindingSource
        '
        Me.ReceiptBindingSource.DataMember = "Receipt"
        Me.ReceiptBindingSource.DataSource = Me.DatabasegpDataSet
        '
        'DatabasegpDataSet
        '
        Me.DatabasegpDataSet.DataSetName = "databasegpDataSet"
        Me.DatabasegpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiptTableAdapter
        '
        Me.ReceiptTableAdapter.ClearBeforeFill = True
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.DatabasegpDataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'frmOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 604)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmOrderHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order History"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DatabasegpDataSet As databasegpDataSet
    Friend WithEvents ReceiptBindingSource As BindingSource
    Friend WithEvents ReceiptTableAdapter As databasegpDataSetTableAdapters.ReceiptTableAdapter
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As databasegpDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents Receipt_ID As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents DrinksName As DataGridViewTextBoxColumn
    Friend WithEvents SidesName As DataGridViewTextBoxColumn
    Friend WithEvents FoodName As DataGridViewTextBoxColumn
    Friend WithEvents CurrentDate As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethod As DataGridViewTextBoxColumn
End Class

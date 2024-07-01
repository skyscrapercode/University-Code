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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReceiptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrinksNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SidesNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasegpDataSet = New GroupProject.databasegpDataSet()
        Me.ReceiptTableAdapter = New GroupProject.databasegpDataSetTableAdapters.ReceiptTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New GroupProject.databasegpDataSetTableAdapters.PaymentTableAdapter()
        Me.PaymentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.ForestGreen
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.GroupProject.My.Resources.Resources.backBtn
        Me.PictureBox1.Location = New System.Drawing.Point(765, 404)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 59)
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
        Me.Label1.Location = New System.Drawing.Point(422, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 74)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order History"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptIDDataGridViewTextBoxColumn, Me.CurrentDateDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.DrinksNameDataGridViewTextBoxColumn, Me.SidesNameDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiptBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(747, 172)
        Me.DataGridView1.TabIndex = 2
        '
        'ReceiptIDDataGridViewTextBoxColumn
        '
        Me.ReceiptIDDataGridViewTextBoxColumn.DataPropertyName = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.HeaderText = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.Name = "ReceiptIDDataGridViewTextBoxColumn"
        '
        'CurrentDateDataGridViewTextBoxColumn
        '
        Me.CurrentDateDataGridViewTextBoxColumn.DataPropertyName = "CurrentDate"
        Me.CurrentDateDataGridViewTextBoxColumn.HeaderText = "CurrentDate"
        Me.CurrentDateDataGridViewTextBoxColumn.Name = "CurrentDateDataGridViewTextBoxColumn"
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        Me.FoodNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DrinksNameDataGridViewTextBoxColumn
        '
        Me.DrinksNameDataGridViewTextBoxColumn.DataPropertyName = "DrinksName"
        Me.DrinksNameDataGridViewTextBoxColumn.HeaderText = "DrinksName"
        Me.DrinksNameDataGridViewTextBoxColumn.Name = "DrinksNameDataGridViewTextBoxColumn"
        Me.DrinksNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SidesNameDataGridViewTextBoxColumn
        '
        Me.SidesNameDataGridViewTextBoxColumn.DataPropertyName = "SidesName"
        Me.SidesNameDataGridViewTextBoxColumn.HeaderText = "SidesName"
        Me.SidesNameDataGridViewTextBoxColumn.Name = "SidesNameDataGridViewTextBoxColumn"
        Me.SidesNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PaymentIDDataGridViewTextBoxColumn, Me.CustIDDataGridViewTextBoxColumn, Me.ReceiptIDDataGridViewTextBoxColumn1, Me.PaymentMethodDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PaymentBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 255)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(747, 208)
        Me.DataGridView2.TabIndex = 3
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
        'PaymentIDDataGridViewTextBoxColumn
        '
        Me.PaymentIDDataGridViewTextBoxColumn.DataPropertyName = "Payment_ID"
        Me.PaymentIDDataGridViewTextBoxColumn.HeaderText = "Payment_ID"
        Me.PaymentIDDataGridViewTextBoxColumn.Name = "PaymentIDDataGridViewTextBoxColumn"
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        '
        'ReceiptIDDataGridViewTextBoxColumn1
        '
        Me.ReceiptIDDataGridViewTextBoxColumn1.DataPropertyName = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn1.HeaderText = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn1.Name = "ReceiptIDDataGridViewTextBoxColumn1"
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        '
        'frmOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 475)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOrderHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order History"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReceiptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrinksNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SidesNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As databasegpDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents PaymentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptIDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

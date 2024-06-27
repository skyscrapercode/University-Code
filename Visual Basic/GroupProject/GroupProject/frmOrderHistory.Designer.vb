<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderHistory
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReceiptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabasegpDataSet = New GroupProject.databasegpDataSet()
        Me.ReceiptTableAdapter = New GroupProject.databasegpDataSetTableAdapters.ReceiptTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReceiptIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrinksPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SidesPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReceiptIDDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.OrderNoteDataGridViewTextBoxColumn, Me.FoodPriceDataGridViewTextBoxColumn, Me.DrinksPriceDataGridViewTextBoxColumn, Me.SidesPriceDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReceiptBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(747, 341)
        Me.DataGridView1.TabIndex = 2
        '
        'ReceiptIDDataGridViewTextBoxColumn
        '
        Me.ReceiptIDDataGridViewTextBoxColumn.DataPropertyName = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.HeaderText = "Receipt_ID"
        Me.ReceiptIDDataGridViewTextBoxColumn.Name = "ReceiptIDDataGridViewTextBoxColumn"
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date & Time"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "Date & Time"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        '
        'OrderNoteDataGridViewTextBoxColumn
        '
        Me.OrderNoteDataGridViewTextBoxColumn.DataPropertyName = "OrderNote"
        Me.OrderNoteDataGridViewTextBoxColumn.HeaderText = "OrderNote"
        Me.OrderNoteDataGridViewTextBoxColumn.Name = "OrderNoteDataGridViewTextBoxColumn"
        '
        'FoodPriceDataGridViewTextBoxColumn
        '
        Me.FoodPriceDataGridViewTextBoxColumn.DataPropertyName = "FoodPrice"
        Me.FoodPriceDataGridViewTextBoxColumn.HeaderText = "FoodPrice"
        Me.FoodPriceDataGridViewTextBoxColumn.Name = "FoodPriceDataGridViewTextBoxColumn"
        '
        'DrinksPriceDataGridViewTextBoxColumn
        '
        Me.DrinksPriceDataGridViewTextBoxColumn.DataPropertyName = "DrinksPrice"
        Me.DrinksPriceDataGridViewTextBoxColumn.HeaderText = "DrinksPrice"
        Me.DrinksPriceDataGridViewTextBoxColumn.Name = "DrinksPriceDataGridViewTextBoxColumn"
        '
        'SidesPriceDataGridViewTextBoxColumn
        '
        Me.SidesPriceDataGridViewTextBoxColumn.DataPropertyName = "SidesPrice"
        Me.SidesPriceDataGridViewTextBoxColumn.HeaderText = "SidesPrice"
        Me.SidesPriceDataGridViewTextBoxColumn.Name = "SidesPriceDataGridViewTextBoxColumn"
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        '
        'frmOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GroupProject.My.Resources.Resources.greenBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(836, 475)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOrderHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order History"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasegpDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DatabasegpDataSet As databasegpDataSet
    Friend WithEvents ReceiptBindingSource As BindingSource
    Friend WithEvents ReceiptTableAdapter As databasegpDataSetTableAdapters.ReceiptTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReceiptIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderNoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DrinksPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SidesPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

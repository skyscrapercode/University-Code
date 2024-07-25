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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TestDataSet = New testDatabase.testDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New testDatabase.testDataSetTableAdapters.CustomerTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New testDatabase.testDataSetTableAdapters.TableAdapterManager()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(663, 314)
        Me.DataGridView1.TabIndex = 0
        '
        'TestDataSet
        '
        Me.TestDataSet.DataSetName = "testDataSet"
        Me.TestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.TestDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = testDatabase.testDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(92, 30)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDLabel1
        '
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(123, 30)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel1.TabIndex = 2
        Me.IDLabel1.Text = "Label1"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(202, 31)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(257, 28)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NameTextBox.TabIndex = 4
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(395, 33)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(37, 17)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(438, 30)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.AgeTextBox.TabIndex = 6
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(544, 35)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(42, 17)
        DOBLabel.TabIndex = 7
        DOBLabel.Text = "DOB:"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(592, 31)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DOBDateTimePicker.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TestDataSet As testDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As testDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As testDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDLabel1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents DOBDateTimePicker As DateTimePicker
End Class

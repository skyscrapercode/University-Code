<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim GroupNameLabel As System.Windows.Forms.Label
        Dim MaximumLabel As System.Windows.Forms.Label
        Dim MinimumLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.dgvGroupDetails = New System.Windows.Forms.DataGridView()
        Me.ClassRegisDataSetLatest = New AccessingDB_TestingDemo.ClassRegisDataSetLatest()
        Me.TblGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGroupTableAdapter = New AccessingDB_TestingDemo.ClassRegisDataSetLatestTableAdapters.tblGroupTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaximumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinimumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New AccessingDB_TestingDemo.ClassRegisDataSetLatestTableAdapters.TableAdapterManager()
        Me.GroupNameTextBox = New System.Windows.Forms.TextBox()
        Me.MaximumTextBox = New System.Windows.Forms.TextBox()
        Me.MinimumTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        GroupNameLabel = New System.Windows.Forms.Label()
        MaximumLabel = New System.Windows.Forms.Label()
        MinimumLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGroupDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassRegisDataSetLatest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Me.IDTextBox)
        Me.GroupBox1.Controls.Add(TotalLabel)
        Me.GroupBox1.Controls.Add(Me.TotalTextBox)
        Me.GroupBox1.Controls.Add(MinimumLabel)
        Me.GroupBox1.Controls.Add(Me.MinimumTextBox)
        Me.GroupBox1.Controls.Add(MaximumLabel)
        Me.GroupBox1.Controls.Add(Me.MaximumTextBox)
        Me.GroupBox1.Controls.Add(GroupNameLabel)
        Me.GroupBox1.Controls.Add(Me.GroupNameTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group Details"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(575, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(150, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(575, 121)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 30)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(575, 175)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(575, 229)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirst.Location = New System.Drawing.Point(46, 328)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(147, 30)
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "FIRST"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(204, 328)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(147, 30)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "PREVIOUS"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(362, 328)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(147, 30)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLast.Location = New System.Drawing.Point(520, 328)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(147, 30)
        Me.btnLast.TabIndex = 8
        Me.btnLast.Text = "LAST"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'dgvGroupDetails
        '
        Me.dgvGroupDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGroupDetails.AutoGenerateColumns = False
        Me.dgvGroupDetails.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvGroupDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGroupDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGroupDetails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.GroupNameDataGridViewTextBoxColumn, Me.MaximumDataGridViewTextBoxColumn, Me.MinimumDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvGroupDetails.DataSource = Me.TblGroupBindingSource
        Me.dgvGroupDetails.Location = New System.Drawing.Point(780, 46)
        Me.dgvGroupDetails.Name = "dgvGroupDetails"
        Me.dgvGroupDetails.ReadOnly = True
        Me.dgvGroupDetails.RowHeadersVisible = False
        Me.dgvGroupDetails.RowTemplate.Height = 24
        Me.dgvGroupDetails.Size = New System.Drawing.Size(520, 312)
        Me.dgvGroupDetails.TabIndex = 9
        '
        'ClassRegisDataSetLatest
        '
        Me.ClassRegisDataSetLatest.DataSetName = "ClassRegisDataSetLatest"
        Me.ClassRegisDataSetLatest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGroupBindingSource
        '
        Me.TblGroupBindingSource.DataMember = "tblGroup"
        Me.TblGroupBindingSource.DataSource = Me.ClassRegisDataSetLatest
        '
        'TblGroupTableAdapter
        '
        Me.TblGroupTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName"
        Me.GroupNameDataGridViewTextBoxColumn.HeaderText = "GroupName"
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        Me.GroupNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MaximumDataGridViewTextBoxColumn
        '
        Me.MaximumDataGridViewTextBoxColumn.DataPropertyName = "maximum"
        Me.MaximumDataGridViewTextBoxColumn.HeaderText = "maximum"
        Me.MaximumDataGridViewTextBoxColumn.Name = "MaximumDataGridViewTextBoxColumn"
        Me.MaximumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MinimumDataGridViewTextBoxColumn
        '
        Me.MinimumDataGridViewTextBoxColumn.DataPropertyName = "minimum"
        Me.MinimumDataGridViewTextBoxColumn.HeaderText = "minimum"
        Me.MinimumDataGridViewTextBoxColumn.Name = "MinimumDataGridViewTextBoxColumn"
        Me.MinimumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGroupTableAdapter = Me.TblGroupTableAdapter
        Me.TableAdapterManager.UpdateOrder = AccessingDB_TestingDemo.ClassRegisDataSetLatestTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupNameLabel
        '
        GroupNameLabel.AutoSize = True
        GroupNameLabel.Location = New System.Drawing.Point(16, 74)
        GroupNameLabel.Name = "GroupNameLabel"
        GroupNameLabel.Size = New System.Drawing.Size(120, 20)
        GroupNameLabel.TabIndex = 15
        GroupNameLabel.Text = "Group Name:"
        '
        'GroupNameTextBox
        '
        Me.GroupNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupBindingSource, "GroupName", True))
        Me.GroupNameTextBox.Location = New System.Drawing.Point(206, 71)
        Me.GroupNameTextBox.Name = "GroupNameTextBox"
        Me.GroupNameTextBox.Size = New System.Drawing.Size(229, 27)
        Me.GroupNameTextBox.TabIndex = 16
        '
        'MaximumLabel
        '
        MaximumLabel.AutoSize = True
        MaximumLabel.Location = New System.Drawing.Point(16, 108)
        MaximumLabel.Name = "MaximumLabel"
        MaximumLabel.Size = New System.Drawing.Size(94, 20)
        MaximumLabel.TabIndex = 16
        MaximumLabel.Text = "maximum:"
        '
        'MaximumTextBox
        '
        Me.MaximumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupBindingSource, "maximum", True))
        Me.MaximumTextBox.Location = New System.Drawing.Point(207, 108)
        Me.MaximumTextBox.Name = "MaximumTextBox"
        Me.MaximumTextBox.Size = New System.Drawing.Size(228, 27)
        Me.MaximumTextBox.TabIndex = 17
        '
        'MinimumLabel
        '
        MinimumLabel.AutoSize = True
        MinimumLabel.Location = New System.Drawing.Point(18, 144)
        MinimumLabel.Name = "MinimumLabel"
        MinimumLabel.Size = New System.Drawing.Size(90, 20)
        MinimumLabel.TabIndex = 17
        MinimumLabel.Text = "minimum:"
        '
        'MinimumTextBox
        '
        Me.MinimumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupBindingSource, "minimum", True))
        Me.MinimumTextBox.Location = New System.Drawing.Point(206, 141)
        Me.MinimumTextBox.Name = "MinimumTextBox"
        Me.MinimumTextBox.Size = New System.Drawing.Size(229, 27)
        Me.MinimumTextBox.TabIndex = 18
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(18, 177)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(52, 20)
        TotalLabel.TabIndex = 18
        TotalLabel.Text = "total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(206, 174)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(229, 27)
        Me.TotalTextBox.TabIndex = 19
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(18, 40)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(34, 20)
        IDLabel.TabIndex = 19
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(206, 40)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(229, 27)
        Me.IDTextBox.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 394)
        Me.Controls.Add(Me.dgvGroupDetails)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Group Registration Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGroupDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassRegisDataSetLatest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents dgvGroupDetails As DataGridView
    Friend WithEvents ClassRegisDataSetLatest As ClassRegisDataSetLatest
    Friend WithEvents TblGroupBindingSource As BindingSource
    Friend WithEvents TblGroupTableAdapter As ClassRegisDataSetLatestTableAdapters.tblGroupTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNameTextBox As TextBox
    Friend WithEvents TableAdapterManager As ClassRegisDataSetLatestTableAdapters.TableAdapterManager
    Friend WithEvents MinimumTextBox As TextBox
    Friend WithEvents MaximumTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents IDTextBox As TextBox
End Class

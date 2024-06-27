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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotRegister = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMinValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGroupId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.ClassdbDataSet = New AccessingDB_TestingDemo.ClassdbDataSet()
        Me.TblGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGroupsTableAdapter = New AccessingDB_TestingDemo.ClassdbDataSetTableAdapters.tblGroupsTableAdapter()
        Me.TableAdapterManager = New AccessingDB_TestingDemo.ClassdbDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClassdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTotRegister)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMinValue)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMaxValue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGroupId)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(97, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Group Details"
        '
        'txtTotRegister
        '
        Me.txtTotRegister.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupsBindingSource, "Total", True))
        Me.txtTotRegister.Location = New System.Drawing.Point(159, 169)
        Me.txtTotRegister.Name = "txtTotRegister"
        Me.txtTotRegister.Size = New System.Drawing.Size(133, 22)
        Me.txtTotRegister.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Registered"
        '
        'txtMinValue
        '
        Me.txtMinValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupsBindingSource, "Minimum", True))
        Me.txtMinValue.Location = New System.Drawing.Point(159, 125)
        Me.txtMinValue.Name = "txtMinValue"
        Me.txtMinValue.Size = New System.Drawing.Size(133, 22)
        Me.txtMinValue.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Minimum Value"
        '
        'txtMaxValue
        '
        Me.txtMaxValue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupsBindingSource, "Maximum", True))
        Me.txtMaxValue.Location = New System.Drawing.Point(159, 81)
        Me.txtMaxValue.Name = "txtMaxValue"
        Me.txtMaxValue.Size = New System.Drawing.Size(133, 22)
        Me.txtMaxValue.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Maximum Value"
        '
        'txtGroupId
        '
        Me.txtGroupId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblGroupsBindingSource, "GroupID", True))
        Me.txtGroupId.Location = New System.Drawing.Point(159, 44)
        Me.txtGroupId.Name = "txtGroupId"
        Me.txtGroupId.Size = New System.Drawing.Size(133, 22)
        Me.txtGroupId.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group ID"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(575, 81)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 30)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(575, 127)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 30)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(575, 173)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 30)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(575, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(71, 291)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(121, 30)
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "FIRST"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(198, 291)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(121, 30)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.Text = "PREVIOUS"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(325, 291)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(121, 30)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "NEXT"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(452, 291)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(121, 30)
        Me.btnLast.TabIndex = 8
        Me.btnLast.Text = "LAST"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'ClassdbDataSet
        '
        Me.ClassdbDataSet.DataSetName = "ClassdbDataSet"
        Me.ClassdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblGroupsBindingSource
        '
        Me.TblGroupsBindingSource.DataMember = "tblGroups"
        Me.TblGroupsBindingSource.DataSource = Me.ClassdbDataSet
        '
        'TblGroupsTableAdapter
        '
        Me.TblGroupsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblGroupsTableAdapter = Me.TblGroupsTableAdapter
        Me.TableAdapterManager.UpdateOrder = AccessingDB_TestingDemo.ClassdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 364)
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
        CType(Me.ClassdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotRegister As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMinValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGroupId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents ClassdbDataSet As ClassdbDataSet
    Friend WithEvents TblGroupsBindingSource As BindingSource
    Friend WithEvents TblGroupsTableAdapter As ClassdbDataSetTableAdapters.tblGroupsTableAdapter
    Friend WithEvents TableAdapterManager As ClassdbDataSetTableAdapters.TableAdapterManager
End Class

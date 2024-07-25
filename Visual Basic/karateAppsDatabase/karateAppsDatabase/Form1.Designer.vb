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
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim IDLabel1 As System.Windows.Forms.Label
        Me.lstMembers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MemberDataSet = New karateAppsDatabase.MemberDataSet()
        Me.MemberDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New karateAppsDatabase.MemberDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New karateAppsDatabase.MemberDataSetTableAdapters.TableAdapterManager()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IDLabel2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertPaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        IDLabel1 = New System.Windows.Forms.Label()
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMembers
        '
        Me.lstMembers.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MembersBindingSource, "ID", True))
        Me.lstMembers.DataSource = Me.MembersBindingSource
        Me.lstMembers.DisplayMember = "Last_Name"
        Me.lstMembers.FormattingEnabled = True
        Me.lstMembers.ItemHeight = 16
        Me.lstMembers.Location = New System.Drawing.Point(31, 45)
        Me.lstMembers.Name = "lstMembers"
        Me.lstMembers.Size = New System.Drawing.Size(220, 292)
        Me.lstMembers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Names"
        '
        'MemberDataSet
        '
        Me.MemberDataSet.DataSetName = "MemberDataSet"
        Me.MemberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberDataSetBindingSource
        '
        Me.MemberDataSetBindingSource.DataSource = Me.MemberDataSet
        Me.MemberDataSetBindingSource.Position = 0
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.MemberDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = karateAppsDatabase.MemberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(277, 93)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(80, 17)
        Last_NameLabel.TabIndex = 4
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(363, 90)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Last_NameTextBox.TabIndex = 5
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(277, 146)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(80, 17)
        First_NameLabel.TabIndex = 6
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(363, 143)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.First_NameTextBox.TabIndex = 7
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(304, 198)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 8
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(363, 195)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneTextBox.TabIndex = 9
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.Location = New System.Drawing.Point(277, 237)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(88, 17)
        Date_JoinedLabel.TabIndex = 10
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(371, 237)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.Date_JoinedDateTimePicker.TabIndex = 11
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(332, 45)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(25, 17)
        IDLabel1.TabIndex = 12
        IDLabel1.Text = "ID:"
        '
        'IDLabel2
        '
        Me.IDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDLabel2.Location = New System.Drawing.Point(363, 45)
        Me.IDLabel2.Name = "IDLabel2"
        Me.IDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel2.TabIndex = 13
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertPaymentToolStripMenuItem})
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.PaymentToolStripMenuItem.Text = "Payment"
        '
        'InsertPaymentToolStripMenuItem
        '
        Me.InsertPaymentToolStripMenuItem.Name = "InsertPaymentToolStripMenuItem"
        Me.InsertPaymentToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.InsertPaymentToolStripMenuItem.Text = "Insert Payment"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(Me.IDLabel2)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMembers)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MemberDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMembers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MemberDataSetBindingSource As BindingSource
    Friend WithEvents MemberDataSet As MemberDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As MemberDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As MemberDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents IDLabel2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertPaymentToolStripMenuItem As ToolStripMenuItem
End Class

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
        Me.lstSort = New System.Windows.Forms.ListBox()
        Me.btnAscending = New System.Windows.Forms.Button()
        Me.btnDescending = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.listSubject = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstSort
        '
        Me.lstSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSort.FormattingEnabled = True
        Me.lstSort.ItemHeight = 23
        Me.lstSort.Location = New System.Drawing.Point(30, 46)
        Me.lstSort.Name = "lstSort"
        Me.lstSort.Size = New System.Drawing.Size(303, 188)
        Me.lstSort.TabIndex = 4
        '
        'btnAscending
        '
        Me.btnAscending.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAscending.Location = New System.Drawing.Point(365, 73)
        Me.btnAscending.Name = "btnAscending"
        Me.btnAscending.Size = New System.Drawing.Size(175, 42)
        Me.btnAscending.TabIndex = 5
        Me.btnAscending.Text = "ASCENDING"
        Me.btnAscending.UseVisualStyleBackColor = True
        '
        'btnDescending
        '
        Me.btnDescending.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDescending.Location = New System.Drawing.Point(365, 147)
        Me.btnDescending.Name = "btnDescending"
        Me.btnDescending.Size = New System.Drawing.Size(175, 42)
        Me.btnDescending.TabIndex = 6
        Me.btnDescending.Text = "DESCENDING"
        Me.btnDescending.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOutput)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.txtInput)
        Me.GroupBox1.Controls.Add(Me.listSubject)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 282)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For-Each Loop Demo"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(309, 165)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(234, 80)
        Me.lblOutput.TabIndex = 7
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(309, 106)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(231, 42)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "FIND MY SUBJECT"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(309, 49)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(231, 30)
        Me.txtInput.TabIndex = 5
        '
        'listSubject
        '
        Me.listSubject.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSubject.FormattingEnabled = True
        Me.listSubject.ItemHeight = 23
        Me.listSubject.Items.AddRange(New Object() {"CSC301", "CSC248", "ICT200", "MAT210", "CSC207"})
        Me.listSubject.Location = New System.Drawing.Point(30, 49)
        Me.listSubject.Name = "listSubject"
        Me.listSubject.Size = New System.Drawing.Size(245, 211)
        Me.listSubject.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstSort)
        Me.GroupBox2.Controls.Add(Me.btnAscending)
        Me.GroupBox2.Controls.Add(Me.btnDescending)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 251)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sorting Demo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 593)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstSort As ListBox
    Friend WithEvents btnAscending As Button
    Friend WithEvents btnDescending As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents listSubject As ListBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

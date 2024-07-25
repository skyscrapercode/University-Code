Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassdbDataSet.tblGroups' table. You can move, or remove it, as needed.
        Me.TblGroupsTableAdapter.Fill(Me.ClassdbDataSet.tblGroups)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.TblGroupsBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TblGroupsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClassdbDataSet)
        MessageBox.Show("Data has been updated successfully")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.TblGroupsBindingSource.RemoveCurrent()
        Me.TableAdapterManager.UpdateAll(Me.ClassdbDataSet)
        MessageBox.Show("Data has been deleted")
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.TblGroupsBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.TblGroupsBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.TblGroupsBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.TblGroupsBindingSource.MoveLast()
    End Sub
End Class

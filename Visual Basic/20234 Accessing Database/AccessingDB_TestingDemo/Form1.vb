Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassRegisDataSetLatest.tblGroup' table. You can move, or remove it, as needed.
        Me.TblGroupTableAdapter.Fill(Me.ClassRegisDataSetLatest.tblGroup)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.TblGroupBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate() 'checks id database data is ready to be written to database
        Me.TblGroupBindingSource.EndEdit() 'applies pending changes to data source
        Me.TblGroupTableAdapter.Update(Me.ClassRegisDataSetLatest)
        'Update method tells TableAdapter to write data changes back to database
        MsgBox("Data has been updated successfully")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.TblGroupBindingSource.RemoveCurrent() 'remove current item from the list
        Me.TblGroupTableAdapter.Update(Me.ClassRegisDataSetLatest)
        MsgBox("Data has been deleted")
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.TblGroupBindingSource.MoveFirst()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.TblGroupBindingSource.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.TblGroupBindingSource.MoveNext()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.TblGroupBindingSource.MoveLast()
    End Sub

End Class

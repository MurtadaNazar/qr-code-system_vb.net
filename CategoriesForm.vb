Public Class CategoriesForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Dim Category As Category
    Private Sub AddNewCategoryBtn_Click(sender As Object, e As EventArgs) Handles AddNewCategoryBtn.Click
        Category.CategoryName = txtCategoryName.Text
        InsertCategory(Category)
        fetchAllCategories(categoriesDGV)
    End Sub


    Private Sub fetchAllCategoriesBtn_Click(sender As Object, e As EventArgs) Handles fetchAllCategoriesBtn.Click
        fetchAllCategories(categoriesDGV)
    End Sub

    Private Sub UpdateCategoryBtn_Click(sender As Object, e As EventArgs) Handles UpdateCategoryBtn.Click
        Category.CategoryName = txtCategoryName.Text
        updateCategory(Category, categoriesDGV)
        txtCategoryName.Clear()
        fetchAllCategories(categoriesDGV)
    End Sub

    Private Sub categoriesDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles categoriesDGV.CellClick
        If e.RowIndex >= 0 Then ' make sure the clicked cell is not a header cell
            ' get the selected row
            Dim row As DataGridViewRow = categoriesDGV.Rows(e.RowIndex)
            ' set the values of the text boxes based on the selected row
            txtCategoryName.Text = row.Cells("category_name").Value.ToString()
        End If
    End Sub

    Private Sub DeleteCategoryBtn_Click(sender As Object, e As EventArgs) Handles DeleteCategoryBtn.Click
        Dim selectedRow As DataGridViewRow = categoriesDGV.CurrentRow
        If selectedRow IsNot Nothing Then
            Dim CategoryID As Integer = CInt(selectedRow.Cells("category_id").Value)
            deleteCategory(CategoryID)
            fetchAllCategories(categoriesDGV)
        End If
    End Sub
End Class
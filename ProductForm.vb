Public Class ProductForm
    '! close form btn
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '! decler a new var as Product data type to use it in the oprition
    Public pp As Product

    'TODO: create new product button
    Private Sub newProducteBtn_Click(sender As Object, e As EventArgs) Handles newProducteBtn.Click
        pp.product_name = txtProducName.Text
        pp.product_price = Val(txtProducPrice.Text)
        pp.product_production_Date = txtProductionDate.Text
        pp.product_expiry_Date = txtExpiryDate.Text
        pp.selectedCategoryID = CInt(cbCategorySelector.SelectedValue)
        InsertProduct(pp, ShowAllProducteDGV)
        txtProducName.Clear()
        txtProducPrice.Clear()
        txtProductionDate.Clear()
        txtExpiryDate.Clear()
        cbCategorySelector.SelectedIndex = -1
    End Sub

    'TODO: create show all product button
    Private Sub fetchAllProducte_Click(sender As Object, e As EventArgs) Handles fetchAllProducte.Click
        fetchAllProdect(ShowAllProducteDGV)
        comboBoxItem(cbCategorySelector)
    End Sub

    'TODO: create update product button
    Private Sub UpdateProducteBtn_Click(sender As Object, e As EventArgs) Handles UpdateProducteBtn.Click
        pp.product_name = txtProducName.Text
        pp.product_price = Val(txtProducPrice.Text)
        pp.product_production_Date = txtProductionDate.Text
        pp.product_expiry_Date = txtExpiryDate.Text
        pp.selectedCategoryID = CInt(cbCategorySelector.SelectedValue)
        updateProducte(pp, ShowAllProducteDGV)
        fetchAllProdect(ShowAllProducteDGV)
        ' clear the TextBoxes and ComboBox
        txtProducName.Clear()
        txtProducPrice.Clear()
        txtProductionDate.Clear()
        txtExpiryDate.Clear()
        cbCategorySelector.SelectedIndex = -1
    End Sub

    '! when click any cell in the data grid view well get it valu and show it in the text boxes

    Private Sub ShowAllProducteDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowAllProducteDGV.CellClick
        If e.RowIndex >= 0 Then ' make sure the clicked cell is not a header cell
            ' get the selected row
            Dim row As DataGridViewRow = ShowAllProducteDGV.Rows(e.RowIndex)
            ' set the values of the text boxes based on the selected row
            txtProducName.Text = row.Cells("product_name").Value.ToString()
            txtProducPrice.Text = row.Cells("product_price").Value.ToString()
            txtProductionDate.Text = row.Cells("product_production_date").Value.ToString()
            txtExpiryDate.Text = row.Cells("product_expiry_date").Value.ToString()
            Dim categoryId As Integer = row.Cells("category_id").Value
            cbCategorySelector.SelectedValue = categoryId
        End If
    End Sub

    Private Sub deleteProductBtn_Click(sender As Object, e As EventArgs) Handles deleteProductBtn.Click
        Dim selectedRow As DataGridViewRow = ShowAllProducteDGV.CurrentRow
        If selectedRow IsNot Nothing Then ' make sure a row is selected
            ' get the product ID from the selected row
            Dim productID As Integer = CInt(selectedRow.Cells("product_id").Value)
            deleteProduct(productID)
            fetchAllProdect(ShowAllProducteDGV)
            txtProducName.Clear()
            txtProducPrice.Clear()
            txtProductionDate.Clear()
            txtExpiryDate.Clear()
            cbCategorySelector.SelectedIndex = -1
        End If
    End Sub

End Class
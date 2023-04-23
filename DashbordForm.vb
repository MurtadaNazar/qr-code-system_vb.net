Public Class DashbordForm
    'TODO:===========================DashBordForm========================================
#Region "DashBord"
    Private Sub EscButton_Click(sender As Object, e As EventArgs) Handles EscButton.Click
        End
    End Sub
    '!: hide tap control button
    Private Sub DashbordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MainTabControl.Appearance = TabAppearance.FlatButtons
            MainTabControl.ItemSize = New Size(0, 1)
            MainTabControl.SizeMode = TabSizeMode.Fixed
        Catch ex As Exception
        End Try
    End Sub
    '!: Navgition throm the tabs
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click, SearchButton.Click, ProductButton.Click, CategoriesButton.Click, QRcodeButton.Click, StatisticsButton.Click, HistoryButton.Click
        Try
            Dim selectedButton = DirectCast(sender, Button)
            Select Case selectedButton.Name
                Case "HomeButton"
                    MainTabControl.SelectedTab = HomeTabPage
                Case "SearchButton"
                    MainTabControl.SelectedTab = SearchTabPage
                Case "ProductButton"
                    MainTabControl.SelectedTab = ProductTabPage
                Case "CategoriesButton"
                    MainTabControl.SelectedTab = CategorieTabPage
                Case "QRcodeButton"
                    MainTabControl.SelectedTab = QRcodeTabPage
                Case "StatisticsButton"
                    MainTabControl.SelectedTab = StatisticsTabPage
                Case "HistoryButton"
                    MainTabControl.SelectedTab = HistoryTabPage
            End Select
        Catch ex As Exception
        End Try
    End Sub
    'TODO:===========================DashBordForm End====================================
#End Region

    'TODO:===========================Search Tab==========================================
#Region "SearchTab"
    Private Sub searchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchComboBox.SelectedIndexChanged
        Dim inr As Integer = searchComboBox.SelectedIndex + 1
        Select Case inr
            Case 1
                PopulateComboBox("Product", BasedOnSearchComboBox)
            Case 2
                PopulateComboBox("Category", BasedOnSearchComboBox)
            Case 3
                PopulateComboBox("QrCode", BasedOnSearchComboBox)
        End Select
    End Sub

    Private Sub searchBTN_Click(sender As Object, e As EventArgs) Handles searchBTN.Click
        Dim search_data As search_Filter
        Dim tableName As String = searchComboBox.SelectedItem.ToString()
        Select Case tableName
            Case "Product"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = BasedOnSearchComboBox.SelectedItem.ToString
            Case "Category"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = BasedOnSearchComboBox.SelectedItem.ToString()
            Case "QrCode"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = BasedOnSearchComboBox.SelectedItem.ToString()
            Case Else
                MessageBox.Show("Invalid table selected")
                Return
        End Select
        If IsNumeric(searchTXT.Text) Then
            search_data.values = Val(searchTXT.Text)
        Else
            search_data.values = searchTXT.Text
        End If
        Dim dataTable As DataTable = SearchData(search_data)
        searchDataGridView.DataSource = dataTable
    End Sub

    Private Sub BasedOnSearchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BasedOnSearchComboBox.SelectedIndexChanged
        Dim autocompleteList As List(Of String) = GetAutocompleteResults("product_name", searchTXT.Text, "Product")
        searchTXT.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        searchTXT.AutoCompleteSource = AutoCompleteSource.CustomSource
        searchTXT.AutoCompleteCustomSource.AddRange(autocompleteList.ToArray())
    End Sub
    'TODO:===========================Search Tab End======================================
#End Region

    'TODO:===========================Product Tab=========================================
#Region "Product Tab"

    Public product As Product
    '!: new Product button
    Private Sub newProducteButton_Click(sender As Object, e As EventArgs) Handles newProducteButton.Click
        product.product_name = txtProducName.Text
        product.product_price = Val(txtProducPrice.Text)
        product.product_production_Date = txtProductionDate.Text
        product.product_expiry_Date = txtExpiryDate.Text
        product.selectedCategoryID = CInt(cbCategorySelector.SelectedValue)
        InsertProduct(product, ShowAllProducteDGV)
        txtProducName.Clear()
        txtProducPrice.Clear()
        txtProductionDate.Clear()
        txtExpiryDate.Clear()
        cbCategorySelector.SelectedIndex = -1
    End Sub

    '!:show all product button
    Private Sub fetchAllProducte_Click(sender As Object, e As EventArgs) Handles fetchAllProducteButton.Click
        fetchAllProdect(ShowAllProducteDGV)
        comboBoxItem(cbCategorySelector)
    End Sub

    '!:update product button
    Private Sub UpdateProducteButton_Click(sender As Object, e As EventArgs) Handles UpdateProducteButton.Click
        product.product_name = txtProducName.Text
        product.product_price = Val(txtProducPrice.Text)
        product.product_production_Date = txtProductionDate.Text
        product.product_expiry_Date = txtExpiryDate.Text
        product.selectedCategoryID = CInt(cbCategorySelector.SelectedValue)
        updateProducte(product, ShowAllProducteDGV)
        fetchAllProdect(ShowAllProducteDGV)
        txtProducName.Clear()
        txtProducPrice.Clear()
        txtProductionDate.Clear()
        txtExpiryDate.Clear()
        cbCategorySelector.SelectedIndex = -1
    End Sub

    '!: delete Product button
    Private Sub deleteProductButton_Click(sender As Object, e As EventArgs) Handles deleteProductButton.Click
        Dim selectedRow As DataGridViewRow = ShowAllProducteDGV.CurrentRow
        If selectedRow IsNot Nothing Then
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

    '! when click any cell in the data grid view well get it valu and show it in the text boxes
    Private Sub ShowAllProducteDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowAllProducteDGV.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = ShowAllProducteDGV.Rows(e.RowIndex)
            txtProducName.Text = row.Cells("product_name").Value.ToString()
            txtProducPrice.Text = row.Cells("product_price").Value.ToString()
            txtProductionDate.Text = row.Cells("product_production_date").Value.ToString()
            txtExpiryDate.Text = row.Cells("product_expiry_date").Value.ToString()
            Dim categoryId As Integer = row.Cells("category_id").Value
            cbCategorySelector.SelectedValue = categoryId
        End If
    End Sub
    'TODO:===========================Product Tab End=====================================
#End Region


End Class
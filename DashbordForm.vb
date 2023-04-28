Imports System.Drawing.Printing
Imports System.IO

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
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click, SearchButton.Click, ProductButton.Click, CategoriesButton.Click, QRcodeButton.Click, DiscountsButton.Click, StatisticsButton.Click
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
                Case "DiscountsButton"
                    MainTabControl.SelectedTab = DiscountsTabPage
                Case "StatisticsButton"
                    MainTabControl.SelectedTab = StatisticsTabPage
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
    Public Sub ShowAllProducteDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ShowAllProducteDGV.CellClick
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

    'todo:==========================Categories Tab=======================================
#Region "Categories"

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
            txtCategoryName.Clear()
            fetchAllCategories(categoriesDGV)
        End If
    End Sub








    'todo:==========================Categories Tab end=======================================
#End Region

    'todo:==========================QR Code Tab==========================================
#Region "QR Code"

    'TODO: create a new qr code
    Private Sub newQRcodeButton_Click(sender As Object, e As EventArgs) Handles newQRcodeButton.Click
        Dim ProductId As Integer = CInt(QRcodeComboBox.SelectedValue)
        Dim CreateQRcodeInfo As Product
        CreateQRcodeInfo.product_name = pronameTextBox.Text
        CreateQRcodeInfo.product_price = Val(propriTextBox.Text)
        CreateQRcodeInfo.product_production_Date = propdTextBox.Text
        CreateQRcodeInfo.product_expiry_Date = proedTextBox.Text
        CreateQRcodeInfo.selectedCategoryID = Val(procTextBox.Text)
        Dim QRcodeName As String = pronameTextBox.Text
        qrcodeinsert(CreateQRcodeInfo, ProductId, QRcodeName)
        LoadQrCodes(QRcodeDataGridView)
    End Sub

    'TODO: show all qr code in the data base
    Private Sub ShowAllQRcodeButton_Click(sender As Object, e As EventArgs) Handles ShowAllQRcodeButton.Click
        LoadQrCodes(QRcodeDataGridView)
        QRCodecomboBoxItem(QRcodeComboBox)
    End Sub

    'TODO: delete qr code
    Private Sub deleteQRCodeButton_Click(sender As Object, e As EventArgs) Handles deleteQRCodeButton.Click
        Dim qrCodeId As Integer = CInt(QRcodeDataGridView.CurrentRow.Cells("qrCodeId").Value)
        DeleteQRCodeRecord(qrCodeId)
        LoadQrCodes(QRcodeDataGridView)
    End Sub

    'TODO: get the specific qr code info from the data grid view
    Private Sub QRcodeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles QRcodeDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim qrCodeId As Integer = CInt(QRcodeDataGridView.Rows(e.RowIndex).Cells("qrCodeId").Value)
            Dim productId As Integer = CInt(QRcodeDataGridView.Rows(e.RowIndex).Cells("productId").Value)
            Dim createdAt As DateTime = QRcodeDataGridView.Rows(e.RowIndex).Cells("createdAt").Value
            Dim qrCodeValue As Byte() = DirectCast(QRcodeDataGridView.Rows(e.RowIndex).Cells("qrCodeValue").Value, Byte())
            'prossec the data
            Dim qrCodeData As Byte() = qrCodeValue
            Dim ms As New MemoryStream(qrCodeData)
            Dim qrCodeImage As New Bitmap(ms)
            QRcodePictureBox.Image = qrCodeImage
        End If
    End Sub

    'TODO: get the product info form database to create the qr code
    Private Sub QRcodeComboBox_Click(sender As Object, e As EventArgs) Handles QRcodeComboBox.DropDownClosed
        getprodinfo(QRcodeComboBox, pronameTextBox, propriTextBox, propdTextBox, proedTextBox, procTextBox)
    End Sub

    'TODO: print the qr code
#Region "Print QRcode"
    Private copiesPrinted As Integer = 0
    Private Sub QRCodePrintDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles QRCodePrintDocument.PrintPage
        Dim x As Integer = e.MarginBounds.Left
        Dim y As Integer = e.MarginBounds.Top
        Dim bmp As New Bitmap(QRcodePictureBox.Image)
        e.Graphics.DrawImage(bmp, x, y)
        Dim qrCodeI As Integer = CInt(QRcodeDataGridView.CurrentRow.Cells("qrCodeId").Value)
        copiesPrinted += 1
        If copiesPrinted = QRCodePrintDocument.PrinterSettings.Copies Then
            If InsertPrintedQRCodeRecord(qrCodeI, copiesPrinted) Then
                MessageBox.Show($"Printed {copiesPrinted} copies of QR Code successfully. Total copies printed: {copiesPrinted}.")
            Else
                MessageBox.Show("Failed to record printed QR Code.")
            End If
            copiesPrinted = 0
        End If
    End Sub

    'TODO: print qr code button
    Private Sub printQRCodeButton_Click(sender As Object, e As EventArgs) Handles printQRCodeButton.Click
        If Not QRcodePictureBox.Image Is Nothing Then
            Dim printDialog As New PrintDialog()
            If printDialog.ShowDialog() = DialogResult.OK Then
                Dim printDocument As PrintDocument = QRCodePrintDocument
                AddHandler printDocument.PrintPage, AddressOf QRCodePrintDocument_PrintPage
                printDocument.PrinterSettings = printDialog.PrinterSettings
                printDocument.Print()
            End If
        End If
    End Sub
#End Region

    'todo:==========================QR Code Tab end======================================
#End Region

    'todo:==========================Discount Tab==========================================
#Region "Discount"

    'TODO:show all Discount Button
    Private Sub ShowAllDiscountButton_Click(sender As Object, e As EventArgs) Handles ShowAllDiscountButton.Click
        DiscountcomboBoxItem(productDiscountComboBox)
        GetAllDiscounts(DiscountsDataGridView)
    End Sub

    'TODO:Add Discount Button
    Private Sub AddDiscountButton_Click(sender As Object, e As EventArgs) Handles AddDiscountButton.Click
        Dim Pid As Integer = Convert.ToInt32(productDiscountComboBox.SelectedValue)
        InsertDiscount(Pid,
            discountExtentTXT,
            priceBeforeTXT,
            priceAfterTXT,
            durationTXT)
    End Sub

    'TODO:Delete Discount Button
    Private Sub DeleteDiscountButton_Click(sender As Object, e As EventArgs) Handles DeleteDiscountButton.Click
        Dim DiscountId As Integer = CInt(DiscountsDataGridView.CurrentRow.Cells("DiscountID").Value)
        DeleteDiscount(DiscountId)
        GetAllDiscounts(DiscountsDataGridView)
        DiscountcomboBoxItem(productDiscountComboBox)
    End Sub

    'TODO:fetch ProductDiscount ComboBox item from database
    Private Sub ProductDiscountComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles productDiscountComboBox.DropDownClosed
        Dim Pid As Integer = Convert.ToInt32(productDiscountComboBox.SelectedValue)
        GetPrice(priceBeforeTXT, Pid)
    End Sub

    'todo:==========================Discount Tab end==========================================
#End Region

    'todo:==========================Statistics Tab==========================================
#Region "Statistics"
    'TODO: Get All Statistics Button
    Private Sub GetAllStatisticsButton_Click(sender As Object, e As EventArgs) Handles GetAllStatisticsButton.Click
        GetDatabaseStatistics(StatisticDataGridView)
    End Sub

    'TODO: Export ToExcel Button
    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        ExportToExcel(StatisticDataGridView)
    End Sub

    'TODO: Export To PDF Button
    Private Sub ExportToPDFButton_Click(sender As Object, e As EventArgs) Handles ExportToPDFButton.Click
        ExportToPDF(StatisticDataGridView)
    End Sub

    'todo:==========================Statistics Tab end==========================================
#End Region

End Class
Imports System.Data.SqlClient

'TODO:==================data fetcher module start================================='
Module DataFetcher
    '!: connect to the data base
    Dim connectionString As String = "Data Source=MURTADANAZAR\MURTADANAZAR;Initial Catalog=db_qr_code_system;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    'todo:==================producet stored start================================='
#Region "producet stored start"
    Public Sub InsertProduct(pp As Product, dgv As DataGridView)
        connection.Open()
        Dim command As New SqlCommand("InsertProduct", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductName", pp.product_name)
        command.Parameters.AddWithValue("@ProductPrice", pp.product_price)
        command.Parameters.AddWithValue("@ProductProductionDate", pp.product_production_Date)
        command.Parameters.AddWithValue("@ProductExpiryDate", pp.product_expiry_Date)
        command.Parameters.AddWithValue("@CategoryID", pp.selectedCategoryID)
        command.ExecuteNonQuery()
        ' Create a DataTable and fill it with the data from the Product table
        Dim command2 As New SqlCommand("SelectAllProducts", connection)
        Dim DataAdapter As New SqlDataAdapter(command2)
        command.CommandType = CommandType.StoredProcedure
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        dgv.DataSource = DataSet.Tables(0)
        connection.Close()
    End Sub

    Public Sub fetchAllProdect(dgv As DataGridView)
        connection.Open()
        Dim command As New SqlCommand("SelectAllProducts", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(command)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        dgv.DataSource = DataSet.Tables(0)
        connection.Close()
    End Sub

    Public Sub updateProducte(update As Product, dgv As DataGridView)
        connection.Open()
        Dim command As New SqlCommand("UpdateProduct", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductID", dgv.CurrentRow.Cells("product_id").Value)
        If Not String.IsNullOrEmpty(update.product_name) Then
            command.Parameters.AddWithValue("@ProductName", update.product_name)
        End If
        If Not String.IsNullOrEmpty(update.product_price) Then
            command.Parameters.AddWithValue("@ProductPrice", Convert.ToDecimal(update.product_price))
        End If
        If Not String.IsNullOrEmpty(update.product_production_Date) Then
            command.Parameters.AddWithValue("@ProductProductionDate", update.product_production_Date)
        End If
        If Not String.IsNullOrEmpty(update.product_expiry_Date) Then
            command.Parameters.AddWithValue("@ProductExpiryDate", update.product_expiry_Date)
        End If
        If Not String.IsNullOrEmpty(update.selectedCategoryID) Then
            command.Parameters.AddWithValue("@CategoryID", update.selectedCategoryID)
        End If
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub deleteProduct(productID)
        connection.Open()
        Dim command As New SqlCommand("DeleteProduct", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@ProductID", productID)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    Public Sub comboBoxItem(combo As ComboBox)
        connection.Open()
        Dim command As New SqlCommand("SelectAllCategories", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        DataAdapter.Fill(table)
        combo.DataSource = table
        combo.ValueMember = "category_id"
        combo.DisplayMember = "category_name"
        connection.Close()
    End Sub
    'todo:==================producet stored end================================='
#End Region

    'todo:==================category stored start================================='
#Region "category stored"
    Public Sub InsertCategory(CategoryName As Category)
        connection.Open()
        Dim command As New SqlCommand("InsertCategory", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CategoryName", CategoryName.CategoryName)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub fetchAllCategories(dgv As DataGridView)
        connection.Open()
        Dim command As New SqlCommand("SelectAllCategories", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(command)
        Dim DataSet As New DataSet
        DataAdapter.Fill(DataSet)
        dgv.DataSource = DataSet.Tables(0)
        connection.Close()
    End Sub

    Public Sub updateCategory(update As Category, dgv As DataGridView)
        connection.Open()
        Dim command As New SqlCommand("UpdateCategory", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CategoryID", dgv.CurrentRow.Cells("category_id").Value)
        If Not String.IsNullOrEmpty(update.CategoryName) Then
            command.Parameters.AddWithValue("@CategoryName", update.CategoryName)
        End If
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub deleteCategory(CategoryID)
        connection.Open()
        Dim command As New SqlCommand("DeleteCategory", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.AddWithValue("@CategoryID", CategoryID)
        command.ExecuteNonQuery()
        connection.Close()
    End Sub
    'todo:==================category stored end================================='
#End Region

    'todo:==================serach stored start================================='
#Region "serach stored"
    Public Function SearchData(search_Filter As search_Filter) As DataTable
        Dim dataTable As New DataTable()
        Try
            connection.Open()
            Using command As New SqlCommand("SearchData", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@TableName", search_Filter.table_Name)
                command.Parameters.AddWithValue("@ColumnName", search_Filter.column_Name)
                command.Parameters.AddWithValue("@SearchValue", search_Filter.values)
                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(dataTable)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            connection.Close()
        End Try
        Return dataTable
        connection.Close()
    End Function

    Public Function GetColumnNames(tableName As String) As List(Of String)
        connection.Open()
        Dim command As New SqlCommand("get_column_names", connection)
        command.CommandType = CommandType.StoredProcedure
        command.Parameters.Add("@table_name", SqlDbType.NVarChar).Value = tableName
        Dim reader As SqlDataReader = command.ExecuteReader()
        Dim columnNames As New List(Of String)()
        While reader.Read()
            columnNames.Add(reader.GetString(0))
        End While
        reader.Close()
        connection.Close()
        Return columnNames
    End Function
    Public Sub PopulateComboBox(tableName As String, comboBox As ComboBox)
        Dim columnNames As List(Of String) = GetColumnNames(tableName)
        comboBox.DataSource = columnNames
    End Sub

    Function GetAutocompleteResults(columnName As String, searchTerm As String, tableName As String) As List(Of String)
        Dim results As New List(Of String)
        connection.Open()
        Dim sqlCommand As New SqlCommand("AutoComplete", connection)
        sqlCommand.CommandType = CommandType.StoredProcedure
        sqlCommand.Parameters.Add("@ColumnName", SqlDbType.NVarChar, 50).Value = columnName
        sqlCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar, 50).Value = searchTerm
        sqlCommand.Parameters.Add("@TableName", SqlDbType.VarChar, 50).Value = tableName
        Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
        While reader.Read()
            Dim result As String = reader.GetString(0)
            results.Add(result)
        End While
        reader.Close()
        connection.Close()
        Return results
    End Function

    'todo:==================serach stored end================================='
#End Region

    'TODO:==================qr code stored start================================='
#Region "QR Code"

    'TODO: get the data from database
    Public Sub LoadQrCodes(dgv As DataGridView)
        dgv.Rows.Clear()
        Dim query As String = "GetAllQrCodes"
        Using command As New SqlCommand(query, connection)
            command.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim qrCodeId As Integer = reader.GetInt32(0)
                Dim qrCodeValue As Byte() = DirectCast(reader.GetValue(1), Byte())
                Dim createdAt As DateTime = reader.GetSqlDateTime(2)
                Dim productId As Integer = reader.GetInt32(3)
                Dim qrCodeName As String = reader.GetString(4)
                dgv.Rows.Add(qrCodeId, productId, createdAt, qrCodeValue, qrCodeName)
                dgv.Rows(dgv.Rows.Count - 1).Cells("qrCodeValue").Tag = qrCodeValue
            End While
            connection.Close()
        End Using
    End Sub

    'TODO: get the prodect name from database for dynmic qr code
    Public Sub QRCodecomboBoxItem(combo As ComboBox)
        connection.Open()
        Dim command As New SqlCommand("SelectAllProducts", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        DataAdapter.Fill(table)
        combo.DataSource = table
        combo.ValueMember = "product_id"
        combo.DisplayMember = "product_name"
        connection.Close()
    End Sub

    'TODO: get the specific product info whene select one in combo box
    Public Sub getprodinfo(combo As ComboBox, tx1 As TextBox, tx2 As TextBox, tx3 As TextBox, tx4 As TextBox, tx5 As TextBox)
        Dim selectedProduct As Object = combo.DisplayMember
        Dim productId As Integer = CInt(combo.SelectedValue)
        Dim command As New SqlCommand("SELECT * FROM Product WHERE product_id = @productId", connection)
        command.Parameters.AddWithValue("@productId", productId)
        connection.Open()
        Dim reader As SqlDataReader = command.ExecuteReader()
        If reader.Read() Then
            tx1.Text = reader.GetString(1)
            tx2.Text = reader.GetDecimal(2).ToString()
            tx3.Text = reader.GetDateTime(3).ToString("yyyy-MM-dd")
            tx4.Text = reader.GetDateTime(4).ToString("yyyy-MM-dd")
            tx5.Text = reader.GetInt32(5)
        End If
        reader.Close()
        connection.Close()
    End Sub

    'TODO: add new qr code to database
    Public Sub qrcodeinsert(product As Product, productid As Integer, qrCodename As String)
        Dim ss As Decimal = GetDiscountExtent(productid)
        ' Generate the QR code and save it to the QrCode table
        Dim qrCode As Bitmap = GenerateQRCode(product, productid, ss)
        Dim qrCodeBytes As Byte() = ImageToByteArray(qrCode)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand("CreateQrCodeRecord", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@qr_code_value", qrCodeBytes)
                command.Parameters.AddWithValue("@product_id", productid)
                command.Parameters.AddWithValue("@qr_code_name", qrCodename)
                command.ExecuteNonQuery()
            End Using
            connection.Close()
        End Using
    End Sub

    'TODO: delete qr code from database
    Public Function DeleteQRCodeRecord(qrCodeId As Integer) As Boolean
        Dim success As Boolean = False
        Using connection
            connection.Open()
            Using command As New SqlCommand("DeleteQRCode", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@qrCodeId", qrCodeId)
                If command.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using
            connection.Close()
        End Using
        Return success
    End Function

    'TODO: add record whene print a new qr code
    Public Function InsertPrintedQRCodeRecord(qrCodeI As Integer, quantity As Integer) As Boolean
        Dim dateOfPrinting As Date = Date.Now
        Dim quantityPrinted As Integer = quantity 'set this to the number of copies printed
        Dim success As Boolean = False
        connection.Open()
        Using command As New SqlCommand("INSERT INTO PrintedQRCodes (QRCodeID, DateOfPrinting, QuantityPrinted) VALUES (@qrCodeId, @dateOfPrinting, @quantityPrinted)", connection)
            command.Parameters.AddWithValue("@qrCodeId", qrCodeI)
            command.Parameters.AddWithValue("@dateOfPrinting", dateOfPrinting)
            command.Parameters.AddWithValue("@quantityPrinted", quantityPrinted)
            If command.ExecuteNonQuery() > 0 Then 'check if a row was affected
                success = True
            End If
        End Using
        connection.Close()
        Return success
    End Function

    'todo:==================qr code stored end================================='
#End Region

    'TODO:==================Discount stored start================================='
#Region "Discount"

    'TODO: get some data dynmicly from data base
#Region "dynmic Data"

    '!: get the prodct name from database to create the dis for them 
    Public Sub DiscountcomboBoxItem(combo As ComboBox)
        connection.Open()
        Dim command As New SqlCommand("SelectAllProducts", connection)
        command.CommandType = CommandType.StoredProcedure
        Dim DataAdapter As New SqlDataAdapter(command)
        Dim table As DataTable = New DataTable()
        DataAdapter.Fill(table)
        combo.DataSource = table
        combo.ValueMember = "product_id"
        combo.DisplayMember = "product_name"
        connection.Close()
    End Sub

    '!:get the orginal price from database
    Public Sub GetPrice(tx As TextBox, productId As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT product_price FROM Product WHERE product_id = @productId", connection)
            command.Parameters.AddWithValue("@productId", productId)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                tx.Text = reader.GetDecimal(0)
            End If
            reader.Close()
        End Using
        connection.Close()
    End Sub

    '!: get the discountExtent from database to add it in qrCode
    Public discountExtent As Decimal
    Public Function GetDiscountExtent(DiscountID As Integer) As Decimal
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT discountExtent FROM Discounts WHERE ProductID = @DiscountID", connection)
            command.Parameters.AddWithValue("@DiscountID", DiscountID)
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                discountExtent = reader.GetDecimal(0)
            End If
            reader.Close()
        End Using
        Return discountExtent
        connection.Close()
    End Function
#End Region

    'TODO: insert Discount method
    Public Sub InsertDiscount(Pid As Integer, discountExtentTXT As TextBox, priceBeforeTXT As TextBox, priceAfterTXT As TextBox, durationTXT As TextBox)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand("InsertDiscount", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@productID", Pid)
                command.Parameters.AddWithValue("@discountExtent", Val(discountExtentTXT.Text))
                command.Parameters.AddWithValue("@priceBefore", Val(priceBeforeTXT.Text))
                command.Parameters.AddWithValue("@priceAfter", Val(priceAfterTXT.Text))
                command.Parameters.AddWithValue("@duration", durationTXT.Text)
                command.ExecuteNonQuery()
            End Using
        End Using
        connection.Close()
    End Sub

    'TODO: get all discount method
    Public Sub GetAllDiscounts(dgv As DataGridView)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetAllDiscounts", connection)
            command.CommandType = CommandType.StoredProcedure
            Dim dataAdapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            dataAdapter.Fill(dataTable)
            dgv.DataSource = dataTable
        End Using
        connection.Close()
    End Sub

    'TODO: delete discount method
    Public Sub DeleteDiscount(discountId As Integer)
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using command As New SqlCommand("DeleteDiscount", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@discountId", discountId)
                command.ExecuteNonQuery()
            End Using
        End Using
        connection.Close()
    End Sub

    'TODO:==================Discount stored end================================='
#End Region

    'TODO:==================Statistics stored start================================='
#Region "Statistics"

    'TODO: get all Statistics from database
    Public Sub GetDatabaseStatistics(dgvData As DataGridView)
        dgvData.Rows.Clear()
        Dim query As String = "GetDatabaseStatistics"
        Using command As New SqlCommand(query, connection)
            command.CommandType = CommandType.StoredProcedure
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            While reader.Read()
                dgvData.Rows.Add(reader("TotalProducts"), reader("TotalQRCodes"), reader("TotalCategories"), reader("TotalPrintedQRCodes"), reader("TotalPrintedReports"), reader("TotalDiscounts"), reader("TotalReports"))
            End While
            connection.Close()
        End Using
    End Sub

    'TODO:==================Statistics stored end================================='
#End Region


    'TODO:==================data fetcher module end================================='
End Module

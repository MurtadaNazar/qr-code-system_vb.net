Imports System.Data.SqlClient
Module DataFetcher
    Dim connectionString As String = "Data Source=MURTADANAZAR\MURTADANAZAR;Initial Catalog=db_qr_code_system;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    'todo:-------------------------producet stored start ----------------------------'
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
    'todo:-------------------------producet stored end ----------------------------'
    'todo:-------------------------category stored start---------------------------'
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

    'TODO: search data 
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





End Module

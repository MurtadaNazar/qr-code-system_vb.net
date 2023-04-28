Public Module DataTypes
    'Todo: product data type
    Public Structure Product
        Public product_name As String
        Public product_price As Decimal
        Public product_production_Date As Date
        Public product_expiry_Date As Date
        Public selectedCategoryID As Integer
    End Structure

    '!: qr code data type
    Structure QR_Code
        Dim qr_code_value As Byte()
        Dim created_at As Date
        Dim product_id As Integer
    End Structure

    '!: category data type
    Public Structure Category
        Public CategoryID As Integer
        Public CategoryName As String
    End Structure

    '!: search filter data type
    Public Structure search_Filter
        Public table_Name As String
        Public column_Name As String
        Public values As String
    End Structure

End Module

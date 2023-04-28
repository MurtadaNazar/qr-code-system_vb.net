Imports System.Data.SqlClient
Imports System.IO
Imports ZXing
Imports ZXing.Common
Module QRCodeGeneratorModule
    Public Function GenerateQRCode(product As Product, pid As Integer) As Bitmap
        Dim writer As New BarcodeWriter()
        writer.Format = BarcodeFormat.QR_CODE
        writer.Options = New ZXing.Common.EncodingOptions() With {
    .Width = 300,
    .Height = 300
}

        Dim text As String = String.Format("Name: {0}, Price: {1}, Production Date: {2}, Expiry Date: {3}, Category ID: {4}",
    product.product_name,
    product.product_price,
    product.product_production_Date,
    product.product_expiry_Date,
    product.selectedCategoryID)
        Dim qrCode As Bitmap = writer.Write(text)
        Return qrCode
    End Function

    ' Converts a bitmap image to a byte array
    Public Function ImageToByteArray(image As Image) As Byte()
        Dim stream As New MemoryStream()
        image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Dim byteArray() As Byte = stream.ToArray()
        Return byteArray
    End Function
End Module

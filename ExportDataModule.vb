Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop

Public Module ExportToEccelModule

    'TODO: Export To Excel method
    Public Sub ExportToExcel(dgvData As DataGridView)
        If dgvData Is Nothing Then
            MessageBox.Show("Data Grid View is null. Please provide a valid instance.")
            Return
        End If

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.Title = "Export to Excel"
        saveFileDialog1.FileName = "MyExport.xlsx"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = saveFileDialog1.FileName
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add(Type.Missing)
            Dim worksheet As Excel.Worksheet = Nothing

            Try
                worksheet = CType(workbook.ActiveSheet, Excel.Worksheet)
                worksheet.Name = "Exported From DataGridView"

                Dim cellRowIndex As Integer = 1
                Dim cellColumnIndex As Integer = 1

                'Add the column headers to the worksheet
                For Each column As DataGridViewColumn In dgvData.Columns
                    worksheet.Cells(cellRowIndex, cellColumnIndex) = column.HeaderText
                    cellColumnIndex += 1
                Next

                cellRowIndex += 1
                cellColumnIndex = 1

                'Loop through each row in the DataGridView and copy its values to the corresponding cells in the Excel worksheet
                For i As Integer = 0 To dgvData.Rows.Count - 1
                    For j As Integer = 0 To dgvData.Columns.Count - 1
                        If dgvData.Rows(i).Cells(j).Value IsNot Nothing Then
                            worksheet.Cells(cellRowIndex, cellColumnIndex) = dgvData.Rows(i).Cells(j).Value.ToString()
                        End If
                        cellColumnIndex += 1
                    Next
                    cellColumnIndex = 1
                    cellRowIndex += 1
                Next

                'Save the Excel workbook to the specified file name and close the Excel application
                workbook.SaveAs(fileName)
                excelApp.Quit()

                MessageBox.Show("Data exported successfully to " + fileName)
            Catch ex As Exception
                MessageBox.Show("Error exporting data to Excel: " + ex.Message)
            Finally
                'Release COM objects
                ReleaseObject(worksheet)
                ReleaseObject(workbook)
                ReleaseObject(excelApp)
            End Try
        End If
    End Sub

    'TODO: Export To pdf method
    Public Sub ExportToPDF(ByVal dgvData As DataGridView)
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveDialog.FileName = "MyReport.pdf"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim document As New Document()
            Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(document, New FileStream(saveDialog.FileName, FileMode.Create))
            document.Open()

            ' Create a table with the same number of columns as the DataGridView
            Dim table As New PdfPTable(dgvData.Columns.Count)
            table.WidthPercentage = 100

            ' Add the column headers to the table
            For Each column As DataGridViewColumn In dgvData.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New BaseColor(dgvData.ColumnHeadersDefaultCellStyle.BackColor)
                cell.HorizontalAlignment = Element.ALIGN_CENTER
                cell.VerticalAlignment = Element.ALIGN_MIDDLE
                table.AddCell(cell)
            Next

            ' Add the data rows to the table
            For Each row As DataGridViewRow In dgvData.Rows
                For Each cell As DataGridViewCell In row.Cells
                    Dim value As Object = cell.Value
                    If value IsNot Nothing Then
                        table.AddCell(value.ToString())
                    Else
                        table.AddCell("")
                    End If
                Next
            Next

            ' Add the table to the document
            document.Add(table)

            ' Close the document and dispose of resources
            document.Close()
            pdfWriter.Close()
        End If
    End Sub

    Private Sub ReleaseObject(obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
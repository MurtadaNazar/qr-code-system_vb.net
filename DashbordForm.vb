Public Class DashbordForm
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

    Private Sub searchComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchComboBox.SelectedIndexChanged
        Dim inr As Integer = searchComboBox.SelectedIndex + 1
        Select Case inr
            Case 1
                PopulateComboBox("Product", ComboBox1)

            Case 2
                PopulateComboBox("Category", ComboBox1)
            Case 3
                PopulateComboBox("QrCode", ComboBox1)
        End Select


    End Sub

    Private Sub searchBTN_Click(sender As Object, e As EventArgs) Handles searchBTN.Click
        Dim search_data As search_Filter
        Dim tableName As String = searchComboBox.SelectedItem.ToString()
        Select Case tableName
            Case "Product"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = ComboBox1.SelectedItem.ToString
            Case "Category"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = ComboBox1.SelectedItem.ToString()

            Case "QrCode"
                search_data.table_Name = searchComboBox.SelectedItem.ToString()
                search_data.column_Name = ComboBox1.SelectedItem.ToString()
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim autocompleteList As List(Of String) = GetAutocompleteResults("product_name", searchTXT.Text, "Product")

        ' Bind the autocomplete list to the text box
        searchTXT.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        searchTXT.AutoCompleteSource = AutoCompleteSource.CustomSource
        searchTXT.AutoCompleteCustomSource.AddRange(autocompleteList.ToArray())
    End Sub

End Class
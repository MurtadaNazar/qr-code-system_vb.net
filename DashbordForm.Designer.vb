<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashbordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle161 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle162 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle163 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle164 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle165 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle166 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle167 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle168 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.StatisticsButton = New System.Windows.Forms.Button()
        Me.QRcodeButton = New System.Windows.Forms.Button()
        Me.CategoriesButton = New System.Windows.Forms.Button()
        Me.ProductButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.HomeTabPage = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchTabPage = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BasedOnSearchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.searchComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchdgvPanel = New System.Windows.Forms.Panel()
        Me.searchDataGridView = New System.Windows.Forms.DataGridView()
        Me.searchBTN = New System.Windows.Forms.Button()
        Me.searchTXT = New System.Windows.Forms.TextBox()
        Me.ProductTabPage = New System.Windows.Forms.TabPage()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtProductionDate = New System.Windows.Forms.TextBox()
        Me.txtProducPrice = New System.Windows.Forms.TextBox()
        Me.txtProducName = New System.Windows.Forms.TextBox()
        Me.cbCategorySelector = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProductdgvPanel = New System.Windows.Forms.Panel()
        Me.ShowAllProducteDGV = New System.Windows.Forms.DataGridView()
        Me.CategorieTabPage = New System.Windows.Forms.TabPage()
        Me.QRcodeTabPage = New System.Windows.Forms.TabPage()
        Me.StatisticsTabPage = New System.Windows.Forms.TabPage()
        Me.HistoryTabPage = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deleteProductButton = New System.Windows.Forms.Button()
        Me.UpdateProducteButton = New System.Windows.Forms.Button()
        Me.fetchAllProducteButton = New System.Windows.Forms.Button()
        Me.newProducteButton = New System.Windows.Forms.Button()
        Me.productTitleLabel = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.EscButton = New System.Windows.Forms.Button()
        Me.pnlbl = New System.Windows.Forms.Label()
        Me.pplbl = New System.Windows.Forms.Label()
        Me.pdlbl = New System.Windows.Forms.Label()
        Me.edlbl = New System.Windows.Forms.Label()
        Me.clbl = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.NavPanel.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.HomeTabPage.SuspendLayout()
        Me.SearchTabPage.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.searchdgvPanel.SuspendLayout()
        CType(Me.searchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductTabPage.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ProductdgvPanel.SuspendLayout()
        CType(Me.ShowAllProducteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavPanel
        '
        Me.NavPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NavPanel.Controls.Add(Me.HomeButton)
        Me.NavPanel.Controls.Add(Me.Label1)
        Me.NavPanel.Controls.Add(Me.EscButton)
        Me.NavPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NavPanel.Location = New System.Drawing.Point(0, 0)
        Me.NavPanel.Name = "NavPanel"
        Me.NavPanel.Size = New System.Drawing.Size(1530, 53)
        Me.NavPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(645, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "QR Code system"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.HistoryButton)
        Me.SidePanel.Controls.Add(Me.StatisticsButton)
        Me.SidePanel.Controls.Add(Me.QRcodeButton)
        Me.SidePanel.Controls.Add(Me.CategoriesButton)
        Me.SidePanel.Controls.Add(Me.ProductButton)
        Me.SidePanel.Controls.Add(Me.SearchButton)
        Me.SidePanel.Controls.Add(Me.Panel1)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 53)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(181, 757)
        Me.SidePanel.TabIndex = 1
        '
        'HistoryButton
        '
        Me.HistoryButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.HistoryButton.FlatAppearance.BorderSize = 0
        Me.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HistoryButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HistoryButton.Location = New System.Drawing.Point(0, 327)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(181, 55)
        Me.HistoryButton.TabIndex = 6
        Me.HistoryButton.Text = "History"
        Me.HistoryButton.UseVisualStyleBackColor = True
        '
        'StatisticsButton
        '
        Me.StatisticsButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatisticsButton.FlatAppearance.BorderSize = 0
        Me.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StatisticsButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatisticsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StatisticsButton.Location = New System.Drawing.Point(0, 272)
        Me.StatisticsButton.Name = "StatisticsButton"
        Me.StatisticsButton.Size = New System.Drawing.Size(181, 55)
        Me.StatisticsButton.TabIndex = 5
        Me.StatisticsButton.Text = "Statistics"
        Me.StatisticsButton.UseVisualStyleBackColor = True
        '
        'QRcodeButton
        '
        Me.QRcodeButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.QRcodeButton.FlatAppearance.BorderSize = 0
        Me.QRcodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QRcodeButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QRcodeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.QRcodeButton.Location = New System.Drawing.Point(0, 217)
        Me.QRcodeButton.Name = "QRcodeButton"
        Me.QRcodeButton.Size = New System.Drawing.Size(181, 55)
        Me.QRcodeButton.TabIndex = 4
        Me.QRcodeButton.Text = "QR Code"
        Me.QRcodeButton.UseVisualStyleBackColor = True
        '
        'CategoriesButton
        '
        Me.CategoriesButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.CategoriesButton.FlatAppearance.BorderSize = 0
        Me.CategoriesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoriesButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoriesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CategoriesButton.Location = New System.Drawing.Point(0, 162)
        Me.CategoriesButton.Name = "CategoriesButton"
        Me.CategoriesButton.Size = New System.Drawing.Size(181, 55)
        Me.CategoriesButton.TabIndex = 3
        Me.CategoriesButton.Text = "Category"
        Me.CategoriesButton.UseVisualStyleBackColor = True
        '
        'ProductButton
        '
        Me.ProductButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductButton.FlatAppearance.BorderSize = 0
        Me.ProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProductButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductButton.Location = New System.Drawing.Point(0, 107)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(181, 55)
        Me.ProductButton.TabIndex = 2
        Me.ProductButton.Text = "Product"
        Me.ProductButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchButton.FlatAppearance.BorderSize = 0
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SearchButton.Location = New System.Drawing.Point(0, 52)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(181, 55)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 52)
        Me.Panel1.TabIndex = 0
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.HomeTabPage)
        Me.MainTabControl.Controls.Add(Me.SearchTabPage)
        Me.MainTabControl.Controls.Add(Me.ProductTabPage)
        Me.MainTabControl.Controls.Add(Me.CategorieTabPage)
        Me.MainTabControl.Controls.Add(Me.QRcodeTabPage)
        Me.MainTabControl.Controls.Add(Me.StatisticsTabPage)
        Me.MainTabControl.Controls.Add(Me.HistoryTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(181, 53)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(1349, 757)
        Me.MainTabControl.TabIndex = 2
        '
        'HomeTabPage
        '
        Me.HomeTabPage.Controls.Add(Me.Label2)
        Me.HomeTabPage.Controls.Add(Me.PictureBox1)
        Me.HomeTabPage.Location = New System.Drawing.Point(4, 40)
        Me.HomeTabPage.Name = "HomeTabPage"
        Me.HomeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HomeTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.HomeTabPage.TabIndex = 0
        Me.HomeTabPage.Text = "Home"
        Me.HomeTabPage.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(555, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wellcome"
        '
        'SearchTabPage
        '
        Me.SearchTabPage.Controls.Add(Me.Label6)
        Me.SearchTabPage.Controls.Add(Me.BasedOnSearchComboBox)
        Me.SearchTabPage.Controls.Add(Me.Label5)
        Me.SearchTabPage.Controls.Add(Me.searchComboBox)
        Me.SearchTabPage.Controls.Add(Me.Panel3)
        Me.SearchTabPage.Controls.Add(Me.Panel2)
        Me.SearchTabPage.Controls.Add(Me.Label4)
        Me.SearchTabPage.Controls.Add(Me.searchdgvPanel)
        Me.SearchTabPage.Controls.Add(Me.searchBTN)
        Me.SearchTabPage.Controls.Add(Me.searchTXT)
        Me.SearchTabPage.Location = New System.Drawing.Point(4, 40)
        Me.SearchTabPage.Name = "SearchTabPage"
        Me.SearchTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SearchTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.SearchTabPage.TabIndex = 1
        Me.SearchTabPage.Text = "Search"
        Me.SearchTabPage.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(579, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 34)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "based on"
        '
        'BasedOnSearchComboBox
        '
        Me.BasedOnSearchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasedOnSearchComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.BasedOnSearchComboBox.FormattingEnabled = True
        Me.BasedOnSearchComboBox.Location = New System.Drawing.Point(497, 200)
        Me.BasedOnSearchComboBox.Name = "BasedOnSearchComboBox"
        Me.BasedOnSearchComboBox.Size = New System.Drawing.Size(313, 42)
        Me.BasedOnSearchComboBox.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(172, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "search for"
        '
        'searchComboBox
        '
        Me.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchComboBox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.searchComboBox.FormattingEnabled = True
        Me.searchComboBox.Items.AddRange(New Object() {"Product", "Category", "QrCode"})
        Me.searchComboBox.Location = New System.Drawing.Point(135, 200)
        Me.searchComboBox.Name = "searchComboBox"
        Me.searchComboBox.Size = New System.Drawing.Size(239, 42)
        Me.searchComboBox.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1335, 88)
        Me.Panel3.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(999, 234)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 3)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1035, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 34)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search text"
        '
        'searchdgvPanel
        '
        Me.searchdgvPanel.Controls.Add(Me.searchDataGridView)
        Me.searchdgvPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.searchdgvPanel.Location = New System.Drawing.Point(3, 426)
        Me.searchdgvPanel.Name = "searchdgvPanel"
        Me.searchdgvPanel.Size = New System.Drawing.Size(1335, 284)
        Me.searchdgvPanel.TabIndex = 6
        '
        'searchDataGridView
        '
        Me.searchDataGridView.AllowUserToResizeColumns = False
        Me.searchDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle161.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle161.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle161.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        DataGridViewCellStyle161.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle161.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle161.SelectionForeColor = System.Drawing.Color.White
        Me.searchDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle161
        Me.searchDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.searchDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.searchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.searchDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle162.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle162.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle162.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle162.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle162.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle162.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle162.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle162
        Me.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle163.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle163.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle163.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle163.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle163.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle163.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle163.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.searchDataGridView.DefaultCellStyle = DataGridViewCellStyle163
        Me.searchDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.searchDataGridView.Name = "searchDataGridView"
        Me.searchDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle164.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle164.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle164.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle164.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle164.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle164.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle164.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.searchDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle164
        Me.searchDataGridView.RowHeadersWidth = 25
        Me.searchDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.searchDataGridView.RowTemplate.Height = 26
        Me.searchDataGridView.Size = New System.Drawing.Size(1335, 284)
        Me.searchDataGridView.TabIndex = 4
        '
        'searchBTN
        '
        Me.searchBTN.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBTN.FlatAppearance.BorderSize = 0
        Me.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchBTN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.searchBTN.Location = New System.Drawing.Point(585, 335)
        Me.searchBTN.Name = "searchBTN"
        Me.searchBTN.Size = New System.Drawing.Size(170, 55)
        Me.searchBTN.TabIndex = 5
        Me.searchBTN.Text = "Search"
        Me.searchBTN.UseVisualStyleBackColor = False
        '
        'searchTXT
        '
        Me.searchTXT.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchTXT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchTXT.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.searchTXT.Location = New System.Drawing.Point(999, 204)
        Me.searchTXT.Margin = New System.Windows.Forms.Padding(0)
        Me.searchTXT.Name = "searchTXT"
        Me.searchTXT.Size = New System.Drawing.Size(257, 35)
        Me.searchTXT.TabIndex = 3
        Me.searchTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductTabPage
        '
        Me.ProductTabPage.Controls.Add(Me.Panel9)
        Me.ProductTabPage.Controls.Add(Me.Panel8)
        Me.ProductTabPage.Controls.Add(Me.Panel7)
        Me.ProductTabPage.Controls.Add(Me.Panel6)
        Me.ProductTabPage.Controls.Add(Me.Panel5)
        Me.ProductTabPage.Controls.Add(Me.clbl)
        Me.ProductTabPage.Controls.Add(Me.edlbl)
        Me.ProductTabPage.Controls.Add(Me.pdlbl)
        Me.ProductTabPage.Controls.Add(Me.pplbl)
        Me.ProductTabPage.Controls.Add(Me.pnlbl)
        Me.ProductTabPage.Controls.Add(Me.txtExpiryDate)
        Me.ProductTabPage.Controls.Add(Me.txtProductionDate)
        Me.ProductTabPage.Controls.Add(Me.txtProducPrice)
        Me.ProductTabPage.Controls.Add(Me.txtProducName)
        Me.ProductTabPage.Controls.Add(Me.deleteProductButton)
        Me.ProductTabPage.Controls.Add(Me.UpdateProducteButton)
        Me.ProductTabPage.Controls.Add(Me.fetchAllProducteButton)
        Me.ProductTabPage.Controls.Add(Me.newProducteButton)
        Me.ProductTabPage.Controls.Add(Me.cbCategorySelector)
        Me.ProductTabPage.Controls.Add(Me.Panel4)
        Me.ProductTabPage.Controls.Add(Me.ProductdgvPanel)
        Me.ProductTabPage.Location = New System.Drawing.Point(4, 40)
        Me.ProductTabPage.Name = "ProductTabPage"
        Me.ProductTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.ProductTabPage.TabIndex = 2
        Me.ProductTabPage.Text = "Product"
        Me.ProductTabPage.UseVisualStyleBackColor = True
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpiryDate.Location = New System.Drawing.Point(1045, 275)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(274, 31)
        Me.txtExpiryDate.TabIndex = 19
        '
        'txtProductionDate
        '
        Me.txtProductionDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductionDate.Location = New System.Drawing.Point(1045, 224)
        Me.txtProductionDate.Name = "txtProductionDate"
        Me.txtProductionDate.Size = New System.Drawing.Size(274, 31)
        Me.txtProductionDate.TabIndex = 18
        '
        'txtProducPrice
        '
        Me.txtProducPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtProducPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducPrice.Location = New System.Drawing.Point(1045, 173)
        Me.txtProducPrice.Name = "txtProducPrice"
        Me.txtProducPrice.Size = New System.Drawing.Size(274, 31)
        Me.txtProducPrice.TabIndex = 17
        '
        'txtProducName
        '
        Me.txtProducName.BackColor = System.Drawing.SystemColors.Window
        Me.txtProducName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducName.Location = New System.Drawing.Point(1045, 122)
        Me.txtProducName.Margin = New System.Windows.Forms.Padding(0)
        Me.txtProducName.Name = "txtProducName"
        Me.txtProducName.Size = New System.Drawing.Size(274, 31)
        Me.txtProducName.TabIndex = 16
        '
        'cbCategorySelector
        '
        Me.cbCategorySelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategorySelector.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!)
        Me.cbCategorySelector.FormattingEnabled = True
        Me.cbCategorySelector.Location = New System.Drawing.Point(1045, 324)
        Me.cbCategorySelector.Name = "cbCategorySelector"
        Me.cbCategorySelector.Size = New System.Drawing.Size(274, 42)
        Me.cbCategorySelector.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.productTitleLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1335, 88)
        Me.Panel4.TabIndex = 10
        '
        'ProductdgvPanel
        '
        Me.ProductdgvPanel.BackColor = System.Drawing.Color.Transparent
        Me.ProductdgvPanel.Controls.Add(Me.ShowAllProducteDGV)
        Me.ProductdgvPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProductdgvPanel.Location = New System.Drawing.Point(3, 440)
        Me.ProductdgvPanel.Name = "ProductdgvPanel"
        Me.ProductdgvPanel.Size = New System.Drawing.Size(1335, 270)
        Me.ProductdgvPanel.TabIndex = 6
        '
        'ShowAllProducteDGV
        '
        Me.ShowAllProducteDGV.AllowUserToResizeColumns = False
        Me.ShowAllProducteDGV.AllowUserToResizeRows = False
        DataGridViewCellStyle165.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle165.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle165.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!)
        DataGridViewCellStyle165.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle165.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle165.SelectionForeColor = System.Drawing.Color.White
        Me.ShowAllProducteDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle165
        Me.ShowAllProducteDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ShowAllProducteDGV.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ShowAllProducteDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShowAllProducteDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ShowAllProducteDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle166.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle166.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle166.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle166.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle166.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle166.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle166.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle166
        Me.ShowAllProducteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShowAllProducteDGV.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle167.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle167.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle167.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle167.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle167.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle167.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle167.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ShowAllProducteDGV.DefaultCellStyle = DataGridViewCellStyle167
        Me.ShowAllProducteDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowAllProducteDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ShowAllProducteDGV.Location = New System.Drawing.Point(0, 0)
        Me.ShowAllProducteDGV.Name = "ShowAllProducteDGV"
        Me.ShowAllProducteDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle168.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle168.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle168.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle168.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle168.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle168.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle168.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle168
        Me.ShowAllProducteDGV.RowHeadersWidth = 25
        Me.ShowAllProducteDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ShowAllProducteDGV.RowTemplate.Height = 26
        Me.ShowAllProducteDGV.Size = New System.Drawing.Size(1335, 270)
        Me.ShowAllProducteDGV.TabIndex = 5
        '
        'CategorieTabPage
        '
        Me.CategorieTabPage.Location = New System.Drawing.Point(4, 40)
        Me.CategorieTabPage.Name = "CategorieTabPage"
        Me.CategorieTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CategorieTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.CategorieTabPage.TabIndex = 3
        Me.CategorieTabPage.Text = "Category"
        Me.CategorieTabPage.UseVisualStyleBackColor = True
        '
        'QRcodeTabPage
        '
        Me.QRcodeTabPage.Location = New System.Drawing.Point(4, 40)
        Me.QRcodeTabPage.Name = "QRcodeTabPage"
        Me.QRcodeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.QRcodeTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.QRcodeTabPage.TabIndex = 4
        Me.QRcodeTabPage.Text = "QR Code"
        Me.QRcodeTabPage.UseVisualStyleBackColor = True
        '
        'StatisticsTabPage
        '
        Me.StatisticsTabPage.Location = New System.Drawing.Point(4, 40)
        Me.StatisticsTabPage.Name = "StatisticsTabPage"
        Me.StatisticsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.StatisticsTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.StatisticsTabPage.TabIndex = 5
        Me.StatisticsTabPage.Text = "Statistics"
        Me.StatisticsTabPage.UseVisualStyleBackColor = True
        '
        'HistoryTabPage
        '
        Me.HistoryTabPage.Location = New System.Drawing.Point(4, 40)
        Me.HistoryTabPage.Name = "HistoryTabPage"
        Me.HistoryTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HistoryTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.HistoryTabPage.TabIndex = 6
        Me.HistoryTabPage.Text = "History"
        Me.HistoryTabPage.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.qr_code_system.My.Resources.Resources.qr_codebig
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1335, 707)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Image = Global.qr_code_system.My.Resources.Resources.search
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(538, -3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 87)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Search"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'deleteProductButton
        '
        Me.deleteProductButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deleteProductButton.FlatAppearance.BorderSize = 0
        Me.deleteProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteProductButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!)
        Me.deleteProductButton.ForeColor = System.Drawing.Color.White
        Me.deleteProductButton.Image = Global.qr_code_system.My.Resources.Resources.delete
        Me.deleteProductButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.deleteProductButton.Location = New System.Drawing.Point(202, 248)
        Me.deleteProductButton.Name = "deleteProductButton"
        Me.deleteProductButton.Size = New System.Drawing.Size(151, 120)
        Me.deleteProductButton.TabIndex = 15
        Me.deleteProductButton.Text = "Delete"
        Me.deleteProductButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.deleteProductButton.UseVisualStyleBackColor = False
        '
        'UpdateProducteButton
        '
        Me.UpdateProducteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateProducteButton.FlatAppearance.BorderSize = 0
        Me.UpdateProducteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateProducteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateProducteButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!)
        Me.UpdateProducteButton.ForeColor = System.Drawing.Color.White
        Me.UpdateProducteButton.Image = Global.qr_code_system.My.Resources.Resources.recycling
        Me.UpdateProducteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UpdateProducteButton.Location = New System.Drawing.Point(45, 248)
        Me.UpdateProducteButton.Name = "UpdateProducteButton"
        Me.UpdateProducteButton.Size = New System.Drawing.Size(151, 120)
        Me.UpdateProducteButton.TabIndex = 14
        Me.UpdateProducteButton.Text = "Update"
        Me.UpdateProducteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UpdateProducteButton.UseVisualStyleBackColor = False
        '
        'fetchAllProducteButton
        '
        Me.fetchAllProducteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fetchAllProducteButton.FlatAppearance.BorderSize = 0
        Me.fetchAllProducteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fetchAllProducteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchAllProducteButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!)
        Me.fetchAllProducteButton.ForeColor = System.Drawing.Color.White
        Me.fetchAllProducteButton.Image = Global.qr_code_system.My.Resources.Resources.download
        Me.fetchAllProducteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.fetchAllProducteButton.Location = New System.Drawing.Point(45, 122)
        Me.fetchAllProducteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.fetchAllProducteButton.Name = "fetchAllProducteButton"
        Me.fetchAllProducteButton.Size = New System.Drawing.Size(151, 120)
        Me.fetchAllProducteButton.TabIndex = 13
        Me.fetchAllProducteButton.Text = "Show All"
        Me.fetchAllProducteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.fetchAllProducteButton.UseVisualStyleBackColor = False
        '
        'newProducteButton
        '
        Me.newProducteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newProducteButton.FlatAppearance.BorderSize = 0
        Me.newProducteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(137, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newProducteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newProducteButton.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!)
        Me.newProducteButton.ForeColor = System.Drawing.Color.White
        Me.newProducteButton.Image = Global.qr_code_system.My.Resources.Resources.new_product
        Me.newProducteButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.newProducteButton.Location = New System.Drawing.Point(202, 122)
        Me.newProducteButton.Margin = New System.Windows.Forms.Padding(0)
        Me.newProducteButton.Name = "newProducteButton"
        Me.newProducteButton.Size = New System.Drawing.Size(151, 120)
        Me.newProducteButton.TabIndex = 12
        Me.newProducteButton.Text = "Add"
        Me.newProducteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.newProducteButton.UseVisualStyleBackColor = False
        '
        'productTitleLabel
        '
        Me.productTitleLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.productTitleLabel.Image = Global.qr_code_system.My.Resources.Resources.product
        Me.productTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.productTitleLabel.Location = New System.Drawing.Point(485, -3)
        Me.productTitleLabel.Name = "productTitleLabel"
        Me.productTitleLabel.Size = New System.Drawing.Size(306, 87)
        Me.productTitleLabel.TabIndex = 0
        Me.productTitleLabel.Text = "Products"
        Me.productTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.Transparent
        Me.HomeButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.HomeButton.FlatAppearance.BorderSize = 0
        Me.HomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet
        Me.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeButton.Image = Global.qr_code_system.My.Resources.Resources.main_menu
        Me.HomeButton.Location = New System.Drawing.Point(0, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(55, 53)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'EscButton
        '
        Me.EscButton.BackColor = System.Drawing.Color.Transparent
        Me.EscButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.EscButton.FlatAppearance.BorderSize = 0
        Me.EscButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.EscButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EscButton.Image = Global.qr_code_system.My.Resources.Resources.close__1_
        Me.EscButton.Location = New System.Drawing.Point(1475, 0)
        Me.EscButton.Name = "EscButton"
        Me.EscButton.Size = New System.Drawing.Size(55, 53)
        Me.EscButton.TabIndex = 0
        Me.EscButton.UseVisualStyleBackColor = False
        '
        'pnlbl
        '
        Me.pnlbl.AutoSize = True
        Me.pnlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlbl.Location = New System.Drawing.Point(793, 123)
        Me.pnlbl.Name = "pnlbl"
        Me.pnlbl.Size = New System.Drawing.Size(226, 34)
        Me.pnlbl.TabIndex = 20
        Me.pnlbl.Text = "Product Name"
        '
        'pplbl
        '
        Me.pplbl.AutoSize = True
        Me.pplbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pplbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pplbl.Location = New System.Drawing.Point(798, 174)
        Me.pplbl.Name = "pplbl"
        Me.pplbl.Size = New System.Drawing.Size(217, 34)
        Me.pplbl.TabIndex = 21
        Me.pplbl.Text = "Product Price"
        '
        'pdlbl
        '
        Me.pdlbl.AutoSize = True
        Me.pdlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pdlbl.Location = New System.Drawing.Point(780, 225)
        Me.pdlbl.Name = "pdlbl"
        Me.pdlbl.Size = New System.Drawing.Size(253, 34)
        Me.pdlbl.TabIndex = 22
        Me.pdlbl.Text = "Production Date"
        '
        'edlbl
        '
        Me.edlbl.AutoSize = True
        Me.edlbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.edlbl.Location = New System.Drawing.Point(814, 276)
        Me.edlbl.Name = "edlbl"
        Me.edlbl.Size = New System.Drawing.Size(184, 34)
        Me.edlbl.TabIndex = 23
        Me.edlbl.Text = "Expiry Date"
        '
        'clbl
        '
        Me.clbl.AutoSize = True
        Me.clbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clbl.Location = New System.Drawing.Point(831, 327)
        Me.clbl.Name = "clbl"
        Me.clbl.Size = New System.Drawing.Size(150, 34)
        Me.clbl.TabIndex = 24
        Me.clbl.Text = "Category"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(1045, 148)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(274, 3)
        Me.Panel5.TabIndex = 25
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(1045, 199)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(274, 3)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(1045, 250)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(274, 3)
        Me.Panel7.TabIndex = 27
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(1045, 301)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(274, 3)
        Me.Panel8.TabIndex = 28
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(1045, 361)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(274, 3)
        Me.Panel9.TabIndex = 29
        '
        'DashbordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1530, 810)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.NavPanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "DashbordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DashbordForm"
        Me.NavPanel.ResumeLayout(False)
        Me.NavPanel.PerformLayout()
        Me.SidePanel.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.HomeTabPage.ResumeLayout(False)
        Me.HomeTabPage.PerformLayout()
        Me.SearchTabPage.ResumeLayout(False)
        Me.SearchTabPage.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.searchdgvPanel.ResumeLayout(False)
        CType(Me.searchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductTabPage.ResumeLayout(False)
        Me.ProductTabPage.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ProductdgvPanel.ResumeLayout(False)
        CType(Me.ShowAllProducteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavPanel As Panel
    Friend WithEvents SidePanel As Panel
    Friend WithEvents EscButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CategoriesButton As Button
    Friend WithEvents ProductButton As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents StatisticsButton As Button
    Friend WithEvents QRcodeButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents HomeTabPage As TabPage
    Friend WithEvents SearchTabPage As TabPage
    Friend WithEvents ProductTabPage As TabPage
    Friend WithEvents CategorieTabPage As TabPage
    Friend WithEvents QRcodeTabPage As TabPage
    Friend WithEvents StatisticsTabPage As TabPage
    Friend WithEvents HistoryTabPage As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents searchBTN As Button
    Friend WithEvents searchDataGridView As DataGridView
    Friend WithEvents searchTXT As TextBox
    Friend WithEvents searchdgvPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents searchComboBox As ComboBox
    Friend WithEvents BasedOnSearchComboBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowAllProducteDGV As DataGridView
    Friend WithEvents ProductdgvPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents productTitleLabel As Label
    Friend WithEvents cbCategorySelector As ComboBox
    Friend WithEvents deleteProductButton As Button
    Friend WithEvents UpdateProducteButton As Button
    Friend WithEvents fetchAllProducteButton As Button
    Friend WithEvents newProducteButton As Button
    Friend WithEvents txtExpiryDate As TextBox
    Friend WithEvents txtProductionDate As TextBox
    Friend WithEvents txtProducPrice As TextBox
    Friend WithEvents txtProducName As TextBox
    Friend WithEvents clbl As Label
    Friend WithEvents edlbl As Label
    Friend WithEvents pdlbl As Label
    Friend WithEvents pplbl As Label
    Friend WithEvents pnlbl As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
End Class

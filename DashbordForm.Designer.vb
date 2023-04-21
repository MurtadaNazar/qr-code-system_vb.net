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
        Me.NavPanel = New System.Windows.Forms.Panel()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EscButton = New System.Windows.Forms.Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchTabPage = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchdgvPanel = New System.Windows.Forms.Panel()
        Me.searchDataGridView = New System.Windows.Forms.DataGridView()
        Me.searchBTN = New System.Windows.Forms.Button()
        Me.searchTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductTabPage = New System.Windows.Forms.TabPage()
        Me.CategorieTabPage = New System.Windows.Forms.TabPage()
        Me.QRcodeTabPage = New System.Windows.Forms.TabPage()
        Me.StatisticsTabPage = New System.Windows.Forms.TabPage()
        Me.HistoryTabPage = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.searchComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NavPanel.SuspendLayout()
        Me.SidePanel.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.HomeTabPage.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchTabPage.SuspendLayout()
        Me.searchdgvPanel.SuspendLayout()
        CType(Me.searchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
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
        'SearchTabPage
        '
        Me.SearchTabPage.Controls.Add(Me.Label6)
        Me.SearchTabPage.Controls.Add(Me.ComboBox1)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(762, 159)
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
        Me.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.searchDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.searchDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.searchDataGridView.Name = "searchDataGridView"
        Me.searchDataGridView.RowHeadersWidth = 51
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
        Me.searchTXT.Location = New System.Drawing.Point(726, 205)
        Me.searchTXT.Margin = New System.Windows.Forms.Padding(0)
        Me.searchTXT.Name = "searchTXT"
        Me.searchTXT.Size = New System.Drawing.Size(257, 31)
        Me.searchTXT.TabIndex = 3
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
        'ProductTabPage
        '
        Me.ProductTabPage.Location = New System.Drawing.Point(4, 40)
        Me.ProductTabPage.Name = "ProductTabPage"
        Me.ProductTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductTabPage.Size = New System.Drawing.Size(1341, 713)
        Me.ProductTabPage.TabIndex = 2
        Me.ProductTabPage.Text = "Product"
        Me.ProductTabPage.UseVisualStyleBackColor = True
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(726, 229)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 3)
        Me.Panel2.TabIndex = 8
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
        'searchComboBox
        '
        Me.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchComboBox.FormattingEnabled = True
        Me.searchComboBox.Items.AddRange(New Object() {"Product", "Category", "QrCode"})
        Me.searchComboBox.Location = New System.Drawing.Point(214, 199)
        Me.searchComboBox.Name = "searchComboBox"
        Me.searchComboBox.Size = New System.Drawing.Size(206, 39)
        Me.searchComboBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(252, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "search for"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(460, 196)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 39)
        Me.ComboBox1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 31)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "based on"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchTabPage.ResumeLayout(False)
        Me.SearchTabPage.PerformLayout()
        Me.searchdgvPanel.ResumeLayout(False)
        CType(Me.searchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class

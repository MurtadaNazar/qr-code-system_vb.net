<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.productInfoPanel = New System.Windows.Forms.Panel()
        Me.txtProducPrice = New System.Windows.Forms.TextBox()
        Me.txtProducName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCategorySelector = New System.Windows.Forms.ComboBox()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtProductionDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.deleteProductBtn = New System.Windows.Forms.Button()
        Me.newProducteBtn = New System.Windows.Forms.Button()
        Me.fetchAllProducte = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UpdateProducteBtn = New System.Windows.Forms.Button()
        Me.dgvPanel = New System.Windows.Forms.Panel()
        Me.ShowAllProducteDGV = New System.Windows.Forms.DataGridView()
        Me.nav_Panel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.main_panel.SuspendLayout()
        Me.productInfoPanel.SuspendLayout()
        Me.dgvPanel.SuspendLayout()
        CType(Me.ShowAllProducteDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.LightCoral
        Me.main_panel.Controls.Add(Me.productInfoPanel)
        Me.main_panel.Controls.Add(Me.dgvPanel)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.main_panel.Location = New System.Drawing.Point(0, 65)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(1556, 697)
        Me.main_panel.TabIndex = 1
        '
        'productInfoPanel
        '
        Me.productInfoPanel.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.productInfoPanel.Controls.Add(Me.txtProducPrice)
        Me.productInfoPanel.Controls.Add(Me.txtProducName)
        Me.productInfoPanel.Controls.Add(Me.Label8)
        Me.productInfoPanel.Controls.Add(Me.Label5)
        Me.productInfoPanel.Controls.Add(Me.Panel4)
        Me.productInfoPanel.Controls.Add(Me.Label4)
        Me.productInfoPanel.Controls.Add(Me.Panel3)
        Me.productInfoPanel.Controls.Add(Me.Label3)
        Me.productInfoPanel.Controls.Add(Me.Panel2)
        Me.productInfoPanel.Controls.Add(Me.Label2)
        Me.productInfoPanel.Controls.Add(Me.Panel1)
        Me.productInfoPanel.Controls.Add(Me.cbCategorySelector)
        Me.productInfoPanel.Controls.Add(Me.txtExpiryDate)
        Me.productInfoPanel.Controls.Add(Me.txtProductionDate)
        Me.productInfoPanel.Controls.Add(Me.Label1)
        Me.productInfoPanel.Controls.Add(Me.deleteProductBtn)
        Me.productInfoPanel.Controls.Add(Me.newProducteBtn)
        Me.productInfoPanel.Controls.Add(Me.fetchAllProducte)
        Me.productInfoPanel.Controls.Add(Me.Label7)
        Me.productInfoPanel.Controls.Add(Me.UpdateProducteBtn)
        Me.productInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productInfoPanel.Location = New System.Drawing.Point(789, 0)
        Me.productInfoPanel.Name = "productInfoPanel"
        Me.productInfoPanel.Size = New System.Drawing.Size(767, 697)
        Me.productInfoPanel.TabIndex = 22
        '
        'txtProducPrice
        '
        Me.txtProducPrice.BackColor = System.Drawing.Color.LightCoral
        Me.txtProducPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducPrice.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProducPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProducPrice.Location = New System.Drawing.Point(485, 261)
        Me.txtProducPrice.Name = "txtProducPrice"
        Me.txtProducPrice.Size = New System.Drawing.Size(258, 32)
        Me.txtProducPrice.TabIndex = 37
        Me.txtProducPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProducName
        '
        Me.txtProducName.BackColor = System.Drawing.Color.LightCoral
        Me.txtProducName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProducName.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtProducName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProducName.Location = New System.Drawing.Point(485, 170)
        Me.txtProducName.Name = "txtProducName"
        Me.txtProducName.Size = New System.Drawing.Size(258, 32)
        Me.txtProducName.TabIndex = 36
        Me.txtProducName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(274, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 27)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Product Operation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Label5.Location = New System.Drawing.Point(557, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 27)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Category"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gold
        Me.Panel4.Location = New System.Drawing.Point(485, 469)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(258, 5)
        Me.Panel4.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Label4.Location = New System.Drawing.Point(544, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 27)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Expiry Date"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gold
        Me.Panel3.Location = New System.Drawing.Point(485, 380)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(258, 5)
        Me.Panel3.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Label3.Location = New System.Drawing.Point(517, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(194, 27)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Production Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gold
        Me.Panel2.Location = New System.Drawing.Point(485, 291)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 5)
        Me.Panel2.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(535, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 27)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Produc Price"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(485, 202)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 5)
        Me.Panel1.TabIndex = 27
        '
        'cbCategorySelector
        '
        Me.cbCategorySelector.BackColor = System.Drawing.Color.LightCoral
        Me.cbCategorySelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCategorySelector.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cbCategorySelector.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbCategorySelector.FormattingEnabled = True
        Me.cbCategorySelector.Location = New System.Drawing.Point(485, 530)
        Me.cbCategorySelector.Name = "cbCategorySelector"
        Me.cbCategorySelector.Size = New System.Drawing.Size(258, 39)
        Me.cbCategorySelector.TabIndex = 26
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.BackColor = System.Drawing.Color.LightCoral
        Me.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpiryDate.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtExpiryDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtExpiryDate.Location = New System.Drawing.Point(485, 439)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(258, 32)
        Me.txtExpiryDate.TabIndex = 25
        Me.txtExpiryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProductionDate
        '
        Me.txtProductionDate.BackColor = System.Drawing.Color.LightCoral
        Me.txtProductionDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProductionDate.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProductionDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtProductionDate.Location = New System.Drawing.Point(485, 350)
        Me.txtProductionDate.Name = "txtProductionDate"
        Me.txtProductionDate.Size = New System.Drawing.Size(258, 32)
        Me.txtProductionDate.TabIndex = 24
        Me.txtProductionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(527, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Name"
        '
        'deleteProductBtn
        '
        Me.deleteProductBtn.BackColor = System.Drawing.Color.IndianRed
        Me.deleteProductBtn.FlatAppearance.BorderSize = 0
        Me.deleteProductBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.deleteProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteProductBtn.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.deleteProductBtn.ForeColor = System.Drawing.Color.Black
        Me.deleteProductBtn.Image = Global.qr_code_system.My.Resources.Resources.warning
        Me.deleteProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deleteProductBtn.Location = New System.Drawing.Point(37, 446)
        Me.deleteProductBtn.Name = "deleteProductBtn"
        Me.deleteProductBtn.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.deleteProductBtn.Size = New System.Drawing.Size(158, 62)
        Me.deleteProductBtn.TabIndex = 19
        Me.deleteProductBtn.Text = "Delete"
        Me.deleteProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteProductBtn.UseVisualStyleBackColor = False
        '
        'newProducteBtn
        '
        Me.newProducteBtn.BackColor = System.Drawing.Color.LimeGreen
        Me.newProducteBtn.FlatAppearance.BorderSize = 0
        Me.newProducteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow
        Me.newProducteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.newProducteBtn.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.newProducteBtn.ForeColor = System.Drawing.Color.Black
        Me.newProducteBtn.Image = Global.qr_code_system.My.Resources.Resources.block
        Me.newProducteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newProducteBtn.Location = New System.Drawing.Point(37, 274)
        Me.newProducteBtn.Name = "newProducteBtn"
        Me.newProducteBtn.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.newProducteBtn.Size = New System.Drawing.Size(158, 62)
        Me.newProducteBtn.TabIndex = 2
        Me.newProducteBtn.Text = "Add"
        Me.newProducteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.newProducteBtn.UseVisualStyleBackColor = False
        '
        'fetchAllProducte
        '
        Me.fetchAllProducte.BackColor = System.Drawing.Color.Tomato
        Me.fetchAllProducte.FlatAppearance.BorderSize = 0
        Me.fetchAllProducte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon
        Me.fetchAllProducte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fetchAllProducte.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.fetchAllProducte.ForeColor = System.Drawing.Color.Black
        Me.fetchAllProducte.Image = Global.qr_code_system.My.Resources.Resources.direct_download24
        Me.fetchAllProducte.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.fetchAllProducte.Location = New System.Drawing.Point(37, 188)
        Me.fetchAllProducte.Name = "fetchAllProducte"
        Me.fetchAllProducte.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.fetchAllProducte.Size = New System.Drawing.Size(158, 62)
        Me.fetchAllProducte.TabIndex = 11
        Me.fetchAllProducte.Text = "Show all"
        Me.fetchAllProducte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fetchAllProducte.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.PeachPuff
        Me.Label7.Location = New System.Drawing.Point(116, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 3)
        Me.Label7.TabIndex = 21
        '
        'UpdateProducteBtn
        '
        Me.UpdateProducteBtn.BackColor = System.Drawing.Color.OldLace
        Me.UpdateProducteBtn.FlatAppearance.BorderSize = 0
        Me.UpdateProducteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FloralWhite
        Me.UpdateProducteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateProducteBtn.Font = New System.Drawing.Font("Mudir MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.UpdateProducteBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateProducteBtn.Image = Global.qr_code_system.My.Resources.Resources.rotate
        Me.UpdateProducteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdateProducteBtn.Location = New System.Drawing.Point(37, 360)
        Me.UpdateProducteBtn.Name = "UpdateProducteBtn"
        Me.UpdateProducteBtn.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.UpdateProducteBtn.Size = New System.Drawing.Size(158, 62)
        Me.UpdateProducteBtn.TabIndex = 12
        Me.UpdateProducteBtn.Text = "Update"
        Me.UpdateProducteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateProducteBtn.UseVisualStyleBackColor = False
        '
        'dgvPanel
        '
        Me.dgvPanel.Controls.Add(Me.ShowAllProducteDGV)
        Me.dgvPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvPanel.Location = New System.Drawing.Point(0, 0)
        Me.dgvPanel.Name = "dgvPanel"
        Me.dgvPanel.Size = New System.Drawing.Size(789, 697)
        Me.dgvPanel.TabIndex = 10
        '
        'ShowAllProducteDGV
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.ShowAllProducteDGV.BackgroundColor = System.Drawing.Color.BlanchedAlmond
        Me.ShowAllProducteDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ShowAllProducteDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ShowAllProducteDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ShowAllProducteDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tajawal", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.DefaultCellStyle = DataGridViewCellStyle8
        Me.ShowAllProducteDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowAllProducteDGV.GridColor = System.Drawing.Color.Orange
        Me.ShowAllProducteDGV.Location = New System.Drawing.Point(0, 0)
        Me.ShowAllProducteDGV.Name = "ShowAllProducteDGV"
        Me.ShowAllProducteDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.ShowAllProducteDGV.RowHeadersWidth = 30
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tajawal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ShowAllProducteDGV.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.ShowAllProducteDGV.RowTemplate.Height = 26
        Me.ShowAllProducteDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ShowAllProducteDGV.Size = New System.Drawing.Size(789, 697)
        Me.ShowAllProducteDGV.TabIndex = 2
        '
        'nav_Panel
        '
        Me.nav_Panel.BackColor = System.Drawing.Color.PeachPuff
        Me.nav_Panel.Controls.Add(Me.Label6)
        Me.nav_Panel.Controls.Add(Me.btnClose)
        Me.nav_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.nav_Panel.Location = New System.Drawing.Point(0, 0)
        Me.nav_Panel.Name = "nav_Panel"
        Me.nav_Panel.Size = New System.Drawing.Size(1556, 65)
        Me.nav_Panel.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(728, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 27)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Product"
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.qr_code_system.My.Resources.Resources.close__1_
        Me.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnClose.Location = New System.Drawing.Point(1515, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1556, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.nav_Panel)
        Me.Controls.Add(Me.main_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ProductForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductForm"
        Me.main_panel.ResumeLayout(False)
        Me.productInfoPanel.ResumeLayout(False)
        Me.productInfoPanel.PerformLayout()
        Me.dgvPanel.ResumeLayout(False)
        CType(Me.ShowAllProducteDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_Panel.ResumeLayout(False)
        Me.nav_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents ShowAllProducteDGV As DataGridView
    Friend WithEvents newProducteBtn As Button
    Friend WithEvents nav_Panel As Panel
    Friend WithEvents dgvPanel As Panel
    Friend WithEvents UpdateProducteBtn As Button
    Friend WithEvents deleteProductBtn As Button
    Friend WithEvents fetchAllProducte As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents productInfoPanel As Panel
    Friend WithEvents cbCategorySelector As ComboBox
    Friend WithEvents txtExpiryDate As TextBox
    Friend WithEvents txtProductionDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtProducName As TextBox
    Friend WithEvents txtProducPrice As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CategoriesForm
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
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.AddNewCategoryBtn = New System.Windows.Forms.Button()
        Me.UpdateCategoryBtn = New System.Windows.Forms.Button()
        Me.fetchAllCategoriesBtn = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DeleteCategoryBtn = New System.Windows.Forms.Button()
        Me.categoriesDGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.categoriesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCategoryName
        '
        Me.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCategoryName.Font = New System.Drawing.Font("El Messiri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCategoryName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtCategoryName.Location = New System.Drawing.Point(328, 325)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(205, 32)
        Me.txtCategoryName.TabIndex = 0
        '
        'AddNewCategoryBtn
        '
        Me.AddNewCategoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddNewCategoryBtn.Location = New System.Drawing.Point(0, 40)
        Me.AddNewCategoryBtn.Name = "AddNewCategoryBtn"
        Me.AddNewCategoryBtn.Size = New System.Drawing.Size(1032, 40)
        Me.AddNewCategoryBtn.TabIndex = 1
        Me.AddNewCategoryBtn.Text = "create"
        Me.AddNewCategoryBtn.UseVisualStyleBackColor = True
        '
        'UpdateCategoryBtn
        '
        Me.UpdateCategoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpdateCategoryBtn.Location = New System.Drawing.Point(0, 80)
        Me.UpdateCategoryBtn.Name = "UpdateCategoryBtn"
        Me.UpdateCategoryBtn.Size = New System.Drawing.Size(1032, 40)
        Me.UpdateCategoryBtn.TabIndex = 2
        Me.UpdateCategoryBtn.Text = "update"
        Me.UpdateCategoryBtn.UseVisualStyleBackColor = True
        '
        'fetchAllCategoriesBtn
        '
        Me.fetchAllCategoriesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.fetchAllCategoriesBtn.Location = New System.Drawing.Point(0, 0)
        Me.fetchAllCategoriesBtn.Name = "fetchAllCategoriesBtn"
        Me.fetchAllCategoriesBtn.Size = New System.Drawing.Size(1032, 40)
        Me.fetchAllCategoriesBtn.TabIndex = 4
        Me.fetchAllCategoriesBtn.Text = "show"
        Me.fetchAllCategoriesBtn.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.qr_code_system.My.Resources.Resources.close__1_
        Me.btnClose.Location = New System.Drawing.Point(999, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(33, 18)
        Me.btnClose.TabIndex = 5
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DeleteCategoryBtn
        '
        Me.DeleteCategoryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteCategoryBtn.Location = New System.Drawing.Point(0, 120)
        Me.DeleteCategoryBtn.Name = "DeleteCategoryBtn"
        Me.DeleteCategoryBtn.Size = New System.Drawing.Size(1032, 48)
        Me.DeleteCategoryBtn.TabIndex = 6
        Me.DeleteCategoryBtn.Text = "delete"
        Me.DeleteCategoryBtn.UseVisualStyleBackColor = True
        '
        'categoriesDGV
        '
        Me.categoriesDGV.BackgroundColor = System.Drawing.Color.Gray
        Me.categoriesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.categoriesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.categoriesDGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.categoriesDGV.Location = New System.Drawing.Point(0, 487)
        Me.categoriesDGV.Name = "categoriesDGV"
        Me.categoriesDGV.RowHeadersWidth = 51
        Me.categoriesDGV.RowTemplate.Height = 26
        Me.categoriesDGV.Size = New System.Drawing.Size(1032, 79)
        Me.categoriesDGV.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 18)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!)
        Me.Label2.Location = New System.Drawing.Point(323, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Category Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DeleteCategoryBtn)
        Me.Panel2.Controls.Add(Me.UpdateCategoryBtn)
        Me.Panel2.Controls.Add(Me.AddNewCategoryBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.fetchAllCategoriesBtn)
        Me.Panel2.Controls.Add(Me.txtCategoryName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1032, 548)
        Me.Panel2.TabIndex = 11
        '
        'CategoriesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1032, 566)
        Me.Controls.Add(Me.categoriesDGV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoriesForm"
        Me.Text = "CategoriesForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.categoriesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents AddNewCategoryBtn As Button
    Friend WithEvents UpdateCategoryBtn As Button
    Friend WithEvents fetchAllCategoriesBtn As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DeleteCategoryBtn As Button
    Friend WithEvents categoriesDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class

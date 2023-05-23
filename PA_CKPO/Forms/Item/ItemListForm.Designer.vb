<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        NavbarControl1 = New NavbarControl()
        Label2 = New Label()
        btnRefresh = New FontAwesome.Sharp.IconButton()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        btnEdit = New FontAwesome.Sharp.IconButton()
        btnHapus = New FontAwesome.Sharp.IconButton()
        btnTambah = New FontAwesome.Sharp.IconButton()
        txtCari = New TextBox()
        id = New DataGridViewTextBoxColumn()
        code = New DataGridViewTextBoxColumn()
        item_name = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        category = New DataGridViewTextBoxColumn()
        color = New DataGridViewTextBoxColumn()
        brand = New DataGridViewTextBoxColumn()
        uom = New DataGridViewTextBoxColumn()
        supplier_name = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NavbarControl1
        ' 
        NavbarControl1.Location = New Point(0, 0)
        NavbarControl1.Name = "NavbarControl1"
        NavbarControl1.Size = New Size(1374, 50)
        NavbarControl1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 17.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(10, 37)
        Label2.Name = "Label2"
        Label2.Size = New Size(271, 35)
        Label2.TabIndex = 18
        Label2.Text = "Manajamen Barang"' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        btnRefresh.IconColor = Drawing.Color.Black
        btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRefresh.IconSize = 25
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(692, 77)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(89, 40)
        btnRefresh.TabIndex = 17
        btnRefresh.Text = "Refresh"
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, code, item_name, price, category, color, brand, uom, supplier_name})
        DataGridView1.Location = New Point(10, 127)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1071, 479)
        DataGridView1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 27)
        Label1.TabIndex = 15
        Label1.Text = "Cari :"' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(255), CByte(192))
        btnEdit.FlatStyle = FlatStyle.Popup
        btnEdit.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileEdit
        btnEdit.IconColor = Drawing.Color.Black
        btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnEdit.IconSize = 25
        btnEdit.ImageAlign = ContentAlignment.MiddleLeft
        btnEdit.Location = New Point(894, 77)
        btnEdit.Margin = New Padding(3, 4, 3, 4)
        btnEdit.Name = "btnEdit"
        btnEdit.Padding = New Padding(0, 0, 5, 0)
        btnEdit.Size = New Size(81, 40)
        btnEdit.TabIndex = 14
        btnEdit.Text = "Edit"
        btnEdit.TextAlign = ContentAlignment.MiddleRight
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Drawing.Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnHapus.FlatStyle = FlatStyle.Popup
        btnHapus.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        btnHapus.IconColor = Drawing.Color.Black
        btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnHapus.IconSize = 25
        btnHapus.ImageAlign = ContentAlignment.MiddleLeft
        btnHapus.Location = New Point(981, 77)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Padding = New Padding(0, 0, 5, 0)
        btnHapus.Size = New Size(101, 40)
        btnHapus.TabIndex = 13
        btnHapus.Text = "Hapus"
        btnHapus.TextAlign = ContentAlignment.MiddleRight
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Drawing.Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnTambah.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        btnTambah.IconColor = Drawing.Color.Black
        btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTambah.IconSize = 25
        btnTambah.ImageAlign = ContentAlignment.MiddleLeft
        btnTambah.Location = New Point(786, 77)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(102, 40)
        btnTambah.TabIndex = 12
        btnTambah.Text = "Tambah"
        btnTambah.TextAlign = ContentAlignment.MiddleRight
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        txtCari.Location = New Point(77, 78)
        txtCari.Margin = New Padding(5, 4, 5, 4)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(606, 34)
        txtCari.TabIndex = 11
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "ID"
        id.MinimumWidth = 6
        id.Name = "id"
        id.ReadOnly = True
        id.Width = 50
        ' 
        ' code
        ' 
        code.DataPropertyName = "code"
        code.HeaderText = "Kode"
        code.MinimumWidth = 6
        code.Name = "code"
        code.ReadOnly = True
        code.Width = 70
        ' 
        ' item_name
        ' 
        item_name.DataPropertyName = "name"
        item_name.HeaderText = "Nama"
        item_name.MinimumWidth = 6
        item_name.Name = "item_name"
        item_name.ReadOnly = True
        item_name.Width = 150
        ' 
        ' price
        ' 
        price.DataPropertyName = "price"
        price.HeaderText = "Harga"
        price.MinimumWidth = 6
        price.Name = "price"
        price.ReadOnly = True
        price.Width = 110
        ' 
        ' category
        ' 
        category.DataPropertyName = "category"
        category.HeaderText = "Kategori"
        category.MinimumWidth = 6
        category.Name = "category"
        category.ReadOnly = True
        category.Width = 150
        ' 
        ' color
        ' 
        color.DataPropertyName = "color"
        color.HeaderText = "Warna"
        color.MinimumWidth = 6
        color.Name = "color"
        color.ReadOnly = True
        ' 
        ' brand
        ' 
        brand.DataPropertyName = "brand"
        brand.HeaderText = "Merk"
        brand.MinimumWidth = 6
        brand.Name = "brand"
        brand.ReadOnly = True
        ' 
        ' uom
        ' 
        uom.DataPropertyName = "uom"
        uom.HeaderText = "Satuan"
        uom.MinimumWidth = 6
        uom.Name = "uom"
        uom.ReadOnly = True
        uom.Width = 120
        ' 
        ' supplier_name
        ' 
        supplier_name.DataPropertyName = "supplier_name"
        supplier_name.HeaderText = "supplier"
        supplier_name.MinimumWidth = 6
        supplier_name.Name = "supplier_name"
        supplier_name.ReadOnly = True
        supplier_name.Width = 150
        ' 
        ' ItemListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 643)
        Controls.Add(Label2)
        Controls.Add(btnRefresh)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(btnTambah)
        Controls.Add(txtCari)
        Controls.Add(NavbarControl1)
        Name = "ItemListForm"
        Text = "ItemListForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHapus As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTambah As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCari As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents uom As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
End Class

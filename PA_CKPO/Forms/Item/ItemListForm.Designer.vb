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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.btnHapus = New FontAwesome.Sharp.IconButton()
        Me.btnTambah = New FontAwesome.Sharp.IconButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnFilter = New FontAwesome.Sharp.IconButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item_name, Me.price, Me.category, Me.code})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(924, 359)
        Me.DataGridView1.TabIndex = 24
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 150
        '
        'item_name
        '
        Me.item_name.HeaderText = "NAMA"
        Me.item_name.Name = "item_name"
        Me.item_name.Width = 250
        '
        'price
        '
        Me.price.HeaderText = "HARGA"
        Me.price.Name = "price"
        Me.price.Width = 150
        '
        'category
        '
        Me.category.HeaderText = "KATEGORI"
        Me.category.Name = "category"
        Me.category.Width = 200
        '
        'code
        '
        Me.code.HeaderText = "KODE"
        Me.code.Name = "code"
        Me.code.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Cari :"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileEdit
        Me.btnEdit.IconColor = System.Drawing.Color.Black
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 25
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(773, 99)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(66, 30)
        Me.btnEdit.TabIndex = 22
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.SystemColors.Control
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnHapus.IconColor = System.Drawing.Color.Black
        Me.btnHapus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHapus.IconSize = 25
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(851, 99)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(73, 30)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.SystemColors.Control
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnTambah.IconColor = System.Drawing.Color.Black
        Me.btnTambah.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTambah.IconSize = 25
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(681, 99)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(83, 30)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(67, 103)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(531, 28)
        Me.TextBox1.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PA_CKPO.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(14, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Control
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFilter.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter
        Me.btnFilter.IconColor = System.Drawing.Color.Black
        Me.btnFilter.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFilter.IconSize = 25
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(605, 99)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(66, 30)
        Me.btnFilter.TabIndex = 25
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'ItemListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFilter)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ItemListForm"
        Me.Text = "ItemListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHapus As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTambah As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFilter As FontAwesome.Sharp.IconButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
End Class

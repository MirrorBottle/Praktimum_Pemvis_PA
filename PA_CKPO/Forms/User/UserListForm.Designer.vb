<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserListForm
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
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnTambah = New FontAwesome.Sharp.IconButton()
        Me.btnHapus = New FontAwesome.Sharp.IconButton()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NavbarControl1 = New PA_CKPO.NavbarControl()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCari.Location = New System.Drawing.Point(79, 93)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(606, 34)
        Me.txtCari.TabIndex = 3
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambah.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnTambah.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnTambah.IconColor = System.Drawing.Color.Black
        Me.btnTambah.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTambah.IconSize = 25
        Me.btnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambah.Location = New System.Drawing.Point(787, 91)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(102, 40)
        Me.btnTambah.TabIndex = 4
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapus.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnHapus.IconColor = System.Drawing.Color.Black
        Me.btnHapus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHapus.IconSize = 25
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(982, 91)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnHapus.Size = New System.Drawing.Size(101, 40)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.FileEdit
        Me.btnEdit.IconColor = System.Drawing.Color.Black
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 25
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(895, 91)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btnEdit.Size = New System.Drawing.Size(81, 40)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(11, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cari :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.customer_name, Me.user_name, Me.contact_number, Me.address})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 141)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1071, 479)
        Me.DataGridView1.TabIndex = 8
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        Me.btnRefresh.IconColor = System.Drawing.Color.Black
        Me.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRefresh.IconSize = 25
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(693, 91)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 40)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(309, 35)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Manajamen Pengguna"
        '
        'NavbarControl1
        '
        Me.NavbarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavbarControl1.Name = "NavbarControl1"
        Me.NavbarControl1.Size = New System.Drawing.Size(1375, 51)
        Me.NavbarControl1.TabIndex = 11
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 50
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "name"
        Me.customer_name.HeaderText = "Nama"
        Me.customer_name.MinimumWidth = 6
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.Width = 250
        '
        'user_name
        '
        Me.user_name.DataPropertyName = "user_name"
        Me.user_name.HeaderText = "Nama Kontak"
        Me.user_name.MinimumWidth = 6
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        Me.user_name.Width = 300
        '
        'contact_number
        '
        Me.contact_number.DataPropertyName = "contact_number"
        Me.contact_number.HeaderText = "No. HP"
        Me.contact_number.MinimumWidth = 6
        Me.contact_number.Name = "contact_number"
        Me.contact_number.ReadOnly = True
        Me.contact_number.Width = 200
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "Alamat"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 200
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 643)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtCari)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "UserListForm"
        Me.Text = "Daftar Pengguna"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnTambah As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHapus As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents customer_name As DataGridViewTextBoxColumn
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents contact_number As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
End Class

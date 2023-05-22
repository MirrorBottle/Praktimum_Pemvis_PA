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
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NavbarControl1 = New PA_CKPO.NavbarControl()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCari.Location = New System.Drawing.Point(68, 69)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(531, 28)
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
        Me.btnTambah.Location = New System.Drawing.Point(689, 68)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(89, 30)
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
        Me.btnHapus.Location = New System.Drawing.Point(859, 68)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.btnHapus.Size = New System.Drawing.Size(88, 30)
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
        Me.btnEdit.Location = New System.Drawing.Point(783, 68)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.btnEdit.Size = New System.Drawing.Size(71, 30)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cari :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.username, Me.user_name, Me.role})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(937, 359)
        Me.DataGridView1.TabIndex = 8
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
        'username
        '
        Me.username.DataPropertyName = "username"
        Me.username.HeaderText = "Username"
        Me.username.MinimumWidth = 6
        Me.username.Name = "username"
        Me.username.ReadOnly = True
        Me.username.Width = 250
        '
        'user_name
        '
        Me.user_name.DataPropertyName = "user_name"
        Me.user_name.HeaderText = "Nama"
        Me.user_name.MinimumWidth = 6
        Me.user_name.Name = "user_name"
        Me.user_name.ReadOnly = True
        Me.user_name.Width = 300
        '
        'role
        '
        Me.role.DataPropertyName = "role"
        Me.role.HeaderText = "Hak Akses"
        Me.role.MinimumWidth = 6
        Me.role.Name = "role"
        Me.role.ReadOnly = True
        Me.role.Width = 200
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
        Me.btnRefresh.Location = New System.Drawing.Point(606, 68)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 30)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 28)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Manajamen Pengguna"
        '
        'NavbarControl1
        '
        Me.NavbarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavbarControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavbarControl1.Name = "NavbarControl1"
        Me.NavbarControl1.Size = New System.Drawing.Size(1203, 38)
        Me.NavbarControl1.TabIndex = 11
        '
        'UserListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 482)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtCari)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents user_name As DataGridViewTextBoxColumn
    Friend WithEvents role As DataGridViewTextBoxColumn
End Class

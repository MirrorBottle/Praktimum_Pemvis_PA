<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDashboardForm
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
        Me.NavbarControl1 = New PA_CKPO.NavbarControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New FontAwesome.Sharp.IconButton()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logistic_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_total_fulfilled = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payed_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavbarControl1
        '
        Me.NavbarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavbarControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavbarControl1.Name = "NavbarControl1"
        Me.NavbarControl1.Size = New System.Drawing.Size(962, 30)
        Me.NavbarControl1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 28)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Selamat Datang, Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Daftar PO"
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
        Me.btnTambah.Location = New System.Drawing.Point(858, 84)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(86, 30)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Buat PO"
        Me.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambah.UseVisualStyleBackColor = False
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
        Me.btnRefresh.Location = New System.Drawing.Point(774, 84)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 30)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.code, Me.status, Me.logistic_name, Me.items_total, Me.items_total_fulfilled, Me.total_amount, Me.payed_amount})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(932, 359)
        Me.DataGridView1.TabIndex = 23
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'code
        '
        Me.code.DataPropertyName = "code"
        Me.code.HeaderText = "Kode"
        Me.code.MinimumWidth = 6
        Me.code.Name = "code"
        Me.code.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "status"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 140
        '
        'logistic_name
        '
        Me.logistic_name.DataPropertyName = "logistic_name"
        Me.logistic_name.HeaderText = "Logistik"
        Me.logistic_name.Name = "logistic_name"
        Me.logistic_name.ReadOnly = True
        '
        'items_total
        '
        Me.items_total.DataPropertyName = "items_total"
        Me.items_total.HeaderText = "Jml. Barang"
        Me.items_total.MinimumWidth = 6
        Me.items_total.Name = "items_total"
        Me.items_total.ReadOnly = True
        '
        'items_total_fulfilled
        '
        Me.items_total_fulfilled.DataPropertyName = "items_total_fulfilled"
        Me.items_total_fulfilled.HeaderText = "Jml. Barang Tersedia"
        Me.items_total_fulfilled.Name = "items_total_fulfilled"
        Me.items_total_fulfilled.ReadOnly = True
        Me.items_total_fulfilled.Width = 150
        '
        'total_amount
        '
        Me.total_amount.DataPropertyName = "total_amount"
        Me.total_amount.HeaderText = "Total"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        '
        'payed_amount
        '
        Me.payed_amount.DataPropertyName = "payed_amount"
        Me.payed_amount.HeaderText = "Total Final"
        Me.payed_amount.Name = "payed_amount"
        Me.payed_amount.ReadOnly = True
        '
        'CustomerDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 482)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CustomerDashboardForm"
        Me.Text = "Dashboard Kustomer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTambah As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents logistic_name As DataGridViewTextBoxColumn
    Friend WithEvents items_total As DataGridViewTextBoxColumn
    Friend WithEvents items_total_fulfilled As DataGridViewTextBoxColumn
    Friend WithEvents total_amount As DataGridViewTextBoxColumn
    Friend WithEvents payed_amount As DataGridViewTextBoxColumn
End Class

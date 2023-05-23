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
        NavbarControl1 = New NavbarControl()
        Label2 = New Label()
        Label1 = New Label()
        btnTambah = New FontAwesome.Sharp.IconButton()
        btnRefresh = New FontAwesome.Sharp.IconButton()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        code = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        logistic_name = New DataGridViewTextBoxColumn()
        items_total = New DataGridViewTextBoxColumn()
        items_total_fulfilled = New DataGridViewTextBoxColumn()
        total_amount = New DataGridViewTextBoxColumn()
        payed_amount = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NavbarControl1
        ' 
        NavbarControl1.Location = New Point(0, 0)
        NavbarControl1.Name = "NavbarControl1"
        NavbarControl1.Size = New Size(1099, 40)
        NavbarControl1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 17.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(14, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(367, 35)
        Label2.TabIndex = 12
        Label2.Text = "Selamat Datang, Customer"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(14, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 30)
        Label1.TabIndex = 14
        Label1.Text = "Daftar PO"' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnTambah.FlatStyle = FlatStyle.Popup
        btnTambah.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnTambah.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        btnTambah.IconColor = Color.Black
        btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnTambah.IconSize = 25
        btnTambah.ImageAlign = ContentAlignment.MiddleLeft
        btnTambah.Location = New Point(981, 112)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(98, 40)
        btnTambah.TabIndex = 15
        btnTambah.Text = "Buat PO"
        btnTambah.TextAlign = ContentAlignment.MiddleRight
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnRefresh.FlatStyle = FlatStyle.Popup
        btnRefresh.Font = New Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.IconChar = FontAwesome.Sharp.IconChar.Repeat
        btnRefresh.IconColor = Color.Black
        btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnRefresh.IconSize = 25
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(885, 112)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(89, 40)
        btnRefresh.TabIndex = 18
        btnRefresh.Text = "Refresh"
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, code, status, logistic_name, items_total, items_total_fulfilled, total_amount, payed_amount})
        DataGridView1.Location = New Point(14, 160)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1065, 479)
        DataGridView1.TabIndex = 23
        ' 
        ' id
        ' 
        id.DataPropertyName = "id"
        id.HeaderText = "ID"
        id.MinimumWidth = 6
        id.Name = "id"
        id.ReadOnly = True
        id.Visible = False
        id.Width = 50
        ' 
        ' code
        ' 
        code.DataPropertyName = "code"
        code.HeaderText = "Kode"
        code.MinimumWidth = 6
        code.Name = "code"
        code.ReadOnly = True
        code.Width = 125
        ' 
        ' status
        ' 
        status.DataPropertyName = "status"
        status.HeaderText = "Status"
        status.MinimumWidth = 6
        status.Name = "status"
        status.ReadOnly = True
        status.Width = 140
        ' 
        ' logistic_name
        ' 
        logistic_name.DataPropertyName = "logistic_name"
        logistic_name.HeaderText = "Logistik"
        logistic_name.MinimumWidth = 6
        logistic_name.Name = "logistic_name"
        logistic_name.ReadOnly = True
        logistic_name.Width = 125
        ' 
        ' items_total
        ' 
        items_total.DataPropertyName = "items_total"
        items_total.HeaderText = "Jml. Barang"
        items_total.MinimumWidth = 6
        items_total.Name = "items_total"
        items_total.ReadOnly = True
        items_total.Width = 125
        ' 
        ' items_total_fulfilled
        ' 
        items_total_fulfilled.DataPropertyName = "items_total_fulfilled"
        items_total_fulfilled.HeaderText = "Jml. Barang Tersedia"
        items_total_fulfilled.MinimumWidth = 6
        items_total_fulfilled.Name = "items_total_fulfilled"
        items_total_fulfilled.ReadOnly = True
        items_total_fulfilled.Width = 150
        ' 
        ' total_amount
        ' 
        total_amount.DataPropertyName = "total_amount"
        total_amount.HeaderText = "Total"
        total_amount.MinimumWidth = 6
        total_amount.Name = "total_amount"
        total_amount.ReadOnly = True
        total_amount.Width = 125
        ' 
        ' payed_amount
        ' 
        payed_amount.DataPropertyName = "payed_amount"
        payed_amount.HeaderText = "Total Final"
        payed_amount.MinimumWidth = 6
        payed_amount.Name = "payed_amount"
        payed_amount.ReadOnly = True
        payed_amount.Width = 125
        ' 
        ' CustomerDashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 643)
        Controls.Add(DataGridView1)
        Controls.Add(btnRefresh)
        Controls.Add(btnTambah)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(NavbarControl1)
        Name = "CustomerDashboardForm"
        Text = "Dashboard Kustomer"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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

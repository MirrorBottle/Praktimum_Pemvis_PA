<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderAdminForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NavbarControl1 = New PA_CKPO.NavbarControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCustomer = New System.Windows.Forms.ComboBox()
        Me.CmbLogistic = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New FontAwesome.Sharp.IconButton()
        Me.BtnRemove = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New FontAwesome.Sharp.IconButton()
        Me.BtnClear = New FontAwesome.Sharp.IconButton()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.items_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 28)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Buat PO"
        '
        'NavbarControl1
        '
        Me.NavbarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavbarControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NavbarControl1.Name = "NavbarControl1"
        Me.NavbarControl1.Size = New System.Drawing.Size(1203, 38)
        Me.NavbarControl1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Customer"
        '
        'CmbCustomer
        '
        Me.CmbCustomer.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbCustomer.FormattingEnabled = True
        Me.CmbCustomer.Location = New System.Drawing.Point(124, 115)
        Me.CmbCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCustomer.Name = "CmbCustomer"
        Me.CmbCustomer.Size = New System.Drawing.Size(309, 30)
        Me.CmbCustomer.TabIndex = 16
        '
        'CmbLogistic
        '
        Me.CmbLogistic.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbLogistic.FormattingEnabled = True
        Me.CmbLogistic.Location = New System.Drawing.Point(613, 115)
        Me.CmbLogistic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbLogistic.Name = "CmbLogistic"
        Me.CmbLogistic.Size = New System.Drawing.Size(331, 30)
        Me.CmbLogistic.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(523, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Logistik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(10, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Katalog Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item_code, Me.item_name, Me.item_price, Me.item_uom, Me.item_supplier})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(421, 180)
        Me.DataGridView1.TabIndex = 22
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'item_code
        '
        Me.item_code.DataPropertyName = "code"
        Me.item_code.HeaderText = "Kode"
        Me.item_code.Name = "item_code"
        Me.item_code.Width = 50
        '
        'item_name
        '
        Me.item_name.DataPropertyName = "name"
        Me.item_name.HeaderText = "Nama"
        Me.item_name.Name = "item_name"
        Me.item_name.Width = 200
        '
        'item_price
        '
        Me.item_price.DataPropertyName = "price"
        Me.item_price.HeaderText = "Harga"
        Me.item_price.Name = "item_price"
        Me.item_price.Width = 80
        '
        'item_uom
        '
        Me.item_uom.DataPropertyName = "uom"
        Me.item_uom.HeaderText = "Satuan"
        Me.item_uom.Name = "item_uom"
        Me.item_uom.Width = 50
        '
        'item_supplier
        '
        Me.item_supplier.DataPropertyName = "supplier"
        Me.item_supplier.HeaderText = "Supplier"
        Me.item_supplier.Name = "item_supplier"
        Me.item_supplier.Width = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(10, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 22)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cari"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtSearch.Location = New System.Drawing.Point(55, 204)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(378, 31)
        Me.TxtSearch.TabIndex = 24
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAdd.Enabled = False
        Me.BtnAdd.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.BtnAdd.IconColor = System.Drawing.Color.Black
        Me.BtnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnAdd.IconSize = 35
        Me.BtnAdd.Location = New System.Drawing.Point(439, 264)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 42)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.BtnRemove.IconColor = System.Drawing.Color.Black
        Me.BtnRemove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRemove.IconSize = 35
        Me.BtnRemove.Location = New System.Drawing.Point(439, 329)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 42)
        Me.BtnRemove.TabIndex = 26
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(523, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "PO Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(523, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 22)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Pembayaran"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotal.Location = New System.Drawing.Point(646, 201)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(298, 31)
        Me.TxtTotal.TabIndex = 30
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.LightGreen
        Me.BtnSubmit.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.BtnSubmit.IconColor = System.Drawing.Color.Black
        Me.BtnSubmit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSubmit.IconSize = 30
        Me.BtnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSubmit.Location = New System.Drawing.Point(841, 555)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(104, 32)
        Me.BtnSubmit.TabIndex = 32
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClear.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.BtnClear.IconColor = System.Drawing.Color.Black
        Me.BtnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnClear.IconSize = 30
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(718, 555)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 32)
        Me.BtnClear.TabIndex = 31
        Me.BtnClear.Text = "    Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.items_id, Me.items_code, Me.items_name, Me.items_price, Me.items_amount, Me.items_total})
        Me.DataGridView2.Location = New System.Drawing.Point(523, 241)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.Size = New System.Drawing.Size(421, 180)
        Me.DataGridView2.TabIndex = 33
        '
        'items_id
        '
        Me.items_id.DataPropertyName = "id"
        Me.items_id.HeaderText = "ID"
        Me.items_id.Name = "items_id"
        Me.items_id.Visible = False
        Me.items_id.Width = 50
        '
        'items_code
        '
        Me.items_code.DataPropertyName = "code"
        Me.items_code.HeaderText = "Kode"
        Me.items_code.Name = "items_code"
        Me.items_code.Width = 50
        '
        'items_name
        '
        Me.items_name.DataPropertyName = "name"
        Me.items_name.HeaderText = "Nama"
        Me.items_name.Name = "items_name"
        '
        'items_price
        '
        Me.items_price.DataPropertyName = "price"
        Me.items_price.HeaderText = "Harga"
        Me.items_price.Name = "items_price"
        Me.items_price.Width = 80
        '
        'items_amount
        '
        Me.items_amount.DataPropertyName = "amount"
        Me.items_amount.HeaderText = "Jumlah"
        Me.items_amount.Name = "items_amount"
        Me.items_amount.Width = 50
        '
        'items_total
        '
        Me.items_total.DataPropertyName = "total"
        Me.items_total.HeaderText = "Total"
        Me.items_total.Name = "items_total"
        '
        'TxtNote
        '
        Me.TxtNote.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNote.Location = New System.Drawing.Point(90, 442)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(343, 105)
        Me.TxtNote.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(10, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 22)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Catatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(10, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 22)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "ID"
        '
        'TxtCode
        '
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCode.Location = New System.Drawing.Point(124, 70)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(309, 31)
        Me.TxtCode.TabIndex = 37
        '
        'PurchaseOrderAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 598)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbLogistic)
        Me.Controls.Add(Me.CmbCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "PurchaseOrderAdminForm"
        Me.Text = "Buat PO"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbCustomer As ComboBox
    Friend WithEvents CmbLogistic As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnAdd As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRemove As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents BtnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents item_price As DataGridViewTextBoxColumn
    Friend WithEvents item_uom As DataGridViewTextBoxColumn
    Friend WithEvents item_supplier As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents items_id As DataGridViewTextBoxColumn
    Friend WithEvents items_code As DataGridViewTextBoxColumn
    Friend WithEvents items_name As DataGridViewTextBoxColumn
    Friend WithEvents items_price As DataGridViewTextBoxColumn
    Friend WithEvents items_amount As DataGridViewTextBoxColumn
    Friend WithEvents items_total As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCode As TextBox
End Class

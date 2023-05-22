<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderApprovalAdminForm
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
        Me.NavbarControl1 = New PA_CKPO.NavbarControl()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount_request = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_request = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbLogistic = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPayment = New System.Windows.Forms.TextBox()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.BtnClear = New FontAwesome.Sharp.IconButton()
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
        'TxtCode
        '
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCode.Location = New System.Drawing.Point(125, 72)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(309, 31)
        Me.TxtCode.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(11, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 22)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(11, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 22)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Catatan"
        '
        'TxtNote
        '
        Me.TxtNote.Enabled = False
        Me.TxtNote.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNote.Location = New System.Drawing.Point(91, 428)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(343, 105)
        Me.TxtNote.TabIndex = 55
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
        Me.BtnSubmit.Location = New System.Drawing.Point(842, 555)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(104, 32)
        Me.BtnSubmit.TabIndex = 53
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(13, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 22)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Daftar Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.item_code, Me.item_name, Me.item_uom, Me.supplier_name, Me.item_price, Me.amount_request, Me.price_request})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(933, 180)
        Me.DataGridView1.TabIndex = 44
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
        Me.item_code.DataPropertyName = "item_code"
        Me.item_code.HeaderText = "Kode"
        Me.item_code.Name = "item_code"
        Me.item_code.Width = 50
        '
        'item_name
        '
        Me.item_name.DataPropertyName = "item_name"
        Me.item_name.HeaderText = "Nama"
        Me.item_name.Name = "item_name"
        Me.item_name.Width = 230
        '
        'item_uom
        '
        Me.item_uom.DataPropertyName = "item_uom"
        Me.item_uom.HeaderText = "Satuan"
        Me.item_uom.Name = "item_uom"
        Me.item_uom.Width = 50
        '
        'supplier_name
        '
        Me.supplier_name.DataPropertyName = "supplier_name"
        Me.supplier_name.HeaderText = "Supplier"
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.Width = 140
        '
        'item_price
        '
        Me.item_price.DataPropertyName = "item_price"
        Me.item_price.HeaderText = "Harga"
        Me.item_price.Name = "item_price"
        Me.item_price.Width = 80
        '
        'amount_request
        '
        Me.amount_request.DataPropertyName = "amount_request"
        Me.amount_request.HeaderText = "Jumlah"
        Me.amount_request.Name = "amount_request"
        '
        'price_request
        '
        Me.price_request.DataPropertyName = "price_request"
        Me.price_request.HeaderText = "Total"
        Me.price_request.Name = "price_request"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(13, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Logistik"
        '
        'CmbLogistic
        '
        Me.CmbLogistic.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbLogistic.FormattingEnabled = True
        Me.CmbLogistic.Location = New System.Drawing.Point(125, 121)
        Me.CmbLogistic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbLogistic.Name = "CmbLogistic"
        Me.CmbLogistic.Size = New System.Drawing.Size(309, 30)
        Me.CmbLogistic.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(523, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 28)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "PO - Approval Admin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(523, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 22)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Pembayaran"
        '
        'TxtPayment
        '
        Me.TxtPayment.Enabled = False
        Me.TxtPayment.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPayment.Location = New System.Drawing.Point(637, 119)
        Me.TxtPayment.Name = "TxtPayment"
        Me.TxtPayment.Size = New System.Drawing.Size(309, 31)
        Me.TxtPayment.TabIndex = 60
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Enabled = False
        Me.TxtCustomer.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCustomer.Location = New System.Drawing.Point(637, 72)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(309, 31)
        Me.TxtCustomer.TabIndex = 61
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClear.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.BtnClear.IconColor = System.Drawing.Color.Black
        Me.BtnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnClear.IconSize = 30
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(732, 555)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 32)
        Me.BtnClear.TabIndex = 62
        Me.BtnClear.Text = "    Close"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'PurchaseOrderApprovalAdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 598)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtCustomer)
        Me.Controls.Add(Me.TxtPayment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbLogistic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Name = "PurchaseOrderApprovalAdminForm"
        Me.Text = "PO - Approval Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents BtnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbLogistic As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPayment As TextBox
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents BtnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents item_uom As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
    Friend WithEvents item_price As DataGridViewTextBoxColumn
    Friend WithEvents amount_request As DataGridViewTextBoxColumn
    Friend WithEvents price_request As DataGridViewTextBoxColumn
End Class

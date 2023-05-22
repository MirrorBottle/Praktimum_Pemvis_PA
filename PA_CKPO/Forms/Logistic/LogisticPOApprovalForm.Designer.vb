<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogisticPOApprovalForm
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
        Me.BtnClear = New FontAwesome.Sharp.IconButton()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.TxtPayment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New FontAwesome.Sharp.IconButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount_request = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price_request = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPaymentFinal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClear.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.BtnClear.IconColor = System.Drawing.Color.Black
        Me.BtnClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnClear.IconSize = 30
        Me.BtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClear.Location = New System.Drawing.Point(733, 551)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(104, 32)
        Me.BtnClear.TabIndex = 77
        Me.BtnClear.Text = "    Close"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Enabled = False
        Me.TxtCustomer.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCustomer.Location = New System.Drawing.Point(689, 68)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.Size = New System.Drawing.Size(258, 31)
        Me.TxtCustomer.TabIndex = 76
        '
        'TxtPayment
        '
        Me.TxtPayment.Enabled = False
        Me.TxtPayment.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPayment.Location = New System.Drawing.Point(177, 119)
        Me.TxtPayment.Name = "TxtPayment"
        Me.TxtPayment.Size = New System.Drawing.Size(258, 31)
        Me.TxtPayment.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 22)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Est. Pembayaran"
        '
        'TxtCode
        '
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCode.Location = New System.Drawing.Point(177, 68)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(258, 31)
        Me.TxtCode.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 22)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 22)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Catatan"
        '
        'TxtNote
        '
        Me.TxtNote.Enabled = False
        Me.TxtNote.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNote.Location = New System.Drawing.Point(92, 424)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(343, 105)
        Me.TxtNote.TabIndex = 70
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
        Me.BtnSubmit.Location = New System.Drawing.Point(843, 551)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(104, 32)
        Me.BtnSubmit.TabIndex = 69
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(14, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 22)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Daftar Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.check, Me.item_code, Me.item_name, Me.item_uom, Me.supplier_name, Me.item_price, Me.amount_request, Me.price_request})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(933, 180)
        Me.DataGridView1.TabIndex = 67
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Visible = False
        Me.id.Width = 50
        '
        'check
        '
        Me.check.HeaderText = "Terpenuhi"
        Me.check.Name = "check"
        Me.check.Width = 70
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(524, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 28)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "PO - Approval Logistik"
        '
        'TxtPaymentFinal
        '
        Me.TxtPaymentFinal.Enabled = False
        Me.TxtPaymentFinal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPaymentFinal.Location = New System.Drawing.Point(689, 124)
        Me.TxtPaymentFinal.Name = "TxtPaymentFinal"
        Me.TxtPaymentFinal.Size = New System.Drawing.Size(258, 31)
        Me.TxtPaymentFinal.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(524, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 22)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Pembayaran Final"
        '
        'LogisticPOApprovalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 598)
        Me.Controls.Add(Me.TxtPaymentFinal)
        Me.Controls.Add(Me.Label3)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "LogisticPOApprovalForm"
        Me.Text = "PO - Approval Logistik"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClear As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents TxtPayment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents BtnSubmit As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPaymentFinal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents check As DataGridViewCheckBoxColumn
    Friend WithEvents item_code As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents item_uom As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
    Friend WithEvents item_price As DataGridViewTextBoxColumn
    Friend WithEvents amount_request As DataGridViewTextBoxColumn
    Friend WithEvents price_request As DataGridViewTextBoxColumn
End Class

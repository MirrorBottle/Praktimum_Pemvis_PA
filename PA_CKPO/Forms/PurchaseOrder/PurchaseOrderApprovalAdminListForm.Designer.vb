<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderApprovalAdminListForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.items_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnApprove = New FontAwesome.Sharp.IconButton()
        Me.txtCari = New System.Windows.Forms.TextBox()
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
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 28)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "PO - Approval Admin"
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
        Me.btnRefresh.Location = New System.Drawing.Point(774, 60)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(78, 30)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.code, Me.customer_name, Me.items_total, Me.total_amount})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(937, 359)
        Me.DataGridView1.TabIndex = 16
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
        Me.code.Width = 250
        '
        'customer_name
        '
        Me.customer_name.DataPropertyName = "customer_name"
        Me.customer_name.HeaderText = "Kustomer"
        Me.customer_name.MinimumWidth = 6
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.Width = 300
        '
        'items_total
        '
        Me.items_total.DataPropertyName = "items_total"
        Me.items_total.HeaderText = "Jumlah Barang"
        Me.items_total.MinimumWidth = 6
        Me.items_total.Name = "items_total"
        Me.items_total.ReadOnly = True
        Me.items_total.Width = 200
        '
        'total_amount
        '
        Me.total_amount.DataPropertyName = "total_amount"
        Me.total_amount.HeaderText = "Total"
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Cari :"
        '
        'BtnApprove
        '
        Me.BtnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnApprove.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnApprove.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.BtnApprove.IconColor = System.Drawing.Color.Black
        Me.BtnApprove.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnApprove.IconSize = 25
        Me.BtnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnApprove.Location = New System.Drawing.Point(858, 60)
        Me.BtnApprove.Name = "BtnApprove"
        Me.BtnApprove.Size = New System.Drawing.Size(89, 30)
        Me.BtnApprove.TabIndex = 12
        Me.BtnApprove.Text = "Approval"
        Me.BtnApprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnApprove.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Roboto", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCari.Location = New System.Drawing.Point(67, 62)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(678, 28)
        Me.txtCari.TabIndex = 11
        '
        'PurchaseOrderApprovalAdminListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 482)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnApprove)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.NavbarControl1)
        Me.Name = "PurchaseOrderApprovalAdminListForm"
        Me.Text = "PO - Approval Admin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnApprove As FontAwesome.Sharp.IconButton
    Friend WithEvents txtCari As TextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents customer_name As DataGridViewTextBoxColumn
    Friend WithEvents items_total As DataGridViewTextBoxColumn
    Friend WithEvents total_amount As DataGridViewTextBoxColumn
End Class

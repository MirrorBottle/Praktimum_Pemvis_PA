<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboardForm
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
        btnRefresh = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        code = New DataGridViewTextBoxColumn()
        customer_name = New DataGridViewTextBoxColumn()
        logistic_name = New DataGridViewTextBoxColumn()
        items_total = New DataGridViewTextBoxColumn()
        total_amount = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' NavbarControl1
        ' 
        NavbarControl1.Location = New Point(0, 0)
        NavbarControl1.Name = "NavbarControl1"
        NavbarControl1.Size = New Size(1375, 51)
        NavbarControl1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 17.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(11, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(248, 35)
        Label2.TabIndex = 11
        Label2.Text = "Dashboard Admin"' 
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
        btnRefresh.Location = New Point(994, 104)
        btnRefresh.Margin = New Padding(3, 4, 3, 4)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(89, 40)
        btnRefresh.TabIndex = 21
        btnRefresh.Text = "Refresh"
        btnRefresh.TextAlign = ContentAlignment.MiddleRight
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 30)
        Label1.TabIndex = 19
        Label1.Text = "PO Status Logistik"' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, code, customer_name, logistic_name, items_total, total_amount})
        DataGridView1.Location = New Point(12, 152)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(1071, 479)
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
        code.Width = 250
        ' 
        ' customer_name
        ' 
        customer_name.DataPropertyName = "customer_name"
        customer_name.HeaderText = "Kustomer"
        customer_name.MinimumWidth = 6
        customer_name.Name = "customer_name"
        customer_name.ReadOnly = True
        customer_name.Width = 300
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
        items_total.HeaderText = "Jumlah Barang"
        items_total.MinimumWidth = 6
        items_total.Name = "items_total"
        items_total.ReadOnly = True
        items_total.Width = 120
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
        ' AdminDashboardForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 643)
        Controls.Add(DataGridView1)
        Controls.Add(btnRefresh)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(NavbarControl1)
        Name = "AdminDashboardForm"
        Text = "Dashboard Admin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents NavbarControl1 As NavbarControl
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRefresh As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents code As DataGridViewTextBoxColumn
    Friend WithEvents customer_name As DataGridViewTextBoxColumn
    Friend WithEvents logistic_name As DataGridViewTextBoxColumn
    Friend WithEvents items_total As DataGridViewTextBoxColumn
    Friend WithEvents total_amount As DataGridViewTextBoxColumn
End Class

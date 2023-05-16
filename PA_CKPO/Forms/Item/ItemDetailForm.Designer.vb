<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabelWarna
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
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Btn_Back = New FontAwesome.Sharp.IconButton()
        LabelColor = New Label()
        LabelCategory = New Label()
        LabelPrice = New Label()
        LabelName = New Label()
        Labelcode = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        LabelBrand = New Label()
        LabelUom = New Label()
        LabelSupplier = New Label()
        Label10 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(24, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(30, 158)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(198, 312)
        Panel1.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(21, 117)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 27)
        Label6.TabIndex = 4
        Label6.Text = "KATEGORI"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(21, 80)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(87, 27)
        Label7.TabIndex = 3
        Label7.Text = "HARGA"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(21, 44)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 27)
        Label4.TabIndex = 2
        Label4.Text = "NAMA"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(21, 8)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 27)
        Label3.TabIndex = 1
        Label3.Text = "KODE"' 
        ' Btn_Back
        ' 
        Btn_Back.IconChar = FontAwesome.Sharp.IconChar.LeftLong
        Btn_Back.IconColor = Color.Black
        Btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btn_Back.IconSize = 40
        Btn_Back.Location = New Point(601, 87)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(119, 42)
        Btn_Back.TabIndex = 21
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' LabelColor
        ' 
        LabelColor.AutoSize = True
        LabelColor.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelColor.Location = New Point(287, 314)
        LabelColor.Margin = New Padding(2, 0, 2, 0)
        LabelColor.Name = "LabelColor"
        LabelColor.Size = New Size(45, 27)
        LabelColor.TabIndex = 20
        LabelColor.Text = "xxx"' 
        ' LabelCategory
        ' 
        LabelCategory.AutoSize = True
        LabelCategory.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelCategory.Location = New Point(287, 275)
        LabelCategory.Margin = New Padding(2, 0, 2, 0)
        LabelCategory.Name = "LabelCategory"
        LabelCategory.Size = New Size(45, 27)
        LabelCategory.TabIndex = 19
        LabelCategory.Text = "xxx"' 
        ' LabelPrice
        ' 
        LabelPrice.AutoSize = True
        LabelPrice.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelPrice.Location = New Point(287, 238)
        LabelPrice.Margin = New Padding(2, 0, 2, 0)
        LabelPrice.Name = "LabelPrice"
        LabelPrice.Size = New Size(82, 27)
        LabelPrice.TabIndex = 18
        LabelPrice.Text = "Rp. xxx"' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelName.Location = New Point(287, 202)
        LabelName.Margin = New Padding(2, 0, 2, 0)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(94, 27)
        LabelName.TabIndex = 17
        LabelName.Text = "Item xxx"' 
        ' Labelcode
        ' 
        Labelcode.AutoSize = True
        Labelcode.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Labelcode.Location = New Point(287, 166)
        Labelcode.Margin = New Padding(2, 0, 2, 0)
        Labelcode.Name = "Labelcode"
        Labelcode.Size = New Size(80, 27)
        Labelcode.TabIndex = 16
        Labelcode.Text = "ITM-02"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 17F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(24, 109)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 35)
        Label1.TabIndex = 15
        Label1.Text = "Detail Pengguna"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(21, 265)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 27)
        Label2.TabIndex = 8
        Label2.Text = "SUPPLIER"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(21, 228)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(99, 27)
        Label5.TabIndex = 7
        Label5.Text = "SATUAN"' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(21, 192)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 27)
        Label8.TabIndex = 6
        Label8.Text = "MERK"' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(21, 156)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(91, 27)
        Label9.TabIndex = 5
        Label9.Text = "WARNA"' 
        ' LabelBrand
        ' 
        LabelBrand.AutoSize = True
        LabelBrand.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelBrand.Location = New Point(287, 350)
        LabelBrand.Margin = New Padding(2, 0, 2, 0)
        LabelBrand.Name = "LabelBrand"
        LabelBrand.Size = New Size(45, 27)
        LabelBrand.TabIndex = 24
        LabelBrand.Text = "xxx"' 
        ' LabelUom
        ' 
        LabelUom.AutoSize = True
        LabelUom.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelUom.Location = New Point(287, 386)
        LabelUom.Margin = New Padding(2, 0, 2, 0)
        LabelUom.Name = "LabelUom"
        LabelUom.Size = New Size(50, 27)
        LabelUom.TabIndex = 25
        LabelUom.Text = "Box"' 
        ' LabelSupplier
        ' 
        LabelSupplier.AutoSize = True
        LabelSupplier.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelSupplier.Location = New Point(287, 423)
        LabelSupplier.Margin = New Padding(2, 0, 2, 0)
        LabelSupplier.Name = "LabelSupplier"
        LabelSupplier.Size = New Size(79, 27)
        LabelSupplier.TabIndex = 26
        LabelSupplier.Text = "Toyota"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(287, 462)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 27)
        Label10.TabIndex = 27
        ' 
        ' LabelWarna
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 493)
        Controls.Add(Label10)
        Controls.Add(LabelSupplier)
        Controls.Add(LabelUom)
        Controls.Add(LabelBrand)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Btn_Back)
        Controls.Add(LabelColor)
        Controls.Add(LabelCategory)
        Controls.Add(LabelPrice)
        Controls.Add(LabelName)
        Controls.Add(Labelcode)
        Controls.Add(Label1)
        Name = "LabelWarna"
        Text = "ItemDetailForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelColor As Label
    Friend WithEvents LabelCategory As Label
    Friend WithEvents LabelPrice As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents Labelcode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelBrand As Label
    Friend WithEvents LabelUom As Label
    Friend WithEvents LabelSupplier As Label
    Friend WithEvents Label10 As Label
End Class

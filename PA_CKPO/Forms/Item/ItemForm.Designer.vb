<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemForm
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Btn_Back = New FontAwesome.Sharp.IconButton()
        CmbSupplier = New ComboBox()
        CmbCategory = New ComboBox()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TxtPrice = New TextBox()
        TxtName = New TextBox()
        TxtCode = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        TxtColor = New TextBox()
        TxtUom = New TextBox()
        TxtBrand = New TextBox()
        Label8 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label7 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 35)
        Label1.TabIndex = 0
        Label1.Text = "ItemForm"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Btn_Back
        ' 
        Btn_Back.IconChar = FontAwesome.Sharp.IconChar.LeftLong
        Btn_Back.IconColor = Color.Black
        Btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btn_Back.IconSize = 40
        Btn_Back.Location = New Point(780, 87)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(119, 42)
        Btn_Back.TabIndex = 19
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' CmbSupplier
        ' 
        CmbSupplier.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        CmbSupplier.FormattingEnabled = True
        CmbSupplier.Location = New Point(616, 313)
        CmbSupplier.Name = "CmbSupplier"
        CmbSupplier.Size = New Size(283, 35)
        CmbSupplier.TabIndex = 31
        ' 
        ' CmbCategory
        ' 
        CmbCategory.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        CmbCategory.FormattingEnabled = True
        CmbCategory.Items.AddRange(New Object() {"1. Admin", "2. logistics", "3. Customer"})
        CmbCategory.Location = New Point(151, 313)
        CmbCategory.Name = "CmbCategory"
        CmbCategory.Size = New Size(283, 35)
        CmbCategory.TabIndex = 30
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.LightGreen
        IconButton2.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(780, 428)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(119, 42)
        IconButton2.TabIndex = 29
        IconButton2.Text = "Submit"
        IconButton2.TextAlign = ContentAlignment.MiddleRight
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(640, 428)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 42)
        IconButton1.TabIndex = 28
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TxtPrice
        ' 
        TxtPrice.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPrice.Location = New Point(206, 262)
        TxtPrice.Name = "TxtPrice"
        TxtPrice.Size = New Size(228, 34)
        TxtPrice.TabIndex = 27
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(151, 209)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(283, 34)
        TxtName.TabIndex = 26
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(151, 156)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(283, 34)
        TxtCode.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(480, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 28)
        Label5.TabIndex = 24
        Label5.Text = "Warna"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 20
        Label2.Text = "Kode"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 28)
        Label4.TabIndex = 23
        Label4.Text = "Kategori"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 28)
        Label3.TabIndex = 22
        Label3.Text = "Harga"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 209)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 28)
        Label6.TabIndex = 21
        Label6.Text = "Nama"' 
        ' TxtColor
        ' 
        TxtColor.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtColor.Location = New Point(616, 150)
        TxtColor.Name = "TxtColor"
        TxtColor.PasswordChar = "*"c
        TxtColor.Size = New Size(283, 34)
        TxtColor.TabIndex = 39
        ' 
        ' TxtUom
        ' 
        TxtUom.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUom.Location = New Point(616, 261)
        TxtUom.Name = "TxtUom"
        TxtUom.Size = New Size(283, 34)
        TxtUom.TabIndex = 38
        ' 
        ' TxtBrand
        ' 
        TxtBrand.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtBrand.Location = New Point(616, 208)
        TxtBrand.Name = "TxtBrand"
        TxtBrand.Size = New Size(283, 34)
        TxtBrand.TabIndex = 37
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(480, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 28)
        Label8.TabIndex = 32
        Label8.Text = "Merk"' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(480, 314)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 28)
        Label10.TabIndex = 34
        Label10.Text = "Supplier"' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(480, 261)
        Label11.Name = "Label11"
        Label11.Size = New Size(86, 28)
        Label11.TabIndex = 33
        Label11.Text = "Satuan"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Roboto", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(151, 265)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 30)
        Label7.TabIndex = 40
        Label7.Text = "Rp."' 
        ' ItemForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(922, 493)
        Controls.Add(Label7)
        Controls.Add(TxtColor)
        Controls.Add(TxtUom)
        Controls.Add(TxtBrand)
        Controls.Add(Label8)
        Controls.Add(Label10)
        Controls.Add(Label11)
        Controls.Add(CmbSupplier)
        Controls.Add(CmbCategory)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(TxtPrice)
        Controls.Add(TxtName)
        Controls.Add(TxtCode)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Btn_Back)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "ItemForm"
        Text = "ItemForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents CmbSupplier As ComboBox
    Friend WithEvents CmbCategory As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtColor As TextBox
    Friend WithEvents TxtUom As TextBox
    Friend WithEvents TxtBrand As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
End Class

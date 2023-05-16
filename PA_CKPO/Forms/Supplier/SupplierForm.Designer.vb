<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierForm
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
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Btn_Back = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TxtContact = New TextBox()
        TxtName = New TextBox()
        TxtCode = New TextBox()
        Label5 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        TxtAddress = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(15, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(192, 35)
        Label2.TabIndex = 2
        Label2.Text = "SupplierForm"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Btn_Back
        ' 
        Btn_Back.IconChar = FontAwesome.Sharp.IconChar.LeftLong
        Btn_Back.IconColor = Color.Black
        Btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btn_Back.IconSize = 40
        Btn_Back.Location = New Point(601, 87)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(119, 42)
        Btn_Back.TabIndex = 19
        Btn_Back.UseVisualStyleBackColor = True
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
        IconButton2.Location = New Point(601, 424)
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
        IconButton1.Location = New Point(461, 424)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 42)
        IconButton1.TabIndex = 28
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TxtContact
        ' 
        TxtContact.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContact.Location = New Point(151, 265)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(569, 34)
        TxtContact.TabIndex = 27
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(151, 212)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(569, 34)
        TxtName.TabIndex = 26
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(151, 159)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(569, 34)
        TxtCode.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(20, 366)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 28)
        Label5.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 28)
        Label1.TabIndex = 20
        Label1.Text = "Kode"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 28)
        Label4.TabIndex = 23
        Label4.Text = "Alamat"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 28)
        Label3.TabIndex = 22
        Label3.Text = "Kontak"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 28)
        Label6.TabIndex = 21
        Label6.Text = "Name"' 
        ' TxtAddress
        ' 
        TxtAddress.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(151, 316)
        TxtAddress.Multiline = True
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(569, 91)
        TxtAddress.TabIndex = 30
        ' 
        ' SupplierForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 493)
        Controls.Add(TxtAddress)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(TxtContact)
        Controls.Add(TxtName)
        Controls.Add(TxtCode)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Btn_Back)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Name = "SupplierForm"
        Text = "SupplierForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAddress As TextBox
End Class

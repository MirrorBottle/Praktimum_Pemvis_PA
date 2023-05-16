<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TxtAddress = New TextBox()
        TxtContact = New TextBox()
        TxtName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 35)
        Label1.TabIndex = 0
        Label1.Text = "CustomerForm"' 
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
        Btn_Back.Location = New Point(601, 87)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(119, 42)
        Btn_Back.TabIndex = 18
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
        IconButton2.TabIndex = 28
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
        IconButton1.TabIndex = 27
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TxtAddress
        ' 
        TxtAddress.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(151, 265)
        TxtAddress.Multiline = True
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(569, 136)
        TxtAddress.TabIndex = 26
        ' 
        ' TxtContact
        ' 
        TxtContact.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtContact.Location = New Point(151, 212)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(569, 34)
        TxtContact.TabIndex = 25
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(151, 159)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(569, 34)
        TxtName.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 28)
        Label2.TabIndex = 19
        Label2.Text = "Nama"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 28)
        Label3.TabIndex = 21
        Label3.Text = "Alamat"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(15, 212)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 28)
        Label6.TabIndex = 20
        Label6.Text = "Kontak"' 
        ' CustomerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 493)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(TxtAddress)
        Controls.Add(TxtContact)
        Controls.Add(TxtName)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label6)
        Controls.Add(Btn_Back)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "CustomerForm"
        Text = "CustomerForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class

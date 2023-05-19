<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Btn_Back = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtUsername = New TextBox()
        TxtName = New TextBox()
        TxtPassword = New TextBox()
        Label6 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        CmbHakAkses = New ComboBox()
        Cmb_Cutomer = New ComboBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Btn_Back.TabIndex = 0
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(15, 159)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 2
        Label2.Text = "Name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 28)
        Label3.TabIndex = 3
        Label3.Text = "Password"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 28)
        Label4.TabIndex = 4
        Label4.Text = "Hak Akses"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(15, 371)
        Label5.Name = "Label5"
        Label5.Size = New Size(113, 28)
        Label5.TabIndex = 5
        Label5.Text = "Customer"' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(151, 159)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(569, 34)
        TxtUsername.TabIndex = 6
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(151, 212)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(569, 34)
        TxtName.TabIndex = 7
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(151, 265)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(569, 34)
        TxtPassword.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(15, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 35)
        Label6.TabIndex = 11
        Label6.Text = "User Form"' 
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
        IconButton1.TabIndex = 12
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
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
        IconButton2.TabIndex = 13
        IconButton2.Text = "Submit"
        IconButton2.TextAlign = ContentAlignment.MiddleRight
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' CmbHakAkses
        ' 
        CmbHakAkses.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        CmbHakAkses.FormattingEnabled = True
        CmbHakAkses.Items.AddRange(New Object() {"1. Admin", "2. logistics", "3. Customer"})
        CmbHakAkses.Location = New Point(151, 316)
        CmbHakAkses.Name = "CmbHakAkses"
        CmbHakAkses.Size = New Size(569, 35)
        CmbHakAkses.TabIndex = 14
        ' 
        ' Cmb_Cutomer
        ' 
        Cmb_Cutomer.Font = New Font("Roboto", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point)
        Cmb_Cutomer.FormattingEnabled = True
        Cmb_Cutomer.Location = New Point(151, 373)
        Cmb_Cutomer.Name = "Cmb_Cutomer"
        Cmb_Cutomer.Size = New Size(569, 35)
        Cmb_Cutomer.TabIndex = 15
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(12, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 493)
        Controls.Add(PictureBox1)
        Controls.Add(Cmb_Cutomer)
        Controls.Add(CmbHakAkses)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(Label6)
        Controls.Add(TxtPassword)
        Controls.Add(TxtName)
        Controls.Add(TxtUsername)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Btn_Back)
        Name = "UserForm"
        Text = "UserForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents CmbHakAkses As ComboBox
    Friend WithEvents Cmb_Cutomer As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtUsername = New TextBox()
        TxtName = New TextBox()
        TxtPassword = New TextBox()
        LabelHeader = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        CmbHakAkses = New ComboBox()
        CmbCustomer = New ComboBox()
        LabelPassword = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(14, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 27)
        Label1.TabIndex = 1
        Label1.Text = "Username"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(14, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 27)
        Label2.TabIndex = 2
        Label2.Text = "Name"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(14, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 27)
        Label3.TabIndex = 3
        Label3.Text = "Password"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 275)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 27)
        Label4.TabIndex = 4
        Label4.Text = "Hak Akses"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(14, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 27)
        Label5.TabIndex = 5
        Label5.Text = "Customer"' 
        ' TxtUsername
        ' 
        TxtUsername.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(150, 97)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(569, 34)
        TxtUsername.TabIndex = 6
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(150, 151)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(569, 34)
        TxtName.TabIndex = 7
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(150, 204)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(569, 34)
        TxtPassword.TabIndex = 8
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Roboto", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        LabelHeader.Location = New Point(14, 32)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(251, 34)
        LabelHeader.TabIndex = 11
        LabelHeader.Text = "Tambah Pengguna"' 
        ' IconButton1
        ' 
        IconButton1.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(459, 384)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 43)
        IconButton1.TabIndex = 12
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.LightGreen
        IconButton2.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(600, 384)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(119, 43)
        IconButton2.TabIndex = 13
        IconButton2.Text = "Submit"
        IconButton2.TextAlign = ContentAlignment.MiddleRight
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' CmbHakAkses
        ' 
        CmbHakAkses.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        CmbHakAkses.FormattingEnabled = True
        CmbHakAkses.Items.AddRange(New Object() {"Admin", "Logistik", "Customer"})
        CmbHakAkses.Location = New Point(150, 275)
        CmbHakAkses.Name = "CmbHakAkses"
        CmbHakAkses.Size = New Size(569, 35)
        CmbHakAkses.TabIndex = 14
        ' 
        ' CmbCustomer
        ' 
        CmbCustomer.Enabled = False
        CmbCustomer.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        CmbCustomer.FormattingEnabled = True
        CmbCustomer.Location = New Point(150, 332)
        CmbCustomer.Name = "CmbCustomer"
        CmbCustomer.Size = New Size(569, 35)
        CmbCustomer.TabIndex = 15
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Roboto", 9F, FontStyle.Italic, GraphicsUnit.Point)
        LabelPassword.ForeColor = Color.IndianRed
        LabelPassword.Location = New Point(431, 245)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(315, 18)
        LabelPassword.TabIndex = 16
        LabelPassword.Text = "*Kosongkan password apabila tidak mengubah"
        LabelPassword.Visible = False
        ' 
        ' UserForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(725, 437)
        Controls.Add(LabelPassword)
        Controls.Add(CmbCustomer)
        Controls.Add(CmbHakAkses)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(LabelHeader)
        Controls.Add(TxtPassword)
        Controls.Add(TxtName)
        Controls.Add(TxtUsername)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "UserForm"
        Text = "UserForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LabelHeader As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents CmbHakAkses As ComboBox
    Friend WithEvents CmbCustomer As ComboBox
    Friend WithEvents LabelPassword As Label
End Class

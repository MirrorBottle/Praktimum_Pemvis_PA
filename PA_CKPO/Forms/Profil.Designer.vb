<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profil
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
        IconButton1 = New FontAwesome.Sharp.IconButton()
        LabelHeader = New Label()
        TxtName = New TextBox()
        TxtUsername = New TextBox()
        Label5 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        TxtCustomer = New TextBox()
        TxtHakAkses = New TextBox()
        SuspendLayout()
        ' 
        ' IconButton1
        ' 
        IconButton1.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(389, 308)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 43)
        IconButton1.TabIndex = 26
        IconButton1.Text = "    Close"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Roboto", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        LabelHeader.Location = New Point(12, 9)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(218, 34)
        LabelHeader.TabIndex = 25
        LabelHeader.Text = "Profil Pengguna"' 
        ' TxtName
        ' 
        TxtName.Enabled = False
        TxtName.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(148, 128)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(360, 34)
        TxtName.TabIndex = 23
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Enabled = False
        TxtUsername.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(148, 74)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(360, 34)
        TxtUsername.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(12, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 27)
        Label5.TabIndex = 21
        Label5.Text = "Customer"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 27)
        Label1.TabIndex = 17
        Label1.Text = "Username"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(12, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 27)
        Label4.TabIndex = 20
        Label4.Text = "Hak Akses"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 27)
        Label2.TabIndex = 18
        Label2.Text = "Name"' 
        ' TxtCustomer
        ' 
        TxtCustomer.Enabled = False
        TxtCustomer.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCustomer.Location = New Point(148, 237)
        TxtCustomer.Name = "TxtCustomer"
        TxtCustomer.Size = New Size(360, 34)
        TxtCustomer.TabIndex = 29
        ' 
        ' TxtHakAkses
        ' 
        TxtHakAkses.Enabled = False
        TxtHakAkses.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtHakAkses.Location = New Point(148, 183)
        TxtHakAkses.Name = "TxtHakAkses"
        TxtHakAkses.Size = New Size(360, 34)
        TxtHakAkses.TabIndex = 28
        ' 
        ' Profil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(529, 363)
        Controls.Add(TxtCustomer)
        Controls.Add(TxtHakAkses)
        Controls.Add(IconButton1)
        Controls.Add(LabelHeader)
        Controls.Add(TxtName)
        Controls.Add(TxtUsername)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Name = "Profil"
        Text = "Profil"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelHeader As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents TxtHakAkses As TextBox
End Class

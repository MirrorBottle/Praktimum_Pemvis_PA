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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.CmbHakAkses = New System.Windows.Forms.ComboBox()
        Me.CmbCustomer = New System.Windows.Forms.ComboBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hak Akses"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Customer"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUsername.Location = New System.Drawing.Point(131, 73)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(498, 29)
        Me.TxtUsername.TabIndex = 6
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtName.Location = New System.Drawing.Point(131, 113)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(498, 29)
        Me.TxtName.TabIndex = 7
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPassword.Location = New System.Drawing.Point(131, 153)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(498, 29)
        Me.TxtPassword.TabIndex = 8
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Roboto", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHeader.Location = New System.Drawing.Point(12, 24)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(204, 28)
        Me.LabelHeader.TabIndex = 11
        Me.LabelHeader.Text = "Tambah Pengguna"
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(402, 288)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(104, 32)
        Me.IconButton1.TabIndex = 12
        Me.IconButton1.Text = "    Clear"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.LightGreen
        Me.IconButton2.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(525, 288)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(104, 32)
        Me.IconButton2.TabIndex = 13
        Me.IconButton2.Text = "Submit"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'CmbHakAkses
        '
        Me.CmbHakAkses.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbHakAkses.FormattingEnabled = True
        Me.CmbHakAkses.Items.AddRange(New Object() {"Admin", "Logistic", "Customer"})
        Me.CmbHakAkses.Location = New System.Drawing.Point(131, 206)
        Me.CmbHakAkses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbHakAkses.Name = "CmbHakAkses"
        Me.CmbHakAkses.Size = New System.Drawing.Size(498, 30)
        Me.CmbHakAkses.TabIndex = 14
        '
        'CmbCustomer
        '
        Me.CmbCustomer.Enabled = False
        Me.CmbCustomer.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CmbCustomer.FormattingEnabled = True
        Me.CmbCustomer.Location = New System.Drawing.Point(131, 249)
        Me.CmbCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCustomer.Name = "CmbCustomer"
        Me.CmbCustomer.Size = New System.Drawing.Size(498, 30)
        Me.CmbCustomer.TabIndex = 15
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.LabelPassword.ForeColor = System.Drawing.Color.IndianRed
        Me.LabelPassword.Location = New System.Drawing.Point(377, 184)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(252, 14)
        Me.LabelPassword.TabIndex = 16
        Me.LabelPassword.Text = "*Kosongkan password apabila tidak mengubah"
        Me.LabelPassword.Visible = False
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 328)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.CmbCustomer)
        Me.Controls.Add(Me.CmbHakAkses)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserForm"
        Me.Text = "UserForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

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
        LabelHeader = New Label()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        TxtConName = New TextBox()
        TxtName = New TextBox()
        TxtCode = New TextBox()
        Label5 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label6 = New Label()
        TxtAddress = New TextBox()
        TxtConNumber = New TextBox()
        label12 = New Label()
        SuspendLayout()
        ' 
        ' LabelHeader
        ' 
        LabelHeader.AutoSize = True
        LabelHeader.Font = New Font("Roboto", 16.8F, FontStyle.Bold, GraphicsUnit.Point)
        LabelHeader.Location = New Point(6, 35)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(184, 34)
        LabelHeader.TabIndex = 2
        LabelHeader.Text = "SupplierForm"' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.LightGreen
        IconButton2.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.IconSize = 30
        IconButton2.ImageAlign = ContentAlignment.MiddleLeft
        IconButton2.Location = New Point(592, 455)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(119, 43)
        IconButton2.TabIndex = 29
        IconButton2.Text = "Submit"
        IconButton2.TextAlign = ContentAlignment.MiddleRight
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.IconSize = 30
        IconButton1.ImageAlign = ContentAlignment.MiddleLeft
        IconButton1.Location = New Point(446, 455)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(119, 43)
        IconButton1.TabIndex = 28
        IconButton1.Text = "    Clear"
        IconButton1.UseVisualStyleBackColor = True
        ' 
        ' TxtConName
        ' 
        TxtConName.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtConName.Location = New Point(142, 199)
        TxtConName.Name = "TxtConName"
        TxtConName.Size = New Size(569, 34)
        TxtConName.TabIndex = 27
        ' 
        ' TxtName
        ' 
        TxtName.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(142, 145)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(569, 34)
        TxtName.TabIndex = 26
        ' 
        ' TxtCode
        ' 
        TxtCode.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtCode.Location = New Point(142, 92)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(569, 34)
        TxtCode.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(11, 299)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 27)
        Label5.TabIndex = 24
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 24)
        Label1.TabIndex = 20
        Label1.Text = "Kode"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(14, 303)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 24)
        Label4.TabIndex = 23
        Label4.Text = "Alamat"' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        label11.Location = New Point(11, 199)
        label11.Name = "label11"
        label11.Size = New Size(132, 24)
        label11.TabIndex = 22
        label11.Text = "Nama Kontak"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(11, 145)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 24)
        Label6.TabIndex = 21
        Label6.Text = "Nama"' 
        ' TxtAddress
        ' 
        TxtAddress.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtAddress.Location = New Point(142, 303)
        TxtAddress.Multiline = True
        TxtAddress.Name = "TxtAddress"
        TxtAddress.Size = New Size(569, 145)
        TxtAddress.TabIndex = 30
        ' 
        ' TxtConNumber
        ' 
        TxtConNumber.Font = New Font("Roboto", 13.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtConNumber.Location = New Point(142, 251)
        TxtConNumber.Name = "TxtConNumber"
        TxtConNumber.Size = New Size(569, 34)
        TxtConNumber.TabIndex = 31
        ' 
        ' label12
        ' 
        label12.AutoSize = True
        label12.Font = New Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point)
        label12.Location = New Point(14, 251)
        label12.Name = "label12"
        label12.Size = New Size(103, 24)
        label12.TabIndex = 32
        label12.Text = "Nomor HP"' 
        ' SupplierForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(725, 512)
        Controls.Add(label12)
        Controls.Add(TxtConNumber)
        Controls.Add(TxtAddress)
        Controls.Add(IconButton2)
        Controls.Add(IconButton1)
        Controls.Add(TxtConName)
        Controls.Add(TxtName)
        Controls.Add(TxtCode)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(label11)
        Controls.Add(Label6)
        Controls.Add(LabelHeader)
        Name = "SupplierForm"
        Text = "SupplierForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelHeader As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TxtConName As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtConNumber As TextBox
    Friend WithEvents label12 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDetailForm
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
        LabelId = New Label()
        LabelCode = New Label()
        LabelContact = New Label()
        LabelName = New Label()
        LabelAddress = New Label()
        Btn_Back = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 17F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(34, 109)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 35)
        Label1.TabIndex = 0
        Label1.Text = "Detail Pengguna"' 
        ' LabelId
        ' 
        LabelId.AutoSize = True
        LabelId.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelId.Location = New Point(291, 166)
        LabelId.Margin = New Padding(2, 0, 2, 0)
        LabelId.Name = "LabelId"
        LabelId.Size = New Size(24, 27)
        LabelId.TabIndex = 2
        LabelId.Text = "2"' 
        ' LabelCode
        ' 
        LabelCode.AutoSize = True
        LabelCode.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelCode.Location = New Point(291, 218)
        LabelCode.Margin = New Padding(2, 0, 2, 0)
        LabelCode.Name = "LabelCode"
        LabelCode.Size = New Size(101, 27)
        LabelCode.TabIndex = 4
        LabelCode.Text = "Kode xxx"' 
        ' LabelContact
        ' 
        LabelContact.AutoSize = True
        LabelContact.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelContact.Location = New Point(291, 322)
        LabelContact.Margin = New Padding(2, 0, 2, 0)
        LabelContact.Name = "LabelContact"
        LabelContact.Size = New Size(119, 27)
        LabelContact.TabIndex = 8
        LabelContact.Text = "Kontak xxx"' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelName.Location = New Point(291, 270)
        LabelName.Margin = New Padding(2, 0, 2, 0)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(109, 27)
        LabelName.TabIndex = 6
        LabelName.Text = "Nama xxx"' 
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelAddress.Location = New Point(291, 373)
        LabelAddress.Margin = New Padding(2, 0, 2, 0)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(119, 27)
        LabelAddress.TabIndex = 10
        LabelAddress.Text = "Alamat xxx"' 
        ' Btn_Back
        ' 
        Btn_Back.IconChar = FontAwesome.Sharp.IconChar.LeftLong
        Btn_Back.IconColor = Color.Black
        Btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto
        Btn_Back.IconSize = 40
        Btn_Back.Location = New Point(601, 87)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(119, 42)
        Btn_Back.TabIndex = 11
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(40, 158)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(198, 259)
        Panel1.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(20, 215)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 27)
        Label6.TabIndex = 4
        Label6.Text = "ALAMAT"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(20, 164)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 27)
        Label7.TabIndex = 3
        Label7.Text = "KONTAK"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(20, 113)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 27)
        Label4.TabIndex = 2
        Label4.Text = "NAMA"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(20, 61)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 27)
        Label3.TabIndex = 1
        Label3.Text = "KODE"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(20, 9)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 27)
        Label2.TabIndex = 0
        Label2.Text = "ID"' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(34, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' UserDetailForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(732, 493)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Btn_Back)
        Controls.Add(LabelAddress)
        Controls.Add(LabelContact)
        Controls.Add(LabelName)
        Controls.Add(LabelCode)
        Controls.Add(LabelId)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "UserDetailForm"
        Text = "UserDetailForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelCode As Label
    Friend WithEvents LabelContact As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelAddress As Label
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

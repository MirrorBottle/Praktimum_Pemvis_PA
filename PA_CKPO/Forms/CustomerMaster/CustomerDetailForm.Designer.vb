<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDetailForm
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
        Label2 = New Label()
        Btn_Back = New FontAwesome.Sharp.IconButton()
        LabelAddress = New Label()
        LabelContact = New Label()
        LabelName = New Label()
        LabelId = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Resources.Resources.logo
        PictureBox1.Location = New Point(26, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(154, 74)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(32, 156)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(198, 213)
        Panel1.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(20, 168)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 27)
        Label6.TabIndex = 4
        Label6.Text = "ALAMAT"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(20, 117)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 27)
        Label7.TabIndex = 3
        Label7.Text = "KONTAK"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto", 13F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(20, 66)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 27)
        Label4.TabIndex = 2
        Label4.Text = "NAMA"' 
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
        ' LabelAddress
        ' 
        LabelAddress.AutoSize = True
        LabelAddress.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelAddress.Location = New Point(283, 324)
        LabelAddress.Margin = New Padding(2, 0, 2, 0)
        LabelAddress.Name = "LabelAddress"
        LabelAddress.Size = New Size(119, 27)
        LabelAddress.TabIndex = 20
        LabelAddress.Text = "Alamat xxx"' 
        ' LabelContact
        ' 
        LabelContact.AutoSize = True
        LabelContact.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelContact.Location = New Point(283, 273)
        LabelContact.Margin = New Padding(2, 0, 2, 0)
        LabelContact.Name = "LabelContact"
        LabelContact.Size = New Size(119, 27)
        LabelContact.TabIndex = 19
        LabelContact.Text = "Kontak xxx"' 
        ' LabelName
        ' 
        LabelName.AutoSize = True
        LabelName.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelName.Location = New Point(283, 222)
        LabelName.Margin = New Padding(2, 0, 2, 0)
        LabelName.Name = "LabelName"
        LabelName.Size = New Size(109, 27)
        LabelName.TabIndex = 18
        LabelName.Text = "Nama xxx"' 
        ' LabelId
        ' 
        LabelId.AutoSize = True
        LabelId.Font = New Font("Roboto", 13F, FontStyle.Regular, GraphicsUnit.Point)
        LabelId.Location = New Point(283, 165)
        LabelId.Margin = New Padding(2, 0, 2, 0)
        LabelId.Name = "LabelId"
        LabelId.Size = New Size(24, 27)
        LabelId.TabIndex = 16
        LabelId.Text = "2"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto", 17F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(26, 107)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 35)
        Label1.TabIndex = 15
        Label1.Text = "Detail Customer"' 
        ' CustomerDetailForm
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
        Controls.Add(LabelId)
        Controls.Add(Label1)
        Name = "CustomerDetailForm"
        Text = "CustomerDetailForm"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Back As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelAddress As Label
    Friend WithEvents LabelContact As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelId As Label
    Friend WithEvents Label1 As Label
End Class

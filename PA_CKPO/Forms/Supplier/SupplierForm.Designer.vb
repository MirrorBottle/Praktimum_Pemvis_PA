﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.TxtConName = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtConNumber = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("Roboto", 16.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHeader.Location = New System.Drawing.Point(6, 35)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(184, 34)
        Me.LabelHeader.TabIndex = 2
        Me.LabelHeader.Text = "SupplierForm"
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
        Me.IconButton2.Location = New System.Drawing.Point(592, 455)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(119, 43)
        Me.IconButton2.TabIndex = 29
        Me.IconButton2.Text = "Submit"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 30
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(446, 455)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(119, 43)
        Me.IconButton1.TabIndex = 28
        Me.IconButton1.Text = "    Clear"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'TxtConName
        '
        Me.TxtConName.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtConName.Location = New System.Drawing.Point(142, 199)
        Me.TxtConName.Name = "TxtConName"
        Me.TxtConName.Size = New System.Drawing.Size(569, 34)
        Me.TxtConName.TabIndex = 27
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtName.Location = New System.Drawing.Point(142, 145)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(569, 34)
        Me.TxtName.TabIndex = 26
        '
        'TxtCode
        '
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCode.Location = New System.Drawing.Point(142, 92)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(569, 34)
        Me.TxtCode.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(11, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 27)
        Me.Label5.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(11, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Kode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(14, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 24)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Alamat"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label11.Location = New System.Drawing.Point(11, 199)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(132, 24)
        Me.label11.TabIndex = 22
        Me.label11.Text = "Nama Kontak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(11, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 24)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nama"
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAddress.Location = New System.Drawing.Point(142, 303)
        Me.TxtAddress.Multiline = True
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(569, 145)
        Me.TxtAddress.TabIndex = 30
        '
        'TxtConNumber
        '
        Me.TxtConNumber.Font = New System.Drawing.Font("Roboto", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtConNumber.Location = New System.Drawing.Point(142, 251)
        Me.TxtConNumber.Name = "TxtConNumber"
        Me.TxtConNumber.Size = New System.Drawing.Size(569, 34)
        Me.TxtConNumber.TabIndex = 31
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.label12.Location = New System.Drawing.Point(14, 251)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(103, 24)
        Me.label12.TabIndex = 32
        Me.label12.Text = "Nomor HP"
        '
        'SupplierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 512)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.TxtConNumber)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.TxtConName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelHeader)
        Me.Name = "SupplierForm"
        Me.Text = "Form Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

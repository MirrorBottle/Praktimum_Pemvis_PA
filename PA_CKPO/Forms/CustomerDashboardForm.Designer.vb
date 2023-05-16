<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDashboardForm
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
        Me.LayoutControl1 = New PA_CKPO.LayoutControl()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Location = New System.Drawing.Point(1, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Size = New System.Drawing.Size(960, 540)
        Me.LayoutControl1.TabIndex = 1
        '
        'CustomerDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 541)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CustomerDashboardForm"
        Me.Text = "CustomerDashboardForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As LayoutControl
End Class

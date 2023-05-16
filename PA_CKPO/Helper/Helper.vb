Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module Helper
    Public Function HashPassword(password As String) As String
        Dim sha256 As SHA256 = SHA256.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Return Convert.ToBase64String(hash)
    End Function

    Public Sub ShowMessage(ByVal message As String, Optional ByVal type As String = "")
        Dim icon As MessageBoxIcon
        Dim button As MessageBoxButtons

        'Set the icon and button based on the type parameter
        Select Case type
            Case "Success"
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
            Case "Error"
                icon = MessageBoxIcon.Error
                button = MessageBoxButtons.OK
            Case "Info"
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
            Case Else
                'Default to showing an information dialog box
                icon = MessageBoxIcon.Information
                button = MessageBoxButtons.OK
        End Select

        'Display the dialog box with the specified message, icon, and button
        MessageBox.Show(message, My.Application.Info.Title, button, icon)
    End Sub
End Module

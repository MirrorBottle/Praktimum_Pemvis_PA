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
End Module

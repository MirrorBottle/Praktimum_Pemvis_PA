Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module UserHelper

    Dim filePath As String = Path.Combine(Application.StartupPath, "user_credentials.txt")

    Public Function Login(username As String, password As String) As Boolean
        Dim passwordHash As String = Helper.HashPassword(password)
        Dim userId As Integer = 0
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)


        Using connection As New MySqlConnection(SqlHelper.connectionString)
            connection.Open()
            Dim query As String = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'"
            Using command As New MySqlCommand(query, connection)

                Using reader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        userId = reader.GetInt32(0)

                        Using writer As StreamWriter = New StreamWriter(filePath, False)
                            writer.WriteLine(userId)
                            writer.WriteLine(username)
                        End Using
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Function GetCredentials() As Tuple(Of Integer, String, String)
        Dim userId As Integer = 0
        Dim username As String = ""
        Dim passwordHash As String = ""
        If File.Exists(filePath) Then
            Using reader As StreamReader = New StreamReader(filePath)
                userId = Integer.Parse(reader.ReadLine())
                username = reader.ReadLine()
                passwordHash = Helper.HashPassword(reader.ReadLine())
            End Using
        End If

        Return New Tuple(Of Integer, String, String)(userId, username, passwordHash)
    End Function

    Public Function GetUsername() As String
        Dim username As String = ""

        If File.Exists(filePath) Then
            Using reader As StreamReader = New StreamReader(filePath)
                reader.ReadLine() ' Skip user ID
                username = reader.ReadLine()
            End Using
        End If

        Return username
    End Function

    Public Sub Logout()
        If File.Exists(filePath) Then
            File.Delete(filePath)
        End If
    End Sub
End Module

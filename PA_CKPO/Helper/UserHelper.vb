Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module UserHelper
    Public Function Login(username As String, password As String) As Boolean
        Dim passwordHash As String = Helper.HashPassword(password)
        Dim userId As Integer = 0
        Using connection As New MySqlConnection(SqlHelper.connectionString)
            connection.Open()
            Dim query As String = "SELECT * FROM users WHERE username=@username AND password_hash=@password_hash"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password_hash", passwordHash)
                Using reader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' Authentication successful, write the username to a file
                        Using writer As StreamWriter = New StreamWriter("user_credentials.txt", False)
                            writer.WriteLine(userId)
                            writer.WriteLine(username)
                        End Using
                        Return True
                    Else
                        ' Authentication failed
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

        If File.Exists("user_credentials.txt") Then
            Using reader As StreamReader = New StreamReader("user_credentials.txt")
                userId = Integer.Parse(reader.ReadLine())
                username = reader.ReadLine()
                passwordHash = Helper.HashPassword(reader.ReadLine())
            End Using
        End If

        Return New Tuple(Of Integer, String, String)(userId, username, passwordHash)
    End Function

    Public Function GetUsername() As String
        Dim username As String = ""

        If File.Exists("user_credentials.txt") Then
            Using reader As StreamReader = New StreamReader("user_credentials.txt")
                reader.ReadLine() ' Skip user ID
                username = reader.ReadLine()
            End Using
        End If

        Return username
    End Function

    Public Sub Logout()
        If File.Exists("user_credentials.txt") Then
            File.Delete("user_credentials.txt")
        End If
    End Sub
End Module

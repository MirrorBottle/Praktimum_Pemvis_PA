Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Module UserHelper

    Dim filePath As String = Path.Combine(Application.StartupPath, "user_credentials.txt")

    Public Function Login(username As String, password As String) As Boolean
        Dim userId As Integer = 0
        Dim name As String = ""
        Dim userRole As Integer = 0
        Dim userCustomerId As Integer = 0
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)


        Using connection As New MySqlConnection(SqlHelper.connectionString)
            connection.Open()
            Dim query As String = $"SELECT * FROM users WHERE username='{username}' AND password='{password}'"
            Using command As New MySqlCommand(query, connection)

                Using reader = command.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read()
                        userId = reader.GetInt32(0)
                        name = reader.GetString(3)
                        userRole = reader.GetInt32(4)
                        userCustomerId = If(IsDBNull(reader.Item(5)), 0, reader.GetInt32(5))

                        Using writer As StreamWriter = New StreamWriter(filePath, False)
                            writer.WriteLine(userId)
                            writer.WriteLine(username)
                            writer.WriteLine(name)
                            writer.WriteLine(userRole)
                            writer.WriteLine(userCustomerId)
                        End Using
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        End Using
    End Function

    Public Function GetCredentials() As (userId As Integer, username As String, name As String, userRole As Integer, userCustomerId As Integer)
        Dim userId As Integer = 0
        Dim username As String = ""
        Dim name As String = ""
        Dim userRole As Integer = 0
        Dim userCustomerId As Integer = 0
        If File.Exists(filePath) Then
            Using reader As StreamReader = New StreamReader(filePath)
                userId = Integer.Parse(reader.ReadLine())
                username = reader.ReadLine()
                name = reader.ReadLine()
                userRole = Integer.Parse(reader.ReadLine())
                userCustomerId = Integer.Parse(reader.ReadLine())
            End Using
        End If

        Return (userId, username, name, userRole, userCustomerId)
    End Function

    Public Sub Logout()
        If File.Exists(filePath) Then
            File.Delete(filePath)
        End If
    End Sub

    Public Function IsLogin() As Boolean
        Return File.Exists(filePath)
    End Function
End Module

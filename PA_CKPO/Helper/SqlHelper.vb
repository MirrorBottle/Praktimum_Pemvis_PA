Imports MySql.Data.MySqlClient

Module SqlHelper

    Public connectionString As String = "server=localhost;database=s4_ck_po;uid=root;password=;"

    Public Function ExecuteQuery(query As String) As DataTable
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable()
                conn.Open()
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
                conn.Close()
                Return dt
            End Using
        End Using
    End Function

    Public Sub ExecuteNonQuery(query As String)
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
    End Sub

    Public Sub InsertRecord(tableName As String, values As Dictionary(Of String, String))
        Dim query As String = "INSERT INTO " & tableName & " (" & String.Join(",", values.Keys) & ") VALUES (" & String.Join(",", values.Values.Select(Function(value) "'" & value.Replace("'", "''") & "'")) & ")"
        ExecuteNonQuery(query)
    End Sub

    Public Sub UpdateRecord(tableName As String, values As Dictionary(Of String, String), whereClause As String)
        Dim query As String = "UPDATE " & tableName & " SET " & String.Join(",", values.Select(Function(pair) pair.Key & "='" & pair.Value.Replace("'", "''") & "'")) & " WHERE " & whereClause
        ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteRecord(tableName As String, whereClause As String)
        Dim query As String = "DELETE FROM " & tableName & " WHERE " & whereClause
        ExecuteNonQuery(query)
    End Sub

End Module

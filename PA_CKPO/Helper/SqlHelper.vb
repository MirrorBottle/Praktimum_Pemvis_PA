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

    Public Function ExecuteScalar(query As String) As Object
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                conn.Open()
                Dim result As Object = cmd.ExecuteScalar()
                conn.Close()
                Return result
            End Using
        End Using
    End Function

    Public Function GetLastInsertedID() As Integer
        Dim query As String = "SELECT LAST_INSERT_ID()"
        Dim result As Object = ExecuteScalar(query)
        Dim id As Integer = 0
        If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), id) Then
            Return id
        End If
        Return 0
    End Function

    Public Sub InsertRecord(tableName As String, values As Dictionary(Of String, String))
        Dim query As String = "INSERT INTO " & tableName & " (" & String.Join(",", values.Keys) & ") VALUES (" & String.Join(",", values.Values.Select(Function(value) "'" & value.Replace("'", "''") & "'")) & ")"
        ExecuteNonQuery(query)
    End Sub

    Public Function InsertRecordAndGetID(tableName As String, values As Dictionary(Of String, String)) As Integer
        InsertRecord(tableName, values)
        Dim id As Integer = GetLastInsertedID()
        Return id
    End Function

    Public Sub UpdateRecord(tableName As String, values As Dictionary(Of String, String), id As String)
        Dim query As String = "UPDATE " & tableName & " SET " & String.Join(",", values.Select(Function(pair) pair.Key & "='" & pair.Value.Replace("'", "''") & "'")) & " WHERE id=" & id
        ExecuteNonQuery(query)
    End Sub

    Public Sub DeleteRecord(tableName As String, whereClause As String)
        Dim query As String = "DELETE FROM " & tableName & " WHERE " & whereClause
        ExecuteNonQuery(query)
    End Sub

    Public Function FindRecord(query As String) As DataRow
        Dim dt As DataTable = ExecuteQuery(query)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function FindRecordById(table As String, id As String) As DataRow
        Dim dt As DataTable = ExecuteQuery($"SELECT * FROM {table} WHERE id={id}")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

End Module

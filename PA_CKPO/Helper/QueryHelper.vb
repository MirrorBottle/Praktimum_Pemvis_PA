Module QueryHelper
    Public Function UserList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT id, username, name as user_name,
                          CASE role
                            WHEN 1 THEN 'Admin'
                            WHEN 2 THEN 'Logistik'
                            ELSE 'Customer'
                           END AS role
                        FROM users"
        If Keyword IsNot Nothing Then
            Query &= $" WHERE name LIKE '%{Keyword}%'"
        End If
        Query &= $" ORDER BY id DESC"
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function
End Module

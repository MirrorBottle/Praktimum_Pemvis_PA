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


    Public Function PurchaseOrderAdminItemList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT
            items.id,
            items.code,
            CONCAT(items.name, ' - ', items.brand, ' - ', items.color) as name,
            REPLACE(FORMAT(CAST(items.price AS DECIMAL), 0), ',', '.') as price,
            items.uom,
            suppliers.code as supplier
        FROM items
        JOIN suppliers ON items.supplier_id=suppliers.id"
        If Keyword IsNot Nothing Then
            Query &= $" WHERE items.name LIKE '%{Keyword}%'"
        End If
        Query &= $" ORDER BY items.id"
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function
End Module

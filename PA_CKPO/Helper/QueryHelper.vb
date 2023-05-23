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

    Public Function SupplierList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT * FROM suppliers"
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

    Public Function PurchaseOrderAdminApprovalList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT
            purchase_orders.id,
            purchase_orders.code,
            customers.name as customer_name,
            REPLACE(FORMAT(CAST(purchase_orders.total_amount AS DECIMAL), 0), ',', '.') as total_amount,
            (
                SELECT COUNT(*) 
                FROM purchase_order_items 
                WHERE purchase_order_items.purchase_order_id = purchase_orders.id
            ) AS items_total
        FROM purchase_orders
        JOIN customers ON purchase_orders.customer_id=customers.id"
        If Keyword IsNot Nothing Then
            Query &= $" WHERE purchase_orders.code LIKE '%{Keyword}%' AND status=0 ORDER BY purchase_orders.id DESC"
        Else
            Query &= $" WHERE status=0 ORDER BY purchase_orders.id DESC"
        End If
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function PurchaseOrderItemList(id As String) As DataTable
        Dim Query As String = $"SELECT
            purchase_order_items.id,
            items.code as item_code,
            CONCAT(items.name, ' - ', items.brand, ' - ', items.color) as item_name,
            items.uom as item_uom,
            suppliers.name as supplier_name,
            REPLACE(FORMAT(CAST(purchase_order_items.price_request / purchase_order_items.amount_request AS DECIMAL), 0), ',', '.') as item_price,
            purchase_order_items.amount_request,
            REPLACE(FORMAT(CAST(purchase_order_items.price_request AS DECIMAL), 0), ',', '.') as price_request
        FROM purchase_order_items
        JOIN purchase_orders ON purchase_order_items.purchase_order_id=purchase_orders.id
        JOIN items ON purchase_order_items.item_id=items.id
        JOIN suppliers ON items.supplier_id=suppliers.id
        WHERE purchase_order_items.purchase_order_id={id}"
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function PurchaseOrderItemFinishList(id As String) As DataTable
        Dim Query As String = $"SELECT
            purchase_order_items.id,
            items.code as item_code,
            CASE purchase_order_items.is_fulfilled
                WHEN 1 THEN 'Tersedia'
                WHEN 2 THEN 'Tidak Tersedia'
                ELSE 'Pending'
            END AS is_fulfilled,
            CONCAT(items.name, ' - ', items.brand, ' - ', items.color) as item_name,
            items.uom as item_uom,
            suppliers.name as supplier_name,
            REPLACE(FORMAT(CAST(purchase_order_items.price_request / purchase_order_items.amount_request AS DECIMAL), 0), ',', '.') as item_price,
            purchase_order_items.amount_request,
            REPLACE(FORMAT(CAST(purchase_order_items.price_request AS DECIMAL), 0), ',', '.') as price_request
        FROM purchase_order_items
        JOIN purchase_orders ON purchase_order_items.purchase_order_id=purchase_orders.id
        JOIN items ON purchase_order_items.item_id=items.id
        JOIN suppliers ON items.supplier_id=suppliers.id
        WHERE purchase_order_items.purchase_order_id={id}"
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function PurchaseOrderDetail(id As String) As DataRow
        Dim Query As String = $"SELECT
            purchase_orders.*,
            customers.name as customer_name,
            COALESCE(users.name, 'N/A') as logistic_name
        FROM purchase_orders
        JOIN customers ON purchase_orders.customer_id=customers.id
        LEFT JOIN users ON purchase_orders.logistic_id=users.id
        WHERE purchase_orders.id={id}"

        Dim DataRow As DataRow = SqlHelper.FindRecord(Query)
        Return DataRow
    End Function

    Public Function PurchaseOrderLogisticApprovalList(Optional Keyword As String = Nothing, Optional logisticId As String = Nothing) As DataTable
        Dim Query As String

        If logisticId IsNot Nothing Then
            Query = $"SELECT
                purchase_orders.id,
                purchase_orders.code,
                customers.name as customer_name,
                REPLACE(FORMAT(CAST(purchase_orders.total_amount AS DECIMAL), 0), ',', '.') as total_amount,
                (
                    SELECT COUNT(*) 
                    FROM purchase_order_items 
                    WHERE purchase_order_items.purchase_order_id = purchase_orders.id
                ) AS items_total
            FROM purchase_orders
            JOIN customers ON purchase_orders.customer_id=customers.id"
        Else
            Query = $"SELECT
                purchase_orders.id,
                purchase_orders.code,
                customers.name as customer_name,
                COALESCE(users.name, 'N/A') as logistic_name,
                REPLACE(FORMAT(CAST(purchase_orders.total_amount AS DECIMAL), 0), ',', '.') as total_amount,
                (
                    SELECT COUNT(*) 
                    FROM purchase_order_items 
                    WHERE purchase_order_items.purchase_order_id = purchase_orders.id
                ) AS items_total
            FROM purchase_orders
            JOIN customers ON purchase_orders.customer_id=customers.id
            LEFT JOIN users ON purchase_orders.logistic_id=users.id"
        End If

        If Keyword IsNot Nothing Then
            Query &= $" WHERE purchase_orders.code LIKE '%{Keyword}%' AND status=1 ORDER BY purchase_orders.id DESC"
        ElseIf logisticId IsNot Nothing Then
            Query &= $" WHERE purchase_orders.logistic_id={logisticId} AND status=1 ORDER BY purchase_orders.id DESC"
        Else
            Query &= $" WHERE status=1 ORDER BY purchase_orders.id DESC"
        End If
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function PurchaseOrderFinishList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT
            purchase_orders.id,
            purchase_orders.code,
            customers.name as customer_name,
            users.name as logistic_name,
            (
                SELECT COUNT(*) 
                FROM purchase_order_items 
                WHERE purchase_order_items.purchase_order_id = purchase_orders.id
            ) AS items_total,
            (
                SELECT COUNT(*) 
                FROM purchase_order_items 
                WHERE purchase_order_items.purchase_order_id = purchase_orders.id AND is_fulfilled=1
            ) AS items_total_fulfilled,
            REPLACE(FORMAT(CAST(purchase_orders.total_amount AS DECIMAL), 0), ',', '.') as total_amount,
            REPLACE(FORMAT(CAST(purchase_orders.payed_amount AS DECIMAL), 0), ',', '.') as payed_amount
        FROM purchase_orders
        JOIN customers ON purchase_orders.customer_id=customers.id
        JOIN users ON purchase_orders.logistic_id=users.id"

        If Keyword IsNot Nothing Then
            Query &= $" WHERE purchase_orders.code LIKE '%{Keyword}%' AND status=2 ORDER BY purchase_orders.id DESC"
        Else
            Query &= $" WHERE status=2 ORDER BY purchase_orders.id DESC"
        End If
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function CustomerDashboard(Optional Keyword As String = Nothing) As DataTable
        Dim Credentials = UserHelper.GetCredentials()
        Dim Query As String = $"SELECT
            purchase_orders.id,
            purchase_orders.code,
            CASE purchase_orders.status
                WHEN 0 THEN 'Pending'
                WHEN 1 THEN 'Admin Approved'
                WHEN 2 THEN 'Logistic Approved'
                ELSE 'Selesai'
            END AS status,
            COALESCE(users.name, 'N/A') as logistic_name,
            (
                SELECT COUNT(*) 
                FROM purchase_order_items 
                WHERE purchase_order_items.purchase_order_id = purchase_orders.id
            ) AS items_total,
            (
                SELECT COUNT(*) 
                FROM purchase_order_items 
                WHERE purchase_order_items.purchase_order_id = purchase_orders.id AND is_fulfilled=1
            ) AS items_total_fulfilled,
            REPLACE(FORMAT(CAST(purchase_orders.total_amount AS DECIMAL), 0), ',', '.') as total_amount,
            COALESCE(REPLACE(FORMAT(CAST(purchase_orders.payed_amount AS DECIMAL), 0), ',', '.'), 'N/A') as payed_amount
        FROM purchase_orders
        JOIN customers ON purchase_orders.customer_id=customers.id
        LEFT JOIN users ON purchase_orders.logistic_id=users.id
        "

        If Keyword IsNot Nothing Then
            Query &= $" WHERE purchase_orders.code LIKE '%{Keyword}%' AND purchase_orders.customer_id={Credentials.userCustomerId} ORDER BY purchase_orders.id DESC"
        Else
            Query &= $" WHERE purchase_orders.customer_id={Credentials.userCustomerId} ORDER BY purchase_orders.id DESC"
        End If
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function

    Public Function CustomerList(Optional Keyword As String = Nothing) As DataTable
        Dim Query As String = $"SELECT
                customers.id,
                customers.name as customer_name,
                customers.contact_name,
                customers.contact_number,
                customers.address
            FROM customers"
        If Keyword IsNot Nothing Then
            Query &= $" WHERE name LIKE '%{Keyword}%'"
        End If
        Query &= $" ORDER BY id DESC"
        Dim Datatable As DataTable = SqlHelper.ExecuteQuery(Query)
        Return Datatable
    End Function
End Module

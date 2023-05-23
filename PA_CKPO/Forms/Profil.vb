Imports Org.BouncyCastle.Asn1.X509

Public Class Profil
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    Private Sub Profil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Credentials = UserHelper.GetCredentials()
        Dim data As DataRow = SqlHelper.FindRecord($"SELECT
                users.name,
                users.username,
                CASE role
                    WHEN 1 THEN 'Admin'
                    WHEN 2 THEN 'Logistik'
                    ELSE 'Customer'
                END AS role,
                COALESCE(customers.name, 'N/A') as customer_name
            FROM users
            LEFT JOIN customers ON users.customer_id=customers.id
            WHERE users.id={Credentials.userId}
        ")
        TxtName.Text = data("name")
        TxtHakAkses.Text = data("role")
        TxtUsername.Text = data("username")
        TxtCustomer.Text = data("customer_name")
    End Sub
End Class
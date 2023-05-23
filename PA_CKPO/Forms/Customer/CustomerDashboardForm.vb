Public Class CustomerDashboardForm
    Public Sub LoadData(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.CustomerDashboard(Nothing)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub

    Private Sub CustomerDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Credentials = UserHelper.GetCredentials()
        Label2.Text = $"Selamat Datang, {Credentials.name}"
        Me.LoadData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        PurchaseOrderForm.ShowDialog()
    End Sub
End Class
Public Class AdminDashboardForm
    Public Sub LoadData(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.PurchaseOrderLogisticApprovalList(Keyword)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub

    Private Sub AdminDashboardForm_Load(sender As Object, e As EventArgs)
        Dim Credentials = UserHelper.GetCredentials()
        Label2.Text = $"Selamat Datang, {Credentials.name}"
        Me.LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        Me.LoadData()
    End Sub

    Private Sub AdminDashboardForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadData()
    End Sub
End Class
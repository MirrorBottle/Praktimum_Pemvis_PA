Public Class LogisticDashboardForm

    Public Sub LoadData(Optional Keyword As String = Nothing)
        Dim Credentials = UserHelper.GetCredentials()
        DataGridView1.DataSource = QueryHelper.PurchaseOrderLogisticApprovalList(Nothing, Credentials.userId)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub
    Private Sub LogisticDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Credentials = UserHelper.GetCredentials()
        Label2.Text = $"Selamat Datang, {Credentials.name}"
        Me.LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        BtnApprove.Enabled = True
    End Sub

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles BtnApprove.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        LogisticPOApprovalForm.LoadData(row.Cells(0).Value)
        LogisticPOApprovalForm.ShowDialog()
    End Sub
End Class
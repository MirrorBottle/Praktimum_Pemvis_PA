Public Class PurchaseOrderFinishListForm
    Public Sub LoadData(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.PurchaseOrderFinishList(Keyword)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub

    Private Sub PurchaseOrderFinishListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnApprove.Enabled = False
        Me.LoadData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadData()
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.LoadData(txtCari.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        BtnApprove.Enabled = True
    End Sub

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles BtnApprove.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        PurchaseOrderFinishForm.LoadData(row.Cells(0).Value)
        PurchaseOrderFinishForm.ShowDialog()
    End Sub
End Class
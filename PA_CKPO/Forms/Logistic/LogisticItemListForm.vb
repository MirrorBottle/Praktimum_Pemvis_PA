Public Class LogisticItemListForm
    Public Sub LoadData(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.ItemList(Keyword)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.LoadData()
    End Sub

    Private Sub txtCari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.LoadData(txtCari.Text)
        End If
    End Sub

    Private Sub LogisticItemListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LoadData()
    End Sub
End Class
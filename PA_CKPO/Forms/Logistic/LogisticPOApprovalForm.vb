Public Class LogisticPOApprovalForm
    Private purchaseOrderId As String = Nothing
    Public Sub LoadData(rowId As String)
        purchaseOrderId = rowId

        DataGridView1.DataSource = QueryHelper.PurchaseOrderItemList(purchaseOrderId)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()

        Dim purchaseOrder As DataRow = QueryHelper.PurchaseOrderDetail(purchaseOrderId)

        TxtCode.Text = purchaseOrder("code")
        TxtCustomer.Text = purchaseOrder("customer_name")
        TxtPayment.Text = "Rp. " & Helper.NumberFormat(purchaseOrder("total_amount"))
        TxtPaymentFinal.Text = "Rp. " & Helper.NumberFormat(purchaseOrder("total_amount"))
        TxtNote.Text = purchaseOrder("note")
    End Sub

    Public Sub LoadFinalPayment(Optional rowIndex As Integer = -1)
        Dim Total As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)
            Dim isChecked As Boolean = CBool(checkboxCell?.Value)
            If isChecked Or rowIndex = row.Index Then
                Dim rowTotal As String = Helper.Parse(row.Cells(8).Value)
                Total += rowTotal
            End If
        Next
        TxtPaymentFinal.Text = "Rp. " + Helper.NumberFormat(Total)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Me.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim uncheckedRowCount As Integer = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim checkboxCell As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)
            Dim isChecked As Boolean = CBool(checkboxCell?.Value)
            If Not isChecked Then
                uncheckedRowCount += 1
            End If
        Next

        Dim message As String = If(uncheckedRowCount > 0, $"Terdapat {uncheckedRowCount} yang tidak bisa terpenuhi. Lanjutkan?", "PO akan dilanjutkan ke tahap selanjutnya. Lanjutkan?")
        Dim result As DialogResult = MessageBox.Show(message, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim values As New Dictionary(Of String, String)()
            values("logistic_at") = DateTime.Now.ToString("yyyy-MM-dd")
            values("payed_amount") = TxtPaymentFinal.Text.Replace("Rp. ", "").Replace(".", "")
            values("status") = Helper.PO_LOGISTIC_APPROVED
            SqlHelper.UpdateRecord("purchase_orders", values, Me.purchaseOrderId)

            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim checkboxCell As DataGridViewCheckBoxCell = TryCast(row.Cells(0), DataGridViewCheckBoxCell)
                Dim isChecked As Boolean = CBool(checkboxCell?.Value)
                Dim purchaseOrderItem As New Dictionary(Of String, String)()
                purchaseOrderItem("is_fulfilled") = If(isChecked, "1", "2")

                SqlHelper.UpdateRecord("purchase_order_items", purchaseOrderItem, row.Cells("id").Value)
            Next

            Helper.ShowMessage("Berhasil approved PO", "Success")
            Me.Close()
            LogisticDashboardForm.LoadData()
        End If

    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If DataGridView1.IsCurrentCellDirty AndAlso DataGridView1.CurrentCell.ColumnIndex = 0 Then
            DataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            Dim currentCell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)

            If TypeOf currentCell Is DataGridViewCheckBoxCell Then
                Dim checked As Boolean = CBool(currentCell.Value)
                If checked Then
                    Me.LoadFinalPayment(e.RowIndex)
                Else
                    Me.LoadFinalPayment()
                End If

            End If
        End If
    End Sub

    Private Sub LogisticPOApprovalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Columns(0).DefaultCellStyle.NullValue = True
    End Sub

    Private Sub dataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For i As Integer = e.RowIndex To e.RowIndex + e.RowCount - 1
            DataGridView1.Rows(i).Cells(0).Value = True
        Next
    End Sub
End Class
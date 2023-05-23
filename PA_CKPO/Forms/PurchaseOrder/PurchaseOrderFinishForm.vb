Public Class PurchaseOrderFinishForm

    Private purchaseOrderId As String = Nothing
    Public Sub LoadData(rowId As String)
        purchaseOrderId = rowId

        DataGridView1.DataSource = QueryHelper.PurchaseOrderItemFinishList(purchaseOrderId)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()

        Dim purchaseOrder As DataRow = QueryHelper.PurchaseOrderDetail(purchaseOrderId)

        TxtCode.Text = purchaseOrder("code")
        TxtCustomer.Text = purchaseOrder("customer_name")
        TxtLogistic.Text = purchaseOrder("logistic_name")
        TxtPayment.Text = "Rp. " & Helper.NumberFormat(purchaseOrder("total_amount"))
        TxtPaymentFinal.Text = "Rp. " & Helper.NumberFormat(purchaseOrder("payed_amount"))
        TxtNote.Text = purchaseOrder("note")
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim result As DialogResult = MessageBox.Show("PO akan selesai. Lanjutkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim values As New Dictionary(Of String, String)()
            values("finish_at") = DateTime.Now.ToString("yyyy-MM-dd")
            values("status") = Helper.PO_DONE
            SqlHelper.UpdateRecord("purchase_orders", values, Me.purchaseOrderId)
            Helper.ShowMessage("Berhasil Menyelesaiakan PO", "Success")
            Me.Close()
            PurchaseOrderFinishListForm.LoadData()
        End If
    End Sub
End Class
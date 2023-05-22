Imports System.Security

Public Class PurchaseOrderApprovalAdminForm
    Private purchaseOrderId As String = Nothing
    Public Sub LoadData(rowId As String)
        purchaseOrderId = rowId

        DataGridView1.DataSource = QueryHelper.PurchaseOrderItemList(purchaseOrderId)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()

        Helper.FormPopulateCmb("SELECT id, name FROM users WHERE role=2", Me.CmbLogistic, "name")

        Dim purchaseOrder As DataRow = QueryHelper.PurchaseOrderDetail(purchaseOrderId)

        TxtCode.Text = purchaseOrder("code")
        TxtCustomer.Text = purchaseOrder("customer_name")
        TxtPayment.Text = "Rp. " & Helper.NumberFormat(purchaseOrder("total_amount"))
        TxtNote.Text = purchaseOrder("note")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Me.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim IsPass As Boolean = Helper.FormValidate(Me, New List(Of String) From {"TxtNote"})

        If IsPass Then
            Dim values As New Dictionary(Of String, String)()
            values("logistic_id") = CmbLogistic.SelectedValue
            values("approval_at") = DateTime.Now.ToString("yyyy-MM-dd")
            values("status") = Helper.PO_ADMIN_APPROVED
            SqlHelper.UpdateRecord("purchase_orders", values, Me.purchaseOrderId)

            Helper.ShowMessage("Berhasil approved PO", "Success")
            Me.Close()
            PurchaseOrderApprovalAdminListForm.LoadData()
        Else
            MessageBox.Show("Mohon lengkapi isian anda!")
        End If
    End Sub
End Class
Public Class SupplierForm

    Private supplierId As String = Nothing
    Public Sub SupplierFormLoadEdit(rowId As String)

        LabelHeader.Text = "Ubah Data Supplier"
        Me.supplierId = rowId

        Dim data As DataRow = SqlHelper.FindRecordById("suppliers", supplierId)
        TxtName.Text = data("name")
        TxtCode.Text = data("code")
        TxtConName.Text = data("contact_name")
        TxtConNumber.Text = data("contact_number")
        TxtAddress.Text = data("address")

    End Sub

    Private Sub SupplierForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LabelHeader.Text = "Tambah Data Supplier"
        Me.supplierId = Nothing
        Helper.FormClear(Me)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Helper.FormClear(Me)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim IsPass As Boolean = Helper.FormValidate(Me)

        If IsPass Then
            Dim values As New Dictionary(Of String, String)()
            values("name") = TxtName.Text
            values("code") = TxtCode.Text
            values("contact_name") = TxtConName.Text
            values("contact_number") = TxtConNumber.Text
            values("address") = TxtAddress.Text

            If IsNothing(supplierId) Then 'CREATE
                SqlHelper.InsertRecord("suppliers", values)
            Else 'UPDATE
                SqlHelper.UpdateRecord("suppliers", values, Me.supplierId)
            End If

            Helper.ShowMessage(If(IsNothing(supplierId), "Berhasil menambah suppliers", "Berhasil mengubah suppliers"), "Success")

            Me.Close()
            SupplierListForm.LoadData()
        Else
            MessageBox.Show("Mohon lengkapi isian anda!")
        End If
    End Sub

    Private Sub SupplierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
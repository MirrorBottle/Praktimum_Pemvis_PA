Public Class ItemForm
    Private itemId As String = Nothing

    Public Sub FormLoad()
        Helper.FormPopulateCmb("SELECT id, name FROM suppliers", Me.CmbSupplier, "name")
    End Sub
    Public Sub FormLoadEdit(rowId As String)
        Me.FormLoad()

        LabelHeader.Text = "Ubah Barang"
        Me.itemId = rowId

        Dim data As DataRow = SqlHelper.FindRecordById("items", itemId)
        TxtCode.Text = data("code")
        TxtName.Text = data("name")
        TxtPrice.Text = data("price")
        TxtCategory.Text = data("category")
        TxtColor.Text = data("color")
        TxtBrand.Text = data("brand")
        TxtUom.Text = data("uom")
        CmbSupplier.SelectedValue = data("supplier_id").ToString()

    End Sub

    Private Sub ItemForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If IsNothing(itemId) Then
            Me.FormLoad()
        End If
    End Sub

    Private Sub ItemForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LabelHeader.Text = "Tambah Barang"
        Me.itemId = Nothing
        Helper.FormClear(Me)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim IsPass As Boolean = Helper.FormValidate(Me)

        If IsPass Then
            Dim values As New Dictionary(Of String, String)()
            values("code") = TxtCode.Text
            values("name") = TxtName.Text
            values("price") = TxtPrice.Text
            values("category") = TxtCategory.Text
            values("color") = TxtColor.Text
            values("brand") = TxtBrand.Text
            values("uom") = TxtUom.Text
            values("supplier_id") = CmbSupplier.SelectedValue

            If IsNothing(itemId) Then 'CREATE
                SqlHelper.InsertRecord("items", values)
            Else 'UPDATE
                SqlHelper.UpdateRecord("items", values, Me.itemId)
            End If

            Helper.ShowMessage(If(IsNothing(itemId), "Berhasil menambah Barang", "Berhasil mengubah Barang"), "Success")

            Me.Close()
            ItemListForm.LoadData()
        Else
            MessageBox.Show("Mohon lengkapi isian anda!")
        End If
    End Sub


End Class
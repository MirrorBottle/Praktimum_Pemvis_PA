Imports System.Runtime.CompilerServices.RuntimeHelpers

Public Class CustomerForm
    Private customersId As String = Nothing
    Public Sub CustomerFormLoadEdit(rowId As String)

        LabelHeader.Text = "Ubah Data Pengguna"
        Me.customersId = rowId

        Dim data As DataRow = SqlHelper.FindRecordById("customers", customersId)
        TxtName.Text = data("name")
        TxtConName.Text = data("contact_name")
        TxtConNumber.Text = data("contact_number")
        TxtAddress.Text = data("address")

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Helper.FormClear(Me)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim IsPass As Boolean = Helper.FormValidate(Me)

        If IsPass Then
            Dim values As New Dictionary(Of String, String)()
            values("name") = TxtName.Text
            values("contact_name") = TxtConName.Text
            values("contact_number") = TxtConNumber.Text
            values("address") = TxtAddress.Text

            If IsNothing(customersId) Then 'CREATE
                SqlHelper.InsertRecord("customers", values)
            Else 'UPDATE
                SqlHelper.UpdateRecord("customers", values, Me.customersId)
            End If

            Helper.ShowMessage(If(IsNothing(customersId), "Berhasil menambah customer", "Berhasil mengubah customer"), "Success")

            Me.Close()
            CustomerListForm.LoadData()
        Else
            MessageBox.Show("Mohon lengkapi isian anda!")
        End If
    End Sub

End Class
Imports System.Windows.Controls
Imports Google.Protobuf.WellKnownTypes

Public Class UserForm
    Private id As String = Nothing

    Public Sub FormLoad()
        Helper.FormPopulateCmb("SELECT id, name FROM customers", Me.CmbCustomer, "name")
    End Sub
    Public Sub FormLoadEdit(row As DataGridViewRow)
        Me.FormLoad()

        LabelHeader.Text = "Ubah Data Pengguna"
        LabelPassword.Visible = True
        id = row.Cells(0).Value

        Dim data As DataRow = SqlHelper.FindRecordById("users", id)
        TxtUsername.Text = data("username")
        TxtName.Text = data("name")
        CmbHakAkses.SelectedIndex = CInt(data("role")) - 1
        CmbCustomer.SelectedValue = If(data.IsNull("customer_id"), "", data("customer_id").ToString())
    End Sub
    Private Sub UserForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If IsNothing(id) Then
            Me.FormLoad()
        End If
    End Sub


    Private Sub UserForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LabelHeader.Text = "Tambah Data Pengguna"
        Me.id = Nothing
        Helper.FormClear(Me)
    End Sub

    Private Sub CmbHakAkses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbHakAkses.SelectedIndexChanged
        CmbCustomer.Enabled = CmbHakAkses.SelectedItem = "Customer"
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Helper.FormClear(Me)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim IsPass As Boolean = If(IsNothing(id), Helper.FormValidate(Me), Helper.FormValidate(Me, New List(Of String) From {"TxtPassword"}))

        If IsPass Then
            Dim values As New Dictionary(Of String, String)()
            values("name") = TxtName.Text
            values("username") = TxtUsername.Text
            values("role") = CmbHakAkses.SelectedIndex + 1

            If values("role") = "3" Then
                values("customer_id") = CmbCustomer.SelectedValue
            End If

            If IsNothing(id) Then 'CREATE
                values("password") = TxtPassword.Text
                SqlHelper.InsertRecord("users", values)
            Else 'UPDATE
                If Not IsNothing(id) And String.IsNullOrEmpty(TxtPassword.Text) Then
                    values("password") = TxtPassword.Text
                End If
                SqlHelper.UpdateRecord("users", values, Me.id)
            End If

            Helper.ShowMessage(If(IsNothing(id), "Berhasil menambah pengguna", "Berhasil mengubah pengguna"), "Success")

            Me.Close()
            UserListForm.LoadData()
        Else
            MessageBox.Show("Mohon lengkapi isian anda!")
        End If
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
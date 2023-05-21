﻿Imports System.Windows.Controls

Public Class UserListForm

    Public Sub LoadData(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.UserList(Keyword)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub

    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEdit.Enabled = False
        btnHapus.Enabled = False
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
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        UserForm.Show()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        UserDetailForm.ShowDialog()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        UserForm.FormLoadEdit(row)
        UserForm.ShowDialog()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim row As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        Dim id As String = row.Cells(0).Value
        Dim result As DialogResult = MessageBox.Show("Apa anda ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            SqlHelper.DeleteRecord("users", $"id={id}")
            Helper.ShowMessage("Data berhasil dihapus", "Success")
            Me.LoadData()
        End If
    End Sub
End Class
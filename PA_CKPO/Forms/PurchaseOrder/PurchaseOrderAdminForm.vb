Imports Google.Protobuf.WellKnownTypes
Imports Mysqlx.XDevAPI.Relational

Public Class PurchaseOrderAdminForm

    Public Sub LoadItemList(Optional Keyword As String = Nothing)
        DataGridView1.DataSource = QueryHelper.PurchaseOrderAdminItemList(Keyword)
        DataGridView1.ReadOnly = False
        DataGridView1.Refresh()
    End Sub

    Public Sub LoadTotalPayment()
        Dim Total As Integer = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim rowTotal As String = Helper.Parse(row.Cells(5).Value)
            Total += rowTotal
        Next
        TxtTotal.Text = "Rp. " + Helper.NumberFormat(Total)
    End Sub

    Public Sub FormClear()
        Helper.FormClear(Me)
        DataGridView2.Rows.Clear()
        TxtCode.Text = Helper.GetNextPurchaseOrderCode()
    End Sub
    Private Sub PurchaseOrderAdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Helper.FormPopulateCmb("SELECT id, name FROM customers", Me.CmbCustomer, "name")
        Helper.FormPopulateCmb("SELECT id, name FROM users WHERE role=2", Me.CmbLogistic, "name")

        TxtCode.Text = Helper.GetNextPurchaseOrderCode()
        CmbCustomer.SelectedIndex = -1
        CmbLogistic.SelectedIndex = -1
        Me.LoadItemList()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.LoadItemList(TxtSearch.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim isExist As Boolean = False
        Dim data As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        Dim id = data.Cells(0).Value.ToString()

        For Each row As DataGridViewRow In DataGridView2.Rows
            Dim cellValue As String = row.Cells(0).Value.ToString()
            If cellValue = id Then
                isExist = True
                Exit For
            End If
        Next

        BtnRemove.Enabled = False
        BtnAdd.Enabled = Not isExist
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        BtnRemove.Enabled = True
        BtnAdd.Enabled = False
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim row As DataGridViewRow = DataGridView2.CurrentRow
        Dim userInput As String = InputBox($"Masukkan Jumlah Barang Baru:", "Number Prompt")

        If Not String.IsNullOrEmpty(userInput) Then
            Dim amount As Integer
            If Integer.TryParse(userInput, amount) Then
                Dim price As Integer = Helper.Parse(row.Cells(3).Value)
                Dim total = amount * price
                row.Cells(4).Value = amount
                row.Cells(5).Value = Helper.NumberFormat(total)
                Me.LoadTotalPayment()
            Else
                MessageBox.Show("Jumlah barang harus angka!")
            End If
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim data As DataGridViewRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index)
        Dim userInput As String = InputBox($"Masukkan Jumlah Barang:", "Number Prompt")

        If Not String.IsNullOrEmpty(userInput) Then
            Dim amount As Integer
            If Integer.TryParse(userInput, amount) Then
                Dim price As Integer = Helper.Parse(data.Cells("item_price").Value)
                Dim total = amount * price

                Dim row As DataGridViewRow = New DataGridViewRow()
                row.CreateCells(DataGridView2)
                row.Cells(0).Value = data.Cells("id").Value
                row.Cells(1).Value = data.Cells("item_code").Value
                row.Cells(2).Value = data.Cells("item_name").Value
                row.Cells(3).Value = data.Cells("item_price").Value
                row.Cells(4).Value = amount
                row.Cells(5).Value = Helper.NumberFormat(total)

                ' Add the row to the DataGridView
                DataGridView2.Rows.Add(row)
                BtnAdd.Enabled = False

                Me.LoadTotalPayment()
            Else
                MessageBox.Show("Jumlah barang harus angka!")
            End If
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim result As DialogResult = MessageBox.Show("Apa anda ingin menghapus ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim currentRow As DataGridViewRow = DataGridView2.CurrentRow
            If currentRow IsNot Nothing Then
                DataGridView2.Rows.Remove(currentRow)
                BtnRemove.Enabled = False
                Me.LoadTotalPayment()
            End If

        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim isPass As Boolean = Helper.FormValidate(Me, New List(Of String) From {"TxtNote", "TxtSearch"})
        If isPass And DataGridView1.Rows.Count > 0 Then
            Dim purchaseOrder As New Dictionary(Of String, String)()
            purchaseOrder("code") = TxtCode.Text
            purchaseOrder("customer_id") = CmbCustomer.SelectedValue
            purchaseOrder("logistic_id") = CmbLogistic.SelectedValue
            purchaseOrder("status") = Helper.PO_ADMIN_APPROVED
            purchaseOrder("note") = TxtNote.Text
            purchaseOrder("total_amount") = TxtTotal.Text.Replace("Rp. ", "").Replace(".", "")
            purchaseOrder("created_at") = DateTime.Now.ToString("yyyy-MM-dd")
            purchaseOrder("approval_at") = DateTime.Now.ToString("yyyy-MM-dd")

            Dim purchaseOrderId = SqlHelper.InsertRecordAndGetID("purchase_orders", purchaseOrder)

            For Each row As DataGridViewRow In DataGridView2.Rows
                Dim purchaseOrderItem As New Dictionary(Of String, String)()
                purchaseOrderItem("purchase_order_id") = purchaseOrderId
                purchaseOrderItem("item_id") = row.Cells(0).Value
                purchaseOrderItem("amount_request") = row.Cells(4).Value
                purchaseOrderItem("price_request") = Helper.Parse(row.Cells(5).Value)

                SqlHelper.InsertRecord("purchase_order_items", purchaseOrderItem)
            Next

            Helper.ShowMessage("Berhasil menambah PO", "Success")

            Me.FormClear()
        Else
            MsgBox("Mohon lengkapi isian anda!")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Me.FormClear()
    End Sub
End Class
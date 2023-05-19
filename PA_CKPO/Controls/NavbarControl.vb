Imports System.Net

Public Class NavbarControl
    Private Sub NavbarControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Credentials = UserHelper.GetCredentials()
        MenuStrip1.Items.Clear()

        Select Case Credentials.userRole
            Case 1 ' Admin
                MenuStrip1.Items.Add(New ToolStripMenuItem("Dashboard") With {.Name = "AdminDashboard"})
                MenuStrip1.Items.Add(New ToolStripMenuItem("Buat PO") With {.Name = "AdminCreatePO"})


                Dim PurchaseOrderMenuItem As New ToolStripMenuItem("Purchase Order")

                Dim userListItem As New ToolStripMenuItem("Manajemen Pengguna") With {.Name = "UserList"}


                Dim AdminPOValidation As New ToolStripMenuItem("Validasi Admin") With {.Name = "PurchaseOrderListAdminValidation"}
                AddHandler AdminPOValidation.Click, AddressOf ToolStripMenuItem_Click

                Dim AdminPOLogistic As New ToolStripMenuItem("Logistik") With {.Name = "PurchaseOrderListLogisticValidation"}
                AddHandler AdminPOLogistic.Click, AddressOf ToolStripMenuItem_Click


                Dim AdminPOPayment As New ToolStripMenuItem("Pembayaran") With {.Name = "PurchaseOrderListPayment"}
                AddHandler AdminPOPayment.Click, AddressOf ToolStripMenuItem_Click


                Dim AdminPOList As New ToolStripMenuItem("Semua") With {.Name = "PurchaseOrderList"}
                AddHandler AdminPOList.Click, AddressOf ToolStripMenuItem_Click


                PurchaseOrderMenuItem.DropDownItems.Add(AdminPOValidation)
                PurchaseOrderMenuItem.DropDownItems.Add(AdminPOLogistic)
                PurchaseOrderMenuItem.DropDownItems.Add(AdminPOPayment)
                PurchaseOrderMenuItem.DropDownItems.Add(AdminPOList)


                MenuStrip1.Items.Add(PurchaseOrderMenuItem)

                Dim AdminMasterMenuItem As New ToolStripMenuItem("Master Data")

                Dim AdminItemMenuItem As New ToolStripMenuItem("Manajemen Barang") With {.Name = "ItemList"}
                AddHandler AdminItemMenuItem.Click, AddressOf ToolStripMenuItem_Click

                Dim AdminSupplierMenuItem As New ToolStripMenuItem("Manajemen Supplier") With {.Name = "SupplierList"}
                AddHandler AdminSupplierMenuItem.Click, AddressOf ToolStripMenuItem_Click

                Dim AdminCustomerMenuItem As New ToolStripMenuItem("Manajemen Kustomer") With {.Name = "CustomerList"}
                AddHandler AdminSupplierMenuItem.Click, AddressOf ToolStripMenuItem_Click

                Dim AdminUserMenuItem As New ToolStripMenuItem("Manajemen Pengguna") With {.Name = "UserList"}
                AddHandler AdminUserMenuItem.Click, AddressOf ToolStripMenuItem_Click


                AdminMasterMenuItem.DropDownItems.Add(AdminItemMenuItem)
                AdminMasterMenuItem.DropDownItems.Add(AdminSupplierMenuItem)
                AdminMasterMenuItem.DropDownItems.Add(AdminCustomerMenuItem)
                AdminMasterMenuItem.DropDownItems.Add(AdminUserMenuItem)
                MenuStrip1.Items.Add(AdminMasterMenuItem)

            Case 2 ' Logistic
                MenuStrip1.Items.Add(New ToolStripMenuItem("Dashboard") With {.Name = "LogisticDashboard"})
                MenuStrip1.Items.Add(New ToolStripMenuItem("Histori PO") With {.Name = "LogisticPurchaseOrder"})
                MenuStrip1.Items.Add(New ToolStripMenuItem("Katalog") With {.Name = "LogisticItem"})

            Case 3 ' Customer
                MenuStrip1.Items.Add(New ToolStripMenuItem("Dashboard") With {.Name = "CustomerDashboard"})
                MenuStrip1.Items.Add(New ToolStripMenuItem("Histori PO") With {.Name = "CustomerPurchaseOrder"})
                MenuStrip1.Items.Add(New ToolStripMenuItem("Katalog") With {.Name = "CustomerItem"})
            Case Else
        End Select
        MenuStrip1.Items.Add(New ToolStripMenuItem("Profil") With {.Name = "Profil"})
        MenuStrip1.Items.Add(New ToolStripMenuItem("Logout") With {.Name = "Logout"})
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
        Dim currentForm As Form = Me.FindForm()
        Select Case e.ClickedItem.Name
            Case "AdminDashboard"
                AdminDashboardForm.Show()
            Case "UserList"
                UserListForm.Show()
            Case Else
        End Select
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim clickedItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim itemName As String = clickedItem.Name
        Dim currentForm As Form = Me.FindForm()
        ' Perform actions based on the clicked item name
        Select Case itemName
            Case "UserList"
                UserListForm.Show()
            Case "SubMenu1"
        End Select
    End Sub
End Class

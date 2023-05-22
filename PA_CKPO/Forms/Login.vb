
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserHelper.IsLogin() Then
            Dim Credentials = UserHelper.GetCredentials()
            Select Case Credentials.userRole
                Case "1"
                    PurchaseOrderApprovalAdminListForm.ShowDialog()
                Case "2"
                    LogisticDashboardForm.ShowDialog()
                Case "3"
                    CustomerDashboardForm.ShowDialog()
            End Select

            Me.Close()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim isLogin = UserHelper.Login(TxtUsername.Text, TxtPassword.Text)
        If (isLogin) Then
            Dim Credentials = UserHelper.GetCredentials()
            Dim AdminDashboardForm = New AdminDashboardForm()
            Dim LogisticDashboardForm = New LogisticDashboardForm()
            Dim CustomerDashboardForm = New CustomerDashboardForm()
            Select Case Credentials.userRole
                Case "1"
                    Me.Hide()
                    AdminDashboardForm.ShowDialog()
                    Me.Close()
                    AdminDashboardForm.ShowDialog()
                Case "2"
                    Me.Hide()
                    LogisticDashboardForm.ShowDialog()
                    Me.Close()
                    LogisticDashboardForm.ShowDialog()
                Case "3"
                    Me.Hide()
                    CustomerDashboardForm.ShowDialog()
                    Me.Close()
                    CustomerDashboardForm.ShowDialog()
            End Select
        Else
            Helper.ShowMessage("Gagal login!", "Error")
        End If
    End Sub
End Class

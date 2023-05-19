
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If UserHelper.IsLogin() Then
            AdminDashboardForm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim isLogin = UserHelper.Login(TxtUsername.Text, TxtPassword.Text)
        If (isLogin) Then
            Dim AdminDashboardForm = New AdminDashboardForm()
            Me.Hide()
            AdminDashboardForm.ShowDialog()
            Me.Close()
        Else
            Helper.ShowMessage("Gagal login!", "Error")
        End If
    End Sub
End Class

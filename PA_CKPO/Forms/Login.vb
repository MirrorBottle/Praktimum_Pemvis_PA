Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Dim isLogin = UserHelper.Login(TxtUsername.Text, TxtPassword.Text)

        If (isLogin) Then
            Helper.ShowMessage("Berhasil login", "Success")
        Else
            Helper.ShowMessage("Gagal login!", "Error")
        End If
    End Sub
End Class

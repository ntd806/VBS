Public Class login
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Loginfor.Username = txtUser.Text
        Loginfor.Password = Util.getHash(txtPass.Text)
        Loginfor.Role = txtRole.Text
        'MessageBox.Show(pass.ToString())
        'Dim sql As String = "INSERT INTO customer (username, password) VALUES ('" + Loginfor.Username + "','" + Loginfor.Password + "')"
        Dim sql As String = "SELECT * FROM customer where username= '" + Loginfor.Username + "' and password = '" + Loginfor.Password + "'"
        If (XL_DuLieu.ThucHienLenh(Sql) = -1) Then
            Dim frm As New Form2()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai mật khẩu hoặc tài khoản")
        End If
    End Sub
End Class
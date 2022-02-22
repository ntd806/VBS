Public Class Login
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim user As String = txtUser.Text
        Dim pass As String = Util.getHash(txtPass.Text)
        Dim sql As String = "SELECT * FROM customer where username= '" + user + "' and [password] = '" + pass + "'"
        If (XL_DuLieu.ThucHienLenh(sql) = -1) Then
            Dim frm As New Form2()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai mật khẩu hoặc tài khoản")
        End If
    End Sub
End Class
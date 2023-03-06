Public Class login
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Loginfor.Username = txtUser.Text
        Loginfor.Password = Util.getHash(txtPass.Text)
        Loginfor.Role = txtRole.Text

        'Dim sql As String = "INSERT INTO customer (username, password, role) VALUES ('" + Loginfor.Username + "','" + Loginfor.Password + "', '" + Loginfor.Role + "')"
        Dim sql As String = "SELECT * FROM customer where username= '" + Loginfor.Username + "' and password = '" + Loginfor.Password + "' and role = '" + Loginfor.Role + "'"
        Console.WriteLine(sql)
        'Console.WriteLine(XL_DuLieu.ThucHienLenh(sql))
        If (XL_DuLieu.ThucHienLenh(sql) = -1) Then
            Dim frm As New Form2()
            frm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sai mật khẩu hoặc tài khoản")
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet.permition' table. You can move, or remove it, as needed.
        Me.PermitionTableAdapter2.Fill(Me.HotelDataSet.permition)

    End Sub
End Class
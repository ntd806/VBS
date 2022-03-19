Public Class frmNhanVien
    Dim dsNhanVien As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_1781006u1DataSet2.chon' table. You can move, or remove it, as needed.
        Me.ChonTableAdapter.Fill(Me._1781006u1DataSet2.chon)
        'TODO: This line of code loads data into the '_1781006u1DataSet.permition' table. You can move, or remove it, as needed.
        Me.PermitionTableAdapter.Fill(Me._1781006u1DataSet.permition)
        Dim sql As String = "SELECT * FROM customer"
        dsNhanVien = XL_DuLieu.DocDuLieu(sql)

        DataGridView1.DataSource = dsNhanVien
    End Sub

    Public Function getUser() As customer
        Dim nhanvien As New customer
        If txtId.Text = String.Empty Then
            nhanvien.id = 0
        Else
            nhanvien.id = Integer.Parse(txtId.Text)
        End If
        nhanvien.usename = txtUsername.Text
        nhanvien.phone = txtPhone.Text
        nhanvien.role = txtRole.Text
        nhanvien.block = Integer.Parse(txtIsblock.Text)
        nhanvien.pass = Util.getHash(txtPassword.Text)
        Return nhanvien
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nhanvien = getUser()
        Dim kh As DataRow = dsNhanVien.NewRow()
        kh("id") = nhanvien.id
        kh("phone") = nhanvien.phone
        kh("role") = nhanvien.role
        kh("is_block") = nhanvien.block
        kh("password") = nhanvien.pass
        kh("username") = nhanvien.usename
        dsNhanVien.Rows.Add(kh)
        XL_DuLieu.GhiDuLieu("customer", dsNhanVien)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nhanvien = getUser()
        Dim sql As String = "UPDATE customer set is_block = " + nhanvien.block.ToString() + " where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nhanvien = getUser()
        Dim sql As String = "DELETE FROM  customer  where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong")
        End If
    End Sub

    Private Sub btResetPassword_Click(sender As Object, e As EventArgs) Handles btResetPassword.Click
        Dim sql1 As String = "SELECT * FROM customer where username= '" + Loginfor.Username + "' and password = '" + Loginfor.Password + "' and role = '" + Loginfor.Role + "'"
        Dim nhanvien = getUser()
        Dim newPass As String
        If (txtNewPass.Text = String.Empty Or txtOldPass.Text = String.Empty Or txtConfirm.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong")
        Else

            If String.Compare(txtNewPass.Text, txtConfirm.Text) = 0 Then
            Else
                newPass = Util.getHash(txtNewPass.Text)
                MessageBox.Show("Mat khau xac nhan va mat khau moi phai giong nhau")
            End If
        End If

        Dim sql As String = "UPDATE customer set password = " + newPass + " where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql1) = -1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong" + nhanvien.id.ToString())
        End If
    End Sub
End Class

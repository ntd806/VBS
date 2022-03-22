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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim nhanvien = getUser()
        Dim kh As DataRow = dsNhanVien.NewRow()
        kh("phone") = nhanvien.phone
        kh("role") = nhanvien.role
        kh("is_block") = nhanvien.block
        kh("password") = nhanvien.pass
        kh("username") = nhanvien.usename
        dsNhanVien.Rows.Add(kh)
        Dim frm As frmNhanVien = New frmNhanVien()
        XL_DuLieu.GhiDuLieu("customer", dsNhanVien)
        frm.WindowState = FormWindowState.Maximized
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Dim nhanvien = getUser()
        If (txtRole.Text = String.Empty Or txtPhone.Text = String.Empty Or txtIsblock.Text = String.Empty Or txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong phone, role, block, id")
        End If

        Dim sql As String = "UPDATE customer set phone = '" + nhanvien.phone.ToString() + "'," + "role = '" + nhanvien.role.ToString() + "'," + "is_block = " + nhanvien.block.ToString() + " where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong" + nhanvien.id.ToString())
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btblock.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim nhanvien = getUser()
        If (txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong id")
        End If
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
        Dim nhanvien = getUser()
        If (txtNewPass.Text = String.Empty Or txtOldPass.Text = String.Empty Or txtConfirm.Text = String.Empty Or txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong mat khau cu, mat khau moi, xac nhan mat khau")
        Else
            If String.Compare(txtNewPass.Text, txtConfirm.Text) = 0 Then
            Else
                MessageBox.Show("Mat khau xac nhan va mat khau moi phai giong nhau")
            End If
        End If

        Dim sql As String = "UPDATE customer set password = '" + Util.getHash(txtNewPass.Text).ToString() + "' where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong" + nhanvien.id.ToString())
        End If
    End Sub
End Class

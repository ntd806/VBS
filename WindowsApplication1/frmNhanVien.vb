Public Class frmNhanVien
    Dim dsNhanVien As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HotelDataSet2.chosse' table. You can move, or remove it, as needed.
        Me.ChosseTableAdapter.Fill(Me.HotelDataSet2.chosse)
        'TODO: This line of code loads data into the 'HotelDataSet1.permition' table. You can move, or remove it, as needed.
        Me.PermitionTableAdapter1.Fill(Me.HotelDataSet1.permition)
        Dim sql As String = "SELECT * FROM customer where not role = 'admin' and is_block = 0"
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
        nhanvien.fullname = Txtname.Text
        nhanvien.phone = txtPhone.Text
        nhanvien.role = txtRole.Text
        nhanvien.sex = Txtsex.Text
        nhanvien.idNumber = TxtCMND.Text
        nhanvien.bird = DateTimePicker1.Value.ToString()
        Console.WriteLine(txtIsblock.Text)
        nhanvien.is_block = Integer.Parse(txtIsblock.Text)
        nhanvien.password = Util.getHash(txtPassword.Text)
        nhanvien.address = TxtAdress.Text
        Return nhanvien
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim nhanvien = getUser()
        Dim kh As DataRow = dsNhanVien.NewRow()
        kh("phone") = nhanvien.phone
        kh("role") = nhanvien.role
        kh("username") = nhanvien.usename
        kh("fullname") = nhanvien.fullname
        kh("idNumber") = nhanvien.idNumber
        kh("is_block") = nhanvien.is_block
        kh("address") = nhanvien.address
        kh("password") = nhanvien.password
        dsNhanVien.Rows.Add(kh)
        Dim sql1 As String = "'" + nhanvien.usename + "','" + nhanvien.password + "','" + nhanvien.phone + "','" + nhanvien.address + "','"
        Dim sql3 As String = nhanvien.role + "','" + nhanvien.fullname + "','" + nhanvien.is_block.ToString() + "','" + nhanvien.idNumber + "'"
        Dim sql As String = "INSERT INTO customer (username, password, phone, address, role,fullname,is_block, idNumber) VALUES (" + sql1 + sql3 + ")"

        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong" + nhanvien.usename)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Dim nhanvien = getUser()
        If (txtRole.Text = String.Empty Or txtPhone.Text = String.Empty Or txtIsblock.Text = String.Empty Or txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong phone, role, is_block, id")
        End If

        Dim sql As String = "UPDATE customer Set phone = '" + nhanvien.phone.ToString() + "'," + "role = '" + nhanvien.role.ToString() + "'," + "is_block = " + nhanvien.is_block.ToString() + " where id = " + nhanvien.id.ToString()
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
        Dim sql As String = "UPDATE customer set is_block = " + nhanvien.is_block.ToString() + " where id = " + nhanvien.id.ToString()
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

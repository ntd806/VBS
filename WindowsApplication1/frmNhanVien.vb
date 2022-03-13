Public Class frmNhanVien
    Dim dsNhanVien As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_1781006u1DataSet.permition' table. You can move, or remove it, as needed.
        Me.PermitionTableAdapter.Fill(Me._1781006u1DataSet.permition)
        Dim sql As String = "SELECT * FROM customer"
        dsNhanVien = XL_DuLieu.DocDuLieu(sql)

        DataGridView1.DataSource = dsNhanVien
    End Sub

    Public Function getUser() As customer
        Dim nhanvien As New customer
        nhanvien.id = Integer.Parse(txtId.Text)
        nhanvien.usename = txtUsername.Text
        nhanvien.phone = txtPhone.Text
        nhanvien.role = txtRole.Text
        nhanvien.block = Integer.Parse(txtIsblock.Text)

        Return nhanvien
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nhanvien = getUser()
        Dim kh As DataRow = dsNhanVien.NewRow()
        'kh("id") = nhanvien.id
        kh("phone") = nhanvien.phone
        kh("role") = nhanvien.role
        kh("is_block") = nhanvien.block
        kh("username") = nhanvien.usename
        dsNhanVien.Rows.Add(kh)
        XL_DuLieu.GhiDuLieu("customer", dsNhanVien)
    End Sub
End Class

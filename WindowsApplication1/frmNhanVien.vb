Public Class frmNhanVien
    Dim dsNhanVien As DataTable

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "Select * from customer"
        dsNhanVien = XL_DuLieu.DocDuLieu(sql)

        DataGridView1.DataSource = dsNhanVien
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nv As DataRow = dsNhanVien.NewRow()
        nv("NV_TenDangNhap") = tb_TenDangNhap.Text
        nv("TK_TenDangNhap") = tb_TenDangNhap.Text
        nv("TK_MatKhau") = Util.getHash(tb_MatKhau.Text)
        nv("NV_HoTen") = tb_HoTen.Text
        nv("NV_Email") = tb_Email.Text
        nv("NV_DiaChi") = tb_DiaChi.Text
        nv("TK_Loai") = 2
        nv("NV_Loai") = 1


        dsNhanVien.Rows.Add(nv)
        XL_DuLieu.GhiDuLieu1("TaiKhoan", dsNhanVien)
        XL_DuLieu.GhiDuLieu("NhanVien", dsNhanVien)
    End Sub
End Class
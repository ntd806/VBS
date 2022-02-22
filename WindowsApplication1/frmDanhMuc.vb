Public Class frmDanhMuc
    Dim dsDanhMuc As DataTable

    Private Sub frmDanhMuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsDanhMuc = XL_DuLieu.DocDuLieu("Select * from DanhMuc")

        'Hien thi du lieu len listbox
        HienThiDSDanhMuc(lb_DanhSach, dsDanhMuc)

    End Sub

    Sub HienThiDSDanhMuc(ByVal lb As ListBox, ByVal ds As DataTable)
        For Each dm In dsDanhMuc.Rows
            lb.Items.Add(dm("DM_Ten"))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(tb_Ten.Text) Then
            MessageBox.Show("Vui long nhap ten danh muc truoc khi them ")
        Else
            Dim dm As DataRow = dsDanhMuc.NewRow()
            dm("DM_Ten") = tb_Ten.Text
            dsDanhMuc.Rows.Add(dm)
            XL_DuLieu.GhiDuLieu("DanhMuc", dsDanhMuc)
            lb_DanhSach.Items.Add(tb_Ten.Text)
        End If
    End Sub
End Class
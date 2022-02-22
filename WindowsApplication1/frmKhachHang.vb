Public Class frmKhachHang
    Dim dsKhachHang As DataTable
    Dim dsKhachHangView As DataView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsKhachHang = XL_DuLieu.DocDuLieu("Select * from KhachHang")

        dsKhachHang.Columns.Add("KH_HoTenSearch")
        'Duyet tat ca dong KH_HoTen => KH_HoTenSearch

        dsKhachHangView = New DataView(dsKhachHang)
        dgv_DsKhachHang.DataSource = dsKhachHangView
        dgv_DsKhachHang.Columns(5).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kh As DataRow = dsKhachHang.NewRow()
        kh("KH_TenTaiKhoan") = tb_TenDangNhap.Text
        kh("KH_HoTen") = tb_HoTen.Text
        kh("KH_Email") = tb_Email.Text
        kh("KH_DiaChi") = tb_DiaChi.Text

        dsKhachHang.Rows.Add(kh)
        XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
    End Sub

    Private Sub dgv_DsKhachHang_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_DsKhachHang.SelectionChanged
        If dgv_DsKhachHang.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
            Dim khv As DataRowView = dgv_DsKhachHang.Rows(i).DataBoundItem
            If khv IsNot Nothing Then
                Dim kh As DataRow = khv.Row
                If IsDBNull(kh(1)) Then
                    tb_TenDangNhap.Text = ""
                Else
                    tb_TenDangNhap.Text = kh(1)
                End If

                tb_HoTen.Text = kh(2)

                'Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
                'Dim ma As Integer = dgv_DsKhachHang.Rows(i).Cells(0).Value
                'Dim kh As DataRow = layKhachHang(ma)
                'If kh IsNot Nothing Then
                '   tb_TenDangNhap.Text = kh(1)
                '   tb_HoTen.Text = kh(2)
                'End If
            End If
        End If
    End Sub

    Private Function layKhachHang(ByVal maso As Integer) As DataRow
        For Each kh In dsKhachHang.Rows
            If kh("KH_ID") = maso Then
                Return kh
            End If
        Next
        Return Nothing
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgv_DsKhachHang.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
            Dim khv As DataRowView = dgv_DsKhachHang.Rows(i).DataBoundItem
            Dim kh As DataRow = khv.Row
            kh(2) = tb_HoTen.Text
            kh(3) = tb_Email.Text
            kh(4) = tb_DiaChi.Text

            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
            'Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
            'Dim ma As Integer = dgv_DsKhachHang.Rows(i).Cells(0).Value
            'Dim kh As DataRow = layKhachHang(ma)
            'If kh IsNot Nothing Then
            '   tb_TenDangNhap.Text = kh(1)
            '   tb_HoTen.Text = kh(2)
            'End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If dgv_DsKhachHang.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
            Dim khv As DataRowView = dgv_DsKhachHang.Rows(i).DataBoundItem
            Dim kh As DataRow = khv.Row
            kh.Delete()
            'dsKhachHang.Rows.Remove(kh)
            XL_DuLieu.GhiDuLieu("KhachHang", dsKhachHang)
            'Dim i As Integer = dgv_DsKhachHang.SelectedCells(0).RowIndex
            'Dim ma As Integer = dgv_DsKhachHang.Rows(i).Cells(0).Value
            'Dim kh As DataRow = layKhachHang(ma)
            'If kh IsNot Nothing Then
            '   tb_TenDangNhap.Text = kh(1)
            '   tb_HoTen.Text = kh(2)
            'End If
        End If
    End Sub

    Private Sub tb_TimKiem_TextChanged(sender As Object, e As EventArgs) Handles tb_TimKiem.TextChanged
        If tb_TimKiem.Text = "" Then
            dsKhachHangView.RowFilter = ""
        Else
            Dim str As String = String.Format("KH_HoTen like '%{0}%'", tb_TimKiem.Text)
            dsKhachHangView.RowFilter = str
        End If
    End Sub
End Class

Public Class Form1
    Dim ma_nv As Integer
    Dim dsChiNhanh As DataTable
    Dim dsMenu As DataTable
    Dim dsMonAnDonHang As DataTable
    Dim dsDonHang As DataTable
    Dim dsKhuyenMaiDongGia As DataTable
    Dim dsKhuyenMaiDongGiaChiTiet As DataTable
    Dim i_TongTien As Integer
    Dim i_TongMon As Integer
    Dim i_KhuyenMai As Integer


    Public Sub New(ByVal ma As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ma_nv = ma
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsChiNhanh = XL_DuLieu.DocDuLieu("Select * from ChiNhanh, NhanVienChiNhanh where CN_ID=NVCN_MaChiNhanh and NVCN_MaNhanVien=" + ma_nv.ToString())
        cb_dsChiNhanh.DisplayMember = "CN_Ten"
        cb_dsChiNhanh.ValueMember = "CN_ID"
        cb_dsChiNhanh.DataSource = dsChiNhanh

        dsMonAnDonHang = XL_DuLieu.DocCauTruc("Select CTDH_MA, CTDH_MonAnId, MA_Ten, CTDH_SoLuong, CTDH_Gia, CTDH_KhuyenMai, CTDH_MaDonHang from ChiTietDonHang, MonAn where MA_Id = CTDH_MonAnId")
        dgv_dsMonAnDonHang.DataSource = dsMonAnDonHang

        dsDonHang = XL_DuLieu.DocCauTruc("select * from DonHang")

        dsKhuyenMaiDongGia = XL_DuLieu.DocDuLieu("Select * from KM_DongGia")
        CheckBox1.Visible = False
        For i As Integer = 0 To dsKhuyenMaiDongGia.Rows.Count - 1
            If dsKhuyenMaiDongGia.Rows(i)("KMDG_KichHoat") = 1 Then
                CheckBox1.Visible = True
                CheckBox1.Text = dsKhuyenMaiDongGia.Rows(i)("KMDG_Ten")
                dsKhuyenMaiDongGiaChiTiet = XL_DuLieu.DocDuLieu("Select * from KM_DongGiaChiTiet where KMDGCT_MaChuongTrinh =" + dsKhuyenMaiDongGia.Rows(i)("KMDG_Ma").ToString())
            End If
        Next
    End Sub

    Private Sub cb_dsChiNhanh_SelectedValueChanged(sender As Object, e As EventArgs) Handles cb_dsChiNhanh.SelectedValueChanged
        If cb_dsChiNhanh.SelectedValue > 0 Then
            dsMenu = XL_DuLieu.DocDuLieu("Select M_ID, MA_ID, MA_Ten, M_Gia from menu, MonAn where M_MonAnId = MA_Id and M_ChiNhanhId=" + cb_dsChiNhanh.SelectedValue.ToString())
            dgv_dsMonAn.DataSource = dsMenu
        End If
    End Sub

    Private Sub dgv_dsMonAn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dsMonAn.CellDoubleClick
        If dgv_dsMonAn.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_dsMonAn.SelectedCells(0).RowIndex
            Dim mav As DataRowView = dgv_dsMonAn.Rows(i).DataBoundItem
            Dim ma As DataRow = mav.Row

            Dim madh_vitri = timMonAnDonHang(ma(1))

            If madh_vitri = -1 Then
                Dim madh As DataRow = dsMonAnDonHang.NewRow()
                madh(1) = ma(1)
                madh(2) = ma(2)
                madh(4) = ma(3)
                madh(3) = 1
                madh("CTDH_KhuyenMai") = 0
                dsMonAnDonHang.Rows.Add(madh)
            Else
                dsMonAnDonHang.Rows(madh_vitri)(3) = dsMonAnDonHang.Rows(madh_vitri)(3) + 1 ' (Integer.Parse(madh(3)) + 1)
            End If
            TinhTongTien()
        End If
    End Sub

    Function timMonAnDonHang(ByVal mamonan As Integer) As Integer
        For i As Integer = 0 To dsMonAnDonHang.Rows.Count - 1
            If mamonan = dsMonAnDonHang.Rows(i)(1) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Sub TinhTongTien()
        i_TongMon = 0
        i_KhuyenMai = 0
        For i As Integer = 0 To dsMonAnDonHang.Rows.Count - 1
            i_TongMon = i_TongMon + dsMonAnDonHang.Rows(i)("CTDH_Gia") * dsMonAnDonHang.Rows(i)("CTDH_SoLuong")
            If CheckBox1.Checked = True Then
                For j As Integer = 0 To dsKhuyenMaiDongGiaChiTiet.Rows.Count - 1
                    If dsMonAnDonHang.Rows(i)("CTDH_MonAnId") = dsKhuyenMaiDongGiaChiTiet(j)("KMDGCT_MaMonAn") Then
                        Dim km As Integer = dsMonAnDonHang.Rows(i)("CTDH_Gia") - dsKhuyenMaiDongGia.Rows(0)("KMDG_GiaBan")
                        dsMonAnDonHang.Rows(i)("CTDH_KhuyenMai") = km
                        i_KhuyenMai = i_KhuyenMai + km * dsMonAnDonHang.Rows(i)("CTDH_SoLuong")
                    End If
                Next
            Else
                dsMonAnDonHang.Rows(i)("CTDH_KhuyenMai") = 0
            End If
        Next
        i_TongTien = i_TongMon - i_KhuyenMai
        l_TongHoaDon.Text = i_TongTien
        l_TongMon.Text = i_TongMon
        l_KhuyenMai.Text = i_KhuyenMai
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dsMonAnDonHang.Rows.Count > 0 Then
            Dim dh As DataRow = dsDonHang.NewRow()

            dh("DH_NgayTao") = Date.Now
            dh("DH_MaChiNhanh") = cb_dsChiNhanh.SelectedValue
            dh("DH_TongMon") = i_TongMon
            dh("DH_KhuyenMai") = i_KhuyenMai
            dh("DH_TongTien") = i_TongTien

            dsDonHang.Rows.Add(dh)
            XL_DuLieu.GhiDuLieu("DonHang", dsDonHang)
            'cap nhat ma don hang cho cac chi tiet
            For i As Integer = 0 To dsMonAnDonHang.Rows.Count - 1
                dsMonAnDonHang.Rows(i)("CTDH_MaDonHang") = dh("DH_Ma")
            Next
            XL_DuLieu.GhiDuLieu("ChiTietDonHang", dsMonAnDonHang)

            If CheckBox1.Checked Then
                XL_DuLieu.ThucHienLenh("Insert into KM_DongGiaDonHang(KMDGDH_MaChuongTrinh, KMDGDH_MaDonHang) values (" + dsKhuyenMaiDongGia.Rows(0)("KMDG_Ma").ToString() + "," + dh("DH_Ma").ToString() + ")")
            End If
        Else
            MessageBox.Show("Anh/chi khong the tao don hang khong co mon an")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TinhTongTien()
    End Sub
End Class
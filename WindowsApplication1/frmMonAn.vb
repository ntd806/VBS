Public Class frmMonAn
    Dim dsMonAn As DataTable
    Dim dsMonAnView As DataView
    Dim dsDanhMuc As DataTable

    Private Sub frmMonAn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dsMonAn = XL_DuLieu.DocDuLieu("Select * from MonAn, DanhMuc where MA_DanhMucId = DM_Id")
        dsMonAnView = New DataView(dsMonAn)
        dgv_dsMonAn.DataSource = dsMonAnView
        dgv_dsMonAn.Columns(4).Visible = False
        dgv_dsMonAn.Columns(5).Visible = False
        dgv_dsMonAn.Columns(0).HeaderText = "Ma"
        dgv_dsMonAn.Columns(1).HeaderText = "Ten"

        dsDanhMuc = XL_DuLieu.DocDuLieu("Select * from DanhMuc")
        cb_DanhMuc.DataSource = dsDanhMuc
        cb_DanhMuc.DisplayMember = "DM_Ten"
        cb_DanhMuc.ValueMember = "DM_Id"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'validate form vb.net win
        'hien thi dau ngan cach cho so
        Dim ma As DataRow = dsMonAn.NewRow()
        ma("MA_Ten") = tb_Ten.Text
        ma("MA_Gia") = tb_Gia.Text
        ma("MA_MoTa") = tb_MoTa.Text
        ma("MA_DanhMucId") = cb_DanhMuc.SelectedValue
        ma("DM_Id") = cb_DanhMuc.SelectedValue
        ma("DM_Ten") = cb_DanhMuc.SelectedItem(1)

        dsMonAn.Rows.Add(ma)
        XL_DuLieu.GhiDuLieu("MonAn", dsMonAn)

    End Sub
End Class
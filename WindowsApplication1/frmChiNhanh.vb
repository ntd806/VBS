Public Class frmChiNhanh
    Dim dsChiNhanh As DataTable

    Private Sub frmChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListView, TreeView
        dsChiNhanh = XL_DuLieu.DocDuLieu("Select * from ChiNhanh")
        dgv_dsChiNhanh.DataSource = dsChiNhanh
    End Sub

    Private Sub btn_Them_Click(sender As Object, e As EventArgs) Handles btn_Them.Click
        Dim cn As DataRow = dsChiNhanh.NewRow()
        cn("CN_Ten") = tb_Ten.Text
        cn("CN_DiaChi") = tb_DiaChi.Text

        dsChiNhanh.Rows.Add(cn)
        XL_DuLieu.GhiDuLieu("ChiNhanh", dsChiNhanh)


    End Sub

    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) Handles btn_Menu.Click
        If dgv_dsChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_dsChiNhanh.SelectedCells(0).RowIndex
            Dim cnv As DataRowView = dgv_dsChiNhanh.Rows(i).DataBoundItem
            Dim cn As DataRow = cnv.Row

            Dim frm As frmMenuChiNhanh = New frmMenuChiNhanh(cn)
            frm.MdiParent = MdiParent
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        End If


    End Sub
End Class
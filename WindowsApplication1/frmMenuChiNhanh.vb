Public Class frmMenuChiNhanh
    Dim chinhanh As DataRow
    Dim dsMonAn As DataTable
    Dim dsMonAnView As DataView
    Dim dsMonAnChiNhanh As DataTable

    Public Sub New(ByVal cn As DataRow)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        chinhanh = cn
    End Sub

    Private Sub frmMenuChiNhanh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsMonAn = XL_DuLieu.DocDuLieu("Select * from MonAn")
        dsMonAnView = New DataView(dsMonAn)
        dgv_dsMon.DataSource = dsMonAnView

        dsMonAnChiNhanh = XL_DuLieu.DocDuLieu("Select * from Menu, MonAn where M_MonAnId = MA_Id and M_ChiNhanhId = " + chinhanh("CN_Id").ToString())
        dgv_dsMonChiNhanh.DataSource = dsMonAnChiNhanh
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If dgv_dsMon.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_dsMon.SelectedCells(0).RowIndex
            Dim mv As DataRowView = dgv_dsMon.Rows(i).DataBoundItem
            Dim m As DataRow = mv.Row

            If TimMon(m, dsMonAnChiNhanh) = -1 Then
                Dim mcn As DataRow = dsMonAnChiNhanh.NewRow()
                mcn("M_MonAnId") = m("MA_Id")
                mcn("M_ChiNhanhId") = chinhanh("CN_Id")
                mcn("M_Gia") = m("MA_Gia")
                dsMonAnChiNhanh.Rows.Add(mcn)
                XL_DuLieu.GhiDuLieu("Menu", dsMonAnChiNhanh)
            End If

        End If
    End Sub

    Function TimMon(ByVal m As DataRow, ByVal dsMonCN As DataTable) As Integer
        Dim kq = -1
        For i As Integer = 0 To dsMonCN.Rows.Count - 1
            If m("MA_Id") = dsMonCN.Rows(i)("M_MonAnId") Then
                kq = i
                Exit For
            End If
        Next
        Return kq
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dgv_dsMonChiNhanh.SelectedCells.Count > 0 Then
            Dim i As Integer = dgv_dsMonChiNhanh.SelectedCells(0).RowIndex
            dsMonAnChiNhanh.Rows(i).Delete()
            XL_DuLieu.GhiDuLieu("Menu", dsMonAnChiNhanh)
        End If
    End Sub
End Class
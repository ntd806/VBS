Public Class FrmLoaiSanPham
    Dim dsloaisp As DataTable
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim category = getCate()
        Dim kh As DataRow = dsloaisp.NewRow()
        kh("name") = category.name
        kh("tpye") = category.type
        dsLoaiSp.Rows.Add(kh)
        Dim frm As New FrmLoaiSanPham
        XL_DuLieu.GhiDuLieu("category", dsLoaiSp)
        frm.WindowState = FormWindowState.Maximized
        Me.Hide()
        frm.Show()
    End Sub

    Public Function getCate() As category
        Dim category As New category
        If txtId.Text = String.Empty Then
            category.id = 0
        Else
            category.id = Integer.Parse(txtId.Text)
        End If

        If (txtCateName.Text = String.Empty Or txtCateType.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong name, type")
        Else
            category.name = txtCateName.Text
            category.type = Integer.Parse(txtCateType.Text)
        End If

        Return category
    End Function

    Private Sub FrmLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT * FROM category"
        dsloaisp = XL_DuLieu.DocDuLieu(sql)

        DataGridView2.DataSource = dsloaisp
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        Dim nhanvien = getCate()
        Dim sql As String = "UPDATE customer set name = '" + nhanvien.name.ToString() + "'," + "tpye = " + nhanvien.type.ToString() + " where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong" + nhanvien.id.ToString())
        End If
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim nhanvien As New category
        If txtId.Text = String.Empty Then
            nhanvien.id = 0
        Else
            nhanvien.id = Integer.Parse(txtId.Text)
        End If
        If (txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong id")
        End If
        Dim sql As String = "DELETE FROM  category  where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As New FrmLoaiSanPham
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong")
        End If
    End Sub
End Class
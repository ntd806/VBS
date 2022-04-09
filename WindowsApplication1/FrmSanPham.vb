Public Class FrmSanPham
    Dim dssp As DataTable
    Private Sub FrmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_1781006u1DataSet5.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me._1781006u1DataSet5.category)
        'TODO: This line of code loads data into the '_1781006u1DataSet3.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me._1781006u1DataSet3.product)
        Dim sql As String = "SELECT * FROM product"
        dssp = XL_DuLieu.DocDuLieu(sql)

        DataGridView3.DataSource = dssp
    End Sub

    Public Function getProduct() As product
        Dim pd As New product
        If txtId.Text = String.Empty Then
            pd.id = 0
        Else
            pd.id = Integer.Parse(txtId.Text)
        End If
        If (txtName.Text = String.Empty Or txtSize.Text = String.Empty Or txtCateId.Text = String.Empty Or txtPrice.Text = String.Empty Or txtHeight.Text = String.Empty Or txtWeight.Text = String.Empty Or txtWidth.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong cach truong name, size, cate_id, price, height, weight, width")
        Else
            pd.name = txtName.Text
            pd.size = Integer.Parse(txtSize.Text)
            pd.cate_id = Integer.Parse(txtCateId.Text)
            pd.price = Integer.Parse(txtPrice.Text)
            pd.height = Integer.Parse(txtHeight.Text)
            pd.weight = Integer.Parse(txtWeight.Text)
            pd.width = Integer.Parse(txtWidth.Text)
        End If

        Return pd

    End Function

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Dim sp = getProduct()
        Dim kh As DataRow = dssp.NewRow()
        kh("price") = sp.price
        kh("cate_id") = sp.cate_id
        kh("name") = sp.name
        kh("width") = sp.width
        kh("weight") = sp.weight
        kh("size") = sp.size
        kh("height") = sp.height
        dssp.Rows.Add(kh)
        Dim frm As FrmSanPham = New FrmSanPham()
        XL_DuLieu.GhiDuLieu("product", dssp)
        frm.WindowState = FormWindowState.Maximized
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub btDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        Dim nhanvien = getProduct()
        If (txtId.Text = String.Empty) Then
            MessageBox.Show("Khong duoc de trong id")
        End If
        Dim sql As String = "DELETE FROM  product  where id = " + nhanvien.id.ToString()
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.WindowState = FormWindowState.Maximized
            Me.Hide()
            frm.Show()
        Else
            MessageBox.Show("Khong thanh cong")
        End If
    End Sub
End Class
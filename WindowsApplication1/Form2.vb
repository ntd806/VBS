Public Class Form2
    Private ma_nv As Integer

    Public ReadOnly Property MaNhanVien() As Integer
        Get
            Return ma_nv
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ma_nv = 1
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        Dim frm As frmKhachHang = New frmKhachHang()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub NhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienToolStripMenuItem.Click
        If String.Equals(Loginfor.Role, "Admin") Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        Else
            MessageBox.Show("Ban Khong quyen truy cap")
        End If
    End Sub

    Private Sub DanhMucToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhMucToolStripMenuItem.Click
        Dim frm As frmDanhMuc = New frmDanhMuc()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub DanhSachMonAnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachMonAnToolStripMenuItem.Click
        Dim frm As frmMonAn = New frmMonAn()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub ChiNhanhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiNhanhToolStripMenuItem.Click
        Dim frm As frmChiNhanh = New frmChiNhanh()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BanHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanHangToolStripMenuItem.Click
        Dim frm As Form1 = New Form1(ma_nv)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub SanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanPhamToolStripMenuItem.Click
        Loginfor.Role = "Admin"
        If String.Equals(Loginfor.Role, "Admin") Or String.Equals(Loginfor.Role, "NhapLieu") Then
            Dim frm As FrmSanPham = New FrmSanPham()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        Else
            MessageBox.Show("Ban Khong quyen truy cap")
        End If
    End Sub

    Private Sub LoaiSanPhamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSanPhamToolStripMenuItem.Click
        Loginfor.Role = "Admin"
        If String.Equals(Loginfor.Role, "Admin") Or String.Equals(Loginfor.Role, "NhapLieu") Then
            Dim frm As FrmLoaiSanPham = New FrmLoaiSanPham()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        Else
            MessageBox.Show("Ban Khong quyen truy cap")
        End If
    End Sub
End Class
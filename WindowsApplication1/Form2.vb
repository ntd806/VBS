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
        Dim frm As frmNhanVien = New frmNhanVien()
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
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
End Class
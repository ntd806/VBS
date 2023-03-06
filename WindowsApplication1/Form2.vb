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

    Private Sub NhanVienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienToolStripMenuItem.Click
        If String.Equals(Loginfor.Role, "admin") Then
            Dim frm As frmNhanVien = New frmNhanVien()
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
            frm.Show()
        Else
            MessageBox.Show("Ban Khong quyen truy cap")
        End If
    End Sub


End Class
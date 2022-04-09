<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NghiepVuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BanHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuanLyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhachHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhanVienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMucToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSachMonAnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiNhanhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoaiSanPhamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NghiepVuToolStripMenuItem, Me.QuanLyToolStripMenuItem, Me.ThongTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(737, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NghiepVuToolStripMenuItem
        '
        Me.NghiepVuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BanHangToolStripMenuItem})
        Me.NghiepVuToolStripMenuItem.Name = "NghiepVuToolStripMenuItem"
        Me.NghiepVuToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.NghiepVuToolStripMenuItem.Text = "Nghiep vu"
        '
        'BanHangToolStripMenuItem
        '
        Me.BanHangToolStripMenuItem.Name = "BanHangToolStripMenuItem"
        Me.BanHangToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.BanHangToolStripMenuItem.Text = "Ban hang"
        '
        'QuanLyToolStripMenuItem
        '
        Me.QuanLyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhachHangToolStripMenuItem, Me.NhanVienToolStripMenuItem, Me.DanhMucToolStripMenuItem, Me.DanhSachMonAnToolStripMenuItem, Me.ChiNhanhToolStripMenuItem, Me.SanPhamToolStripMenuItem, Me.LoaiSanPhamToolStripMenuItem})
        Me.QuanLyToolStripMenuItem.Name = "QuanLyToolStripMenuItem"
        Me.QuanLyToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuanLyToolStripMenuItem.Text = "Quan ly"
        '
        'KhachHangToolStripMenuItem
        '
        Me.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem"
        Me.KhachHangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.KhachHangToolStripMenuItem.Text = "Khach hang"
        '
        'NhanVienToolStripMenuItem
        '
        Me.NhanVienToolStripMenuItem.Name = "NhanVienToolStripMenuItem"
        Me.NhanVienToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NhanVienToolStripMenuItem.Text = "Nhan vien"
        '
        'DanhMucToolStripMenuItem
        '
        Me.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem"
        Me.DanhMucToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DanhMucToolStripMenuItem.Text = "Danh muc"
        '
        'DanhSachMonAnToolStripMenuItem
        '
        Me.DanhSachMonAnToolStripMenuItem.Name = "DanhSachMonAnToolStripMenuItem"
        Me.DanhSachMonAnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DanhSachMonAnToolStripMenuItem.Text = "Menu tong"
        '
        'ChiNhanhToolStripMenuItem
        '
        Me.ChiNhanhToolStripMenuItem.Name = "ChiNhanhToolStripMenuItem"
        Me.ChiNhanhToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChiNhanhToolStripMenuItem.Text = "Chi nhanh"
        '
        'SanPhamToolStripMenuItem
        '
        Me.SanPhamToolStripMenuItem.Name = "SanPhamToolStripMenuItem"
        Me.SanPhamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SanPhamToolStripMenuItem.Text = "San Pham"
        '
        'ThongTinToolStripMenuItem
        '
        Me.ThongTinToolStripMenuItem.Name = "ThongTinToolStripMenuItem"
        Me.ThongTinToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ThongTinToolStripMenuItem.Text = "Thong tin"
        '
        'LoaiSanPhamToolStripMenuItem
        '
        Me.LoaiSanPhamToolStripMenuItem.Name = "LoaiSanPhamToolStripMenuItem"
        Me.LoaiSanPhamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LoaiSanPhamToolStripMenuItem.Text = "Loai san pham"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 392)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NghiepVuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuanLyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhachHangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThongTinToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhanVienToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhMucToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhSachMonAnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChiNhanhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BanHangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanPhamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoaiSanPhamToolStripMenuItem As ToolStripMenuItem
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhachHang
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
        Me.dgv_DsKhachHang = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.tb_HoTen = New System.Windows.Forms.TextBox()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_DiaChi = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tb_TimKiem = New System.Windows.Forms.TextBox()
        CType(Me.dgv_DsKhachHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_DsKhachHang
        '
        Me.dgv_DsKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DsKhachHang.Location = New System.Drawing.Point(12, 56)
        Me.dgv_DsKhachHang.Name = "dgv_DsKhachHang"
        Me.dgv_DsKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_DsKhachHang.Size = New System.Drawing.Size(512, 237)
        Me.dgv_DsKhachHang.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(530, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_TenDangNhap
        '
        Me.tb_TenDangNhap.Location = New System.Drawing.Point(622, 56)
        Me.tb_TenDangNhap.Name = "tb_TenDangNhap"
        Me.tb_TenDangNhap.Size = New System.Drawing.Size(100, 20)
        Me.tb_TenDangNhap.TabIndex = 0
        '
        'tb_HoTen
        '
        Me.tb_HoTen.Location = New System.Drawing.Point(622, 97)
        Me.tb_HoTen.Name = "tb_HoTen"
        Me.tb_HoTen.Size = New System.Drawing.Size(100, 20)
        Me.tb_HoTen.TabIndex = 1
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(622, 139)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(100, 20)
        Me.tb_Email.TabIndex = 2
        '
        'tb_DiaChi
        '
        Me.tb_DiaChi.Location = New System.Drawing.Point(622, 181)
        Me.tb_DiaChi.Name = "tb_DiaChi"
        Me.tb_DiaChi.Size = New System.Drawing.Size(100, 20)
        Me.tb_DiaChi.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(571, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(661, 223)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Button2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(742, 223)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tb_TimKiem
        '
        Me.tb_TimKiem.Location = New System.Drawing.Point(12, 30)
        Me.tb_TimKiem.Name = "tb_TimKiem"
        Me.tb_TimKiem.Size = New System.Drawing.Size(241, 20)
        Me.tb_TimKiem.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 344)
        Me.Controls.Add(Me.tb_TimKiem)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tb_DiaChi)
        Me.Controls.Add(Me.tb_Email)
        Me.Controls.Add(Me.tb_HoTen)
        Me.Controls.Add(Me.tb_TenDangNhap)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_DsKhachHang)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_DsKhachHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_DsKhachHang As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_TenDangNhap As TextBox
    Friend WithEvents tb_HoTen As TextBox
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents tb_DiaChi As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents tb_TimKiem As TextBox
End Class

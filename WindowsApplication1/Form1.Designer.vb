<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cb_dsChiNhanh = New System.Windows.Forms.ComboBox()
        Me.dgv_dsMonAn = New System.Windows.Forms.DataGridView()
        Me.dgv_dsMonAnDonHang = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.l_TongMon = New System.Windows.Forms.Label()
        Me.l_KhuyenMai = New System.Windows.Forms.Label()
        Me.l_TongHoaDon = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgv_dsMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dsMonAnDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cb_dsChiNhanh
        '
        Me.cb_dsChiNhanh.FormattingEnabled = True
        Me.cb_dsChiNhanh.Location = New System.Drawing.Point(24, 24)
        Me.cb_dsChiNhanh.Name = "cb_dsChiNhanh"
        Me.cb_dsChiNhanh.Size = New System.Drawing.Size(121, 21)
        Me.cb_dsChiNhanh.TabIndex = 0
        '
        'dgv_dsMonAn
        '
        Me.dgv_dsMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsMonAn.Location = New System.Drawing.Point(24, 65)
        Me.dgv_dsMonAn.Name = "dgv_dsMonAn"
        Me.dgv_dsMonAn.Size = New System.Drawing.Size(375, 333)
        Me.dgv_dsMonAn.TabIndex = 1
        '
        'dgv_dsMonAnDonHang
        '
        Me.dgv_dsMonAnDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsMonAnDonHang.Location = New System.Drawing.Point(443, 65)
        Me.dgv_dsMonAnDonHang.Name = "dgv_dsMonAnDonHang"
        Me.dgv_dsMonAnDonHang.Size = New System.Drawing.Size(390, 329)
        Me.dgv_dsMonAnDonHang.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(773, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Tao don hang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'l_TongMon
        '
        Me.l_TongMon.AutoSize = True
        Me.l_TongMon.Location = New System.Drawing.Point(687, 405)
        Me.l_TongMon.Name = "l_TongMon"
        Me.l_TongMon.Size = New System.Drawing.Size(39, 13)
        Me.l_TongMon.TabIndex = 4
        Me.l_TongMon.Text = "Label1"
        '
        'l_KhuyenMai
        '
        Me.l_KhuyenMai.AutoSize = True
        Me.l_KhuyenMai.Location = New System.Drawing.Point(687, 427)
        Me.l_KhuyenMai.Name = "l_KhuyenMai"
        Me.l_KhuyenMai.Size = New System.Drawing.Size(39, 13)
        Me.l_KhuyenMai.TabIndex = 4
        Me.l_KhuyenMai.Text = "Label1"
        '
        'l_TongHoaDon
        '
        Me.l_TongHoaDon.AutoSize = True
        Me.l_TongHoaDon.Location = New System.Drawing.Point(687, 455)
        Me.l_TongHoaDon.Name = "l_TongHoaDon"
        Me.l_TongHoaDon.Size = New System.Drawing.Size(39, 13)
        Me.l_TongHoaDon.TabIndex = 4
        Me.l_TongHoaDon.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(599, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tong mon: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(599, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Khuyen mai:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(599, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tong tien"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(380, 428)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 505)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.l_TongHoaDon)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.l_KhuyenMai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.l_TongMon)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_dsMonAnDonHang)
        Me.Controls.Add(Me.dgv_dsMonAn)
        Me.Controls.Add(Me.cb_dsChiNhanh)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_dsMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dsMonAnDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_dsChiNhanh As ComboBox
    Friend WithEvents dgv_dsMonAn As DataGridView
    Friend WithEvents dgv_dsMonAnDonHang As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents l_TongMon As Label
    Friend WithEvents l_KhuyenMai As Label
    Friend WithEvents l_TongHoaDon As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanVien
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tb_TenDangNhap = New System.Windows.Forms.TextBox()
        Me.tb_MatKhau = New System.Windows.Forms.TextBox()
        Me.tb_HoTen = New System.Windows.Forms.TextBox()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_DiaChi = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(571, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tb_TenDangNhap
        '
        Me.tb_TenDangNhap.Location = New System.Drawing.Point(575, 29)
        Me.tb_TenDangNhap.Name = "tb_TenDangNhap"
        Me.tb_TenDangNhap.Size = New System.Drawing.Size(100, 20)
        Me.tb_TenDangNhap.TabIndex = 7
        '
        'tb_MatKhau
        '
        Me.tb_MatKhau.Location = New System.Drawing.Point(571, 67)
        Me.tb_MatKhau.Name = "tb_MatKhau"
        Me.tb_MatKhau.Size = New System.Drawing.Size(100, 20)
        Me.tb_MatKhau.TabIndex = 7
        '
        'tb_HoTen
        '
        Me.tb_HoTen.Location = New System.Drawing.Point(575, 108)
        Me.tb_HoTen.Name = "tb_HoTen"
        Me.tb_HoTen.Size = New System.Drawing.Size(100, 20)
        Me.tb_HoTen.TabIndex = 7
        '
        'tb_Email
        '
        Me.tb_Email.Location = New System.Drawing.Point(571, 134)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(100, 20)
        Me.tb_Email.TabIndex = 7
        '
        'tb_DiaChi
        '
        Me.tb_DiaChi.Location = New System.Drawing.Point(571, 169)
        Me.tb_DiaChi.Name = "tb_DiaChi"
        Me.tb_DiaChi.Size = New System.Drawing.Size(100, 20)
        Me.tb_DiaChi.TabIndex = 7
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 359)
        Me.Controls.Add(Me.tb_DiaChi)
        Me.Controls.Add(Me.tb_Email)
        Me.Controls.Add(Me.tb_HoTen)
        Me.Controls.Add(Me.tb_MatKhau)
        Me.Controls.Add(Me.tb_TenDangNhap)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tb_TenDangNhap As TextBox
    Friend WithEvents tb_MatKhau As TextBox
    Friend WithEvents tb_HoTen As TextBox
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents tb_DiaChi As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonAn
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
        Me.dgv_dsMonAn = New System.Windows.Forms.DataGridView()
        Me.tb_Ten = New System.Windows.Forms.TextBox()
        Me.tb_Gia = New System.Windows.Forms.TextBox()
        Me.tb_MoTa = New System.Windows.Forms.TextBox()
        Me.cb_DanhMuc = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_dsMonAn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dsMonAn
        '
        Me.dgv_dsMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsMonAn.Location = New System.Drawing.Point(12, 73)
        Me.dgv_dsMonAn.Name = "dgv_dsMonAn"
        Me.dgv_dsMonAn.Size = New System.Drawing.Size(521, 281)
        Me.dgv_dsMonAn.TabIndex = 0
        '
        'tb_Ten
        '
        Me.tb_Ten.Location = New System.Drawing.Point(597, 80)
        Me.tb_Ten.Name = "tb_Ten"
        Me.tb_Ten.Size = New System.Drawing.Size(100, 20)
        Me.tb_Ten.TabIndex = 1
        '
        'tb_Gia
        '
        Me.tb_Gia.Location = New System.Drawing.Point(597, 116)
        Me.tb_Gia.Name = "tb_Gia"
        Me.tb_Gia.Size = New System.Drawing.Size(100, 20)
        Me.tb_Gia.TabIndex = 1
        '
        'tb_MoTa
        '
        Me.tb_MoTa.Location = New System.Drawing.Point(597, 153)
        Me.tb_MoTa.Name = "tb_MoTa"
        Me.tb_MoTa.Size = New System.Drawing.Size(100, 20)
        Me.tb_MoTa.TabIndex = 1
        '
        'cb_DanhMuc
        '
        Me.cb_DanhMuc.FormattingEnabled = True
        Me.cb_DanhMuc.Location = New System.Drawing.Point(597, 198)
        Me.cb_DanhMuc.Name = "cb_DanhMuc"
        Me.cb_DanhMuc.Size = New System.Drawing.Size(121, 21)
        Me.cb_DanhMuc.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 45)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMonAn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 440)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cb_DanhMuc)
        Me.Controls.Add(Me.tb_MoTa)
        Me.Controls.Add(Me.tb_Gia)
        Me.Controls.Add(Me.tb_Ten)
        Me.Controls.Add(Me.dgv_dsMonAn)
        Me.Name = "frmMonAn"
        Me.Text = "frmMonAn"
        CType(Me.dgv_dsMonAn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dsMonAn As DataGridView
    Friend WithEvents tb_Ten As TextBox
    Friend WithEvents tb_Gia As TextBox
    Friend WithEvents tb_MoTa As TextBox
    Friend WithEvents cb_DanhMuc As ComboBox
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiNhanh
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
        Me.dgv_dsChiNhanh = New System.Windows.Forms.DataGridView()
        Me.tb_Ten = New System.Windows.Forms.TextBox()
        Me.tb_DiaChi = New System.Windows.Forms.TextBox()
        Me.btn_Them = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        CType(Me.dgv_dsChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dsChiNhanh
        '
        Me.dgv_dsChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsChiNhanh.Location = New System.Drawing.Point(27, 22)
        Me.dgv_dsChiNhanh.Name = "dgv_dsChiNhanh"
        Me.dgv_dsChiNhanh.Size = New System.Drawing.Size(271, 212)
        Me.dgv_dsChiNhanh.TabIndex = 0
        '
        'tb_Ten
        '
        Me.tb_Ten.Location = New System.Drawing.Point(359, 33)
        Me.tb_Ten.Name = "tb_Ten"
        Me.tb_Ten.Size = New System.Drawing.Size(100, 20)
        Me.tb_Ten.TabIndex = 1
        '
        'tb_DiaChi
        '
        Me.tb_DiaChi.Location = New System.Drawing.Point(359, 59)
        Me.tb_DiaChi.Name = "tb_DiaChi"
        Me.tb_DiaChi.Size = New System.Drawing.Size(100, 20)
        Me.tb_DiaChi.TabIndex = 1
        '
        'btn_Them
        '
        Me.btn_Them.Location = New System.Drawing.Point(343, 105)
        Me.btn_Them.Name = "btn_Them"
        Me.btn_Them.Size = New System.Drawing.Size(75, 23)
        Me.btn_Them.TabIndex = 2
        Me.btn_Them.Text = "Them"
        Me.btn_Them.UseVisualStyleBackColor = True
        '
        'btn_Menu
        '
        Me.btn_Menu.Location = New System.Drawing.Point(343, 155)
        Me.btn_Menu.Name = "btn_Menu"
        Me.btn_Menu.Size = New System.Drawing.Size(134, 23)
        Me.btn_Menu.TabIndex = 2
        Me.btn_Menu.Text = "menu chi nhanh"
        Me.btn_Menu.UseVisualStyleBackColor = True
        '
        'frmChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 279)
        Me.Controls.Add(Me.btn_Menu)
        Me.Controls.Add(Me.btn_Them)
        Me.Controls.Add(Me.tb_DiaChi)
        Me.Controls.Add(Me.tb_Ten)
        Me.Controls.Add(Me.dgv_dsChiNhanh)
        Me.Name = "frmChiNhanh"
        Me.Text = "frmChiNhanh"
        CType(Me.dgv_dsChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dsChiNhanh As DataGridView
    Friend WithEvents tb_Ten As TextBox
    Friend WithEvents tb_DiaChi As TextBox
    Friend WithEvents btn_Them As Button
    Friend WithEvents btn_Menu As Button
End Class

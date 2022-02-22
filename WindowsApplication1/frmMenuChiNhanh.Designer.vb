<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuChiNhanh
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
        Me.dgv_dsMon = New System.Windows.Forms.DataGridView()
        Me.dgv_dsMonChiNhanh = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgv_dsMon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_dsMonChiNhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_dsMon
        '
        Me.dgv_dsMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsMon.Location = New System.Drawing.Point(28, 33)
        Me.dgv_dsMon.Name = "dgv_dsMon"
        Me.dgv_dsMon.Size = New System.Drawing.Size(307, 321)
        Me.dgv_dsMon.TabIndex = 0
        '
        'dgv_dsMonChiNhanh
        '
        Me.dgv_dsMonChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dsMonChiNhanh.Location = New System.Drawing.Point(475, 33)
        Me.dgv_dsMonChiNhanh.Name = "dgv_dsMonChiNhanh"
        Me.dgv_dsMonChiNhanh.Size = New System.Drawing.Size(307, 321)
        Me.dgv_dsMonChiNhanh.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(356, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(368, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMenuChiNhanh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 495)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv_dsMonChiNhanh)
        Me.Controls.Add(Me.dgv_dsMon)
        Me.Name = "frmMenuChiNhanh"
        Me.Text = "frmMenuChiNhanh"
        CType(Me.dgv_dsMon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_dsMonChiNhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_dsMon As DataGridView
    Friend WithEvents dgv_dsMonChiNhanh As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class

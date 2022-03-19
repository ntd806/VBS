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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtIsblock = New System.Windows.Forms.ComboBox()
        Me.ChonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet2 = New WindowsApplication1._1781006u1DataSet2()
        Me.b = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.ComboBox()
        Me.PermitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet = New WindowsApplication1._1781006u1DataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PermitionTableAdapter = New WindowsApplication1._1781006u1DataSetTableAdapters.permitionTableAdapter()
        Me.ChonTableAdapter = New WindowsApplication1._1781006u1DataSet2TableAdapters.chonTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btResetPassword = New System.Windows.Forms.Button()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ChonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 15)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(713, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 20)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Thêm"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(19, 62)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(132, 22)
        Me.txtId.TabIndex = 7
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(19, 146)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(132, 22)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(18, 224)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(132, 22)
        Me.txtPassword.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(19, 304)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(132, 22)
        Me.txtPhone.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtIsblock)
        Me.Panel1.Controls.Add(Me.b)
        Me.Panel1.Controls.Add(Me.txtRole)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(789, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 418)
        Me.Panel1.TabIndex = 8
        '
        'txtIsblock
        '
        Me.txtIsblock.DataSource = Me.ChonBindingSource
        Me.txtIsblock.DisplayMember = "chon"
        Me.txtIsblock.FormattingEnabled = True
        Me.txtIsblock.Location = New System.Drawing.Point(177, 372)
        Me.txtIsblock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIsblock.Name = "txtIsblock"
        Me.txtIsblock.Size = New System.Drawing.Size(160, 24)
        Me.txtIsblock.TabIndex = 9
        Me.txtIsblock.ValueMember = "chon"
        '
        'ChonBindingSource
        '
        Me.ChonBindingSource.DataMember = "chon"
        Me.ChonBindingSource.DataSource = Me._1781006u1DataSet2
        '
        '_1781006u1DataSet2
        '
        Me._1781006u1DataSet2.DataSetName = "_1781006u1DataSet2"
        Me._1781006u1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'b
        '
        Me.b.AutoSize = True
        Me.b.Location = New System.Drawing.Point(173, 350)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(163, 16)
        Me.b.TabIndex = 20
        Me.b.Text = "Block nhập 1 mở 0 là khóa"
        '
        'txtRole
        '
        Me.txtRole.DataSource = Me.PermitionBindingSource
        Me.txtRole.DisplayMember = "name"
        Me.txtRole.FormattingEnabled = True
        Me.txtRole.Location = New System.Drawing.Point(19, 372)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(121, 24)
        Me.txtRole.TabIndex = 9
        Me.txtRole.ValueMember = "name"
        '
        'PermitionBindingSource
        '
        Me.PermitionBindingSource.DataMember = "permition"
        Me.PermitionBindingSource.DataSource = Me._1781006u1DataSet
        '
        '_1781006u1DataSet
        '
        Me._1781006u1DataSet.DataSetName = "_1781006u1DataSet"
        Me._1781006u1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(217, 224)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Khóa tài khoản"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(217, 163)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Xóa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 89)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Sửa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID"
        '
        'PermitionTableAdapter
        '
        Me.PermitionTableAdapter.ClearBeforeFill = True
        '
        'ChonTableAdapter
        '
        Me.ChonTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btResetPassword)
        Me.Panel2.Controls.Add(Me.txtConfirm)
        Me.Panel2.Controls.Add(Me.txtNewPass)
        Me.Panel2.Controls.Add(Me.txtOldPass)
        Me.Panel2.Location = New System.Drawing.Point(1213, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 418)
        Me.Panel2.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nhập lại mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Mật khẩu mới"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mật khẩu cũ"
        '
        'btResetPassword
        '
        Me.btResetPassword.Location = New System.Drawing.Point(243, 248)
        Me.btResetPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.btResetPassword.Name = "btResetPassword"
        Me.btResetPassword.Size = New System.Drawing.Size(100, 28)
        Me.btResetPassword.TabIndex = 21
        Me.btResetPassword.Text = "Đổi mật khẩu"
        Me.btResetPassword.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(16, 254)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(132, 22)
        Me.txtConfirm.TabIndex = 23
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(16, 163)
        Me.txtNewPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(132, 22)
        Me.txtNewPass.TabIndex = 22
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(16, 71)
        Me.txtOldPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(132, 22)
        Me.txtOldPass.TabIndex = 21
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1636, 605)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmNhanVien"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRole As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents _1781006u1DataSet As _1781006u1DataSet
    Friend WithEvents PermitionBindingSource As BindingSource
    Friend WithEvents PermitionTableAdapter As _1781006u1DataSetTableAdapters.permitionTableAdapter
    Friend WithEvents b As Label
    Friend WithEvents txtIsblock As ComboBox
    Friend WithEvents _1781006u1DataSet2 As _1781006u1DataSet2
    Friend WithEvents ChonBindingSource As BindingSource
    Friend WithEvents ChonTableAdapter As _1781006u1DataSet2TableAdapters.chonTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btResetPassword As Button
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

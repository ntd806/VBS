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
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtsex = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCMND = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAdress = New System.Windows.Forms.TextBox()
        Me.txtIsblock = New System.Windows.Forms.ComboBox()
        Me.ChosseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDataSet2 = New WindowsApplication1.hotelDataSet2()
        Me.txtRole = New System.Windows.Forms.ComboBox()
        Me.PermitionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDataSet1 = New WindowsApplication1.hotelDataSet1()
        Me.btblock = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet2 = New WindowsApplication1._1781006u1DataSet2()
        Me.PermitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet = New WindowsApplication1._1781006u1DataSet()
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
        Me.PermitionTableAdapter1 = New WindowsApplication1.hotelDataSet1TableAdapters.permitionTableAdapter()
        Me.ChosseTableAdapter = New WindowsApplication1.hotelDataSet2TableAdapters.chosseTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ChosseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermitionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(473, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(325, 16)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 6
        Me.btAdd.Text = "Thêm"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(14, 23)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 7
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(14, 93)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(14, 155)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(3, 222)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Txtsex)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Txtname)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtCMND)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtAdress)
        Me.Panel1.Controls.Add(Me.txtIsblock)
        Me.Panel1.Controls.Add(Me.txtRole)
        Me.Panel1.Controls.Add(Me.btblock)
        Me.Panel1.Controls.Add(Me.btDelete)
        Me.Panel1.Controls.Add(Me.btEdit)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.btAdd)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(503, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 340)
        Me.Panel1.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 182)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "gioi tinh"
        '
        'Txtsex
        '
        Me.Txtsex.Location = New System.Drawing.Point(300, 206)
        Me.Txtsex.Name = "Txtsex"
        Me.Txtsex.Size = New System.Drawing.Size(100, 20)
        Me.Txtsex.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(5, 247)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "chon: 0 mo 1 khoa "
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(136, 104)
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(100, 20)
        Me.Txtname.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(143, 88)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Ho ten"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CMND"
        '
        'TxtCMND
        '
        Me.TxtCMND.Location = New System.Drawing.Point(136, 50)
        Me.TxtCMND.Name = "TxtCMND"
        Me.TxtCMND.Size = New System.Drawing.Size(100, 20)
        Me.TxtCMND.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(231, 96)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Ngay sinh"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 132)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 182)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "diachi"
        '
        'TxtAdress
        '
        Me.TxtAdress.Location = New System.Drawing.Point(191, 206)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(100, 20)
        Me.TxtAdress.TabIndex = 19
        '
        'txtIsblock
        '
        Me.txtIsblock.DataSource = Me.ChosseBindingSource
        Me.txtIsblock.DisplayMember = "type"
        Me.txtIsblock.FormattingEnabled = True
        Me.txtIsblock.Location = New System.Drawing.Point(3, 271)
        Me.txtIsblock.Name = "txtIsblock"
        Me.txtIsblock.Size = New System.Drawing.Size(121, 21)
        Me.txtIsblock.TabIndex = 9
        Me.txtIsblock.ValueMember = "type"
        '
        'ChosseBindingSource
        '
        Me.ChosseBindingSource.DataMember = "chosse"
        Me.ChosseBindingSource.DataSource = Me.HotelDataSet2
        '
        'HotelDataSet2
        '
        Me.HotelDataSet2.DataSetName = "hotelDataSet2"
        Me.HotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtRole
        '
        Me.txtRole.DataSource = Me.PermitionBindingSource1
        Me.txtRole.DisplayMember = "name"
        Me.txtRole.FormattingEnabled = True
        Me.txtRole.Location = New System.Drawing.Point(199, 262)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(92, 21)
        Me.txtRole.TabIndex = 9
        Me.txtRole.ValueMember = "name"
        '
        'PermitionBindingSource1
        '
        Me.PermitionBindingSource1.DataMember = "permition"
        Me.PermitionBindingSource1.DataSource = Me.HotelDataSet1
        '
        'HotelDataSet1
        '
        Me.HotelDataSet1.DataSetName = "hotelDataSet1"
        Me.HotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btblock
        '
        Me.btblock.Location = New System.Drawing.Point(244, 58)
        Me.btblock.Name = "btblock"
        Me.btblock.Size = New System.Drawing.Size(75, 23)
        Me.btblock.TabIndex = 18
        Me.btblock.Text = "Khóa tài khoản"
        Me.btblock.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(325, 56)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 17
        Me.btDelete.Text = "Xóa"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(244, 16)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 16
        Me.btEdit.Text = "Sửa"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 193)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 247)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID"
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
        Me.Panel2.Location = New System.Drawing.Point(910, 12)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 340)
        Me.Panel2.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 182)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Nhập lại mật khẩu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Mật khẩu mới"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Mật khẩu cũ"
        '
        'btResetPassword
        '
        Me.btResetPassword.Location = New System.Drawing.Point(182, 202)
        Me.btResetPassword.Name = "btResetPassword"
        Me.btResetPassword.Size = New System.Drawing.Size(75, 23)
        Me.btResetPassword.TabIndex = 21
        Me.btResetPassword.Text = "Đổi mật khẩu"
        Me.btResetPassword.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Location = New System.Drawing.Point(12, 206)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirm.TabIndex = 23
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(12, 132)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPass.TabIndex = 22
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(12, 58)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(100, 20)
        Me.txtOldPass.TabIndex = 21
        '
        'PermitionTableAdapter1
        '
        Me.PermitionTableAdapter1.ClearBeforeFill = True
        '
        'ChosseTableAdapter
        '
        Me.ChosseTableAdapter.ClearBeforeFill = True
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 492)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmNhanVien"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ChosseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermitionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btAdd As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRole As ComboBox
    Friend WithEvents btblock As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents _1781006u1DataSet As _1781006u1DataSet
    Friend WithEvents PermitionBindingSource As BindingSource
    Friend WithEvents PermitionTableAdapter As _1781006u1DataSetTableAdapters.permitionTableAdapter
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
    Friend WithEvents HotelDataSet1 As hotelDataSet1
    Friend WithEvents PermitionBindingSource1 As BindingSource
    Friend WithEvents PermitionTableAdapter1 As hotelDataSet1TableAdapters.permitionTableAdapter
    Friend WithEvents HotelDataSet2 As hotelDataSet2
    Friend WithEvents ChosseBindingSource As BindingSource
    Friend WithEvents ChosseTableAdapter As hotelDataSet2TableAdapters.chosseTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtCMND As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAdress As TextBox
    Friend WithEvents Txtname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Txtsex As TextBox
End Class

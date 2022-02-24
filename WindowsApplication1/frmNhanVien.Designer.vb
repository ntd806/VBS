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
        Me.Them = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPermitId = New System.Windows.Forms.ComboBox()
        Me.PermitsionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006VBDataSet = New WindowsApplication1._1781006VBDataSet()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.TxtBlock = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PermitsionTableAdapter = New WindowsApplication1._1781006VBDataSetTableAdapters.permitsionTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.ComboBox()
        Me._1781006VBDataSet1 = New WindowsApplication1._1781006VBDataSet1()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New WindowsApplication1._1781006VBDataSet1TableAdapters.customerTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PermitsionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006VBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006VBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(793, 335)
        Me.DataGridView1.TabIndex = 0
        '
        'Them
        '
        Me.Them.Location = New System.Drawing.Point(1241, 437)
        Me.Them.Name = "Them"
        Me.Them.Size = New System.Drawing.Size(75, 23)
        Me.Them.TabIndex = 6
        Me.Them.Text = "Them"
        Me.Them.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1339, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1232, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1339, 504)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtPermitId)
        Me.Panel1.Controls.Add(Me.TxtAddress)
        Me.Panel1.Controls.Add(Me.TxtUsername)
        Me.Panel1.Controls.Add(Me.TxtEmail)
        Me.Panel1.Controls.Add(Me.TxtPhone)
        Me.Panel1.Controls.Add(Me.TxtPass)
        Me.Panel1.Controls.Add(Me.TxtBlock)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(853, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 321)
        Me.Panel1.TabIndex = 10
        '
        'TxtPermitId
        '
        Me.TxtPermitId.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PermitsionBindingSource, "id", True))
        Me.TxtPermitId.DataSource = Me.PermitsionBindingSource
        Me.TxtPermitId.DisplayMember = "name"
        Me.TxtPermitId.FormattingEnabled = True
        Me.TxtPermitId.Location = New System.Drawing.Point(418, 116)
        Me.TxtPermitId.Name = "TxtPermitId"
        Me.TxtPermitId.Size = New System.Drawing.Size(121, 21)
        Me.TxtPermitId.TabIndex = 20
        Me.TxtPermitId.ValueMember = "id"
        '
        'PermitsionBindingSource
        '
        Me.PermitsionBindingSource.DataMember = "permitsion"
        Me.PermitsionBindingSource.DataSource = Me._1781006VBDataSet
        '
        '_1781006VBDataSet
        '
        Me._1781006VBDataSet.DataSetName = "_1781006VBDataSet"
        Me._1781006VBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(21, 118)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(100, 20)
        Me.TxtAddress.TabIndex = 19
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(21, 217)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(100, 20)
        Me.TxtUsername.TabIndex = 18
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(231, 32)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(100, 20)
        Me.TxtEmail.TabIndex = 17
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(231, 118)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(100, 20)
        Me.TxtPhone.TabIndex = 16
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(418, 32)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 15
        '
        'TxtBlock
        '
        Me.TxtBlock.Location = New System.Drawing.Point(231, 217)
        Me.TxtBlock.Name = "TxtBlock"
        Me.TxtBlock.Size = New System.Drawing.Size(100, 20)
        Me.TxtBlock.TabIndex = 12
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(21, 32)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "permit_id"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "pass"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "block"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(228, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "usename"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "name"
        '
        'PermitsionTableAdapter
        '
        Me.PermitsionTableAdapter.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(424, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "id"
        '
        'TxtId
        '
        Me.TxtId.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PermitsionBindingSource, "id", True))
        Me.TxtId.DataSource = Me.CustomerBindingSource
        Me.TxtId.DisplayMember = "id"
        Me.TxtId.FormattingEnabled = True
        Me.TxtId.Location = New System.Drawing.Point(427, 217)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(121, 21)
        Me.TxtId.TabIndex = 22
        Me.TxtId.ValueMember = "id"
        '
        '_1781006VBDataSet1
        '
        Me._1781006VBDataSet1.DataSetName = "_1781006VBDataSet1"
        Me._1781006VBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me._1781006VBDataSet1
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'frmNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Them)
        Me.Name = "frmNhanVien"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PermitsionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006VBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006VBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Them As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPermitId As ComboBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents TxtBlock As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _1781006VBDataSet As _1781006VBDataSet
    Friend WithEvents PermitsionBindingSource As BindingSource
    Friend WithEvents PermitsionTableAdapter As _1781006VBDataSetTableAdapters.permitsionTableAdapter
    Friend WithEvents TxtId As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents _1781006VBDataSet1 As _1781006VBDataSet1
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As _1781006VBDataSet1TableAdapters.customerTableAdapter
End Class

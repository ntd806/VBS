<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.txtRole = New System.Windows.Forms.ComboBox()
        Me.PermitionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication1.DataSet1()
        Me.PermitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet1 = New WindowsApplication1._1781006u1DataSet1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PermitionTableAdapter = New WindowsApplication1._1781006u1DataSet1TableAdapters.permitionTableAdapter()
        Me.PermitionTableAdapter1 = New WindowsApplication1.DataSet1TableAdapters.permitionTableAdapter()
        Me.HotelDataSet = New WindowsApplication1.hotelDataSet()
        Me.PermitionBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PermitionTableAdapter2 = New WindowsApplication1.hotelDataSetTableAdapters.permitionTableAdapter()
        CType(Me.PermitionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermitionBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(233, 67)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(190, 20)
        Me.txtUser.TabIndex = 2
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(233, 166)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(190, 20)
        Me.txtPass.TabIndex = 3
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(359, 264)
        Me.btLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(56, 19)
        Me.btLogin.TabIndex = 4
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'txtRole
        '
        Me.txtRole.DataSource = Me.PermitionBindingSource2
        Me.txtRole.DisplayMember = "name"
        Me.txtRole.FormattingEnabled = True
        Me.txtRole.Location = New System.Drawing.Point(233, 225)
        Me.txtRole.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRole.Name = "txtRole"
        Me.txtRole.Size = New System.Drawing.Size(92, 21)
        Me.txtRole.TabIndex = 5
        Me.txtRole.ValueMember = "name"
        '
        'PermitionBindingSource1
        '
        Me.PermitionBindingSource1.DataMember = "permition"
        Me.PermitionBindingSource1.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PermitionBindingSource
        '
        Me.PermitionBindingSource.DataMember = "permition"
        Me.PermitionBindingSource.DataSource = Me._1781006u1DataSet1
        '
        '_1781006u1DataSet1
        '
        Me._1781006u1DataSet1.DataSetName = "_1781006u1DataSet1"
        Me._1781006u1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(231, 202)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Chức Danh"
        '
        'PermitionTableAdapter
        '
        Me.PermitionTableAdapter.ClearBeforeFill = True
        '
        'PermitionTableAdapter1
        '
        Me.PermitionTableAdapter1.ClearBeforeFill = True
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "hotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PermitionBindingSource2
        '
        Me.PermitionBindingSource2.DataMember = "permition"
        Me.PermitionBindingSource2.DataSource = Me.HotelDataSet
        '
        'PermitionTableAdapter2
        '
        Me.PermitionTableAdapter2.ClearBeforeFill = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "login"
        Me.Text = "login"
        CType(Me.PermitionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermitionBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btLogin As Button
    Friend WithEvents txtRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents _1781006u1DataSet1 As _1781006u1DataSet1
    Friend WithEvents PermitionBindingSource As BindingSource
    Friend WithEvents PermitionTableAdapter As _1781006u1DataSet1TableAdapters.permitionTableAdapter
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PermitionBindingSource1 As BindingSource
    Friend WithEvents PermitionTableAdapter1 As DataSet1TableAdapters.permitionTableAdapter
    Friend WithEvents HotelDataSet As hotelDataSet
    Friend WithEvents PermitionBindingSource2 As BindingSource
    Friend WithEvents PermitionTableAdapter2 As hotelDataSetTableAdapters.permitionTableAdapter
End Class

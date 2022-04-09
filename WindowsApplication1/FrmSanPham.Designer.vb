<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSanPham
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet3 = New WindowsApplication1._1781006u1DataSet3()
        Me.ProductTableAdapter = New WindowsApplication1._1781006u1DataSet3TableAdapters.productTableAdapter()
        Me.txtCateId = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet5 = New WindowsApplication1._1781006u1DataSet5()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.td = New System.Windows.Forms.Label()
        Me.size = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.CategoryTableAdapter = New WindowsApplication1._1781006u1DataSet5TableAdapters.categoryTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UpdateatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedatDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.WeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CateidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Location = New System.Drawing.Point(4, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1352, 368)
        Me.Panel1.TabIndex = 0
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "product"
        Me.ProductBindingSource.DataSource = Me._1781006u1DataSet3
        '
        '_1781006u1DataSet3
        '
        Me._1781006u1DataSet3.DataSetName = "_1781006u1DataSet3"
        Me._1781006u1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'txtCateId
        '
        Me.txtCateId.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CategoryBindingSource, "name", True))
        Me.txtCateId.DataSource = Me.CategoryBindingSource
        Me.txtCateId.DisplayMember = "id"
        Me.txtCateId.FormattingEnabled = True
        Me.txtCateId.Location = New System.Drawing.Point(41, 544)
        Me.txtCateId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCateId.Name = "txtCateId"
        Me.txtCateId.Size = New System.Drawing.Size(160, 24)
        Me.txtCateId.TabIndex = 1
        Me.txtCateId.ValueMember = "id"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "category"
        Me.CategoryBindingSource.DataSource = Me._1781006u1DataSet5
        '
        '_1781006u1DataSet5
        '
        Me._1781006u1DataSet5.DataSetName = "_1781006u1DataSet5"
        Me._1781006u1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 510)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "cate_id"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(32, 425)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 22)
        Me.txtName.TabIndex = 3
        '
        'td
        '
        Me.td.AutoSize = True
        Me.td.Location = New System.Drawing.Point(29, 405)
        Me.td.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(44, 16)
        Me.td.TabIndex = 4
        Me.td.Text = "Name"
        '
        'size
        '
        Me.size.AutoSize = True
        Me.size.Location = New System.Drawing.Point(233, 402)
        Me.size.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(31, 16)
        Me.size.TabIndex = 5
        Me.size.Text = "size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(468, 402)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(721, 405)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "width"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(724, 434)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(160, 22)
        Me.txtWidth.TabIndex = 8
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(236, 434)
        Me.txtSize.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(160, 22)
        Me.txtSize.TabIndex = 9
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(480, 445)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(160, 22)
        Me.txtHeight.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 603)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "weight"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(32, 646)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(160, 22)
        Me.txtWeight.TabIndex = 12
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(513, 646)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(100, 28)
        Me.btAdd.TabIndex = 13
        Me.btAdd.Text = "Thêm"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(873, 643)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(100, 28)
        Me.btEdit.TabIndex = 14
        Me.btEdit.Text = "Sửa"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(692, 646)
        Me.btDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(100, 28)
        Me.btDelete.TabIndex = 15
        Me.btDelete.Text = "Xóa"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(986, 414)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Id"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(989, 457)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(160, 22)
        Me.txtId.TabIndex = 17
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(277, 646)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 599)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "price"
        '
        'UpdateatDataGridViewTextBoxColumn
        '
        Me.UpdateatDataGridViewTextBoxColumn.DataPropertyName = "update_at"
        Me.UpdateatDataGridViewTextBoxColumn.HeaderText = "update_at"
        Me.UpdateatDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UpdateatDataGridViewTextBoxColumn.Name = "UpdateatDataGridViewTextBoxColumn"
        Me.UpdateatDataGridViewTextBoxColumn.Width = 125
        '
        'CreatedatDataGridViewImageColumn
        '
        Me.CreatedatDataGridViewImageColumn.DataPropertyName = "created_at"
        Me.CreatedatDataGridViewImageColumn.HeaderText = "created_at"
        Me.CreatedatDataGridViewImageColumn.MinimumWidth = 6
        Me.CreatedatDataGridViewImageColumn.Name = "CreatedatDataGridViewImageColumn"
        Me.CreatedatDataGridViewImageColumn.ReadOnly = True
        Me.CreatedatDataGridViewImageColumn.Width = 125
        '
        'WeightDataGridViewTextBoxColumn
        '
        Me.WeightDataGridViewTextBoxColumn.DataPropertyName = "weight"
        Me.WeightDataGridViewTextBoxColumn.HeaderText = "weight"
        Me.WeightDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WeightDataGridViewTextBoxColumn.Name = "WeightDataGridViewTextBoxColumn"
        Me.WeightDataGridViewTextBoxColumn.Width = 125
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "width"
        Me.WidthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        Me.WidthDataGridViewTextBoxColumn.Width = 125
        '
        'HeightDataGridViewTextBoxColumn
        '
        Me.HeightDataGridViewTextBoxColumn.DataPropertyName = "height"
        Me.HeightDataGridViewTextBoxColumn.HeaderText = "height"
        Me.HeightDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HeightDataGridViewTextBoxColumn.Name = "HeightDataGridViewTextBoxColumn"
        Me.HeightDataGridViewTextBoxColumn.Width = 125
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "size"
        Me.SizeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'CateidDataGridViewTextBoxColumn
        '
        Me.CateidDataGridViewTextBoxColumn.DataPropertyName = "cate_id"
        Me.CateidDataGridViewTextBoxColumn.HeaderText = "cate_id"
        Me.CateidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CateidDataGridViewTextBoxColumn.Name = "CateidDataGridViewTextBoxColumn"
        Me.CateidDataGridViewTextBoxColumn.Width = 125
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CateidDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.HeightDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.WeightDataGridViewTextBoxColumn, Me.CreatedatDataGridViewImageColumn, Me.UpdateatDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ProductBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(11, 4)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.Size = New System.Drawing.Size(1310, 364)
        Me.DataGridView3.TabIndex = 0
        '
        'FrmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1620, 821)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.size)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCateId)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmSanPham"
        Me.Text = "FrmSanPham"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents _1781006u1DataSet3 As _1781006u1DataSet3
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As _1781006u1DataSet3TableAdapters.productTableAdapter
    Friend WithEvents txtCateId As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents td As Label
    Friend WithEvents size As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents btAdd As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents _1781006u1DataSet5 As _1781006u1DataSet5
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As _1781006u1DataSet5TableAdapters.categoryTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CateidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedatDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents UpdateatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

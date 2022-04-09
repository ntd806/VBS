
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoaiSanPham
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpyeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._1781006u1DataSet4 = New WindowsApplication1._1781006u1DataSet4()
        Me.CategoryTableAdapter = New WindowsApplication1._1781006u1DataSet4TableAdapters.categoryTableAdapter()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.txtCateName = New System.Windows.Forms.TextBox()
        Me.txtCateType = New System.Windows.Forms.TextBox()
        Me.lba = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._1781006u1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 358)
        Me.Panel1.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TpyeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CategoryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(19, 18)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(352, 352)
        Me.DataGridView2.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TpyeDataGridViewTextBoxColumn
        '
        Me.TpyeDataGridViewTextBoxColumn.DataPropertyName = "tpye"
        Me.TpyeDataGridViewTextBoxColumn.HeaderText = "tpye"
        Me.TpyeDataGridViewTextBoxColumn.Name = "TpyeDataGridViewTextBoxColumn"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "category"
        Me.CategoryBindingSource.DataSource = Me._1781006u1DataSet4
        '
        '_1781006u1DataSet4
        '
        Me._1781006u1DataSet4.DataSetName = "_1781006u1DataSet4"
        Me._1781006u1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(686, 347)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(75, 23)
        Me.btAdd.TabIndex = 1
        Me.btAdd.Text = "Them"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(581, 347)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(75, 23)
        Me.btDelete.TabIndex = 2
        Me.btDelete.Text = "Xoa"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(468, 347)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(75, 23)
        Me.btEdit.TabIndex = 3
        Me.btEdit.Text = "Sua"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'txtCateName
        '
        Me.txtCateName.Location = New System.Drawing.Point(443, 41)
        Me.txtCateName.Name = "txtCateName"
        Me.txtCateName.Size = New System.Drawing.Size(128, 20)
        Me.txtCateName.TabIndex = 4
        '
        'txtCateType
        '
        Me.txtCateType.Location = New System.Drawing.Point(443, 135)
        Me.txtCateType.Name = "txtCateType"
        Me.txtCateType.Size = New System.Drawing.Size(128, 20)
        Me.txtCateType.TabIndex = 5
        '
        'lba
        '
        Me.lba.AutoSize = True
        Me.lba.Location = New System.Drawing.Point(440, 18)
        Me.lba.Name = "lba"
        Me.lba.Size = New System.Drawing.Size(45, 13)
        Me.lba.TabIndex = 6
        Me.lba.Text = "Tên loại"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kiểu loại"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(443, 214)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID"
        '
        'FrmLoaiSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lba)
        Me.Controls.Add(Me.txtCateType)
        Me.Controls.Add(Me.txtCateName)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btDelete)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmLoaiSanPham"
        Me.Text = "FrmLoaiSanPham"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._1781006u1DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents _1781006u1DataSet4 As _1781006u1DataSet4
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryTableAdapter As _1781006u1DataSet4TableAdapters.categoryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TpyeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btAdd As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents txtCateName As TextBox
    Friend WithEvents txtCateType As TextBox
    Friend WithEvents lba As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
End Class

Public Class frmNhanVien
    Dim dsNhanVien As DataTable
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_1781006VBDataSet1.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me._1781006VBDataSet1.customer)
        'TODO: This line of code loads data into the '_1781006VBDataSet.permitsion' table. You can move, or remove it, as needed.
        Me.PermitsionTableAdapter.Fill(Me._1781006VBDataSet.permitsion)
        Dim sql As String = "Select * from customer"
        dsNhanVien = XL_DuLieu.DocDuLieu(sql)

        DataGridView1.DataSource = dsNhanVien
    End Sub

    Private Sub Them_Click(sender As Object, e As EventArgs) Handles Them.Click
        Dim user As customer = getUser()
        Dim sql As String = "INSERT INTO customer (name,address,usename,email,phone,permit_id,pass,block)
        VALUES ('" + user.name + "', '+" + user.address + "', '" + user.email + "','" + user.phone + "'," + user.permit_id + ", '" + user.pass + "', " + user.block + ")"
        If (XL_DuLieu.ThucHienLenh(sql) = 1) Then
            MessageBox.Show("them ok")
        Else
            MessageBox.Show("khong them duoc")
        End If
    End Sub

    Public Function getUser() As customer
        Dim User As customer = New customer()
        User.name = txtName.Text
        User.address = TxtAddress.Text
        User.block = Convert.ToByte(TxtBlock.Text)
        User.email = TxtEmail.Text
        User.phone = TxtPhone.Text
        User.permit_id = Convert.ToInt32(TxtPermitId.Text)
        User.usename = TxtUsername.Text
        User.pass = TxtPass.Text
        User.id = Convert.ToInt32(TxtId.Text)
        Return User
    End Function
End Class
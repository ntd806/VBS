Imports System.Data.OleDb
Imports System.Data.SqlClient


Module XL_DuLieu
    '/* Data Source=DESKTOP-M6H7GKA\SQLEXPRESS;Initial Catalog=1781006u1;Integrated Security=True*/
    Public ChuoiKetNoi As String = "Provider=SQLOLEDB;Data Source=DESKTOP-M6H7GKA\SQLEXPRESS;Initial Catalog=1781006u1;Integrated Security=SSPI"

    Public Function DocDuLieu(ByVal sql As String) As DataTable
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, ChuoiKetNoi)
        Dim dt As DataTable = New DataTable()
        adapter.Fill(dt)
        Return dt
    End Function

    Public Function DocCauTruc(ByVal sql As String) As DataTable
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(sql, ChuoiKetNoi)
        Dim dt As DataTable = New DataTable()
        adapter.FillSchema(dt, SchemaType.Source)
        Return dt
    End Function

    Public Sub GhiDuLieu(ByVal table As String, ByVal dt As DataTable)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("Select * from " + table, ChuoiKetNoi)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        AddHandler adapter.RowUpdated, AddressOf CapNhatMaSo
        adapter.Update(dt)
    End Sub

    Public Function ThucHienLenh(ByVal sql As String) As Integer
        Dim kq As Integer
        Dim ket_noi As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim cau_lenh As OleDbCommand = New OleDbCommand(sql, ket_noi)
        ket_noi.Open()
        kq = cau_lenh.ExecuteNonQuery()
        ket_noi.Close()
        Return kq
    End Function

    Public Function ThucHienHam(ByVal ten As String) As Integer
        Dim kq As Integer
        Dim ket_noi As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim cau_lenh As OleDbCommand = New OleDbCommand(ten, ket_noi)
        cau_lenh.CommandText = CommandType.StoredProcedure
        ket_noi.Open()
        kq = cau_lenh.ExecuteNonQuery()
        ket_noi.Close()
        Return kq
    End Function

    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Dim Ket_noi As OleDbConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim Lenh As OleDbCommand = New OleDbCommand("Select @@IDENTITY", Ket_noi)
            Dim ma_so As Integer = Integer.Parse(Lenh.ExecuteScalar())
            e.Row(0) = ma_so
        End If
    End Sub

    Public Sub GhiDuLieu1(ByVal table As String, ByVal dt As DataTable)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter("Select * from " + table, ChuoiKetNoi)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        AddHandler adapter.RowUpdated, AddressOf CapNhatMaSo1
        adapter.Update(dt)
    End Sub

    Private Sub CapNhatMaSo1(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Dim Ket_noi As OleDbConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim Lenh As OleDbCommand = New OleDbCommand("Select @@IDENTITY", Ket_noi)
            Dim ma_so As Integer = Integer.Parse(Lenh.ExecuteScalar())
            e.Row(1) = ma_so
        End If
    End Sub
End Module

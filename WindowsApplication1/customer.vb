Public Class customer

	Public Property id As Integer
	Public Property name As String
	Public Property address As String
	Public Property usename As String
	Public Property email As String
	Public Property phone As String
	Public Property permit_id As String
	Public Property type As Integer
	Public Property pass As String
	Public Property block As Byte

	Sub New(ByVal id_ As Integer, ByVal name_ As String, ByVal address_ As String, ByVal usename_ As String, ByVal email_ As String, ByVal phone_ As String, ByVal permit_id_ As String, ByVal type_ As Integer, ByVal pass_ As String, ByVal block_ As Byte)
		Me.id = id_
		Me.name = name_
		Me.address = address_
		Me.usename = usename_
		Me.email = email_
		Me.phone = phone_
		Me.permit_id = permit_id_
		Me.type = type_
		Me.pass = pass_
		Me.block = block_
	End Sub
End Class
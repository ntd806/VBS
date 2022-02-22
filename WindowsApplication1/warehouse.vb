Public Class warehouse

	Public Property id As Integer
	Public Property name As String
	Public Property created_at As Byte()
	Public Property updated_at As DateTime

	Sub New(ByVal id_ As Integer, ByVal name_ As String, ByVal created_at_ As Byte(), ByVal updated_at_ As DateTime)
		Me.id = id_
		Me.name = name_
		Me.created_at = created_at_
		Me.updated_at = updated_at_
	End Sub
End Class
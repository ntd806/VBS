Public Class product

	Public Property id As Integer
	Public Property name As String
	Public Property cate_id As Integer
	Public Property price As Integer
	Public Property created_at As Byte()
	Public Property updated_at As DateTime

	Sub New(ByVal id_ As Integer, ByVal name_ As String, ByVal cate_id_ As Integer, ByVal price_ As Integer, ByVal created_at_ As Byte(), ByVal updated_at_ As DateTime)
		Me.id = id_
		Me.name = name_
		Me.cate_id = cate_id_
		Me.price = price_
		Me.created_at = created_at_
		Me.updated_at = updated_at_
	End Sub
End Class
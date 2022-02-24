Public Class issue

	Public Property id As Integer
	Public Property name As String
	Public Property customer_id As Integer
	Public Property warehouse_id As Integer
	Public Property created_at As Byte()
	Public Property updated_at As DateTime

	Sub New(ByVal id_ As Integer, ByVal name_ As String, ByVal customer_id_ As Integer, ByVal warehouse_id_ As Integer, ByVal created_at_ As Byte(), ByVal updated_at_ As DateTime)
		Me.id = id_
		Me.name = name_
		Me.customer_id = customer_id_
		Me.warehouse_id = warehouse_id_
		Me.created_at = created_at_
		Me.updated_at = updated_at_
	End Sub
End Class
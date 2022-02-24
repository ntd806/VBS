Public Class waybill

	Public Property id As Integer
	Public Property origin_id As Integer
	Public Property destinaton_id As Integer
	Public Property customer_id As Integer
	Public Property order_id As Integer
	Public Property created_at As Byte()
	Public Property updated_at As DateTime

	Sub New(ByVal id_ As Integer, ByVal origin_id_ As Integer, ByVal destinaton_id_ As Integer, ByVal customer_id_ As Integer, ByVal order_id_ As Integer, ByVal created_at_ As Byte(), ByVal updated_at_ As DateTime)
		Me.id = id_
		Me.origin_id = origin_id_
		Me.destinaton_id = destinaton_id_
		Me.customer_id = customer_id_
		Me.order_id = order_id_
		Me.created_at = created_at_
		Me.updated_at = updated_at_
	End Sub
End Class
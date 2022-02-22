Public Class orderdescription

	Public Property order_id As Long
	Public Property product_id As Long
	Public Property amount As Integer

	Sub New(ByVal order_id_ As Long, ByVal product_id_ As Long, ByVal amount_ As Integer)
		Me.order_id = order_id_
		Me.product_id = product_id_
		Me.amount = amount_
	End Sub
End Class
Public Class permitsion

	Public Property id As Integer
	Public Property name As String
	Public Property type As Integer

	Sub New(ByVal id_ As Integer, ByVal name_ As String, ByVal type_ As Integer)
		Me.id = id_
		Me.name = name_
		Me.type = type_
	End Sub
End Class
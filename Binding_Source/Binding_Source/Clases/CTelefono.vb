Public Class CTelefono

	'Declaracion de las variables _nombre y _telefono
	Private _nombre As String = "Un nombre"
	Private _telefono As Decimal = 0

	'Se asigna la propiedad Nombre
	Public Property Nombre() As String
		Get
			Return _nombre
		End Get
		Set(value As String)
			_nombre = value
		End Set
	End Property

	'Se asigna la propiedad Telefono
	Public Property Telefono() As Decimal
		Get
			Return _telefono
		End Get
		Set(value As Decimal)
			_telefono = value
		End Set
	End Property

End Class

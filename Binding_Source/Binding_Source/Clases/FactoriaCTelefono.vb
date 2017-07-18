Public Class FactoriaCTelefono

	Private Shared _telefonos As List(Of CTelefono)

	'Nuevo CTelefono
	Public Shared Function CrearCTelefono(nom As String, tfn As Decimal) As CTelefono

		Dim tfno As New CTelefono()

		tfno.Nombre = nom
		tfno.Telefono = tfn
		Return tfno

	End Function

	Public Shared Function ObtenerColeccionCTelefono() As List(Of CTelefono)

		_telefonos = New List(Of CTelefono)()

		Dim rnd As New Random()

		For i As Integer = 1 To 9

			_telefonos.Add(CrearCTelefono("Persona " & i, rnd.Next(636000000, 636999999)))
		Next
		Return _telefonos
	End Function

End Class

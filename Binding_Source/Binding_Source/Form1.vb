Public Class Form1

	Private colTfnos As List(Of CTelefono)
	Private bs As BindingSource

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		colTfnos = FactoriaCTelefono.ObtenerColeccionCTelefono()
		bs = New BindingSource()
		bs.DataSource = colTfnos
		listTfnos.DataSource = bs
		listTfnos.DisplayMember = "Nombre"
		ctTfnoSelec.DataBindings.Add("Text", bs, "Telefono")

	End Sub

	Private Sub btAñadir_Click(sender As Object, e As EventArgs) Handles btAñadir.Click

		Dim tef As Decimal = 0
		If ctNombre.Text.Length <> 0 AndAlso ctTfno.Text.Length <> 0 AndAlso Decimal.TryParse(ctTfno.Text, tef) Then

			colTfnos.Add(FactoriaCTelefono.CrearCTelefono(ctNombre.Text, tef))
			bs.Position = bs.Count
			bs.CurrencyManager.Refresh()

		End If

	End Sub

	Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click

		If bs.Position < 0 Then Return
		colTfnos.RemoveAt(bs.Position)
		bs.CurrencyManager.Refresh()

	End Sub

	Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click

		Dim cambios As Boolean = False
		If ctNombre.Text.Length <> 0 Then

			TryCast(bs.Current, CTelefono).Nombre = ctNombre.Text
			cambios = True

		End If

		Dim tef As Decimal = 0
		If ctTfno.Text.Length <> 0 AndAlso Decimal.TryParse(ctTfno.Text, tef) Then

			TryCast(bs.Current, CTelefono).Telefono = tef
			cambios = True

		End If

		If cambios Then bs.CurrencyManager.Refresh()

	End Sub
End Class

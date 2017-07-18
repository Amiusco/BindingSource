<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.listTfnos = New System.Windows.Forms.ListBox()
		Me.ctTfnoSelec = New System.Windows.Forms.TextBox()
		Me.ctNombre = New System.Windows.Forms.TextBox()
		Me.ctTfno = New System.Windows.Forms.TextBox()
		Me.btAñadir = New System.Windows.Forms.Button()
		Me.btBorrar = New System.Windows.Forms.Button()
		Me.btModificar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'listTfnos
		'
		Me.listTfnos.FormattingEnabled = True
		Me.listTfnos.Location = New System.Drawing.Point(13, 13)
		Me.listTfnos.Name = "listTfnos"
		Me.listTfnos.Size = New System.Drawing.Size(120, 108)
		Me.listTfnos.TabIndex = 0
		'
		'ctTfnoSelec
		'
		Me.ctTfnoSelec.Location = New System.Drawing.Point(13, 127)
		Me.ctTfnoSelec.Name = "ctTfnoSelec"
		Me.ctTfnoSelec.ReadOnly = True
		Me.ctTfnoSelec.Size = New System.Drawing.Size(120, 20)
		Me.ctTfnoSelec.TabIndex = 1
		'
		'ctNombre
		'
		Me.ctNombre.Location = New System.Drawing.Point(150, 13)
		Me.ctNombre.Name = "ctNombre"
		Me.ctNombre.Size = New System.Drawing.Size(100, 20)
		Me.ctNombre.TabIndex = 2
		'
		'ctTfno
		'
		Me.ctTfno.Location = New System.Drawing.Point(150, 39)
		Me.ctTfno.Name = "ctTfno"
		Me.ctTfno.Size = New System.Drawing.Size(100, 20)
		Me.ctTfno.TabIndex = 3
		'
		'btAñadir
		'
		Me.btAñadir.Location = New System.Drawing.Point(150, 66)
		Me.btAñadir.Name = "btAñadir"
		Me.btAñadir.Size = New System.Drawing.Size(100, 23)
		Me.btAñadir.TabIndex = 4
		Me.btAñadir.Text = "Añadir"
		Me.btAñadir.UseVisualStyleBackColor = True
		'
		'btBorrar
		'
		Me.btBorrar.Location = New System.Drawing.Point(150, 95)
		Me.btBorrar.Name = "btBorrar"
		Me.btBorrar.Size = New System.Drawing.Size(100, 23)
		Me.btBorrar.TabIndex = 5
		Me.btBorrar.Text = "Borrar"
		Me.btBorrar.UseVisualStyleBackColor = True
		'
		'btModificar
		'
		Me.btModificar.Location = New System.Drawing.Point(150, 124)
		Me.btModificar.Name = "btModificar"
		Me.btModificar.Size = New System.Drawing.Size(100, 23)
		Me.btModificar.TabIndex = 6
		Me.btModificar.Text = "Modificar"
		Me.btModificar.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(271, 165)
		Me.Controls.Add(Me.btModificar)
		Me.Controls.Add(Me.btBorrar)
		Me.Controls.Add(Me.btAñadir)
		Me.Controls.Add(Me.ctTfno)
		Me.Controls.Add(Me.ctNombre)
		Me.Controls.Add(Me.ctTfnoSelec)
		Me.Controls.Add(Me.listTfnos)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents listTfnos As ListBox
	Friend WithEvents ctTfnoSelec As TextBox
	Friend WithEvents ctNombre As TextBox
	Friend WithEvents ctTfno As TextBox
	Friend WithEvents btAñadir As Button
	Friend WithEvents btBorrar As Button
	Friend WithEvents btModificar As Button
End Class

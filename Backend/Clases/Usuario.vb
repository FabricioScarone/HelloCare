Public Class Usuario
    Private ReadOnly _ID As Integer
    Private ReadOnly _Contrasena As String
    Private ReadOnly _Persona As Persona
    Private ReadOnly _Tipo As TiposUsuario
    Private ReadOnly _Habilitado As Boolean

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Contrasena As String
        Get
            Return _Contrasena
        End Get
    End Property

    Public ReadOnly Property Persona As Persona
        Get
            Return _Persona
        End Get
    End Property

    Public ReadOnly Property Tipo As TiposUsuario
        Get
            Return _Tipo
        End Get
    End Property

    Public Sub New(contrasena As String, persona As Persona)
        _ID = Integer.MinValue
        ValidarDatos(contrasena)
        _Contrasena = contrasena
        _Persona = persona
        Select Case persona.GetType
            Case GetType(Paciente)
                _Tipo = TiposUsuario.Paciente
            Case GetType(Medico)
                _Tipo = TiposUsuario.Medico
            Case GetType(Administrativo)
                _Tipo = TiposUsuario.Administrativo
        End Select
        _Habilitado = True
    End Sub

    Public Sub New(id As Integer, contrasena As String, persona As Persona, habilitado As Boolean)
        _ID = id
        ValidarDatos(contrasena)
        _Contrasena = contrasena
        _Persona = persona
        Select Case persona.GetType
            Case GetType(Paciente)
                _Tipo = TiposUsuario.Paciente
            Case GetType(Medico)
                _Tipo = TiposUsuario.Medico
            Case GetType(Administrativo)
                _Tipo = TiposUsuario.Administrativo
        End Select
        _Habilitado = habilitado
    End Sub

    Private Sub ValidarDatos(contrasena As String)
        ' Manejo de errores de datos ingresados
        ' contrasena tiene un valor nulo
        If contrasena = Nothing Or contrasena = "" Then
            Throw New ArgumentException("La contraseña se encuentra vacía.")
        End If

        ' contrasena excede el largo máximo
        If contrasena.Length > 1000 Then
            Throw New ArgumentException("La clave no puede exceder los 1000 caracteres.")
        End If
    End Sub
End Class
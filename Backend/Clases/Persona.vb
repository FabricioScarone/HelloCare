Public MustInherit Class Persona
    Protected ReadOnly _ID As Integer
    Protected ReadOnly _CI As String
    Protected ReadOnly _Nombre As String
    Protected ReadOnly _Apellido As String
    Protected ReadOnly _Correo As String
    Protected ReadOnly _Localidad As Localidad
    Protected ReadOnly _Tipo As TiposPersona

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property CI As String
        Get
            Return _CI
        End Get
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return _Nombre
        End Get
    End Property

    Public ReadOnly Property Apellido As String
        Get
            Return _Apellido
        End Get
    End Property

    Public ReadOnly Property Correo As String
        Get
            Return _Correo
        End Get
    End Property

    Public ReadOnly Property Localidad As Localidad
        Get
            Return _Localidad
        End Get
    End Property

    Public ReadOnly Property Tipo As TiposPersona
        Get
            Return _Tipo
        End Get
    End Property

    Protected Sub New(ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, tipo As TiposPersona)
        ValidarDatos(ci, nombre, apellido, correo, localidad, tipo)
        _CI = ci
        _Nombre = nombre
        _Apellido = apellido
        _Correo = correo
        _Localidad = localidad
        _Tipo = tipo
    End Sub

    Protected Sub New(id As Integer, ci As String, nombre As String, apellido As String,
                      correo As String, localidad As Localidad, tipo As TiposPersona)
        _ID = id
        ValidarDatos(ci, nombre, apellido, correo, localidad, tipo)
        _CI = ci
        _Nombre = nombre
        _Apellido = apellido
        _Correo = correo
        _Localidad = localidad
        _Tipo = tipo
    End Sub

    Private Sub ValidarDatos(ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, tipo As TiposPersona)
        ' Manejo de errores de datos ingresados
        ' Célula equivocada o con formato equivocado
        If Not CedulaValida(ci) Then
            Throw New ArgumentException("El número de cédula ingresado no corresponde con el dígito verificador.")
        End If

        ' nombre tiene un valor nulo
        If nombre = Nothing Or nombre = "" Then
            Throw New ArgumentNullException("nombre", "El nombre se encuentra vacío.")
        End If

        ' nombre excede el largo máximo
        If nombre.Length >= 100 Then
            Throw New ArgumentException("El largo del nombre no debe superar los 100 caracteres.")
        End If

        ' apellido tiene un valor nulo
        If apellido = Nothing Or apellido = "" Then
            Throw New ArgumentNullException("apellido", "El apellido se encuentra vacío.")
        End If

        ' apellido excede el largo máximo
        If apellido.Length >= 100 Then
            Throw New ArgumentException("El largo del apellido no debe superar los 100 caracteres.")
        End If

        ValidarCaracteresNombre(nombre, apellido)

        ' Correo con un formato inválido
        If Not CorreoValido(correo) Then
            Throw New ArgumentException("El correo no tiene un formato válido.")
        End If

        If Not [Enum].IsDefined(GetType(TiposPersona), tipo) Then
            Throw New ArgumentException("El tipo de persona es inválido.")
        End If
    End Sub

    Protected Shared Function CedulaValida(ci As String) As Boolean
        ' Manejo de errores de formato
        ' Valor nulo o cadena vacía
        If ci = Nothing Or ci = "" Then
            Throw New ArgumentNullException("ci", "La cédula no ha sido ingresada.")
        End If

        ' La cédula posee más de 8 caracteres
        If ci.Length > 8 Then
            Throw New ArgumentException("La cédula no puede poseer más de 8 caracteres. Ingrésela sin puntos ni guiones.")
        End If

        ' Algún dígito no es un valor numérico (0-9)
        'For Each c As Char In ci.ToCharArray
        '    Dim valorASCIICaracter As Integer = Asc(c)
        '    If valorASCIICaracter < Asc("0"c) Or valorASCIICaracter > Asc("9"c) Then
        '        Throw New ArgumentException("El caracter " & c & " en la cédula " & ci & " no es un dígito válido.")
        '    End If
        'Next

        ValidarCaracteresNumero(ci)

        ' Completa la cédula con ceros a la izquierda en caso de que tenga menos de 8 dígitos
        While ci.Length < 8
            ci = "0" & ci
        End While

        ' Calcula el dígito verificador a través de los dígitos numéricos, y lo compara con el ingresado
        Dim constantesVerificacion() As Integer = {2, 9, 8, 7, 6, 3, 4}
        Dim suma As Integer = 0
        For i = 0 To constantesVerificacion.Length - 1
            suma += (Val(ci(i)) * constantesVerificacion(i)) Mod 10
        Next
        Dim digitoVerificador As Integer = 10 - (suma Mod 10)
        If digitoVerificador = 10 Then
            digitoVerificador = 0
        End If

        ' Si el digito verificador calculado coincide con el ingresado, retorna True, sino retorna False
        If digitoVerificador = Integer.Parse(ci.ToCharArray.Last()) Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Shared Function CorreoValido(correo As String) As Boolean
        ' Manejo de errores de formato
        ' Valor nulo
        If correo = Nothing Or correo = "" Then
            Throw New ArgumentNullException("correo", "El correo no ha sido ingresado.")
        End If

        ' El correo posee más de 100 caracteres
        If correo.Length > 100 Then
            Throw New ArgumentException("El correo no puede poseer más de 100 caracteres.")
        End If

        ValidarCaracteresCorreo(correo)

        ' Si la cadena tiene un formato adecuado, retorna True, sino retorna False
        If correo Like "?*@?*.?*" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function ToString() As String
        Return _Nombre & " " & _Apellido
    End Function
End Class

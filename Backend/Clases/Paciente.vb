Public Class Paciente
    Inherits Persona

    Private ReadOnly _TelefonoMovil As String
    Private ReadOnly _TelefonoFijo As String
    Private ReadOnly _Sexo As TiposSexo
    Private ReadOnly _FechaNacimiento As Date
    Private ReadOnly _FechaDefuncion As Date
    Private ReadOnly _Calle As String
    Private ReadOnly _NumeroPuerta As String
    Private ReadOnly _Apartamento As String

    Public ReadOnly Property TelefonoMovil As String
        Get
            Return _TelefonoMovil
        End Get
    End Property

    Public ReadOnly Property TelefonoFijo As String
        Get
            Return _TelefonoFijo
        End Get
    End Property

    Public ReadOnly Property Sexo As TiposSexo
        Get
            Return _Sexo
        End Get
    End Property

    Public ReadOnly Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
    End Property

    Public ReadOnly Property FechaDefuncion As Date
        Get
            Return _FechaDefuncion
        End Get
    End Property

    Public ReadOnly Property HaFallecido As Boolean
        Get
            If _FechaDefuncion = Nothing Then
                Return False
            Else
                Return True
            End If
        End Get
    End Property

    Public ReadOnly Property Calle As String
        Get
            Return _Calle
        End Get
    End Property

    Public ReadOnly Property NumeroPuerta As String
        Get
            Return _NumeroPuerta
        End Get
    End Property

    Public ReadOnly Property Apartamento As String
        Get
            Return _Apartamento
        End Get
    End Property

    Sub New(ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, telefonoMovil As String,
            telefonoFijo As String, sexo As TiposSexo, fechaNacimiento As Date, fechaDefuncion As Date, calle As String, numeroPuerta As String,
            apartamento As String)

        MyBase.New(ci, nombre, apellido, correo, localidad, TiposPersona.Paciente)
        ValidarDatos(telefonoMovil, telefonoFijo, sexo, fechaNacimiento, fechaDefuncion, calle, numeroPuerta, apartamento)
        _TelefonoMovil = telefonoMovil
        _TelefonoFijo = telefonoFijo
        _Sexo = sexo
        _FechaNacimiento = fechaNacimiento
        _FechaDefuncion = fechaDefuncion
        _Calle = calle
        _NumeroPuerta = numeroPuerta
        _Apartamento = apartamento
    End Sub

    Sub New(id As Integer, ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, telefonoMovil As String,
            telefonoFijo As String, sexo As TiposSexo, fechaNacimiento As Date, fechaDefuncion As Date, calle As String, numeroPuerta As String,
            apartamento As String)

        MyBase.New(id, ci, nombre, apellido, correo, localidad, TiposPersona.Paciente)
        ValidarDatos(telefonoMovil, telefonoFijo, sexo, fechaNacimiento, fechaDefuncion, calle, numeroPuerta, apartamento)
        _TelefonoMovil = telefonoMovil
        _TelefonoFijo = telefonoFijo
        _Sexo = sexo
        _FechaNacimiento = fechaNacimiento
        _FechaDefuncion = fechaDefuncion
        _Calle = calle
        _NumeroPuerta = numeroPuerta
        _Apartamento = apartamento
    End Sub

    Private Sub ValidarDatos(telefonoMovil As String, telefonoFijo As String, sexo As TiposSexo, fechaNacimiento As Date, fechaDefuncion As Date,
                             calle As String, numeroPuerta As String, apartamento As String)
        ' Manejo de errores de datos ingresados
        ' telefonoMovil tiene un valor nulo
        If telefonoMovil Is Nothing Or telefonoMovil = "" Then
            Throw New ArgumentException("No se ingresó el telefono móvil del paciente.")
        End If

        ' telefonoMovil excede el largo máximo
        If telefonoMovil.Length > 9 Then
            Throw New ArgumentException("El telefono móvil no puede tener mas de 9 caracteres.")
        End If

        ' Algún dígito no es un valor numérico (0-9)
        'For Each c As Char In telefonoMovil.ToCharArray
        '    Dim valorASCIICaracter As Integer = Asc(c)
        '    If valorASCIICaracter < Asc("0"c) Or valorASCIICaracter > Asc("9"c) Then
        '        Throw New ArgumentException("El caracter " & c & " en el número de teléfono " & CI & " no es un dígito válido.")
        '    End If
        'Next

        ' telefonoFijo tiene un valor nulo
        If telefonoFijo Is Nothing Or telefonoFijo = "" Then
            Throw New ArgumentException("No se ingresó el teléfono fijo del paciente.")
        End If

        ' telefonoFijo excede el largo máximo
        If telefonoFijo.Length > 8 Then
            Throw New ArgumentException("El teléfono fijo no puede tener mas de 8 caracteres.")
        End If

        ' Algún dígito no es un valor numérico (0-9)
        'For Each c As Char In telefonoFijo.ToCharArray
        '    Dim valorASCIICaracter As Integer = Asc(c)
        '    If valorASCIICaracter < Asc("0"c) Or valorASCIICaracter > Asc("9"c) Then
        '        Throw New ArgumentException("El caracter " & c & " en el número de teléfono " & CI & " no es un dígito válido.")
        '    End If
        'Next

        ValidarCaracteresNumero(telefonoMovil, telefonoFijo)

        ' sexo no tiene un valor válido
        If Not [Enum].IsDefined(GetType(TiposSexo), sexo) Then
            Throw New ArgumentException("No se ingresó un sexo válido.")
        End If

        ' fechaNacimiento tiene un valor nulo
        If fechaNacimiento = Nothing Then
            Throw New ArgumentException("No se ingresó la fecha de nacimiento.")
        End If

        ' fechaNacimiento representa un valor posterior al momento actual
        If fechaNacimiento > Now Then
            Throw New ArgumentException("La fecha de nacimiento del paciente no puede ser posterior al momento actual.")
        End If

        ' fechaNacimiento representa una fecha previa a 1900 y es por ende inválida
        If fechaNacimiento < New Date(1900, 1, 1) Then
            Throw New ArgumentException("La fecha de nacimiento del paciente no puede ser anterior a 1900.")
        End If

        If fechaDefuncion <> Nothing Then
            If fechaDefuncion > Now Then
                Throw New ArgumentException("La fecha de defunción del paciente no puede ser posterior al momento actual.")
            End If

            If fechaDefuncion < New Date(1900, 1, 1) Then
                Throw New ArgumentException("La fecha de defunción del paciente no puede ser anterior a 1900.")
            End If

            If fechaDefuncion < fechaNacimiento Then
                Throw New ArgumentException("La fecha de defunción no puede ser anterior a la fecha de nacimiento del paciente.")
            End If
        End If

        ' calle tiene un valor nulo
        If calle Is Nothing Or calle = "" Then
            Throw New ArgumentException("No se ingresó la calle del domicilio del paciente.")
        End If

        ' calle excede el largo máximo
        If calle.Length > 100 Then
            Throw New ArgumentException("La calle no puede tener más de 100 caracteres.")
        End If

        ValidarCaracteresCalle(calle)

        ' numeroPuerta tiene un valor nulo
        If numeroPuerta Is Nothing Or numeroPuerta = "" Then
            Throw New ArgumentException("No se ingresó el número de puerta del domicilio del paciente.")
        End If

        ' numeroPuerta excede el largo máximo
        If numeroPuerta.Length > 10 Then
            Throw New ArgumentException("El número de puerta del domicilio del paciente no puede tener más de 10 caracteres.")
        End If

        ValidarCaracteresNumero(numeroPuerta)

        If apartamento IsNot Nothing AndAlso apartamento.Length > 10 Then
            If apartamento.Length > 10 Then
                Throw New ArgumentException("El número de apartamento no puede tener más de 10 caracteres.")
            End If

            ValidarCaracteresTexto(apartamento)
        End If
    End Sub
End Class

Public Class DiagnosticoPrimario
    Protected ReadOnly _ID As Integer
    Protected ReadOnly _Paciente As Paciente
    Protected ReadOnly _Sintomas As List(Of Sintoma)
    Protected ReadOnly _Enfermedades As EnfermedadesDiagnosticadas
    Protected ReadOnly _FechaHora As Date
    Protected ReadOnly _Tipo As TiposDiagnosticosPrimarios

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Paciente As Paciente
        Get
            Return _Paciente
        End Get
    End Property

    Public ReadOnly Property Sintomas As List(Of Sintoma)
        Get
            Return _Sintomas
        End Get
    End Property

    Public ReadOnly Property Sintomas(indice As Integer) As Sintoma
        Get
            Return _Sintomas(indice)
        End Get
    End Property

    Public ReadOnly Property Enfermedades As List(Of Enfermedad)
        Get
            Return _Enfermedades.Items
        End Get
    End Property

    Public ReadOnly Property EnfermedadesDiagnosticadas As EnfermedadesDiagnosticadas
        Get
            Return _Enfermedades
        End Get
    End Property

    Public ReadOnly Property Enfermedades(indice As Integer) As Enfermedad
        Get
            Return _Enfermedades.Item(indice)
        End Get
    End Property

    Public ReadOnly Property Probabilidad(indice As Integer) As Decimal
        Get
            Return _Enfermedades.Probabilidad(indice)
        End Get
    End Property

    Public ReadOnly Property FechaHora As Date
        Get
            Return _FechaHora
        End Get
    End Property

    Public ReadOnly Property Tipo As TiposDiagnosticosPrimarios
        Get
            Return _Tipo
        End Get
    End Property

    Public Sub New(paciente As Paciente, sintomas As List(Of Sintoma), enfermedades As EnfermedadesDiagnosticadas, fechaHora As Date,
                   tipo As TiposDiagnosticosPrimarios)
        _ID = Integer.MinValue
        ValidarDatos(fechaHora, tipo)
        _Paciente = paciente
        _Sintomas = sintomas
        _Enfermedades = enfermedades
        _FechaHora = fechaHora
        _Tipo = tipo
    End Sub

    Public Sub New(id As Integer, paciente As Paciente, sintomas As List(Of Sintoma), enfermedades As EnfermedadesDiagnosticadas, fechaHora As Date,
                   tipo As TiposDiagnosticosPrimarios)
        _ID = id
        ValidarDatos(fechaHora, tipo)
        _Paciente = paciente
        _Sintomas = sintomas
        _Enfermedades = enfermedades
        _FechaHora = fechaHora
        _Tipo = tipo
    End Sub

    Private Sub ValidarDatos(fechaHora As Date, tipo As TiposDiagnosticosPrimarios)
        If fechaHora = Nothing Or fechaHora < New Date(2010, 1, 1) Or fechaHora > Now Then
            Throw New ArgumentException("La fecha registrada en el diagnóstico diferencial no es válida.")
        End If

        If Not [Enum].IsDefined(GetType(TiposDiagnosticosPrimarios), tipo) Then
            Throw New ArgumentException("No se especificó un tipo de diagnóstico primario válido.")
        End If
    End Sub
End Class

Public Class Especialidad
    Private ReadOnly _ID As Integer
    Private ReadOnly _Nombre As String
    Private ReadOnly _Medicos As New List(Of Medico)
    Private ReadOnly _Habilitada As Boolean

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return _Nombre
        End Get
    End Property

    Public ReadOnly Property Medicos As List(Of Medico)
        Get
            Return _Medicos
        End Get
    End Property

    Public ReadOnly Property Habilitada As Boolean
        Get
            Return _Habilitada
        End Get
    End Property

    Public Sub New(nombre As String, medicos As List(Of Medico))
        _ID = Integer.MinValue
        ValidarDatos(nombre)
        _Nombre = nombre
        _Medicos = medicos
        _Habilitada = True
    End Sub

    Public Sub New(id As Integer, nombre As String, medicos As List(Of Medico), habilitada As Boolean)
        _ID = id
        ValidarDatos(nombre)
        _Nombre = nombre
        _Medicos = medicos
        _Habilitada = habilitada
    End Sub

    Private Sub ValidarDatos(nombre As String)
        If nombre = Nothing Or nombre = "" Then
            Throw New ArgumentException("No se ingresó el nombre de la especialidad.")
        End If

        If nombre.Length > 100 Then
            Throw New ArgumentException("El nombre de la enfermedad no puede exceder los 100 caracteres.")
        End If

        ValidarCaracteresNombre(nombre)
    End Sub

    Public Overrides Function ToString() As String
        Return _Nombre
    End Function

    Public Shared Operator =(e1 As Especialidad, e2 As Especialidad) As Boolean
        Return e1.ID = e2.ID
    End Operator

    Public Shared Operator <>(e1 As Especialidad, e2 As Especialidad) As Boolean
        Return e1.ID <> e2.ID
    End Operator
End Class

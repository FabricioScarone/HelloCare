Public Class Departamento
    Private ReadOnly _ID As Integer
    Private ReadOnly _Nombre As String

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

    Public Sub New(nombre As String)
        _ID = Integer.MinValue
        ValidarDatos(nombre)
        _Nombre = nombre
    End Sub

    Public Sub New(id As Integer, nombre As String)
        _ID = id
        ValidarDatos(nombre)
        _Nombre = nombre
    End Sub

    Private Sub ValidarDatos(nombre As String)
        If nombre = Nothing Or nombre = "" Then
            Throw New ArgumentException("No se ingresó el nombre del departamento.")
        End If

        If nombre.Length > 100 Then
            Throw New ArgumentException("El nombre del departamento no puede exceder los 100 caracteres.")
        End If

        ValidarCaracteresNombre(nombre)
    End Sub

    Public Overrides Function ToString() As String
        Return _Nombre
    End Function

    Public Shared Operator =(d1 As Departamento, d2 As Departamento)
        Return d1.ID = d2.ID
    End Operator

    Public Shared Operator <>(d1 As Departamento, d2 As Departamento)
        Return d1.ID <> d2.ID
    End Operator
End Class
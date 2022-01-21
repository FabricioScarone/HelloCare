Public Class Localidad
    Private ReadOnly _ID As Integer
    Private ReadOnly _Nombre As String
    Private ReadOnly _Departamento As Departamento

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

    Public ReadOnly Property Departamento As Departamento
        Get
            Return _Departamento
        End Get
    End Property

    Public Sub New(nombre As String, departamento As Departamento)
        _ID = Integer.MinValue
        ValidarDatos(nombre)
        _Nombre = nombre
        _Departamento = departamento
    End Sub

    Public Sub New(id As Integer, nombre As String, departamento As Departamento)
        _ID = id
        ValidarDatos(nombre)
        _Nombre = nombre
        _Departamento = departamento
    End Sub

    Private Sub ValidarDatos(nombre As String)
        ' Manejo de errores de datos ingresados
        ' nombre tiene un valor nulo
        If nombre = Nothing Then
            Throw New ArgumentNullException("nombre", "No se ingresó el nombre de la localidad.")
        End If

        ' nombre excede el máximo de caracteres
        If nombre.Length > 100 Then
            Throw New ArgumentException("El nombre de la localidad excede los 100 caracteres de largo.")
        End If

        ValidarCaracteresNombre(nombre)
    End Sub

    Public Overrides Function ToString() As String
        Return _Nombre
    End Function
End Class

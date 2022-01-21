Public Class Sintoma
    Private ReadOnly _ID As Integer
    Private ReadOnly _Recomendaciones As String
    Private ReadOnly _Nombre As String
    Private ReadOnly _Descripcion As String
    Private ReadOnly _Urgencia As Integer
    Private ReadOnly _Enfermedades As EnfermedadesAsociadas
    Private ReadOnly _Habilitado As Boolean

    Public ReadOnly Property ID As Integer
        Get
            Return _ID
        End Get
    End Property

    Public ReadOnly Property Recomendaciones As String
        Get
            Return _Recomendaciones
        End Get
    End Property

    Public ReadOnly Property Nombre As String
        Get
            Return _Nombre
        End Get
    End Property

    Public ReadOnly Property Descripcion As String
        Get
            Return _Descripcion
        End Get
    End Property

    Public ReadOnly Property Urgencia As Integer
        Get
            Return _Urgencia
        End Get
    End Property

    Public ReadOnly Property Enfermedades As List(Of Enfermedad)
        Get
            Return _Enfermedades.Items
        End Get
    End Property

    Public ReadOnly Property Enfermedades(indice As Integer) As Enfermedad
        Get
            Return _Enfermedades.Item(indice)
        End Get
    End Property

    Public ReadOnly Property FrecuenciaEnfermedad(indice As Integer) As Decimal
        Get
            Return _Enfermedades.Frecuencia(indice)
        End Get
    End Property

    Public ReadOnly Property Habilitado As Boolean
        Get
            Return _Habilitado
        End Get
    End Property

    Public Sub New(nombre As String, descripcion As String, recomendaciones As String, urgencia As String, enfermedades As EnfermedadesAsociadas)
        _ID = Integer.MinValue
        ValidarDatos(nombre, descripcion, recomendaciones, urgencia)
        _Nombre = nombre
        _Descripcion = descripcion
        _Urgencia = urgencia
        _Recomendaciones = recomendaciones
        _Enfermedades = enfermedades
        _Habilitado = True
    End Sub

    Public Sub New(id As Integer, nombre As String, descripcion As String, recomendaciones As String, urgencia As Integer,
                   enfermedades As EnfermedadesAsociadas, habilitado As Boolean)
        _ID = id
        ValidarDatos(nombre, descripcion, recomendaciones, urgencia)
        _Nombre = nombre
        _Descripcion = descripcion
        _Urgencia = urgencia
        _Recomendaciones = recomendaciones
        _Enfermedades = enfermedades
        _Habilitado = habilitado
    End Sub

    Private Sub ValidarDatos(nombre As String, descripcion As String, recomendaciones As String, urgencia As String)
        ' Manejo de errores
        ' nombre tiene un valor nulo
        If nombre = Nothing Or nombre = "" Then
            Throw New ArgumentException("No se ingresó el nombre del síntoma.")
        End If

        ' nombre excede el largo máximo
        If nombre.Length > 100 Then
            Throw New ArgumentException("El largo del nombre no debe superar los 100 caracteres.")
        End If

        ValidarCaracteresTexto(nombre)

        ' descripcion excede el largo máximo
        If descripcion.Length > 1000 Then
            Throw New ArgumentException("El largo de la descripción no debe superar los 1000 caracteres.")
        End If

        ' urgencia tiene un valor inválido
        If urgencia < 1 Or urgencia > 100 Then
            Throw New ArgumentException("La urgencia debe tener un valor numérico entero entre 1 y 100.")
        End If

        ' recomendaciones excede el largo máximo
        If recomendaciones.Length > 1000 Then
            Throw New ArgumentException("El largo de las recomendaciones no debe superar los 1000 caracteres.")
        End If

        ValidarCaracteresTexto(descripcion, recomendaciones)
    End Sub

    Public Overrides Function ToString() As String
        Return _Nombre
    End Function
End Class

Public Class Administrativo
    Inherits Persona
    Private ReadOnly _EsEncargado As Boolean
    Private ReadOnly _Habilitado As Boolean

    Public ReadOnly Property EsEncargado As Boolean
        Get
            Return _EsEncargado
        End Get
    End Property

    Public ReadOnly Property Habilitado As Boolean
        Get
            Return _Habilitado
        End Get
    End Property

    Public Sub New(ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, esEncargado As Boolean)
        MyBase.New(ci, nombre, apellido, correo, localidad, TiposPersona.Funcionario)
        _EsEncargado = esEncargado
        _Habilitado = True
    End Sub

    Public Sub New(id As Integer, ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, esEncargado As Boolean,
                   habilitado As Boolean)
        MyBase.New(id, ci, nombre, apellido, correo, localidad, TiposPersona.Funcionario)
        _EsEncargado = esEncargado
        _Habilitado = habilitado
    End Sub
End Class
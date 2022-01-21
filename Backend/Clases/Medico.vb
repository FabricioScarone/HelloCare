Public Class Medico
    Inherits Persona
    Private ReadOnly _Especialidades As List(Of Especialidad)
    Private ReadOnly _Habilitado As Boolean

    Public ReadOnly Property Especialidades As List(Of Especialidad)
        Get
            Return _Especialidades
        End Get
    End Property

    Public ReadOnly Property Habilitado As Boolean
        Get
            Return _Habilitado
        End Get
    End Property

    Public Sub New(ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad, especialidades As List(Of Especialidad))
        MyBase.New(ci, nombre, apellido, correo, localidad, TiposPersona.Funcionario)
        ValidarDatos(especialidades)
        _Especialidades = especialidades
        _Habilitado = True
    End Sub

    Public Sub New(id As Integer, ci As String, nombre As String, apellido As String, correo As String, localidad As Localidad,
                   especialidades As List(Of Especialidad), habilitado As Boolean)
        MyBase.New(id, ci, nombre, apellido, correo, localidad, TiposPersona.Funcionario)
        _Especialidades = especialidades
        _Habilitado = habilitado
    End Sub

    Private Sub ValidarDatos(especialidades As List(Of Especialidad))
        If especialidades.Count = 0 Then
            Throw New Exception("Cada médico debe tener al menos una especialidad asociada.")
        End If
    End Sub
End Class
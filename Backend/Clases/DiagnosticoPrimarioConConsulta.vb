Public Class DiagnosticoPrimarioConConsulta
    Inherits DiagnosticoPrimario
    Private ReadOnly _Medico As Medico
    Private ReadOnly _ComentariosAdicionales As String

    Public ReadOnly Property Medico As Medico
        Get
            Return _Medico
        End Get
    End Property

    Public ReadOnly Property ComentariosAdicionales As String
        Get
            Return _ComentariosAdicionales
        End Get
    End Property

    Public ReadOnly Property IndiceEnfermedadMasProbable As Integer
        Get
            Dim indiceMasProbable As Integer = 0
            Dim mayorProbabilidad As Decimal = 0
            For i = 0 To _Enfermedades.Items.Count - 1
                If _Enfermedades.Probabilidad(i) > mayorProbabilidad Then
                    mayorProbabilidad = _Enfermedades.Probabilidad(i)
                    indiceMasProbable = i
                End If
            Next
            Return indiceMasProbable
        End Get
    End Property

    Public Sub New(diagnosticoPrimario As DiagnosticoPrimario, comentariosAdicionales As String)
        MyBase.New(diagnosticoPrimario.ID, diagnosticoPrimario.Paciente, diagnosticoPrimario.Sintomas, diagnosticoPrimario.EnfermedadesDiagnosticadas,
                   diagnosticoPrimario.FechaHora, TiposDiagnosticosPrimarios.Con_Consulta)
        _Medico = Nothing
        ValidarDatos(comentariosAdicionales)
        _ComentariosAdicionales = comentariosAdicionales
    End Sub

    Public Sub New(id As Integer, paciente As Paciente, sintomas As List(Of Sintoma), enfermedades As EnfermedadesDiagnosticadas, fechaHora As Date,
                   medico As Medico, comentariosAdicionales As String)

        MyBase.New(id, paciente, sintomas, enfermedades, fechaHora, TiposDiagnosticosPrimarios.Con_Consulta)
        _Medico = medico
        ValidarDatos(comentariosAdicionales)
        _ComentariosAdicionales = comentariosAdicionales
    End Sub

    Private Sub ValidarDatos(comentariosAdicionales As String)
        If comentariosAdicionales IsNot Nothing AndAlso comentariosAdicionales.Length > 1000 Then
            Throw New ArgumentException("La longitud de los comentarios no puede exceder los 1000 caracteres.")
        End If

        ValidarCaracteresTexto(comentariosAdicionales)
    End Sub
End Class
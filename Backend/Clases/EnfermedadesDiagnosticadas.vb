Public Class EnfermedadesDiagnosticadas
    Private ReadOnly _Items As List(Of Enfermedad)
    Private ReadOnly _Probabilidades As List(Of Decimal)

    Public ReadOnly Property Item(indice As Integer) As Enfermedad
        Get
            Return _Items(indice)
        End Get
    End Property

    Public ReadOnly Property Probabilidad(indice As Integer) As Decimal
        Get
            Return _Probabilidades(indice)
        End Get
    End Property

    Public ReadOnly Property Items As List(Of Enfermedad)
        Get
            Return _Items
        End Get
    End Property

    Public Sub New(enfermedades As List(Of Enfermedad), probabilidades As List(Of Decimal))
        _Items = enfermedades
        _Probabilidades = probabilidades
    End Sub
End Class

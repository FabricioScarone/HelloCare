Public Class SintomasAsociados
    Private ReadOnly _Items As List(Of Sintoma)
    Private ReadOnly _Frecuencias As List(Of Decimal)

    Public ReadOnly Property Item(indice As Integer) As Sintoma
        Get
            Return _Items(indice)
        End Get
    End Property

    Public ReadOnly Property Frecuencia(indice As Integer) As Decimal
        Get
            Return _Frecuencias(indice)
        End Get
    End Property

    Public ReadOnly Property Items As List(Of Sintoma)
        Get
            Return _Items
        End Get
    End Property

    Public Sub New(sintomas As List(Of Sintoma), frecuencias As List(Of Decimal))
        _Items = sintomas
        For Each f As Decimal In frecuencias
            If f < 0 Or f > 100 Then
                Throw New Exception("La frecuencia de cada síntoma debe estar entre 0 y 100.")
            End If
        Next
        _Frecuencias = frecuencias
    End Sub
End Class

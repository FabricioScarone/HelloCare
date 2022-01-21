Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports CapaLogica
Imports Clases

Public Class FrmDiagnosticoPrimario
    'Private nuevoDiagnostico As Boolean
    Private diagnosticoMostrado As DiagnosticoPrimario

    ' listaSintomasIngresados recibe la lista de síntomas seleccionados en el formulario anterior
    Sub New(sintomasIngresados As List(Of Sintoma))
        InitializeComponent()

        ' Muestra en pantalla los síntomas seleccionados en los cuales se basa el diagnóstico primario
        lstSintomas.Items.AddRange(sintomasIngresados.ToArray)

        ' Muestra las recomendaciones del sistema para tratar cada síntoma ingresado
        For Each s As Sintoma In sintomasIngresados
            txtRecomendaciones.Text &= "Para aliviar " & s.Nombre.ToLower & ":" & vbNewLine
            txtRecomendaciones.Text &= s.Recomendaciones & vbNewLine & vbNewLine
        Next

        Dim enfermedadesDiagnosticadas As EnfermedadesDiagnosticadas
        Try
            enfermedadesDiagnosticadas = RealizarDiagnostico(sintomasIngresados)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        For i = 0 To enfermedadesDiagnosticadas.Items.Count - 1
            tblEnfermedadesDiagnosticadas.Rows.Add(enfermedadesDiagnosticadas.Items(i), enfermedadesDiagnosticadas.Probabilidad(i) & "%",
                                                   enfermedadesDiagnosticadas.Item(i).Nombre)
        Next

        If enfermedadesDiagnosticadas.Items.Count = 0 Then
            tblEnfermedadesDiagnosticadas.Rows.Add("", "", "Ninguna enfermedad del sistema coincide con los síntomas seleccionados.")
            tblEnfermedadesDiagnosticadas.Rows(0).Height *= 2       ' Permite visualizar dicho mensaje mejor
            lblResultado.Visible = False                            ' Si no se determinó un resultado fiable, oculta el Label
        Else
            lblResultado.Text = "De acuerdo con los síntomas ingresados, la enfermedad que más probablemente padece es: " &
                                enfermedadesDiagnosticadas.Items(0).Nombre & ", con una certeza del " & Math.Round(enfermedadesDiagnosticadas.Probabilidad(0), 1) & "%."
        End If

        Try
            diagnosticoMostrado = CrearDiagnosticoPrimario(pacienteLogeado, sintomasIngresados, enfermedadesDiagnosticadas)
        Catch ex As Exception
            MostrarMensaje(MsgBoxStyle.Critical, "Hubo un error al guardar el diagnóstico en la base de datos.", "Error", "There was an error while savine the diagnosis to the database.", "Error")
        End Try
    End Sub

    Public Sub New(diagnostico As DiagnosticoPrimario)
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        For Each s As Sintoma In diagnostico.Sintomas
            lstSintomas.Items.Add(s)
        Next

        For i = 0 To diagnostico.Enfermedades.Count - 1
            tblEnfermedadesDiagnosticadas.Rows.Add(diagnostico.Enfermedades(i), diagnostico.Probabilidad(i) & "%", diagnostico.Enfermedades(i))
        Next

        If diagnostico.Enfermedades.Count > 0 Then
            lblResultado.Text = "El resultado del diagnóstico es " & diagnostico.Enfermedades(0).ToString & ", con una certeza del " &
                                 Math.Round(diagnostico.Probabilidad(0), 1) & "%."
        Else
            tblEnfermedadesDiagnosticadas.Rows.Add("", "", "Ninguna enfermedad del sistema coincide con los síntomas seleccionados.")
            tblEnfermedadesDiagnosticadas.Rows(0).Height *= 2       ' Permite visualizar dicho mensaje mejor
            lblResultado.Visible = False                            ' Si no se determinó un resultado fiable, oculta el Label
        End If


        ' Muestra las recomendaciones del sistema para tratar cada síntoma ingresado
        For Each s As Sintoma In diagnostico.Sintomas
            txtRecomendaciones.Text &= "Para aliviar " & s.Nombre.ToLower & ":" & vbNewLine
            txtRecomendaciones.Text &= s.Recomendaciones & vbNewLine & vbNewLine
        Next

        diagnosticoMostrado = diagnostico
    End Sub

    ' Deselecciona lo que haya quedado seleccionado por defecto
    Private Sub DiagnosticoPrimario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tblEnfermedadesDiagnosticadas.ClearSelection()
        Me.ActiveControl = lblTitulo

        If TypeOf diagnosticoMostrado Is DiagnosticoPrimarioConConsulta Then
            Dim cantidadDiagnosticosDiferenciales As Integer
            Try
                cantidadDiagnosticosDiferenciales = ContarDiagnosticosDiferenciales(diagnosticoMostrado)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return
            End Try
            lblDiagnosticosDiferenciales.Text = lblDiagnosticosDiferenciales.Text.Replace("#", cantidadDiagnosticosDiferenciales)
            btnDiagnosticosDiferenciales.Visible = cantidadDiagnosticosDiferenciales > 0
        Else
            lblDiagnosticosDiferenciales.Hide()
            btnDiagnosticosDiferenciales.Hide()
        End If
    End Sub

    Private Sub btnDiagnosticosDiferenciales_Click(sender As Object, e As EventArgs) Handles btnDiagnosticosDiferenciales.Click
        Dim frmDiferenciales As New FrmDiagnosticosDiferenciales(diagnosticoMostrado)
        Me.Hide()
        frmDiferenciales.ShowDialog()
        Me.DialogResult = DialogResult.None
        Me.Show()
    End Sub

    Private Sub btnRealizarConsulta_Click(sender As Object, e As EventArgs) Handles btnRealizarConsulta.Click
        Dim frmComentarios As New FrmComentariosAdicionales
        Dim confirmacion As DialogResult = DialogResult.OK
        If diagnosticoMostrado.Tipo = TiposDiagnosticosPrimarios.Sin_Consulta Then
            confirmacion = frmComentarios.ShowDialog()
        End If

        If confirmacion = DialogResult.OK Then
            Dim diagnosticoConConsulta As DiagnosticoPrimarioConConsulta
            If TryCast(diagnosticoMostrado, DiagnosticoPrimarioConConsulta) Is Nothing Then
                Try
                    diagnosticoConConsulta = AgregarConsultaADiagnostico(diagnosticoMostrado, frmComentarios.txtComentariosAdicionales.Text)
                Catch ex As Exception
                    MostrarMensaje(MsgBoxStyle.Critical, "Ocurrió un problema al solicitar la consulta médica.", "Error", "There was a problem when requesting a medical consultation.", "Error")
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                    Return
                End Try
                diagnosticoMostrado = diagnosticoConConsulta
            Else
                diagnosticoConConsulta = diagnosticoMostrado
            End If

            Dim frmChat As New FrmChatPaciente(diagnosticoConConsulta)
            Me.Hide()
            frmChat.ShowDialog()
            Me.DialogResult = DialogResult.None
            diagnosticoMostrado = frmChat.consultaEnCurso
            Me.Show()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblTraducir_Click(sender As Object, e As EventArgs) Handles lblTraducir.Click
        TraducirAplicacion()
    End Sub

    Private Sub lblDiagnosticosDiferenciales_TextChanged(sender As Object, e As EventArgs) Handles lblDiagnosticosDiferenciales.TextChanged
        If TypeOf diagnosticoMostrado Is DiagnosticoPrimarioConConsulta Then
            Dim cantidadDiagnosticosDiferenciales As Integer
            Try
                cantidadDiagnosticosDiferenciales = ContarDiagnosticosDiferenciales(diagnosticoMostrado)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                Return
            End Try
            lblDiagnosticosDiferenciales.Text = lblDiagnosticosDiferenciales.Text.Replace("#", cantidadDiagnosticosDiferenciales)
            If cantidadDiagnosticosDiferenciales > 0 Then
                btnDiagnosticosDiferenciales.Visible = True
            Else
                btnDiagnosticosDiferenciales.Visible = False
            End If
        Else
            lblDiagnosticosDiferenciales.Hide()
            btnDiagnosticosDiferenciales.Hide()
        End If
    End Sub

    Private Sub FrmDiagnosticoPrimario_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Try
                AbrirAyuda(TiposUsuario.Paciente, Me)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End If
    End Sub
End Class
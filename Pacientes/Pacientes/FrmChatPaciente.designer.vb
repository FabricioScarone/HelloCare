<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChatPaciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChatPaciente))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtMensaje = New System.Windows.Forms.RichTextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.btnAdjuntar = New System.Windows.Forms.Button()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.lstArchivos = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.expAdjuntar = New System.Windows.Forms.OpenFileDialog()
        Me.txtConversacion = New System.Windows.Forms.TextBox()
        Me.tmrActualizar = New System.Windows.Forms.Timer(Me.components)
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtMensaje
        '
        resources.ApplyResources(Me.txtMensaje, "txtMensaje")
        Me.txtMensaje.Name = "txtMensaje"
        '
        'btnEnviar
        '
        resources.ApplyResources(Me.btnEnviar, "btnEnviar")
        Me.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'btnAdjuntar
        '
        resources.ApplyResources(Me.btnAdjuntar, "btnAdjuntar")
        Me.btnAdjuntar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdjuntar.Name = "btnAdjuntar"
        Me.btnAdjuntar.UseVisualStyleBackColor = True
        '
        'lblMedico
        '
        Me.lblMedico.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblMedico, "lblMedico")
        Me.lblMedico.Name = "lblMedico"
        '
        'lstArchivos
        '
        Me.lstArchivos.FormattingEnabled = True
        resources.ApplyResources(Me.lstArchivos, "lstArchivos")
        Me.lstArchivos.Name = "lstArchivos"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'expAdjuntar
        '
        Me.expAdjuntar.FileName = "OpenFileDialog1"
        '
        'txtConversacion
        '
        Me.txtConversacion.AcceptsReturn = True
        Me.txtConversacion.AcceptsTab = True
        Me.txtConversacion.BackColor = System.Drawing.Color.White
        Me.txtConversacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtConversacion, "txtConversacion")
        Me.txtConversacion.Name = "txtConversacion"
        Me.txtConversacion.ReadOnly = True
        '
        'tmrActualizar
        '
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmChatPaciente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstArchivos)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.txtConversacion)
        Me.Controls.Add(Me.btnAdjuntar)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.btnSalir)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmChatPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Splitter1 As Windows.Forms.Splitter
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents txtMensaje As Windows.Forms.RichTextBox
    Friend WithEvents btnEnviar As Windows.Forms.Button
    Friend WithEvents btnAdjuntar As Windows.Forms.Button
    Friend WithEvents lblMedico As Windows.Forms.Label
    Friend WithEvents lstArchivos As Windows.Forms.ListBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents expAdjuntar As Windows.Forms.OpenFileDialog
    Friend WithEvents txtConversacion As Windows.Forms.TextBox
    Friend WithEvents tmrActualizar As Windows.Forms.Timer
    Friend WithEvents lblTraducir As Windows.Forms.Label
End Class

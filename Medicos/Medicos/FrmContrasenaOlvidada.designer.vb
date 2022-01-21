Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContrasenaOlvidada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContrasenaOlvidada))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnEnviarCodigo = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Name = "lblTitulo"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtCedula, "txtCedula")
        Me.txtCedula.Name = "txtCedula"
        '
        'btnEnviarCodigo
        '
        Me.btnEnviarCodigo.BackColor = System.Drawing.Color.LightCoral
        resources.ApplyResources(Me.btnEnviarCodigo, "btnEnviarCodigo")
        Me.btnEnviarCodigo.ForeColor = System.Drawing.Color.White
        Me.btnEnviarCodigo.Name = "btnEnviarCodigo"
        Me.btnEnviarCodigo.UseVisualStyleBackColor = False
        '
        'lblCodigo
        '
        resources.ApplyResources(Me.lblCodigo, "lblCodigo")
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.ForeColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Name = "lblCodigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtCodigo, "txtCodigo")
        Me.txtCodigo.Name = "txtCodigo"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.LightCoral
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmContrasenaOlvidada
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnEnviarCodigo)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmContrasenaOlvidada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnEnviarCodigo As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents lblTraducir As Label
End Class

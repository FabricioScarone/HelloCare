<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistro))
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkMostrarContrasena = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtContrasena, "txtContrasena")
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtRepetir
        '
        Me.txtRepetir.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtRepetir, "txtRepetir")
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.UseSystemPasswordChar = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'chkMostrarContrasena
        '
        resources.ApplyResources(Me.chkMostrarContrasena, "chkMostrarContrasena")
        Me.chkMostrarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrarContrasena.ForeColor = System.Drawing.Color.Transparent
        Me.chkMostrarContrasena.Name = "chkMostrarContrasena"
        Me.chkMostrarContrasena.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.LightCoral
        resources.ApplyResources(Me.btnGuardar, "btnGuardar")
        Me.btnGuardar.ForeColor = System.Drawing.Color.Transparent
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Name = "lblTitulo"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmRegistro
        '
        Me.AcceptButton = Me.btnGuardar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkMostrarContrasena)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRepetir)
        Me.Controls.Add(Me.txtContrasena)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtRepetir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkMostrarContrasena As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTraducir As Label
End Class

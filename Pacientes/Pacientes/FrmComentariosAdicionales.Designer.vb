<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmComentariosAdicionales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComentariosAdicionales))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComentariosAdicionales = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviarConsulta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtComentariosAdicionales
        '
        resources.ApplyResources(Me.txtComentariosAdicionales, "txtComentariosAdicionales")
        Me.txtComentariosAdicionales.Name = "txtComentariosAdicionales"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnCancelar, "btnCancelar")
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEnviarConsulta
        '
        Me.btnEnviarConsulta.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnEnviarConsulta, "btnEnviarConsulta")
        Me.btnEnviarConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnviarConsulta.Name = "btnEnviarConsulta"
        Me.btnEnviarConsulta.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmComentariosAdicionales
        '
        Me.AcceptButton = Me.btnEnviarConsulta
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEnviarConsulta)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtComentariosAdicionales)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmComentariosAdicionales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtComentariosAdicionales As Windows.Forms.TextBox
    Friend WithEvents btnCancelar As Windows.Forms.Button
    Friend WithEvents btnEnviarConsulta As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents lblTraducir As Windows.Forms.Label
End Class

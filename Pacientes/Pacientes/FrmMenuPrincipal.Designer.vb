<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresoSintoma = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnHistorialDiagnosticos = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLogeado = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'btnIngresoSintoma
        '
        Me.btnIngresoSintoma.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnIngresoSintoma, "btnIngresoSintoma")
        Me.btnIngresoSintoma.ForeColor = System.Drawing.Color.White
        Me.btnIngresoSintoma.Name = "btnIngresoSintoma"
        Me.btnIngresoSintoma.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.Color.Transparent
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnHistorialDiagnosticos
        '
        Me.btnHistorialDiagnosticos.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnHistorialDiagnosticos, "btnHistorialDiagnosticos")
        Me.btnHistorialDiagnosticos.ForeColor = System.Drawing.Color.White
        Me.btnHistorialDiagnosticos.Name = "btnHistorialDiagnosticos"
        Me.btnHistorialDiagnosticos.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'lblLogeado
        '
        resources.ApplyResources(Me.lblLogeado, "lblLogeado")
        Me.lblLogeado.BackColor = System.Drawing.Color.Transparent
        Me.lblLogeado.ForeColor = System.Drawing.Color.White
        Me.lblLogeado.Name = "lblLogeado"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmMenuPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.lblLogeado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnHistorialDiagnosticos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIngresoSintoma)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnIngresoSintoma As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents btnHistorialDiagnosticos As Windows.Forms.Button
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lblLogeado As Windows.Forms.Label
    Friend WithEvents lblTraducir As Windows.Forms.Label
End Class

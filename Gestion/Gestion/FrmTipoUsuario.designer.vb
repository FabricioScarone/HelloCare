<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoUsuario))
        Me.btnPaciente = New System.Windows.Forms.Button()
        Me.btnMedico = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.btnAdministrativo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPaciente
        '
        Me.btnPaciente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnPaciente, "btnPaciente")
        Me.btnPaciente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.UseVisualStyleBackColor = False
        '
        'btnMedico
        '
        Me.btnMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnMedico, "btnMedico")
        Me.btnMedico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMedico.Name = "btnMedico"
        Me.btnMedico.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'btnAdministrativo
        '
        Me.btnAdministrativo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAdministrativo, "btnAdministrativo")
        Me.btnAdministrativo.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAdministrativo.Name = "btnAdministrativo"
        Me.btnAdministrativo.UseVisualStyleBackColor = False
        '
        'FrmTipoUsuario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnAdministrativo)
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMedico)
        Me.Controls.Add(Me.btnPaciente)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmTipoUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPaciente As Button
    Friend WithEvents btnMedico As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblTraducir As Label
    Friend WithEvents btnAdministrativo As Button
End Class

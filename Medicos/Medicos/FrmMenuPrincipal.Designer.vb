<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.btnPeticiones = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnHistorialPacientes = New System.Windows.Forms.Button()
        Me.btnHistorialChat = New System.Windows.Forms.Button()
        Me.lblLogeado = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPeticiones
        '
        resources.ApplyResources(Me.btnPeticiones, "btnPeticiones")
        Me.btnPeticiones.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPeticiones.Name = "btnPeticiones"
        Me.btnPeticiones.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnHistorialPacientes
        '
        resources.ApplyResources(Me.btnHistorialPacientes, "btnHistorialPacientes")
        Me.btnHistorialPacientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHistorialPacientes.Name = "btnHistorialPacientes"
        Me.btnHistorialPacientes.UseVisualStyleBackColor = True
        '
        'btnHistorialChat
        '
        resources.ApplyResources(Me.btnHistorialChat, "btnHistorialChat")
        Me.btnHistorialChat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnHistorialChat.Name = "btnHistorialChat"
        Me.btnHistorialChat.UseVisualStyleBackColor = True
        '
        'lblLogeado
        '
        Me.lblLogeado.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblLogeado, "lblLogeado")
        Me.lblLogeado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblLogeado.Name = "lblLogeado"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'FrmMenuPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnHistorialPacientes)
        Me.Controls.Add(Me.lblLogeado)
        Me.Controls.Add(Me.btnHistorialChat)
        Me.Controls.Add(Me.btnPeticiones)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmMenuPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPeticiones As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnHistorialPacientes As Button
    Friend WithEvents btnHistorialChat As Button
    Friend WithEvents lblLogeado As Label
    Friend WithEvents lblTraducir As Label
    Friend WithEvents Label1 As Label
End Class

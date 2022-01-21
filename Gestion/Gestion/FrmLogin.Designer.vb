<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.chkMostrarContrasena = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblContrasenaOlvidada = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnIngresar, "btnIngresar")
        Me.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtContrasena, "txtContrasena")
        Me.txtContrasena.ForeColor = System.Drawing.Color.White
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.DarkGray
        resources.ApplyResources(Me.txtCedula, "txtCedula")
        Me.txtCedula.ForeColor = System.Drawing.Color.White
        Me.txtCedula.Name = "txtCedula"
        '
        'chkMostrarContrasena
        '
        resources.ApplyResources(Me.chkMostrarContrasena, "chkMostrarContrasena")
        Me.chkMostrarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrarContrasena.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chkMostrarContrasena.Name = "chkMostrarContrasena"
        Me.chkMostrarContrasena.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Name = "Label4"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Name = "Label5"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Name = "Label7"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'lblContrasenaOlvidada
        '
        resources.ApplyResources(Me.lblContrasenaOlvidada, "lblContrasenaOlvidada")
        Me.lblContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent
        Me.lblContrasenaOlvidada.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnIngresar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.lblContrasenaOlvidada)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkMostrarContrasena)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.btnIngresar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents chkMostrarContrasena As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblContrasenaOlvidada As Label
    Friend WithEvents lblTraducir As Label
End Class

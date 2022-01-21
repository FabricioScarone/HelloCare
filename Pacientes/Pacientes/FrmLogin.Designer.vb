<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.chkMostrarContrasena = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.lblContrasenaOlvidada = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.DarkGray
        Me.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtCedula, "txtCedula")
        Me.txtCedula.ForeColor = System.Drawing.Color.White
        Me.txtCedula.Name = "txtCedula"
        '
        'txtContrasena
        '
        Me.txtContrasena.BackColor = System.Drawing.Color.DarkGray
        Me.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtContrasena, "txtContrasena")
        Me.txtContrasena.ForeColor = System.Drawing.Color.White
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.UseSystemPasswordChar = True
        '
        'btnIngresar
        '
        Me.btnIngresar.AutoEllipsis = True
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnIngresar, "btnIngresar")
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'chkMostrarContrasena
        '
        resources.ApplyResources(Me.chkMostrarContrasena, "chkMostrarContrasena")
        Me.chkMostrarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.chkMostrarContrasena.ForeColor = System.Drawing.SystemColors.Control
        Me.chkMostrarContrasena.Name = "chkMostrarContrasena"
        Me.chkMostrarContrasena.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Name = "Label3"
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'lblContrasenaOlvidada
        '
        resources.ApplyResources(Me.lblContrasenaOlvidada, "lblContrasenaOlvidada")
        Me.lblContrasenaOlvidada.BackColor = System.Drawing.Color.Transparent
        Me.lblContrasenaOlvidada.ForeColor = System.Drawing.SystemColors.Control
        Me.lblContrasenaOlvidada.Name = "lblContrasenaOlvidada"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnIngresar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblContrasenaOlvidada)
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkMostrarContrasena)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.btnIngresar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCedula As Windows.Forms.TextBox
    Friend WithEvents txtContrasena As Windows.Forms.TextBox
    Friend WithEvents btnIngresar As Windows.Forms.Button
    Friend WithEvents chkMostrarContrasena As Windows.Forms.CheckBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents lblTraducir As Windows.Forms.Label
    Friend WithEvents lblContrasenaOlvidada As Label
End Class

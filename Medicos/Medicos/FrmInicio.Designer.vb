<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.picHelloCare = New System.Windows.Forms.PictureBox()
        Me.picHelloCode = New System.Windows.Forms.PictureBox()
        Me.tmrSplashWindow = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picHelloCare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHelloCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHelloCare
        '
        Me.picHelloCare.Image = CType(resources.GetObject("picHelloCare.Image"), System.Drawing.Image)
        Me.picHelloCare.Location = New System.Drawing.Point(-10, 12)
        Me.picHelloCare.Name = "picHelloCare"
        Me.picHelloCare.Size = New System.Drawing.Size(319, 316)
        Me.picHelloCare.TabIndex = 0
        Me.picHelloCare.TabStop = False
        '
        'picHelloCode
        '
        Me.picHelloCode.Image = CType(resources.GetObject("picHelloCode.Image"), System.Drawing.Image)
        Me.picHelloCode.Location = New System.Drawing.Point(0, 399)
        Me.picHelloCode.Name = "picHelloCode"
        Me.picHelloCode.Size = New System.Drawing.Size(300, 150)
        Me.picHelloCode.TabIndex = 1
        Me.picHelloCode.TabStop = False
        '
        'tmrSplashWindow
        '
        Me.tmrSplashWindow.Enabled = True
        Me.tmrSplashWindow.Interval = 5000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Otro producto de"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(300, 548)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picHelloCode)
        Me.Controls.Add(Me.picHelloCare)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash window"
        CType(Me.picHelloCare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHelloCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picHelloCare As PictureBox
    Friend WithEvents picHelloCode As PictureBox
    Friend WithEvents tmrSplashWindow As Timer
    Friend WithEvents Label1 As Label
End Class

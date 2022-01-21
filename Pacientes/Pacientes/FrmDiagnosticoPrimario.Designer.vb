<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDiagnosticoPrimario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiagnosticoPrimario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecomendaciones = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstSintomas = New System.Windows.Forms.ListBox()
        Me.tblEnfermedadesDiagnosticadas = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProbabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnRealizarConsulta = New System.Windows.Forms.Button()
        Me.lblDiagnosticosDiferenciales = New System.Windows.Forms.Label()
        Me.btnDiagnosticosDiferenciales = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblEnfermedadesDiagnosticadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSintomas
        '
        resources.ApplyResources(Me.lblSintomas, "lblSintomas")
        Me.lblSintomas.BackColor = System.Drawing.Color.Transparent
        Me.lblSintomas.Name = "lblSintomas"
        '
        'lblDiagnostico
        '
        resources.ApplyResources(Me.lblDiagnostico, "lblDiagnostico")
        Me.lblDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.lblDiagnostico.Name = "lblDiagnostico"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'txtRecomendaciones
        '
        resources.ApplyResources(Me.txtRecomendaciones, "txtRecomendaciones")
        Me.txtRecomendaciones.Name = "txtRecomendaciones"
        Me.txtRecomendaciones.ReadOnly = True
        '
        'btnSalir
        '
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lstSintomas
        '
        resources.ApplyResources(Me.lstSintomas, "lstSintomas")
        Me.lstSintomas.FormattingEnabled = True
        Me.lstSintomas.Name = "lstSintomas"
        '
        'tblEnfermedadesDiagnosticadas
        '
        Me.tblEnfermedadesDiagnosticadas.AllowUserToAddRows = False
        Me.tblEnfermedadesDiagnosticadas.AllowUserToDeleteRows = False
        Me.tblEnfermedadesDiagnosticadas.AllowUserToResizeColumns = False
        Me.tblEnfermedadesDiagnosticadas.AllowUserToResizeRows = False
        Me.tblEnfermedadesDiagnosticadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedadesDiagnosticadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblEnfermedadesDiagnosticadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEnfermedadesDiagnosticadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colProbabilidad, Me.colNombre})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblEnfermedadesDiagnosticadas.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.tblEnfermedadesDiagnosticadas, "tblEnfermedadesDiagnosticadas")
        Me.tblEnfermedadesDiagnosticadas.Name = "tblEnfermedadesDiagnosticadas"
        Me.tblEnfermedadesDiagnosticadas.ReadOnly = True
        Me.tblEnfermedadesDiagnosticadas.RowHeadersVisible = False
        Me.tblEnfermedadesDiagnosticadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colObjeto
        '
        resources.ApplyResources(Me.colObjeto, "colObjeto")
        Me.colObjeto.Name = "colObjeto"
        Me.colObjeto.ReadOnly = True
        '
        'colProbabilidad
        '
        Me.colProbabilidad.FillWeight = 20.0!
        resources.ApplyResources(Me.colProbabilidad, "colProbabilidad")
        Me.colProbabilidad.Name = "colProbabilidad"
        Me.colProbabilidad.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.FillWeight = 60.0!
        resources.ApplyResources(Me.colNombre, "colNombre")
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblResultado, "lblResultado")
        Me.lblResultado.Name = "lblResultado"
        '
        'btnRealizarConsulta
        '
        resources.ApplyResources(Me.btnRealizarConsulta, "btnRealizarConsulta")
        Me.btnRealizarConsulta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRealizarConsulta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRealizarConsulta.Name = "btnRealizarConsulta"
        Me.btnRealizarConsulta.UseVisualStyleBackColor = True
        '
        'lblDiagnosticosDiferenciales
        '
        resources.ApplyResources(Me.lblDiagnosticosDiferenciales, "lblDiagnosticosDiferenciales")
        Me.lblDiagnosticosDiferenciales.BackColor = System.Drawing.Color.Transparent
        Me.lblDiagnosticosDiferenciales.Name = "lblDiagnosticosDiferenciales"
        '
        'btnDiagnosticosDiferenciales
        '
        resources.ApplyResources(Me.btnDiagnosticosDiferenciales, "btnDiagnosticosDiferenciales")
        Me.btnDiagnosticosDiferenciales.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDiagnosticosDiferenciales.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDiagnosticosDiferenciales.Name = "btnDiagnosticosDiferenciales"
        Me.btnDiagnosticosDiferenciales.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Name = "lblTitulo"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmDiagnosticoPrimario
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnDiagnosticosDiferenciales)
        Me.Controls.Add(Me.lblDiagnosticosDiferenciales)
        Me.Controls.Add(Me.btnRealizarConsulta)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.tblEnfermedadesDiagnosticadas)
        Me.Controls.Add(Me.lstSintomas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtRecomendaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDiagnostico)
        Me.Controls.Add(Me.lblSintomas)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmDiagnosticoPrimario"
        CType(Me.tblEnfermedadesDiagnosticadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSintomas As Windows.Forms.Label
    Friend WithEvents lblDiagnostico As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtRecomendaciones As Windows.Forms.TextBox
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents lstSintomas As Windows.Forms.ListBox
    Friend WithEvents tblEnfermedadesDiagnosticadas As Windows.Forms.DataGridView
    Friend WithEvents lblResultado As Windows.Forms.Label
    Friend WithEvents btnRealizarConsulta As Windows.Forms.Button
    Friend WithEvents lblDiagnosticosDiferenciales As Windows.Forms.Label
    Friend WithEvents btnDiagnosticosDiferenciales As Windows.Forms.Button
    Friend WithEvents lblTitulo As Windows.Forms.Label
    Friend WithEvents colObjeto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colProbabilidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Windows.Forms.Label
End Class

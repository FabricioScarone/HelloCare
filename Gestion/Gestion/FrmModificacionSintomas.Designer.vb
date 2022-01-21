<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificacionSintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificacionSintomas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecomendaciones = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtUrgencia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tblAsociadas = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblPatologias = New System.Windows.Forms.DataGridView()
        Me.colObjeto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarPatologia = New System.Windows.Forms.Button()
        Me.btnAgregarPatologia = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBuscarPatologia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblAsociadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        '
        'txtDescripcion
        '
        resources.ApplyResources(Me.txtDescripcion, "txtDescripcion")
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'txtNombre
        '
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.Name = "txtNombre"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtUrgencia
        '
        resources.ApplyResources(Me.txtUrgencia, "txtUrgencia")
        Me.txtUrgencia.Name = "txtUrgencia"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'tblAsociadas
        '
        Me.tblAsociadas.AllowUserToAddRows = False
        Me.tblAsociadas.AllowUserToDeleteRows = False
        Me.tblAsociadas.AllowUserToResizeColumns = False
        Me.tblAsociadas.AllowUserToResizeRows = False
        Me.tblAsociadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblAsociadas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblAsociadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblAsociadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblAsociadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colNomEnfermedad, Me.colFrecuencia})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblAsociadas.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.tblAsociadas, "tblAsociadas")
        Me.tblAsociadas.Name = "tblAsociadas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblAsociadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblAsociadas.RowHeadersVisible = False
        Me.tblAsociadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colObjeto
        '
        resources.ApplyResources(Me.colObjeto, "colObjeto")
        Me.colObjeto.Name = "colObjeto"
        '
        'colNomEnfermedad
        '
        Me.colNomEnfermedad.FillWeight = 75.0!
        resources.ApplyResources(Me.colNomEnfermedad, "colNomEnfermedad")
        Me.colNomEnfermedad.Name = "colNomEnfermedad"
        Me.colNomEnfermedad.ReadOnly = True
        '
        'colFrecuencia
        '
        Me.colFrecuencia.FillWeight = 25.0!
        resources.ApplyResources(Me.colFrecuencia, "colFrecuencia")
        Me.colFrecuencia.Name = "colFrecuencia"
        '
        'tblPatologias
        '
        Me.tblPatologias.AllowUserToAddRows = False
        Me.tblPatologias.AllowUserToDeleteRows = False
        Me.tblPatologias.AllowUserToResizeColumns = False
        Me.tblPatologias.AllowUserToResizeRows = False
        Me.tblPatologias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblPatologias.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPatologias.ColumnHeadersVisible = False
        Me.tblPatologias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto2, Me.colPatologia})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblPatologias.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.tblPatologias, "tblPatologias")
        Me.tblPatologias.Name = "tblPatologias"
        Me.tblPatologias.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPatologias.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tblPatologias.RowHeadersVisible = False
        Me.tblPatologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colObjeto2
        '
        resources.ApplyResources(Me.colObjeto2, "colObjeto2")
        Me.colObjeto2.Name = "colObjeto2"
        Me.colObjeto2.ReadOnly = True
        '
        'colPatologia
        '
        resources.ApplyResources(Me.colPatologia, "colPatologia")
        Me.colPatologia.Name = "colPatologia"
        Me.colPatologia.ReadOnly = True
        '
        'btnQuitarPatologia
        '
        Me.btnQuitarPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnQuitarPatologia, "btnQuitarPatologia")
        Me.btnQuitarPatologia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuitarPatologia.Name = "btnQuitarPatologia"
        Me.btnQuitarPatologia.UseVisualStyleBackColor = False
        '
        'btnAgregarPatologia
        '
        Me.btnAgregarPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarPatologia, "btnAgregarPatologia")
        Me.btnAgregarPatologia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregarPatologia.Name = "btnAgregarPatologia"
        Me.btnAgregarPatologia.UseVisualStyleBackColor = False
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'txtBuscarPatologia
        '
        resources.ApplyResources(Me.txtBuscarPatologia, "txtBuscarPatologia")
        Me.txtBuscarPatologia.Name = "txtBuscarPatologia"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmModificacionSintomas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnVolver
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblPatologias)
        Me.Controls.Add(Me.btnQuitarPatologia)
        Me.Controls.Add(Me.btnAgregarPatologia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBuscarPatologia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tblAsociadas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtUrgencia)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtRecomendaciones)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmModificacionSintomas"
        CType(Me.tblAsociadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRecomendaciones As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtUrgencia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tblAsociadas As DataGridView
    Friend WithEvents tblPatologias As DataGridView
    Friend WithEvents colObjeto2 As DataGridViewTextBoxColumn
    Friend WithEvents colPatologia As DataGridViewTextBoxColumn
    Friend WithEvents btnQuitarPatologia As Button
    Friend WithEvents btnAgregarPatologia As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBuscarPatologia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents colObjeto As DataGridViewTextBoxColumn
    Friend WithEvents colNomEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents colFrecuencia As DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Label
End Class

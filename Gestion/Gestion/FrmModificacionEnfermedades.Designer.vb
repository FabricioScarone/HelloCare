<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificacionEnfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificacionEnfermedades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtRecomendaciones = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGravedad = New System.Windows.Forms.TextBox()
        Me.tblSintomas = New System.Windows.Forms.DataGridView()
        Me.colObjeto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPatologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarSintoma = New System.Windows.Forms.Button()
        Me.btnAgregarSintoma = New System.Windows.Forms.Button()
        Me.txtBuscarSintoma = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tblAsociados = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNomEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscarEspecialidades = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tblEspecialidades = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'txtGravedad
        '
        resources.ApplyResources(Me.txtGravedad, "txtGravedad")
        Me.txtGravedad.Name = "txtGravedad"
        '
        'tblSintomas
        '
        Me.tblSintomas.AllowUserToAddRows = False
        Me.tblSintomas.AllowUserToDeleteRows = False
        Me.tblSintomas.AllowUserToResizeColumns = False
        Me.tblSintomas.AllowUserToResizeRows = False
        Me.tblSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblSintomas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblSintomas.ColumnHeadersVisible = False
        Me.tblSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto2, Me.colPatologia})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblSintomas.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.tblSintomas, "tblSintomas")
        Me.tblSintomas.Name = "tblSintomas"
        Me.tblSintomas.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblSintomas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblSintomas.RowHeadersVisible = False
        Me.tblSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        'btnQuitarSintoma
        '
        Me.btnQuitarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnQuitarSintoma, "btnQuitarSintoma")
        Me.btnQuitarSintoma.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuitarSintoma.Name = "btnQuitarSintoma"
        Me.btnQuitarSintoma.UseVisualStyleBackColor = False
        '
        'btnAgregarSintoma
        '
        Me.btnAgregarSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarSintoma, "btnAgregarSintoma")
        Me.btnAgregarSintoma.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregarSintoma.Name = "btnAgregarSintoma"
        Me.btnAgregarSintoma.UseVisualStyleBackColor = False
        '
        'txtBuscarSintoma
        '
        resources.ApplyResources(Me.txtBuscarSintoma, "txtBuscarSintoma")
        Me.txtBuscarSintoma.Name = "txtBuscarSintoma"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'tblAsociados
        '
        Me.tblAsociados.AllowUserToAddRows = False
        Me.tblAsociados.AllowUserToDeleteRows = False
        Me.tblAsociados.AllowUserToResizeColumns = False
        Me.tblAsociados.AllowUserToResizeRows = False
        Me.tblAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblAsociados.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblAsociados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.tblAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colNomEnfermedad, Me.colFrecuencia})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblAsociados.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.tblAsociados, "tblAsociados")
        Me.tblAsociados.Name = "tblAsociados"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblAsociados.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.tblAsociados.RowHeadersVisible = False
        Me.tblAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Name = "Label9"
        '
        'txtBuscarEspecialidades
        '
        resources.ApplyResources(Me.txtBuscarEspecialidades, "txtBuscarEspecialidades")
        Me.txtBuscarEspecialidades.Name = "txtBuscarEspecialidades"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Name = "Label10"
        '
        'tblEspecialidades
        '
        Me.tblEspecialidades.AllowUserToAddRows = False
        Me.tblEspecialidades.AllowUserToDeleteRows = False
        Me.tblEspecialidades.AllowUserToResizeColumns = False
        Me.tblEspecialidades.AllowUserToResizeRows = False
        Me.tblEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEspecialidades.ColumnHeadersVisible = False
        Me.tblEspecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        resources.ApplyResources(Me.tblEspecialidades, "tblEspecialidades")
        Me.tblEspecialidades.MultiSelect = False
        Me.tblEspecialidades.Name = "tblEspecialidades"
        Me.tblEspecialidades.ReadOnly = True
        Me.tblEspecialidades.RowHeadersVisible = False
        Me.tblEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmModificacionEnfermedades
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblEspecialidades)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBuscarEspecialidades)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tblSintomas)
        Me.Controls.Add(Me.btnQuitarSintoma)
        Me.Controls.Add(Me.btnAgregarSintoma)
        Me.Controls.Add(Me.txtBuscarSintoma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tblAsociados)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGravedad)
        Me.Controls.Add(Me.Label5)
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
        Me.Name = "FrmModificacionEnfermedades"
        CType(Me.tblSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRecomendaciones As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGravedad As TextBox
    Friend WithEvents tblSintomas As DataGridView
    Friend WithEvents colObjeto2 As DataGridViewTextBoxColumn
    Friend WithEvents colPatologia As DataGridViewTextBoxColumn
    Friend WithEvents btnQuitarSintoma As Button
    Friend WithEvents btnAgregarSintoma As Button
    Friend WithEvents txtBuscarSintoma As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tblAsociados As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscarEspecialidades As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tblEspecialidades As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents colObjeto As DataGridViewTextBoxColumn
    Friend WithEvents colNomEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents colFrecuencia As DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Label
End Class

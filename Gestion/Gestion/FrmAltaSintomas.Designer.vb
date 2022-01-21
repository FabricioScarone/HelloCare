<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaSintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaSintomas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtRecomendaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblUrgenciaSintoma = New System.Windows.Forms.Label()
        Me.txtUrgencia = New System.Windows.Forms.TextBox()
        Me.tblPatologias = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAsociacion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colEnfermedades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFrecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
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
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'txtNombre
        '
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.Name = "txtNombre"
        '
        'txtDescripcion
        '
        resources.ApplyResources(Me.txtDescripcion, "txtDescripcion")
        Me.txtDescripcion.Name = "txtDescripcion"
        '
        'txtRecomendaciones
        '
        resources.ApplyResources(Me.txtRecomendaciones, "txtRecomendaciones")
        Me.txtRecomendaciones.Name = "txtRecomendaciones"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        'lblUrgenciaSintoma
        '
        resources.ApplyResources(Me.lblUrgenciaSintoma, "lblUrgenciaSintoma")
        Me.lblUrgenciaSintoma.BackColor = System.Drawing.Color.Transparent
        Me.lblUrgenciaSintoma.Name = "lblUrgenciaSintoma"
        '
        'txtUrgencia
        '
        resources.ApplyResources(Me.txtUrgencia, "txtUrgencia")
        Me.txtUrgencia.Name = "txtUrgencia"
        '
        'tblPatologias
        '
        Me.tblPatologias.AllowUserToAddRows = False
        Me.tblPatologias.AllowUserToDeleteRows = False
        Me.tblPatologias.AllowUserToResizeColumns = False
        Me.tblPatologias.AllowUserToResizeRows = False
        Me.tblPatologias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblPatologias.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPatologias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colAsociacion, Me.colEnfermedades, Me.colFrecuencia})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblPatologias.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.tblPatologias, "tblPatologias")
        Me.tblPatologias.Name = "tblPatologias"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPatologias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblPatologias.RowHeadersVisible = False
        Me.tblPatologias.TabStop = False
        '
        'colObjeto
        '
        resources.ApplyResources(Me.colObjeto, "colObjeto")
        Me.colObjeto.Name = "colObjeto"
        '
        'colAsociacion
        '
        Me.colAsociacion.FillWeight = 15.0!
        resources.ApplyResources(Me.colAsociacion, "colAsociacion")
        Me.colAsociacion.Name = "colAsociacion"
        Me.colAsociacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAsociacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colEnfermedades
        '
        Me.colEnfermedades.FillWeight = 70.0!
        resources.ApplyResources(Me.colEnfermedades, "colEnfermedades")
        Me.colEnfermedades.Name = "colEnfermedades"
        Me.colEnfermedades.ReadOnly = True
        '
        'colFrecuencia
        '
        Me.colFrecuencia.FillWeight = 15.0!
        resources.ApplyResources(Me.colFrecuencia, "colFrecuencia")
        Me.colFrecuencia.Name = "colFrecuencia"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmAltaSintomas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnVolver
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblPatologias)
        Me.Controls.Add(Me.lblUrgenciaSintoma)
        Me.Controls.Add(Me.txtUrgencia)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAgregar)
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
        Me.Name = "FrmAltaSintomas"
        CType(Me.tblPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtRecomendaciones As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblUrgenciaSintoma As Label
    Friend WithEvents txtUrgencia As TextBox
    Friend WithEvents tblPatologias As DataGridView
    Friend WithEvents lblTraducir As Label
    Friend WithEvents colObjeto As DataGridViewTextBoxColumn
    Friend WithEvents colAsociacion As DataGridViewCheckBoxColumn
    Friend WithEvents colEnfermedades As DataGridViewTextBoxColumn
    Friend WithEvents colFrecuencia As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoPacientes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoPacientes))
        Me.tblPacientes = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGravedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelMovil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelFijo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaDefuncion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNumeroPuerta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.txtBP_Localidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBP_CI = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.tblPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblPacientes
        '
        Me.tblPacientes.AllowUserToAddRows = False
        Me.tblPacientes.AllowUserToDeleteRows = False
        Me.tblPacientes.AllowUserToResizeColumns = False
        Me.tblPacientes.AllowUserToResizeRows = False
        Me.tblPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tblPacientes.BackgroundColor = System.Drawing.Color.White
        Me.tblPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colNombre, Me.colDesc, Me.colGravedad, Me.colRec, Me.colLocalidad, Me.colTelMovil, Me.colTelFijo, Me.colSexo, Me.colFechaNacimiento, Me.ColFechaDefuncion, Me.colCalle, Me.colNumeroPuerta, Me.colApartamento})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblPacientes.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.tblPacientes, "tblPacientes")
        Me.tblPacientes.Name = "tblPacientes"
        Me.tblPacientes.ReadOnly = True
        Me.tblPacientes.RowHeadersVisible = False
        Me.tblPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblPacientes.TabStop = False
        '
        'colObjeto
        '
        resources.ApplyResources(Me.colObjeto, "colObjeto")
        Me.colObjeto.Name = "colObjeto"
        Me.colObjeto.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.FillWeight = 65.27477!
        resources.ApplyResources(Me.colNombre, "colNombre")
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDesc
        '
        Me.colDesc.FillWeight = 44.68057!
        resources.ApplyResources(Me.colDesc, "colDesc")
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colGravedad
        '
        Me.colGravedad.FillWeight = 49.4206!
        resources.ApplyResources(Me.colGravedad, "colGravedad")
        Me.colGravedad.Name = "colGravedad"
        Me.colGravedad.ReadOnly = True
        Me.colGravedad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colRec
        '
        Me.colRec.FillWeight = 54.73695!
        resources.ApplyResources(Me.colRec, "colRec")
        Me.colRec.Name = "colRec"
        Me.colRec.ReadOnly = True
        Me.colRec.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colLocalidad
        '
        Me.colLocalidad.FillWeight = 61.50316!
        resources.ApplyResources(Me.colLocalidad, "colLocalidad")
        Me.colLocalidad.Name = "colLocalidad"
        Me.colLocalidad.ReadOnly = True
        Me.colLocalidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colTelMovil
        '
        Me.colTelMovil.FillWeight = 66.10226!
        resources.ApplyResources(Me.colTelMovil, "colTelMovil")
        Me.colTelMovil.Name = "colTelMovil"
        Me.colTelMovil.ReadOnly = True
        Me.colTelMovil.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colTelFijo
        '
        Me.colTelFijo.FillWeight = 71.36985!
        resources.ApplyResources(Me.colTelFijo, "colTelFijo")
        Me.colTelFijo.Name = "colTelFijo"
        Me.colTelFijo.ReadOnly = True
        Me.colTelFijo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colSexo
        '
        Me.colSexo.FillWeight = 77.40308!
        resources.ApplyResources(Me.colSexo, "colSexo")
        Me.colSexo.Name = "colSexo"
        Me.colSexo.ReadOnly = True
        Me.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colFechaNacimiento
        '
        Me.colFechaNacimiento.FillWeight = 84.31325!
        resources.ApplyResources(Me.colFechaNacimiento, "colFechaNacimiento")
        Me.colFechaNacimiento.Name = "colFechaNacimiento"
        Me.colFechaNacimiento.ReadOnly = True
        Me.colFechaNacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ColFechaDefuncion
        '
        resources.ApplyResources(Me.ColFechaDefuncion, "ColFechaDefuncion")
        Me.ColFechaDefuncion.Name = "ColFechaDefuncion"
        Me.ColFechaDefuncion.ReadOnly = True
        '
        'colCalle
        '
        Me.colCalle.FillWeight = 92.22777!
        resources.ApplyResources(Me.colCalle, "colCalle")
        Me.colCalle.Name = "colCalle"
        Me.colCalle.ReadOnly = True
        Me.colCalle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colNumeroPuerta
        '
        Me.colNumeroPuerta.FillWeight = 101.2927!
        resources.ApplyResources(Me.colNumeroPuerta, "colNumeroPuerta")
        Me.colNumeroPuerta.Name = "colNumeroPuerta"
        Me.colNumeroPuerta.ReadOnly = True
        Me.colNumeroPuerta.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colApartamento
        '
        Me.colApartamento.FillWeight = 111.6751!
        resources.ApplyResources(Me.colApartamento, "colApartamento")
        Me.colApartamento.Name = "colApartamento"
        Me.colApartamento.ReadOnly = True
        Me.colApartamento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.Color.Transparent
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVer, "btnVer")
        Me.btnVer.ForeColor = System.Drawing.Color.Transparent
        Me.btnVer.Name = "btnVer"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.ForeColor = System.Drawing.Color.Transparent
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'txtBP_Localidad
        '
        resources.ApplyResources(Me.txtBP_Localidad, "txtBP_Localidad")
        Me.txtBP_Localidad.Name = "txtBP_Localidad"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'txtBP_CI
        '
        resources.ApplyResources(Me.txtBP_CI, "txtBP_CI")
        Me.txtBP_CI.Name = "txtBP_CI"
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
        'FrmListadoPacientes
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtBP_Localidad)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBP_CI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblPacientes)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmListadoPacientes"
        CType(Me.tblPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblPacientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblTraducir As Label
    Friend WithEvents colObjeto As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colGravedad As DataGridViewTextBoxColumn
    Friend WithEvents colRec As DataGridViewTextBoxColumn
    Friend WithEvents colLocalidad As DataGridViewTextBoxColumn
    Friend WithEvents colTelMovil As DataGridViewTextBoxColumn
    Friend WithEvents colTelFijo As DataGridViewTextBoxColumn
    Friend WithEvents colSexo As DataGridViewTextBoxColumn
    Friend WithEvents colFechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaDefuncion As DataGridViewTextBoxColumn
    Friend WithEvents colCalle As DataGridViewTextBoxColumn
    Friend WithEvents colNumeroPuerta As DataGridViewTextBoxColumn
    Friend WithEvents colApartamento As DataGridViewTextBoxColumn
    Friend WithEvents txtBP_Localidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBP_CI As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

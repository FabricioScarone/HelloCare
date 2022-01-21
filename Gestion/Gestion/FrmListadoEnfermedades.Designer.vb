<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListadoEnfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoEnfermedades))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.tblEnfermedades = New System.Windows.Forms.DataGridView()
        Me.colObjeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGravedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exploradorArchivos = New System.Windows.Forms.OpenFileDialog()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscarEnfermedad = New System.Windows.Forms.TextBox()
        CType(Me.tblEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnImportar, "btnImportar")
        Me.btnImportar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVer, "btnVer")
        Me.btnVer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVer.Name = "btnVer"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnEliminar, "btnEliminar")
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        Me.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnModificar, "btnModificar")
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'tblEnfermedades
        '
        Me.tblEnfermedades.AllowUserToAddRows = False
        Me.tblEnfermedades.AllowUserToDeleteRows = False
        Me.tblEnfermedades.AllowUserToResizeColumns = False
        Me.tblEnfermedades.AllowUserToResizeRows = False
        Me.tblEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEnfermedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tblEnfermedades.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEnfermedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto, Me.colNombre, Me.colDesc, Me.colGravedad, Me.colRec})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedades.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.tblEnfermedades, "tblEnfermedades")
        Me.tblEnfermedades.Name = "tblEnfermedades"
        Me.tblEnfermedades.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 12.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedades.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblEnfermedades.RowHeadersVisible = False
        Me.tblEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblEnfermedades.TabStop = False
        '
        'colObjeto
        '
        resources.ApplyResources(Me.colObjeto, "colObjeto")
        Me.colObjeto.Name = "colObjeto"
        Me.colObjeto.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.FillWeight = 20.0!
        resources.ApplyResources(Me.colNombre, "colNombre")
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colDesc
        '
        Me.colDesc.FillWeight = 30.0!
        resources.ApplyResources(Me.colDesc, "colDesc")
        Me.colDesc.Name = "colDesc"
        Me.colDesc.ReadOnly = True
        Me.colDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colGravedad
        '
        Me.colGravedad.FillWeight = 10.0!
        resources.ApplyResources(Me.colGravedad, "colGravedad")
        Me.colGravedad.Name = "colGravedad"
        Me.colGravedad.ReadOnly = True
        Me.colGravedad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'colRec
        '
        Me.colRec.FillWeight = 20.0!
        resources.ApplyResources(Me.colRec, "colRec")
        Me.colRec.Name = "colRec"
        Me.colRec.ReadOnly = True
        Me.colRec.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'exploradorArchivos
        '
        Me.exploradorArchivos.FileName = "OpenFileDialog1"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Name = "Label4"
        '
        'txtBuscarEnfermedad
        '
        resources.ApplyResources(Me.txtBuscarEnfermedad, "txtBuscarEnfermedad")
        Me.txtBuscarEnfermedad.Name = "txtBuscarEnfermedad"
        '
        'FrmListadoEnfermedades
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnVolver
        Me.Controls.Add(Me.txtBuscarEnfermedad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblEnfermedades)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmListadoEnfermedades"
        CType(Me.tblEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImportar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents tblEnfermedades As DataGridView
    Friend WithEvents exploradorArchivos As OpenFileDialog
    Friend WithEvents colObjeto As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colDesc As DataGridViewTextBoxColumn
    Friend WithEvents colGravedad As DataGridViewTextBoxColumn
    Friend WithEvents colRec As DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscarEnfermedad As TextBox
End Class

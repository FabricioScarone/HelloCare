<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoSintoma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoSintoma))
        Me.LblIngresarSintoma = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tblDisponibles = New System.Windows.Forms.DataGridView()
        Me.colObjeto1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblSeleccionados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIngresarSintoma
        '
        resources.ApplyResources(Me.LblIngresarSintoma, "LblIngresarSintoma")
        Me.LblIngresarSintoma.BackColor = System.Drawing.Color.Transparent
        Me.LblIngresarSintoma.Name = "LblIngresarSintoma"
        '
        'Titulo
        '
        resources.ApplyResources(Me.Titulo, "Titulo")
        Me.Titulo.BackColor = System.Drawing.Color.Transparent
        Me.Titulo.Name = "Titulo"
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnAgregar
        '
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        resources.ApplyResources(Me.btnQuitar, "btnQuitar")
        Me.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblSintomasSeleccionados
        '
        resources.ApplyResources(Me.lblSintomasSeleccionados, "lblSintomasSeleccionados")
        Me.lblSintomasSeleccionados.BackColor = System.Drawing.Color.Transparent
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        '
        'btnEnviar
        '
        resources.ApplyResources(Me.btnEnviar, "btnEnviar")
        Me.btnEnviar.ForeColor = System.Drawing.Color.White
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'tblDisponibles
        '
        Me.tblDisponibles.AllowUserToAddRows = False
        Me.tblDisponibles.AllowUserToDeleteRows = False
        Me.tblDisponibles.AllowUserToResizeColumns = False
        Me.tblDisponibles.AllowUserToResizeRows = False
        Me.tblDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblDisponibles.ColumnHeadersVisible = False
        Me.tblDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto1, Me.colNombre1})
        resources.ApplyResources(Me.tblDisponibles, "tblDisponibles")
        Me.tblDisponibles.Name = "tblDisponibles"
        Me.tblDisponibles.ReadOnly = True
        Me.tblDisponibles.RowHeadersVisible = False
        Me.tblDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblDisponibles.TabStop = False
        '
        'colObjeto1
        '
        resources.ApplyResources(Me.colObjeto1, "colObjeto1")
        Me.colObjeto1.Name = "colObjeto1"
        Me.colObjeto1.ReadOnly = True
        '
        'colNombre1
        '
        resources.ApplyResources(Me.colNombre1, "colNombre1")
        Me.colNombre1.Name = "colNombre1"
        Me.colNombre1.ReadOnly = True
        '
        'tblSeleccionados
        '
        Me.tblSeleccionados.AllowUserToAddRows = False
        Me.tblSeleccionados.AllowUserToDeleteRows = False
        Me.tblSeleccionados.AllowUserToResizeColumns = False
        Me.tblSeleccionados.AllowUserToResizeRows = False
        Me.tblSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblSeleccionados.ColumnHeadersVisible = False
        Me.tblSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        resources.ApplyResources(Me.tblSeleccionados, "tblSeleccionados")
        Me.tblSeleccionados.Name = "tblSeleccionados"
        Me.tblSeleccionados.ReadOnly = True
        Me.tblSeleccionados.RowHeadersVisible = False
        Me.tblSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tblSeleccionados.TabStop = False
        '
        'DataGridViewTextBoxColumn1
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmIngresoSintoma
        '
        Me.AcceptButton = Me.btnEnviar
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblSeleccionados)
        Me.Controls.Add(Me.tblDisponibles)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lblSintomasSeleccionados)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.LblIngresarSintoma)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmIngresoSintoma"
        CType(Me.tblDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblIngresarSintoma As Windows.Forms.Label
    Friend WithEvents Titulo As Windows.Forms.Label
    Friend WithEvents txtBuscar As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents btnAgregar As Windows.Forms.Button
    Friend WithEvents btnQuitar As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents lblSintomasSeleccionados As Windows.Forms.Label
    Friend WithEvents btnEnviar As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents tblDisponibles As Windows.Forms.DataGridView
    Friend WithEvents tblSeleccionados As Windows.Forms.DataGridView
    Friend WithEvents colObjeto1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificacionMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificacionMedico))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.tblLocalidad = New System.Windows.Forms.DataGridView()
        Me.colNomEnfermedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscarEspecialidades = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tblAsociados = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarE = New System.Windows.Forms.Button()
        Me.btnAgregarE = New System.Windows.Forms.Button()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.tblEspecialidades = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblLocalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblAsociados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.Color.Transparent
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'tblLocalidad
        '
        Me.tblLocalidad.AllowUserToAddRows = False
        Me.tblLocalidad.AllowUserToDeleteRows = False
        Me.tblLocalidad.AllowUserToResizeColumns = False
        Me.tblLocalidad.AllowUserToResizeRows = False
        Me.tblLocalidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblLocalidad.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.tblLocalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblLocalidad.ColumnHeadersVisible = False
        Me.tblLocalidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNomEnfermedad})
        resources.ApplyResources(Me.tblLocalidad, "tblLocalidad")
        Me.tblLocalidad.MultiSelect = False
        Me.tblLocalidad.Name = "tblLocalidad"
        Me.tblLocalidad.RowHeadersVisible = False
        Me.tblLocalidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colNomEnfermedad
        '
        Me.colNomEnfermedad.FillWeight = 75.0!
        resources.ApplyResources(Me.colNomEnfermedad, "colNomEnfermedad")
        Me.colNomEnfermedad.Name = "colNomEnfermedad"
        Me.colNomEnfermedad.ReadOnly = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Name = "Label6"
        '
        'txtCorreo
        '
        resources.ApplyResources(Me.txtCorreo, "txtCorreo")
        Me.txtCorreo.Name = "txtCorreo"
        '
        'txtApellido
        '
        resources.ApplyResources(Me.txtApellido, "txtApellido")
        Me.txtApellido.Name = "txtApellido"
        '
        'txtNombre
        '
        resources.ApplyResources(Me.txtNombre, "txtNombre")
        Me.txtNombre.Name = "txtNombre"
        '
        'txtCI
        '
        resources.ApplyResources(Me.txtCI, "txtCI")
        Me.txtCI.Name = "txtCI"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Name = "Label3"
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
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnConfirmar, "btnConfirmar")
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Transparent
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Name = "Label10"
        '
        'txtBuscarEspecialidades
        '
        resources.ApplyResources(Me.txtBuscarEspecialidades, "txtBuscarEspecialidades")
        Me.txtBuscarEspecialidades.Name = "txtBuscarEspecialidades"
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.FormattingEnabled = True
        resources.ApplyResources(Me.cmbDepartamento, "cmbDepartamento")
        Me.cmbDepartamento.Name = "cmbDepartamento"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Name = "Label14"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Name = "Label7"
        '
        'tblAsociados
        '
        Me.tblAsociados.AllowUserToAddRows = False
        Me.tblAsociados.AllowUserToDeleteRows = False
        Me.tblAsociados.AllowUserToResizeColumns = False
        Me.tblAsociados.AllowUserToResizeRows = False
        Me.tblAsociados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblAsociados.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.tblAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblAsociados.ColumnHeadersVisible = False
        Me.tblAsociados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.tblAsociados.EnableHeadersVisualStyles = False
        resources.ApplyResources(Me.tblAsociados, "tblAsociados")
        Me.tblAsociados.MultiSelect = False
        Me.tblAsociados.Name = "tblAsociados"
        Me.tblAsociados.ReadOnly = True
        Me.tblAsociados.RowHeadersVisible = False
        Me.tblAsociados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'DataGridViewTextBoxColumn1
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnQuitarE
        '
        Me.btnQuitarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnQuitarE, "btnQuitarE")
        Me.btnQuitarE.ForeColor = System.Drawing.Color.Transparent
        Me.btnQuitarE.Name = "btnQuitarE"
        Me.btnQuitarE.UseVisualStyleBackColor = False
        '
        'btnAgregarE
        '
        Me.btnAgregarE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarE, "btnAgregarE")
        Me.btnAgregarE.ForeColor = System.Drawing.Color.Transparent
        Me.btnAgregarE.Name = "btnAgregarE"
        Me.btnAgregarE.UseVisualStyleBackColor = False
        '
        'lblEspecialidad
        '
        resources.ApplyResources(Me.lblEspecialidad, "lblEspecialidad")
        Me.lblEspecialidad.BackColor = System.Drawing.Color.Transparent
        Me.lblEspecialidad.Name = "lblEspecialidad"
        '
        'tblEspecialidades
        '
        Me.tblEspecialidades.AllowUserToAddRows = False
        Me.tblEspecialidades.AllowUserToDeleteRows = False
        Me.tblEspecialidades.AllowUserToResizeColumns = False
        Me.tblEspecialidades.AllowUserToResizeRows = False
        Me.tblEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEspecialidades.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.tblEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEspecialidades.ColumnHeadersVisible = False
        Me.tblEspecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.tblEspecialidades.EnableHeadersVisualStyles = False
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
        'FrmModificacionMedico
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tblAsociados)
        Me.Controls.Add(Me.btnQuitarE)
        Me.Controls.Add(Me.btnAgregarE)
        Me.Controls.Add(Me.lblEspecialidad)
        Me.Controls.Add(Me.tblEspecialidades)
        Me.Controls.Add(Me.cmbDepartamento)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBuscarEspecialidades)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.tblLocalidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmModificacionMedico"
        CType(Me.tblLocalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblAsociados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents tblLocalidad As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBuscarEspecialidades As TextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tblAsociados As DataGridView
    Friend WithEvents btnQuitarE As Button
    Friend WithEvents btnAgregarE As Button
    Friend WithEvents lblEspecialidad As Label
    Friend WithEvents tblEspecialidades As DataGridView
    Friend WithEvents colNomEnfermedad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Label
End Class

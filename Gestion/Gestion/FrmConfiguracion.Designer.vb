<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnAgregarDepartamento = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAgregarDepartamento = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.btnModificarDepartamento = New System.Windows.Forms.Button()
        Me.txtNuevoNombreDepartamento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreDepartamentoAModificar = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.btnEliminarDepartamento = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEliminarDepartamento = New System.Windows.Forms.TextBox()
        Me.grdDepartamentos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarDepartamento = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbxDepartamentos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnAgregarLocalidad = New System.Windows.Forms.Button()
        Me.cbxDepartamentoDeNuevaLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAgregarLocalidad = New System.Windows.Forms.TextBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.btnModificarLocalidad = New System.Windows.Forms.Button()
        Me.txtNuevoNombreLocalidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Localidad = New System.Windows.Forms.Label()
        Me.txtNombreLocalidadAModificar = New System.Windows.Forms.TextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.btnCambiarDepartamentoDeLocalidad = New System.Windows.Forms.Button()
        Me.txtLocalidadParaCambiarDepartamento = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDepartamentoActual = New System.Windows.Forms.TextBox()
        Me.cbxNuevoDepartamentoDeLocalidad = New System.Windows.Forms.ComboBox()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.btnEliminarLocalidad = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEliminarLocalidad = New System.Windows.Forms.TextBox()
        Me.grdLocalidades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBuscarLocalidades = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.btnAgregarEspecialidad = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAgregarEspecialidad = New System.Windows.Forms.TextBox()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.btnModificarEspecialidad = New System.Windows.Forms.Button()
        Me.txtNuevoNombreEspecialidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtNombreEspecialidadAModificar = New System.Windows.Forms.TextBox()
        Me.TabPage13 = New System.Windows.Forms.TabPage()
        Me.btnEliminarEspecialidad = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEliminarEspecialidad = New System.Windows.Forms.TextBox()
        Me.grdEspecialidades = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtBuscarEspecialidad = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTraducir = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.grdDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        CType(Me.grdLocalidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        CType(Me.grdEspecialidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Controls.Add(Me.grdDepartamentos)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtBuscarDepartamento)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        resources.ApplyResources(Me.TabControl2, "TabControl2")
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnAgregarDepartamento)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.txtAgregarDepartamento)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnAgregarDepartamento
        '
        Me.btnAgregarDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarDepartamento, "btnAgregarDepartamento")
        Me.btnAgregarDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarDepartamento.Name = "btnAgregarDepartamento"
        Me.btnAgregarDepartamento.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtAgregarDepartamento
        '
        resources.ApplyResources(Me.txtAgregarDepartamento, "txtAgregarDepartamento")
        Me.txtAgregarDepartamento.Name = "txtAgregarDepartamento"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnModificarDepartamento)
        Me.TabPage5.Controls.Add(Me.txtNuevoNombreDepartamento)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.txtNombreDepartamentoAModificar)
        resources.ApplyResources(Me.TabPage5, "TabPage5")
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'btnModificarDepartamento
        '
        Me.btnModificarDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnModificarDepartamento, "btnModificarDepartamento")
        Me.btnModificarDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarDepartamento.Name = "btnModificarDepartamento"
        Me.btnModificarDepartamento.UseVisualStyleBackColor = False
        '
        'txtNuevoNombreDepartamento
        '
        resources.ApplyResources(Me.txtNuevoNombreDepartamento, "txtNuevoNombreDepartamento")
        Me.txtNuevoNombreDepartamento.Name = "txtNuevoNombreDepartamento"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtNombreDepartamentoAModificar
        '
        resources.ApplyResources(Me.txtNombreDepartamentoAModificar, "txtNombreDepartamentoAModificar")
        Me.txtNombreDepartamentoAModificar.Name = "txtNombreDepartamentoAModificar"
        Me.txtNombreDepartamentoAModificar.ReadOnly = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnEliminarDepartamento)
        Me.TabPage6.Controls.Add(Me.Label6)
        Me.TabPage6.Controls.Add(Me.txtEliminarDepartamento)
        resources.ApplyResources(Me.TabPage6, "TabPage6")
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'btnEliminarDepartamento
        '
        Me.btnEliminarDepartamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnEliminarDepartamento, "btnEliminarDepartamento")
        Me.btnEliminarDepartamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarDepartamento.Name = "btnEliminarDepartamento"
        Me.btnEliminarDepartamento.UseVisualStyleBackColor = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtEliminarDepartamento
        '
        resources.ApplyResources(Me.txtEliminarDepartamento, "txtEliminarDepartamento")
        Me.txtEliminarDepartamento.Name = "txtEliminarDepartamento"
        Me.txtEliminarDepartamento.ReadOnly = True
        '
        'grdDepartamentos
        '
        Me.grdDepartamentos.AllowUserToAddRows = False
        Me.grdDepartamentos.AllowUserToDeleteRows = False
        Me.grdDepartamentos.AllowUserToResizeColumns = False
        Me.grdDepartamentos.AllowUserToResizeRows = False
        Me.grdDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDepartamentos.BackgroundColor = System.Drawing.Color.White
        Me.grdDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDepartamentos.ColumnHeadersVisible = False
        Me.grdDepartamentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDepartamentos.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.grdDepartamentos, "grdDepartamentos")
        Me.grdDepartamentos.MultiSelect = False
        Me.grdDepartamentos.Name = "grdDepartamentos"
        Me.grdDepartamentos.ReadOnly = True
        Me.grdDepartamentos.RowHeadersVisible = False
        Me.grdDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtBuscarDepartamento
        '
        resources.ApplyResources(Me.txtBuscarDepartamento, "txtBuscarDepartamento")
        Me.txtBuscarDepartamento.Name = "txtBuscarDepartamento"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cbxDepartamentos)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.TabControl3)
        Me.TabPage2.Controls.Add(Me.grdLocalidades)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtBuscarLocalidades)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cbxDepartamentos
        '
        Me.cbxDepartamentos.FormattingEnabled = True
        resources.ApplyResources(Me.cbxDepartamentos, "cbxDepartamentos")
        Me.cbxDepartamentos.Name = "cbxDepartamentos"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Controls.Add(Me.TabPage10)
        Me.TabControl3.Controls.Add(Me.TabPage9)
        resources.ApplyResources(Me.TabControl3, "TabControl3")
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.btnAgregarLocalidad)
        Me.TabPage7.Controls.Add(Me.cbxDepartamentoDeNuevaLocalidad)
        Me.TabPage7.Controls.Add(Me.Label13)
        Me.TabPage7.Controls.Add(Me.Label7)
        Me.TabPage7.Controls.Add(Me.txtAgregarLocalidad)
        resources.ApplyResources(Me.TabPage7, "TabPage7")
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'btnAgregarLocalidad
        '
        Me.btnAgregarLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarLocalidad, "btnAgregarLocalidad")
        Me.btnAgregarLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarLocalidad.Name = "btnAgregarLocalidad"
        Me.btnAgregarLocalidad.UseVisualStyleBackColor = False
        '
        'cbxDepartamentoDeNuevaLocalidad
        '
        Me.cbxDepartamentoDeNuevaLocalidad.FormattingEnabled = True
        resources.ApplyResources(Me.cbxDepartamentoDeNuevaLocalidad, "cbxDepartamentoDeNuevaLocalidad")
        Me.cbxDepartamentoDeNuevaLocalidad.Name = "cbxDepartamentoDeNuevaLocalidad"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtAgregarLocalidad
        '
        resources.ApplyResources(Me.txtAgregarLocalidad, "txtAgregarLocalidad")
        Me.txtAgregarLocalidad.Name = "txtAgregarLocalidad"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnModificarLocalidad)
        Me.TabPage8.Controls.Add(Me.txtNuevoNombreLocalidad)
        Me.TabPage8.Controls.Add(Me.Label8)
        Me.TabPage8.Controls.Add(Me.Localidad)
        Me.TabPage8.Controls.Add(Me.txtNombreLocalidadAModificar)
        resources.ApplyResources(Me.TabPage8, "TabPage8")
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'btnModificarLocalidad
        '
        Me.btnModificarLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnModificarLocalidad, "btnModificarLocalidad")
        Me.btnModificarLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarLocalidad.Name = "btnModificarLocalidad"
        Me.btnModificarLocalidad.UseVisualStyleBackColor = False
        '
        'txtNuevoNombreLocalidad
        '
        resources.ApplyResources(Me.txtNuevoNombreLocalidad, "txtNuevoNombreLocalidad")
        Me.txtNuevoNombreLocalidad.Name = "txtNuevoNombreLocalidad"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Localidad
        '
        resources.ApplyResources(Me.Localidad, "Localidad")
        Me.Localidad.Name = "Localidad"
        '
        'txtNombreLocalidadAModificar
        '
        resources.ApplyResources(Me.txtNombreLocalidadAModificar, "txtNombreLocalidadAModificar")
        Me.txtNombreLocalidadAModificar.Name = "txtNombreLocalidadAModificar"
        Me.txtNombreLocalidadAModificar.ReadOnly = True
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.btnCambiarDepartamentoDeLocalidad)
        Me.TabPage10.Controls.Add(Me.txtLocalidadParaCambiarDepartamento)
        Me.TabPage10.Controls.Add(Me.Label20)
        Me.TabPage10.Controls.Add(Me.Label14)
        Me.TabPage10.Controls.Add(Me.Label9)
        Me.TabPage10.Controls.Add(Me.txtDepartamentoActual)
        Me.TabPage10.Controls.Add(Me.cbxNuevoDepartamentoDeLocalidad)
        resources.ApplyResources(Me.TabPage10, "TabPage10")
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'btnCambiarDepartamentoDeLocalidad
        '
        Me.btnCambiarDepartamentoDeLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnCambiarDepartamentoDeLocalidad, "btnCambiarDepartamentoDeLocalidad")
        Me.btnCambiarDepartamentoDeLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCambiarDepartamentoDeLocalidad.Name = "btnCambiarDepartamentoDeLocalidad"
        Me.btnCambiarDepartamentoDeLocalidad.UseVisualStyleBackColor = False
        '
        'txtLocalidadParaCambiarDepartamento
        '
        resources.ApplyResources(Me.txtLocalidadParaCambiarDepartamento, "txtLocalidadParaCambiarDepartamento")
        Me.txtLocalidadParaCambiarDepartamento.Name = "txtLocalidadParaCambiarDepartamento"
        Me.txtLocalidadParaCambiarDepartamento.ReadOnly = True
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'txtDepartamentoActual
        '
        resources.ApplyResources(Me.txtDepartamentoActual, "txtDepartamentoActual")
        Me.txtDepartamentoActual.Name = "txtDepartamentoActual"
        Me.txtDepartamentoActual.ReadOnly = True
        '
        'cbxNuevoDepartamentoDeLocalidad
        '
        Me.cbxNuevoDepartamentoDeLocalidad.FormattingEnabled = True
        resources.ApplyResources(Me.cbxNuevoDepartamentoDeLocalidad, "cbxNuevoDepartamentoDeLocalidad")
        Me.cbxNuevoDepartamentoDeLocalidad.Name = "cbxNuevoDepartamentoDeLocalidad"
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.btnEliminarLocalidad)
        Me.TabPage9.Controls.Add(Me.Label10)
        Me.TabPage9.Controls.Add(Me.txtEliminarLocalidad)
        resources.ApplyResources(Me.TabPage9, "TabPage9")
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'btnEliminarLocalidad
        '
        Me.btnEliminarLocalidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnEliminarLocalidad, "btnEliminarLocalidad")
        Me.btnEliminarLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarLocalidad.Name = "btnEliminarLocalidad"
        Me.btnEliminarLocalidad.UseVisualStyleBackColor = False
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txtEliminarLocalidad
        '
        resources.ApplyResources(Me.txtEliminarLocalidad, "txtEliminarLocalidad")
        Me.txtEliminarLocalidad.Name = "txtEliminarLocalidad"
        Me.txtEliminarLocalidad.ReadOnly = True
        '
        'grdLocalidades
        '
        Me.grdLocalidades.AllowUserToAddRows = False
        Me.grdLocalidades.AllowUserToDeleteRows = False
        Me.grdLocalidades.AllowUserToResizeColumns = False
        Me.grdLocalidades.AllowUserToResizeRows = False
        Me.grdLocalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdLocalidades.BackgroundColor = System.Drawing.Color.White
        Me.grdLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLocalidades.ColumnHeadersVisible = False
        Me.grdLocalidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdLocalidades.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.grdLocalidades, "grdLocalidades")
        Me.grdLocalidades.MultiSelect = False
        Me.grdLocalidades.Name = "grdLocalidades"
        Me.grdLocalidades.ReadOnly = True
        Me.grdLocalidades.RowHeadersVisible = False
        Me.grdLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'DataGridViewTextBoxColumn1
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'txtBuscarLocalidades
        '
        resources.ApplyResources(Me.txtBuscarLocalidades, "txtBuscarLocalidades")
        Me.txtBuscarLocalidades.Name = "txtBuscarLocalidades"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TabControl4)
        Me.TabPage3.Controls.Add(Me.grdEspecialidades)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.txtBuscarEspecialidad)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage11)
        Me.TabControl4.Controls.Add(Me.TabPage12)
        Me.TabControl4.Controls.Add(Me.TabPage13)
        resources.ApplyResources(Me.TabControl4, "TabControl4")
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.btnAgregarEspecialidad)
        Me.TabPage11.Controls.Add(Me.Label15)
        Me.TabPage11.Controls.Add(Me.txtAgregarEspecialidad)
        resources.ApplyResources(Me.TabPage11, "TabPage11")
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'btnAgregarEspecialidad
        '
        Me.btnAgregarEspecialidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnAgregarEspecialidad, "btnAgregarEspecialidad")
        Me.btnAgregarEspecialidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregarEspecialidad.Name = "btnAgregarEspecialidad"
        Me.btnAgregarEspecialidad.UseVisualStyleBackColor = False
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'txtAgregarEspecialidad
        '
        resources.ApplyResources(Me.txtAgregarEspecialidad, "txtAgregarEspecialidad")
        Me.txtAgregarEspecialidad.Name = "txtAgregarEspecialidad"
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.btnModificarEspecialidad)
        Me.TabPage12.Controls.Add(Me.txtNuevoNombreEspecialidad)
        Me.TabPage12.Controls.Add(Me.Label16)
        Me.TabPage12.Controls.Add(Me.Label17)
        Me.TabPage12.Controls.Add(Me.txtNombreEspecialidadAModificar)
        resources.ApplyResources(Me.TabPage12, "TabPage12")
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'btnModificarEspecialidad
        '
        Me.btnModificarEspecialidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnModificarEspecialidad, "btnModificarEspecialidad")
        Me.btnModificarEspecialidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificarEspecialidad.Name = "btnModificarEspecialidad"
        Me.btnModificarEspecialidad.UseVisualStyleBackColor = False
        '
        'txtNuevoNombreEspecialidad
        '
        resources.ApplyResources(Me.txtNuevoNombreEspecialidad, "txtNuevoNombreEspecialidad")
        Me.txtNuevoNombreEspecialidad.Name = "txtNuevoNombreEspecialidad"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'txtNombreEspecialidadAModificar
        '
        resources.ApplyResources(Me.txtNombreEspecialidadAModificar, "txtNombreEspecialidadAModificar")
        Me.txtNombreEspecialidadAModificar.Name = "txtNombreEspecialidadAModificar"
        Me.txtNombreEspecialidadAModificar.ReadOnly = True
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.btnEliminarEspecialidad)
        Me.TabPage13.Controls.Add(Me.Label18)
        Me.TabPage13.Controls.Add(Me.txtEliminarEspecialidad)
        resources.ApplyResources(Me.TabPage13, "TabPage13")
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'btnEliminarEspecialidad
        '
        Me.btnEliminarEspecialidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnEliminarEspecialidad, "btnEliminarEspecialidad")
        Me.btnEliminarEspecialidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad"
        Me.btnEliminarEspecialidad.UseVisualStyleBackColor = False
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'txtEliminarEspecialidad
        '
        resources.ApplyResources(Me.txtEliminarEspecialidad, "txtEliminarEspecialidad")
        Me.txtEliminarEspecialidad.Name = "txtEliminarEspecialidad"
        Me.txtEliminarEspecialidad.ReadOnly = True
        '
        'grdEspecialidades
        '
        Me.grdEspecialidades.AllowUserToAddRows = False
        Me.grdEspecialidades.AllowUserToDeleteRows = False
        Me.grdEspecialidades.AllowUserToResizeColumns = False
        Me.grdEspecialidades.AllowUserToResizeRows = False
        Me.grdEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdEspecialidades.BackgroundColor = System.Drawing.Color.White
        Me.grdEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEspecialidades.ColumnHeadersVisible = False
        Me.grdEspecialidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdEspecialidades.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.grdEspecialidades, "grdEspecialidades")
        Me.grdEspecialidades.MultiSelect = False
        Me.grdEspecialidades.Name = "grdEspecialidades"
        Me.grdEspecialidades.ReadOnly = True
        Me.grdEspecialidades.RowHeadersVisible = False
        Me.grdEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'DataGridViewTextBoxColumn2
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'txtBuscarEspecialidad
        '
        resources.ApplyResources(Me.txtBuscarEspecialidad, "txtBuscarEspecialidad")
        Me.txtBuscarEspecialidad.Name = "txtBuscarEspecialidad"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Name = "Label1"
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmConfiguracion
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmConfiguracion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.grdDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        CType(Me.grdLocalidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        CType(Me.grdEspecialidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnAgregarDepartamento As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAgregarDepartamento As TextBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents txtNuevoNombreDepartamento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombreDepartamentoAModificar As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEliminarDepartamento As TextBox
    Friend WithEvents grdDepartamentos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscarDepartamento As TextBox
    Friend WithEvents cbxDepartamentos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents cbxDepartamentoDeNuevaLocalidad As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAgregarLocalidad As TextBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents txtNuevoNombreLocalidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Localidad As Label
    Friend WithEvents txtNombreLocalidadAModificar As TextBox
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDepartamentoActual As TextBox
    Friend WithEvents cbxNuevoDepartamentoDeLocalidad As ComboBox
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEliminarLocalidad As TextBox
    Friend WithEvents grdLocalidades As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBuscarLocalidades As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TabPage11 As TabPage
    Friend WithEvents Label15 As Label
    Friend WithEvents txtAgregarEspecialidad As TextBox
    Friend WithEvents TabPage12 As TabPage
    Friend WithEvents txtNuevoNombreEspecialidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtNombreEspecialidadAModificar As TextBox
    Friend WithEvents TabPage13 As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEliminarEspecialidad As TextBox
    Friend WithEvents grdEspecialidades As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBuscarEspecialidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtLocalidadParaCambiarDepartamento As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnModificarDepartamento As Button
    Friend WithEvents btnEliminarDepartamento As Button
    Friend WithEvents btnAgregarLocalidad As Button
    Friend WithEvents btnModificarLocalidad As Button
    Friend WithEvents btnCambiarDepartamentoDeLocalidad As Button
    Friend WithEvents btnEliminarLocalidad As Button
    Friend WithEvents btnAgregarEspecialidad As Button
    Friend WithEvents btnModificarEspecialidad As Button
    Friend WithEvents btnEliminarEspecialidad As Button
    Friend WithEvents lblTraducir As Label
End Class

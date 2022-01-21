<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevoDiagnostico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoDiagnostico))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnEnviarDiagnostico = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConductaASeguir = New System.Windows.Forms.TextBox()
        Me.tblEnfermedades = New System.Windows.Forms.DataGridView()
        Me.colObjeto2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTraducir = New System.Windows.Forms.Label()
        CType(Me.tblEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnviarDiagnostico
        '
        Me.btnEnviarDiagnostico.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnEnviarDiagnostico, "btnEnviarDiagnostico")
        Me.btnEnviarDiagnostico.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEnviarDiagnostico.Name = "btnEnviarDiagnostico"
        Me.btnEnviarDiagnostico.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        resources.ApplyResources(Me.btnVolver, "btnVolver")
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Name = "Label2"
        '
        'txtBuscar
        '
        resources.ApplyResources(Me.txtBuscar, "txtBuscar")
        Me.txtBuscar.Name = "txtBuscar"
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
        'txtConductaASeguir
        '
        resources.ApplyResources(Me.txtConductaASeguir, "txtConductaASeguir")
        Me.txtConductaASeguir.Name = "txtConductaASeguir"
        '
        'tblEnfermedades
        '
        Me.tblEnfermedades.AllowUserToAddRows = False
        Me.tblEnfermedades.AllowUserToDeleteRows = False
        Me.tblEnfermedades.AllowUserToResizeColumns = False
        Me.tblEnfermedades.AllowUserToResizeRows = False
        Me.tblEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tblEnfermedades.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tblEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblEnfermedades.ColumnHeadersVisible = False
        Me.tblEnfermedades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObjeto2})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tblEnfermedades.DefaultCellStyle = DataGridViewCellStyle2
        Me.tblEnfermedades.GridColor = System.Drawing.Color.White
        resources.ApplyResources(Me.tblEnfermedades, "tblEnfermedades")
        Me.tblEnfermedades.MultiSelect = False
        Me.tblEnfermedades.Name = "tblEnfermedades"
        Me.tblEnfermedades.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Lato", 15.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tblEnfermedades.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.tblEnfermedades.RowHeadersVisible = False
        Me.tblEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colObjeto2
        '
        resources.ApplyResources(Me.colObjeto2, "colObjeto2")
        Me.colObjeto2.Name = "colObjeto2"
        Me.colObjeto2.ReadOnly = True
        '
        'lblTraducir
        '
        Me.lblTraducir.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTraducir, "lblTraducir")
        Me.lblTraducir.ForeColor = System.Drawing.Color.White
        Me.lblTraducir.Name = "lblTraducir"
        '
        'FrmNuevoDiagnostico
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTraducir)
        Me.Controls.Add(Me.tblEnfermedades)
        Me.Controls.Add(Me.txtConductaASeguir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEnviarDiagnostico)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "FrmNuevoDiagnostico"
        CType(Me.tblEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnviarDiagnostico As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtConductaASeguir As TextBox
    Friend WithEvents tblEnfermedades As DataGridView
    Friend WithEvents colObjeto2 As DataGridViewTextBoxColumn
    Friend WithEvents lblTraducir As Label
End Class

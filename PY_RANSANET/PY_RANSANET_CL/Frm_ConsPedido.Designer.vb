<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsPedido
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsPedido))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.hgPedido = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.dgvPedido = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonHeaderGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.KryptonGroup3 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDesCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtCodCliente = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkCliente = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkFecha = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.dtpFecFin = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpFecInicio = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodPedido = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.chkCodPedido = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbConsultar = New System.Windows.Forms.ToolStripButton()
        Me.tsbExportar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgPedido.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgPedido.Panel.SuspendLayout()
        Me.hgPedido.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonHeaderGroup1.Panel.SuspendLayout()
        Me.KryptonHeaderGroup1.SuspendLayout()
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup3.Panel.SuspendLayout()
        Me.KryptonGroup3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgPedido)
        Me.KryptonPanel.Controls.Add(Me.KryptonHeaderGroup1)
        Me.KryptonPanel.Controls.Add(Me.ToolStrip1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(787, 282)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgPedido
        '
        Me.hgPedido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgPedido.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgPedido.HeaderVisibleSecondary = False
        Me.hgPedido.Location = New System.Drawing.Point(0, 110)
        Me.hgPedido.Name = "hgPedido"
        '
        'hgPedido.Panel
        '
        Me.hgPedido.Panel.Controls.Add(Me.KryptonGroup1)
        Me.hgPedido.Size = New System.Drawing.Size(787, 172)
        Me.hgPedido.TabIndex = 1
        Me.hgPedido.ValuesPrimary.Heading = "Pedidos (Registros: 0)"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonGroup1.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.dgvPedido)
        Me.KryptonGroup1.Size = New System.Drawing.Size(779, 143)
        Me.KryptonGroup1.TabIndex = 1
        '
        'dgvPedido
        '
        Me.dgvPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPedido.Location = New System.Drawing.Point(3, 3)
        Me.dgvPedido.Name = "dgvPedido"
        Me.dgvPedido.ReadOnly = True
        Me.dgvPedido.Size = New System.Drawing.Size(771, 135)
        Me.dgvPedido.TabIndex = 0
        '
        'KryptonHeaderGroup1
        '
        Me.KryptonHeaderGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonHeaderGroup1.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.KryptonHeaderGroup1.HeaderVisibleSecondary = False
        Me.KryptonHeaderGroup1.Location = New System.Drawing.Point(0, 25)
        Me.KryptonHeaderGroup1.Name = "KryptonHeaderGroup1"
        '
        'KryptonHeaderGroup1.Panel
        '
        Me.KryptonHeaderGroup1.Panel.Controls.Add(Me.KryptonGroup3)
        Me.KryptonHeaderGroup1.Size = New System.Drawing.Size(787, 85)
        Me.KryptonHeaderGroup1.TabIndex = 0
        Me.KryptonHeaderGroup1.ValuesPrimary.Heading = "Filtro Búsqueda"
        '
        'KryptonGroup3
        '
        Me.KryptonGroup3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonGroup3.Location = New System.Drawing.Point(3, 3)
        Me.KryptonGroup3.Name = "KryptonGroup3"
        '
        'KryptonGroup3.Panel
        '
        Me.KryptonGroup3.Panel.Controls.Add(Me.GroupBox2)
        Me.KryptonGroup3.Panel.Controls.Add(Me.GroupBox3)
        Me.KryptonGroup3.Panel.Controls.Add(Me.GroupBox1)
        Me.KryptonGroup3.Size = New System.Drawing.Size(779, 56)
        Me.KryptonGroup3.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtDesCliente)
        Me.GroupBox2.Controls.Add(Me.txtCodCliente)
        Me.GroupBox2.Controls.Add(Me.chkCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(452, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 47)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtDesCliente
        '
        Me.txtDesCliente.Enabled = False
        Me.txtDesCliente.Location = New System.Drawing.Point(101, 18)
        Me.txtDesCliente.Name = "txtDesCliente"
        Me.txtDesCliente.Size = New System.Drawing.Size(215, 20)
        Me.txtDesCliente.TabIndex = 2
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Enabled = False
        Me.txtCodCliente.Location = New System.Drawing.Point(60, 18)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(40, 20)
        Me.txtCodCliente.TabIndex = 1
        '
        'chkCliente
        '
        Me.chkCliente.Location = New System.Drawing.Point(3, 18)
        Me.chkCliente.Name = "chkCliente"
        Me.chkCliente.Size = New System.Drawing.Size(61, 20)
        Me.chkCliente.TabIndex = 0
        Me.chkCliente.Values.Text = "Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.ChkFecha)
        Me.GroupBox3.Controls.Add(Me.dtpFecFin)
        Me.GroupBox3.Controls.Add(Me.dtpFecInicio)
        Me.GroupBox3.Controls.Add(Me.KryptonLabel2)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 47)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'ChkFecha
        '
        Me.ChkFecha.Location = New System.Drawing.Point(4, 18)
        Me.ChkFecha.Name = "ChkFecha"
        Me.ChkFecha.Size = New System.Drawing.Size(42, 20)
        Me.ChkFecha.TabIndex = 1
        Me.ChkFecha.Values.Text = "Del"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Enabled = False
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(162, 17)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecFin.TabIndex = 1
        '
        'dtpFecInicio
        '
        Me.dtpFecInicio.Enabled = False
        Me.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecInicio.Location = New System.Drawing.Point(52, 17)
        Me.dtpFecInicio.Name = "dtpFecInicio"
        Me.dtpFecInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecInicio.TabIndex = 0
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(139, 18)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(21, 20)
        Me.KryptonLabel2.TabIndex = 0
        Me.KryptonLabel2.Values.Text = "Al"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCodPedido)
        Me.GroupBox1.Controls.Add(Me.chkCodPedido)
        Me.GroupBox1.Location = New System.Drawing.Point(261, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 47)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtCodPedido
        '
        Me.txtCodPedido.Enabled = False
        Me.txtCodPedido.Location = New System.Drawing.Point(91, 18)
        Me.txtCodPedido.Name = "txtCodPedido"
        Me.txtCodPedido.Size = New System.Drawing.Size(91, 20)
        Me.txtCodPedido.TabIndex = 1
        '
        'chkCodPedido
        '
        Me.chkCodPedido.Location = New System.Drawing.Point(6, 18)
        Me.chkCodPedido.Name = "chkCodPedido"
        Me.chkCodPedido.Size = New System.Drawing.Size(90, 20)
        Me.chkCodPedido.TabIndex = 0
        Me.chkCodPedido.Values.Text = "Cod. Pedido"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.tsbConsultar, Me.tsbExportar, Me.tsbSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(787, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.PY_RANSANET_CL.My.Resources.Resources._New
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton1.Text = "&Nuevo"
        '
        'tsbConsultar
        '
        Me.tsbConsultar.Image = Global.PY_RANSANET_CL.My.Resources.Resources.Search
        Me.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbConsultar.Name = "tsbConsultar"
        Me.tsbConsultar.Size = New System.Drawing.Size(78, 22)
        Me.tsbConsultar.Text = "&Consultar"
        '
        'tsbExportar
        '
        Me.tsbExportar.Image = Global.PY_RANSANET_CL.My.Resources.Resources.Tramas
        Me.tsbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportar.Name = "tsbExportar"
        Me.tsbExportar.Size = New System.Drawing.Size(70, 22)
        Me.tsbExportar.Text = "&Exportar"
        '
        'tsbSalir
        '
        Me.tsbSalir.Image = Global.PY_RANSANET_CL.My.Resources.Resources.Out
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(49, 22)
        Me.tsbSalir.Text = "&Salir"
        '
        'Frm_ConsPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 282)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConsPedido"
        Me.Text = "Pedidos"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.KryptonPanel.PerformLayout()
        CType(Me.hgPedido.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgPedido.Panel.ResumeLayout(False)
        CType(Me.hgPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgPedido.ResumeLayout(False)
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.dgvPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonHeaderGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonHeaderGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonHeaderGroup1.ResumeLayout(False)
        CType(Me.KryptonGroup3.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents hgPedido As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonHeaderGroup1 As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgvPedido As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonGroup3 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecInicio As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCodCliente As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkCliente As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents dtpFecFin As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtCodPedido As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents chkCodPedido As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ChkFecha As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class

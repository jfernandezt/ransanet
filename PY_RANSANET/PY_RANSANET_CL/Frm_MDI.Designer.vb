<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MDI
    'Inherits System.Windows.Forms.Form
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2010BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2010BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2010SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2007BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2007BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Office2007SilverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.ProcesosToolStripMenuItem, Me.FondoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MantenimientosToolStripMenuItem.Text = "&Mantenimientos"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ProcesosToolStripMenuItem.Text = "&Procesos"
        '
        'PedidosToolStripMenuItem
        '
        Me.PedidosToolStripMenuItem.Name = "PedidosToolStripMenuItem"
        Me.PedidosToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PedidosToolStripMenuItem.Text = "&Pedidos"
        '
        'FondoToolStripMenuItem
        '
        Me.FondoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Office2010BlueToolStripMenuItem, Me.Office2010BlackToolStripMenuItem, Me.Office2010SilverToolStripMenuItem, Me.Office2007BlueToolStripMenuItem, Me.Office2007BlackToolStripMenuItem, Me.Office2007SilverToolStripMenuItem})
        Me.FondoToolStripMenuItem.Name = "FondoToolStripMenuItem"
        Me.FondoToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FondoToolStripMenuItem.Text = "&Fondo"
        '
        'Office2010BlueToolStripMenuItem
        '
        Me.Office2010BlueToolStripMenuItem.Name = "Office2010BlueToolStripMenuItem"
        Me.Office2010BlueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2010BlueToolStripMenuItem.Text = "Office 2010 - Blue"
        '
        'Office2010BlackToolStripMenuItem
        '
        Me.Office2010BlackToolStripMenuItem.Name = "Office2010BlackToolStripMenuItem"
        Me.Office2010BlackToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2010BlackToolStripMenuItem.Text = "Office 2010 - Black"
        '
        'Office2010SilverToolStripMenuItem
        '
        Me.Office2010SilverToolStripMenuItem.Name = "Office2010SilverToolStripMenuItem"
        Me.Office2010SilverToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2010SilverToolStripMenuItem.Text = "Office 2010 - Silver"
        '
        'Office2007BlueToolStripMenuItem
        '
        Me.Office2007BlueToolStripMenuItem.Name = "Office2007BlueToolStripMenuItem"
        Me.Office2007BlueToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2007BlueToolStripMenuItem.Text = "Office 2007 - Blue"
        '
        'Office2007BlackToolStripMenuItem
        '
        Me.Office2007BlackToolStripMenuItem.Name = "Office2007BlackToolStripMenuItem"
        Me.Office2007BlackToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2007BlackToolStripMenuItem.Text = "Office 2007 - Black"
        '
        'Office2007SilverToolStripMenuItem
        '
        Me.Office2007SilverToolStripMenuItem.Name = "Office2007SilverToolStripMenuItem"
        Me.Office2007SilverToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.Office2007SilverToolStripMenuItem.Text = "Office 2007 - Silver"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(714, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Frm_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Frm_MDI"
        Me.Text = "Sistema Ransa NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MantenimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2010BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2010BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2010SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2007BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2007BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Office2007SilverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager
End Class

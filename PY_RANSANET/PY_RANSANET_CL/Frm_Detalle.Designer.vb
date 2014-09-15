<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Detalle
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
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.hgDetalle = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.dgvDetalle = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.hgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hgDetalle.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hgDetalle.Panel.SuspendLayout()
        Me.hgDetalle.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.hgDetalle)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(550, 186)
        Me.KryptonPanel.TabIndex = 0
        '
        'hgDetalle
        '
        Me.hgDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hgDetalle.HeaderStylePrimary = ComponentFactory.Krypton.Toolkit.HeaderStyle.Secondary
        Me.hgDetalle.HeaderVisibleSecondary = False
        Me.hgDetalle.Location = New System.Drawing.Point(0, 0)
        Me.hgDetalle.Name = "hgDetalle"
        '
        'hgDetalle.Panel
        '
        Me.hgDetalle.Panel.Controls.Add(Me.KryptonGroup1)
        Me.hgDetalle.Size = New System.Drawing.Size(550, 186)
        Me.hgDetalle.TabIndex = 1
        Me.hgDetalle.ValuesPrimary.Heading = "Total: 0 registros"
        '
        'dgvDetalle
        '
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 3)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(534, 149)
        Me.dgvDetalle.TabIndex = 1
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
        Me.KryptonGroup1.Panel.Controls.Add(Me.dgvDetalle)
        Me.KryptonGroup1.Size = New System.Drawing.Size(542, 157)
        Me.KryptonGroup1.TabIndex = 2
        '
        'Frm_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 186)
        Me.Controls.Add(Me.KryptonPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 80)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.hgDetalle.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalle.Panel.ResumeLayout(False)
        CType(Me.hgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hgDetalle.ResumeLayout(False)
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
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
    Friend WithEvents hgDetalle As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents dgvDetalle As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class

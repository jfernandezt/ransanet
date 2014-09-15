Public Class Frm_MDI

#Region "Formulario"
    Private Sub Frm_MDI_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Frm_MDI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "ToolStripMenuGeneral"
    Private Sub Office2010BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2010BlueToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Blue
        My.Settings.Fondo = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Blue
        My.Settings.Save()
    End Sub

    Private Sub Office2010BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2010BlackToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        My.Settings.Fondo = KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black
        My.Settings.Save()
    End Sub

    Private Sub Office2010SilverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2010SilverToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        My.Settings.Fondo = KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver
        My.Settings.Save()
    End Sub

    Private Sub Office2007BlueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2007BlueToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        My.Settings.Fondo = KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        My.Settings.Save()
    End Sub

    Private Sub Office2007BlackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2007BlackToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black
        My.Settings.Fondo = KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Black
        My.Settings.Save()
    End Sub

    Private Sub Office2007SilverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2007SilverToolStripMenuItem.Click
        KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver
        My.Settings.Fondo = KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Silver
        My.Settings.Save()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub
#End Region

#Region "ToolStripMenuWindows"
    Private Sub PedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PedidosToolStripMenuItem.Click
        If gBoo_FrmConsPedido = True Then
            Return
        Else
            Frm_ConsPedido.MdiParent = Me
            Frm_ConsPedido.BringToFront()
            Frm_ConsPedido.Show()
        End If
    End Sub
#End Region
End Class
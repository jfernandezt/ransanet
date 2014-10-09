Imports ComponentFactory.Krypton.Toolkit

Public Class Frm_ConsPedido

#Region "Atributos"
    Private lObj_FrmPedido As Frm_MantPedido
#End Region

#Region "Formulario"
    Private Sub Frm_ConsPedido_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        gBoo_FrmConsPedido = False
    End Sub

    Private Sub Frm_ConsPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gBoo_FrmConsPedido = True
    End Sub
#End Region
    
#Region "DataGridView"
    Private Sub dgvPedido_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvPedido.DoubleClick
        lObj_FrmPedido = New Frm_MantPedido

        lObj_FrmPedido.ShowDialog()
    End Sub
#End Region

#Region "TollStrip"
    Private Sub tsbConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsbConsultar.Click

    End Sub

    Private Sub tsbExportar_Click(sender As System.Object, e As System.EventArgs) Handles tsbExportar.Click

    End Sub

    Private Sub tsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
#End Region

End Class

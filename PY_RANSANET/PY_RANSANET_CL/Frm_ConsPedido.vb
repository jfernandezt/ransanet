Imports ComponentFactory.Krypton.Toolkit
Imports System.Collections.ArrayList

Public Class Frm_ConsPedido

#Region "Atributos"
    Private lObj_FrmPedido As Frm_MantPedido
    Private lWs_RansaNet As Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
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
        lObj_FrmPedido = New Frm_MantPedido(dgvPedido.Item("IdPedido", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("FecPedido", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("CodPedido", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("IdTipoPedido", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("IdCliente", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("NomCliente", dgvPedido.CurrentRow.Index).Value, _
                                            dgvPedido.Item("NomEstadoPedido", dgvPedido.CurrentRow.Index).Value)
        lObj_FrmPedido.txtOperacion.Text = "FILEOPEN"
        lObj_FrmPedido.ShowDialog()

        If lObj_FrmPedido.txtOperacion.Text = "SAVE" Then
            tsbConsultar_Click(sender, e)
        End If
    End Sub
#End Region

#Region "TollStrip"
    Private Sub tsbConsultar_Click(sender As System.Object, e As System.EventArgs) Handles tsbConsultar.Click
        Dim lStr_Filtro As String = ""

        If ChkFecha.Checked Then
            Dim lDatFecIni As Date
            Dim lDatFecFin As Date

            lDatFecIni = dtpFecInicio.Value.Date
            lDatFecFin = DateAdd(DateInterval.Day, 1, dtpFecFin.Value.Date)

            lStr_Filtro = lStr_Filtro & " and p.FecCreacion >= '" & lDatFecIni.ToString("yyyy-MM-dd") & "'" & " and p.FecCreacion < '" & lDatFecFin.ToString("yyyy-MM-dd") & "'"
        End If

        If chkCodPedido.Checked Then
            lStr_Filtro = lStr_Filtro & " and p.CodPedido = '" & txtCodPedido.Text & "'"
        End If

        If chkCliente.Checked Then
            lStr_Filtro = lStr_Filtro & " and p.IdCliente = " & txtCodCliente.Text
        End If

        '-----------------
        lWs_RansaNet = New Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
        Dim lObj_Pedido() As Ws_RansaNet.PedidoRansa

        lObj_Pedido = lWs_RansaNet.get_bus_pedido(lStr_Filtro)
        '-----------------

        dgvPedido.DataSource = lObj_Pedido

        hgPedido.ValuesPrimary.Heading = "Pedidos (Registros: " & dgvPedido.RowCount & ")"

        KryptonMessageBox.Show("Se encontraron " & dgvPedido.RowCount & " pedidos", "Información", System.Windows.Forms.MessageBoxButtons.OK)

    End Sub

    Private Sub tsbExportar_Click(sender As System.Object, e As System.EventArgs) Handles tsbExportar.Click

    End Sub

    Private Sub tsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "CheckBox"
    Private Sub chkCodPedido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCodPedido.CheckedChanged
        If chkCodPedido.Checked Then
            txtCodPedido.Enabled = True
        Else
            txtCodPedido.Enabled = False
        End If
    End Sub

    Private Sub ChkFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkFecha.CheckedChanged
        If ChkFecha.Checked Then
            dtpFecInicio.Enabled = True
            dtpFecFin.Enabled = True
        Else
            dtpFecInicio.Enabled = False
            dtpFecFin.Enabled = False
        End If
    End Sub

    Private Sub chkCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCliente.CheckedChanged
        If chkCliente.Checked Then
            txtCodCliente.Enabled = True
        Else
            txtCodCliente.Enabled = False
        End If
    End Sub
#End Region
    
End Class

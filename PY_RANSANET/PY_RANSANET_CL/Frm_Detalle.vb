Imports ComponentFactory.Krypton.Toolkit
Imports PY_RANSANET_CL.Ws_RansaNet
Imports System.Collections.ArrayList

Public Class Frm_Detalle

#Region "Atributos"
    Private lWs_RansaNet As Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient

#End Region

#Region "Constructores"
    Sub New(ByVal pStr_TipoDetalle As String, _
            ByVal pStr_CodPedido As String, _
            ByVal pInt_Idpedido As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        lWs_RansaNet = New Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient


        Dim lObj_PedidoMovimiento() As Ws_RansaNet.PedidoMovimientoRansa
        Dim lObj_PedidoDetalle() As Ws_RansaNet.PedidoDetalleRansa

        Select Case pStr_TipoDetalle
            Case "MOVIMIENTO"
                'Detalles = lWs_RansaNet.getPedidos(pStr_CodPedido)
                lObj_PedidoMovimiento = lWs_RansaNet.getPedidoMovimiento(pStr_CodPedido)
                dgvDetalle.DataSource = lObj_PedidoMovimiento
            Case "DETALLE"
                'Detalles = lWs_RansaNet.getLisGenerico("PEDIDO_DETALLE", " and pd.IdPedido = " & pInt_Idpedido)
                lObj_PedidoDetalle = lWs_RansaNet.get_bus_pedido_detalle(pInt_Idpedido)
                dgvDetalle.DataSource = lObj_PedidoDetalle
        End Select

        hgDetalle.ValuesPrimary.Heading = "Total: " & dgvDetalle.RowCount & " registros"

    End Sub
#End Region

#Region "Formulario"
    Private Sub Frm_Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

End Class

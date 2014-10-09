Imports ComponentFactory.Krypton.Toolkit
Imports System.Xml

Public Class Frm_MantPedido

#Region "Atributos"
    Private lObj_FrmDetalle As Frm_Detalle
    Private lWs_RansaNet As Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
    Private lWs_RansaNetMessage As Ws_RansaNetMessage.ServicioPedidoClient
#End Region

#Region "Constructores"
    Sub New(ByVal pInt_IdPedido As Integer, _
            pStr_FecPedido As String, _
            pStr_CodPedido As String, _
            pStr_TipoPedido As Integer, _
            pStr_IdCliente As String, _
            pStr_DesCliente As String, _
            pStr_EstadoPedido As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        txtIdPedido.Text = pInt_IdPedido
        dtpFecPedido.Value = pStr_FecPedido
        txtCodPedido.Text = pStr_CodPedido
        Select Case pStr_TipoPedido
            Case "1"
                cboTipoPedido.Text = "RECOJO"
            Case "2"
                cboTipoPedido.Text = "ENVIO"
        End Select

        txtCodCliente.Text = pStr_IdCliente
        txtDesCliente.Text = pStr_DesCliente
        cboEstadoPedido.Text = pStr_EstadoPedido

        

    End Sub
#End Region

#Region "Formulario"
    Private Sub Frm_MantPedido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "Funciones y Procedimiento"
    Private Sub S_HabilitarBotones(ByVal pStr_Operacion As String)
        Select Case pStr_Operacion
            Case "GUARDAR", "CANCELAR", "ANULAR"
                tsbGuardar.Enabled = False
                tsbEditar.Enabled = True
                tsbCancelar.Enabled = False
                tsbAnular.Enabled = False

                grDatosPedido.Enabled = False
            Case "EDITAR"
                tsbGuardar.Enabled = True
                tsbEditar.Enabled = False
                tsbCancelar.Enabled = True
                tsbAnular.Enabled = True

                grDatosPedido.Enabled = True
        End Select
    End Sub

    Private Function F_ObtenerIdEstadoPedido(ByVal pStr_NomEstadoPedido As String) As Integer
        Dim lInt_IdEstadoPedido As Integer

        Select Case pStr_NomEstadoPedido
            Case "EN PEDIDO"
                lInt_IdEstadoPedido = 1
            Case "EN REQUERIMIENTO"
                lInt_IdEstadoPedido = 2
            Case "EN BUSQUEDA"
                lInt_IdEstadoPedido = 3
            Case "EN DESPACHO"
                lInt_IdEstadoPedido = 4
            Case "EN CAMINO"
                lInt_IdEstadoPedido = 5
            Case "RECIBIDO"
                lInt_IdEstadoPedido = 6
            Case "ANULADO"
                lInt_IdEstadoPedido = 7
        End Select

        Return lInt_IdEstadoPedido
    End Function
#End Region

#Region "ToolStrip"
    Private Sub tsbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbGuardar.Click
        lWs_RansaNet = New Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
        lWs_RansaNetMessage = New Ws_RansaNetMessage.ServicioPedidoClient

        Dim lObj_PedidoMovimiento() As Ws_RansaNetMessage.PedidoMovimientoRansa = Nothing

        Dim lStr_Mensaje As String = ""

        Select Case cboEstadoPedido.Text
            Case "EN PEDIDO", "EN DESPACHO", "EN CAMINO", "RECIBIDO", "ANULADO"
                lStr_Mensaje = lWs_RansaNet.insertarPedidoMovimiento(CInt(txtIdPedido.Text), F_ObtenerIdEstadoPedido(cboEstadoPedido.Text), gInt_IdUsuarioField)
            Case "EN REQUERIMIENTO"
                Dim lObj_PedidoEN As New Ws_RansaNetMessage.Cls_PedidoEN

                With lObj_PedidoEN
                    .IdPedido = txtIdPedido.Text
                    .IdEstadoPedido = F_ObtenerIdEstadoPedido(cboEstadoPedido.Text)
                    .IdUsuario = gInt_IdUsuarioField
                End With

                If lWs_RansaNetMessage.RegistrarPedidoMovimiento(lObj_PedidoEN) Then
                    lStr_Mensaje = ""
                Else
                    lStr_Mensaje = "ERROR"
                End If

            Case "EN BUSQUEDA"
                lObj_PedidoMovimiento = lWs_RansaNetMessage.ConsultaPedidoMovimiento(txtCodPedido.Text)

                If lObj_PedidoMovimiento.Count > 0 Then
                    lStr_Mensaje = ""
                Else
                    lStr_Mensaje = "ERROR"
                End If

        End Select



        If lStr_Mensaje = "" Then
            S_HabilitarBotones("GUARDAR")

            txtOperacion.Text = "SAVE"

            KryptonMessageBox.Show("Registro guardado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            KryptonMessageBox.Show("Error al guardar el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Select Case cboEstadoPedido.Text
            Case "EN BUSQUEDA"
                lObj_FrmDetalle = New Frm_Detalle()
                lObj_FrmDetalle.Text = "Movimientos del pedido " & txtCodPedido.Text
                lObj_FrmDetalle.dgvDetalle.DataSource = lObj_PedidoMovimiento
                lObj_FrmDetalle.hgDetalle.ValuesPrimary.Heading = "Total: " & lObj_FrmDetalle.dgvDetalle.RowCount & " registros"
                lObj_FrmDetalle.ShowDialog()
        End Select
    End Sub

    Private Sub tsbEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbEditar.Click
        S_HabilitarBotones("EDITAR")
        cboEstadoPedido.Enabled = True
    End Sub

    Private Sub tsbCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbCancelar.Click
        S_HabilitarBotones("CANCELAR")
    End Sub

    Private Sub tsbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbAnular.Click
        lWs_RansaNet = New Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient

        Dim lStr_Mensaje As String = ""

        lStr_Mensaje = lWs_RansaNet.insertarPedidoMovimiento(txtIdPedido.Text, 7, gInt_IdUsuarioField)

        If lStr_Mensaje = "" Then
            S_HabilitarBotones("ANULAR")

            txtOperacion.Text = "SAVE"

            KryptonMessageBox.Show("Registro anulado satisfactoriamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            KryptonMessageBox.Show("Error al anular el registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Button"
    Private Sub btnVerMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerMovimientos.Click
        lObj_FrmDetalle = New Frm_Detalle("MOVIMIENTO", txtCodPedido.Text, txtIdPedido.Text)
        lObj_FrmDetalle.Text = "Movimientos del pedido " & txtCodPedido.Text
        lObj_FrmDetalle.ShowDialog()
    End Sub

    Private Sub btnVerDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerDetalles.Click
        lObj_FrmDetalle = New Frm_Detalle("DETALLE", txtCodPedido.Text, txtIdPedido.Text)
        lObj_FrmDetalle.Text = "Detalles del pedido " & txtCodPedido.Text
        lObj_FrmDetalle.ShowDialog()
    End Sub

    Private Sub btnImprimirPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPedido.Click

    End Sub
#End Region


End Class

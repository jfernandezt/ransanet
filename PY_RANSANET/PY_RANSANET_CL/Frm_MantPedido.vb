Imports ComponentFactory.Krypton.Toolkit

Public Class Frm_MantPedido

#Region "Atributos"
    Private lObj_FrmDetalle As Frm_Detalle
#End Region

#Region "Formulario"

#End Region

#Region "Funciones y Procedimiento"
    Private Sub S_HabilitarBotones(pStr_Operacion As String)
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
#End Region

#Region "ToolStrip"
    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click


        S_HabilitarBotones("GUARDAR")
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click


        S_HabilitarBotones("EDITAR")
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click


        S_HabilitarBotones("CANCELAR")
    End Sub

    Private Sub tsbAnular_Click(sender As System.Object, e As System.EventArgs) Handles tsbAnular.Click


        S_HabilitarBotones("ANULAR")
    End Sub

    Private Sub tsbSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub
#End Region

#Region "Button"
    Private Sub btnVerMovimientos_Click(sender As System.Object, e As System.EventArgs) Handles btnVerMovimientos.Click
        lObj_FrmDetalle = New Frm_Detalle
        lObj_FrmDetalle.Text = "Movimientos del pedido " & "XXXXXXX"
        lObj_FrmDetalle.ShowDialog()
    End Sub

    Private Sub btnVerDetalles_Click(sender As System.Object, e As System.EventArgs) Handles btnVerDetalles.Click
        lObj_FrmDetalle = New Frm_Detalle
        lObj_FrmDetalle.Text = "Detalles del pedido " & "XXXXXXX"
        lObj_FrmDetalle.ShowDialog()
    End Sub

    Private Sub btnImprimirPedido_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimirPedido.Click

    End Sub
#End Region

End Class

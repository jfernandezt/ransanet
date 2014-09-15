Imports ComponentFactory.Krypton.Toolkit
Public Class Frm_Detalle

#Region "Atributos"

#End Region

#Region "Constructores"
    Sub New(pStr_TipoDetalle As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Select Case pStr_TipoDetalle
            Case "MOVIMIENTO"

            Case "DETALLE"

        End Select

        hgDetalle.ValuesPrimary.Heading = "Total: " & dgvDetalle.RowCount & " registros"

    End Sub
#End Region

#Region "Formulario"
    Private Sub Frm_Detalle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
#End Region

End Class

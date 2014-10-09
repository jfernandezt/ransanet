Imports ComponentFactory.Krypton.Toolkit

Public Class Frm_InicioSesion

#Region "Atributos"
    Private lWs_RansaNet As Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
    Private lObj_DatosUsuario As Ws_RansaNet.UsuarioRansa
#End Region

#Region "Button"
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If txtUsuario.Text.Trim = "" Then
            KryptonMessageBox.Show("Por favor ingrese un Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Return
        End If

        If txtPassword.Text.Trim = "" Then
            KryptonMessageBox.Show("Por favor ingrese un Password", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Return
        End If


        lWs_RansaNet = New Ws_RansaNet.UsuarioRansaServiceImplPortTypeClient
        lObj_DatosUsuario = New Ws_RansaNet.UsuarioRansa

        Dim lBoo_Existe As Boolean = False

        lBoo_Existe = lWs_RansaNet.iniciarSesion(txtUsuario.Text, txtPassword.Text)

        If lBoo_Existe Then

            lObj_DatosUsuario = lWs_RansaNet.datosUsuario(txtUsuario.Text, txtPassword.Text, "O")

            gStr_ApellidosUsuarioField = lObj_DatosUsuario.apellidosUsuario
            gStr_CodUsuarioField = lObj_DatosUsuario.codUsuario
            gStr_CorreoUsuarioField = lObj_DatosUsuario.correoUsuario
            gInt_IdClienteField = lObj_DatosUsuario.idCliente
            gInt_IdUsuarioField = lObj_DatosUsuario.idUsuario
            gStr_NombresUsuarioField = lObj_DatosUsuario.nombresUsuario
            gStr_TipoUsuarioField = lObj_DatosUsuario.tipoUsuario

            KryptonMessageBox.Show("Usuario logueado satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frm_MDI.Show()
            Me.Hide()
        Else
            KryptonMessageBox.Show("Datos de Usuario incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Return
        End If

        lWs_RansaNet = Nothing
        lObj_DatosUsuario = Nothing
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
#End Region
End Class

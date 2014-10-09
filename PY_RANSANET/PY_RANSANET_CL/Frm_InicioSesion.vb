Imports ComponentFactory.Krypton.Toolkit

Public Class Frm_InicioSesion
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

        '----------
        '----WS----
        '----------
        'Dim lObj_ServiceReference1  As New ServiceReference1.


        Dim lObj_ServiceReference1 As New ServiceReference1.logeowsdlPortTypeClient()

        If lObj_ServiceReference1.logeo(txtUsuario.Text, txtPassword.Text) Then
            'If 1 = 1 Then
            Frm_MDI.Show()
            Me.Hide()
        Else
            KryptonMessageBox.Show("Datos de Usuario incorrecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Return
        End If

        'MsgBox(CStr(lObj_ServiceReference1.logeo(txtUsuario.Text, txtPassword.Text)))

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class

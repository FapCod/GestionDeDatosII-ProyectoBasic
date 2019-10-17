Imports CapaNegocio
'Imports System.Runtime.InteropServices
Public Class Login

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim user As String
        Dim pass As String
        user = txtUser.Text
        pass = txtPass.Text
        Dim userModel As New negUsuario()
        Dim validLogin = userModel.login(user, pass)
        If validLogin = True Then
            MessageBox.Show("Ingresaste")
            Me.Hide()
            Dim frm As New Principal()
            frm.Show()
            AddHandler frm.FormClosed, AddressOf Me.Logout
            'Application.Exit()

        Else
            MessageBox.Show("clave incorrecta o usuario incorrecto" + vbNewLine + "Por favor intentalo de nuevo")
            txtUser.Clear()
            txtPass.Clear()
            txtUser.Focus()

        End If
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Focus()
        Me.Show()

    End Sub
End Class

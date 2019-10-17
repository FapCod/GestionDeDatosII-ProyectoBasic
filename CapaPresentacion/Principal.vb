Imports CapaEntidad
Imports CapaNegocio
Imports System.Data.SqlClient

Public Class Principal



    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim reporte As New Reporte
        reporte.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'se crea el objeto y se le envia los datos
        Dim objentP As New entPersona

        objentP.nombres = txtnombre.Text
        objentP.apellidos = txtapellido.Text
        objentP.edad = Val(txtedad.Text)
        objentP.sexo = cmbSexo.Text
        Dim objneg As New negUsuario
        If objneg.nuevoPersona(objentP) Then
            MsgBox("REGISTRO EXITOSO")
        Else
            MsgBox("ERROR", vbCritical)
        End If
    End Sub

  
End Class
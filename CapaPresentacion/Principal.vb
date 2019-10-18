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
            Ver()
        Else
            MsgBox("ERROR", vbCritical)
        End If
    End Sub

  
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'se crea el objeto y se le envia los datos
        Dim objentP As New entPersona

        objentP.nombres = txtnombre.Text
        objentP.apellidos = txtapellido.Text
        objentP.edad = Val(txtedad.Text)
        objentP.sexo = cmbSexo.Text
        Dim objneg As New negUsuario
        Dim i As Integer
        Dim id As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        If objneg.actualizarPersona(objentP, id) Then
            MsgBox("ACTUALIZACION EXITOSA")
            Ver()
        Else
            MsgBox("ERROR", vbCritical)
        End If
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ver()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtnombre.Text = DataGridView1.Item(1, i).Value()
        txtapellido.Text = DataGridView1.Item(2, i).Value()
        txtedad.Text = DataGridView1.Item(3, i).Value()
        cmbSexo.Text = DataGridView1.Item(4, i).Value()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim objneg As New negUsuario
        Dim i As Integer
        Dim id As Integer
        i = DataGridView1.CurrentRow.Index
        id = DataGridView1.Item(0, i).Value()
        If objneg.eliminarPersona(id) Then
            MsgBox("ELIMINACION EXITOSA")
            Ver()
        Else
            MsgBox("ERROR", vbCritical)
        End If
    End Sub
    Sub Ver()
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("select * from persona")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtnerDataTableLike("select * from persona where nombre like '" + txtbuscar.Text + "%'")
    End Sub
End Class
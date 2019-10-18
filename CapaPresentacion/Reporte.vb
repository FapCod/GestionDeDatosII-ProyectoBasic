Imports CapaNegocio
Public Class Reporte

   
    Private Sub btnPersonasMayores_Click(sender As Object, e As EventArgs) Handles btnPersonasMayores.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("declare @totalPMA int;exec seleccionPMA  18, '" + cmbEleccion.Text + "',@totalPMA output ;select @totalPMA")
    End Sub

    Private Sub btnPersonasMenores_Click(sender As Object, e As EventArgs) Handles btnPersonasMenores.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("declare @totalPME int;exec seleccionPME  18, '" + cmbEleccion1.Text + "',@totalPME output ;select @totalPME")
    End Sub

    Private Sub btnMasculinos_Click(sender As Object, e As EventArgs) Handles btnMasculinos.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("SELECT dbo.Cont_Sexo('M') As [Conteo de Sexos]")
    End Sub

    Private Sub btnFemenino_Click(sender As Object, e As EventArgs) Handles btnFemenino.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("SELECT dbo.Cont_Sexo('F') As [Conteo de Sexos]")
    End Sub

    Private Sub btnPromediodeEdades_Click(sender As Object, e As EventArgs) Handles btnPromediodeEdades.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("select dbo.prom_Edades('" + cmbEleccion2.Text + "') as [Sexo de persona]")
    End Sub

    
    Private Sub btnEdaMaxima_Click(sender As Object, e As EventArgs) Handles btnEdaMaxima.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("select dbo.Max_Edad('" + cmbEleccion3.Text + "') as [Maxima Edad]")
    End Sub

  
    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim conexion As New negUsuario

        DataGridView1.DataSource = conexion.obtenerDataTable("exec mostrarPersonasMayoresDE 18, '" + cmbEleccion.Text + "'")
    End Sub

    Private Sub btnVer1_Click(sender As Object, e As EventArgs) Handles btnVer1.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("exec mostrarPersonasMenoresDE 18, '" + cmbEleccion1.Text + "'")
    End Sub
    

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("Begin tran ;delete from persona where edad >=18 and sexo='" + cmbEleccion.Text + "';select * from persona where sexo= '" + cmbEleccion.Text + "'")
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("Begin tran ;delete from persona where edad <18 and sexo='" + cmbEleccion1.Text + "';select * from persona where sexo= '" + cmbEleccion.Text + "' ")
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("rollback;select * from persona where sexo= '" + cmbEleccion.Text + "' ")
    End Sub

    Private Sub btnRecuperar1_Click(sender As Object, e As EventArgs) Handles btnRecuperar1.Click
        Dim conexion As New negUsuario
        DataGridView1.DataSource = conexion.obtenerDataTable("rollback;select * from persona where sexo= '" + cmbEleccion.Text + "' ")
    End Sub
End Class
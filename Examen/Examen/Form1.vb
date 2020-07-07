Public Class Form1
    Dim conexion As New conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        llenar()
        dtg.DataSource = conexion.dv
        llenarcb()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim agregar As String = "insert into  values('" + mtxtID.Text + "','" + mtxtFechaVenta.Text + "','" + txtPrecio.Text + "','" + txtcantidad.Text + "','" + cbCliente.Text + "','" + cbProducto.Text + "')"
        If (conexion.insert(agregar, mtxtID.Text)) Then
            MessageBox.Show("Datos agregados exitosamente")
            llenar()


        Else
            MessageBox.Show("Ya existe una venta con el numero   " + mtxtID.Text + "")
        End If
    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        Dim update As String = "fechaVenta='" + mtxtFechaVenta.Text + "', precio='" + txtPrecio.Text + "', cantidad='" + txtcantidad.Text + "', cliente='" + +"', producto='" + +"'"
        If (conexion.modificar("factura.Venta", update, "idVenta='" + mtxtID.Text + "'")) Then
            MessageBox.Show("Se ha actualizado satisfactoreamente")
            llenar()
        Else
            MessageBox.Show("Error al actualizar los datos")
        End If
    End Sub

    Private Sub btnelim_Click(sender As Object, e As EventArgs) Handles btnelim.Click
        If (conexion.eliminar("factura.Venta", " idVenta='" + mtxtID.Text + "'")) Then
            MessageBox.Show("Dato eliminado satisfactoreamente")
            llenar()

        Else
            MessageBox.Show("Error al eliminar datos")
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub dtg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg.CellContentClick
        Dim dgv As DataGridViewRow = dtg.Rows(e.RowIndex)
        mtxtID.Text = dgv.Cells(0).Value.ToString()
        mtxtFechaVenta.Text = dgv.Cells(1).Value.ToString()
        txtPrecio.Text = dgv.Cells(2).Value.ToString()
        txtcantidad.Text = dgv.Cells(3).Value.ToString()
        cbCliente.Text = dgv.Cells(4).Value.ToString()
        cbProducto.Text = dgv.Cells(5).Value.ToString()

    End Sub
    Public Sub llenar()
        conexion.Llenar("Select * from factura.Venta", "factura.Venta")
        dtg.DataSource = conexion.ds.Tables("factura.Venta")
    End Sub

    Public Sub llenarcb()
        conexion.llenarcbCliente()
        cbCliente.DataSource = conexion.datos2.Tables("factura.cliente")
        cbCliente.DisplayMember = "Nombre" + "Apellido"

        conexion.llenarcb()
        cbProducto.DataSource = conexion.datos2.Tables("factura.producto")
        cbProducto.DisplayMember = "nombreProducto"
    End Sub
End Class

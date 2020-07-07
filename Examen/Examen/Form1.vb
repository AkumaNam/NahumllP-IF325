Imports System.ComponentModel

Public Class Form1
    Dim conexion As New conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        llenar()
        dtg.DataSource = conexion.dv
        llenarcb()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If Me.ValidateChildren And txtcantidad.Text <> String.Empty And IsNumeric(txtcantidad.Text) = True And mtxtID.Text <> String.Empty And txtPrecio.Text <> String.Empty Then
                Dim agregar As String = "insert into  values('" + mtxtID.Text + "','" + mtxtFechaVenta.Text + "','" + txtPrecio.Text + "','" + txtcantidad.Text + "','" + cbCliente.Text + "','" + cbProducto.Text + "')"
                If (conexion.insert(agregar, mtxtID.Text)) Then
                    MessageBox.Show("Datos agregados exitosamente")
                    llenar()


                Else
                    MessageBox.Show("Ya existe una venta con el numero   " + mtxtID.Text + "")
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

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
        cbCliente.DisplayMember = "Nombre"

        conexion.llenarcbproducto()
        cbProducto.DataSource = conexion.datos2.Tables("factura.producto")
        cbProducto.DisplayMember = "nombreProducto"
    End Sub

    Private Sub mtxtID_MouseHover(sender As Object, e As EventArgs) Handles mtxtID.MouseHover
        ToolTip1.SetToolTip(mtxtID, "Ingrese el ID")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles mtxtID.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtFechaVenta_MouseHover(sender As Object, e As EventArgs) Handles mtxtFechaVenta.MouseHover
        ToolTip1.SetToolTip(mtxtFechaVenta, "Ingrese la fecha de la venta")
        ToolTip1.ToolTipTitle = "Fecha Venta"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip1.SetToolTip(txtPrecio, "Ingrese el precio del producto")
        ToolTip1.ToolTipTitle = "Precio"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        ToolTip1.SetToolTip(txtcantidad, "Ingrese la cantidad de productos a compar")
        ToolTip1.ToolTipTitle = "Cantidad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbCliente_MouseHover(sender As Object, e As EventArgs) Handles cbCliente.MouseHover
        ToolTip1.SetToolTip(cbCliente, "Ingrese el nombre del cliente")
        ToolTip1.ToolTipTitle = "Clente"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cbProducto_MouseHover(sender As Object, e As EventArgs) Handles cbProducto.MouseHover
        ToolTip1.SetToolTip(cbProducto, "Ingrese el producto a comprar")
        ToolTip1.ToolTipTitle = "Producto"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtFechaVenta_Validating(sender As Object, e As CancelEventArgs) Handles mtxtFechaVenta.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cbCliente_Validating(sender As Object, e As CancelEventArgs) Handles cbCliente.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cbProducto_Validating(sender As Object, e As CancelEventArgs) Handles cbProducto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class


Public Class Producto
    Dim conexion As New conexion

    Private Sub txtDesc_MouseHover(sender As Object, e As EventArgs) Handles txtDesc.MouseHover
        ToolTip1.SetToolTip(txtDesc, "Ingrese la descripción del producto")
        ToolTip1.ToolTipTitle = "Descripción"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip1.SetToolTip(txtNombre, "Ingrese el Nombre del producto")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        ToolTip1.SetToolTip(txtID, "Ingrese el ID")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtID.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDesc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDesc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If Me.ValidateChildren And IsNumeric(txtNombre.Text) = False And txtNombre.Text <> String.Empty And txtDesc.Text <> String.Empty And txtID.Text <> String.Empty And IsNumeric(txtID.Text) = True Then
                Dim agregar As String = "insert into factura.producto values('" + txtID.Text + "','" + txtNombre.Text + "','" + txtDesc.Text + "')"
                If (conexion.insert1(agregar, txtID.Text)) Then
                    MessageBox.Show("Datos agregados exitosamente")
                    limpiar()
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        txtDesc.Clear()
        txtID.Clear()
        txtNombre.Clear()

    End Sub
End Class
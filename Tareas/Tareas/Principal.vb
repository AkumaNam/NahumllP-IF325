Imports System.ComponentModel

Public Class Principal
    Dim conexion As New conexion()
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        llenar()
        dgtv.DataSource = conexion.dv
        llenarcmbdepa()
        llenarcmbEstado()
        llenarcmbBolsa()
    End Sub
    Public Sub llenar()
        conexion.llenar("Select * from informacion", "informacion")
        dgtv.DataSource = conexion.ds.Tables("informacion")

    End Sub
    Public Sub llenarcmbdepa()
        conexion.llenarcmbDepa()
        cmbDepa.DataSource = conexion.datos2.Tables("departamento")
        cmbDepa.DisplayMember = "depa"
    End Sub

    Public Sub llenarcmbEstado()
        conexion.llenarcmbEstado()
        cmbEstado.DataSource = conexion.datos.Tables("estado")
        cmbEstado.DisplayMember = "TipoEstado"
    End Sub
    Public Sub llenarcmbBolsa()
        conexion.llenarcmbBolsa()
        cmbBolsa.DataSource = conexion.datos2.Tables("bolsa")
        cmbBolsa.DisplayMember = "TipoBolsa"
    End Sub
    Public Sub limpiar()
        txtID.Clear()
        txt1Nom.Clear()
        txt2Nom.Clear()
        txt1Apellido.Clear()
        txt2Apellido.Clear()
        txtDireccion.Clear()
        mtxtIntegrantes.Clear()
        cmbBolsa.Text = ""
        cmbDepa.Text = ""
        cmbEstado.Text = ""

    End Sub

    Private Sub dgtv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgtv.CellClick
        Dim dgv As DataGridViewRow = dgtv.Rows(e.RowIndex)
        txtID.Text = dgv.Cells(0).Value.ToString()
        txt1Nom.Text = dgv.Cells(1).Value.ToString()
        txt2Nom.Text = dgv.Cells(2).Value.ToString()
        txt1Apellido.Text = dgv.Cells(3).Value.ToString()
        txt2Apellido.Text = dgv.Cells(4).Value.ToString()
        mtxtIntegrantes.Text = dgv.Cells(5).Value.ToString()
        cmbEstado.Text = dgv.Cells(6).Value.ToString()
        cmbBolsa.Text = dgv.Cells(7).Value.ToString()
        cmbDepa.Text = dgv.Cells(8).Value.ToString()
        txtDireccion.Text = dgv.Cells(9).Value.ToString()
        txtID.ReadOnly = True
    End Sub

    Private Sub btnEntregado_Click(sender As Object, e As EventArgs) Handles btnEntregado.Click
        Try
            If Me.ValidateChildren And txtID.Text <> String.Empty And mtxtIntegrantes.Text <> String.Empty And txtID.Text.Length = 13 And txtDireccion.Text <> String.Empty Then
                Dim agregar As String = "insert into informacion values('" + txtID.Text + "','" + txt1Nom.Text + "','" + txt2Nom.Text + "','" + txt1Apellido.Text + "','" + txt2Apellido.Text + "','" + mtxtIntegrantes.Text + "','" + cmbEstado.Text + "','" + cmbBolsa.Text + "','" + cmbDepa.Text + "','" + txtDireccion.Text + "')"
                If (conexion.insert(agregar, txtID.Text)) Then
                    MessageBox.Show("Datos agregados exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenar()
                    limpiar()
                Else
                    MessageBox.Show("Ya se le entrego a la persona con el numero de identidad  " + txtID.Text + "")
                End If
            Else
                MessageBox.Show("Revise los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtID_MouseHover(sender As Object, e As EventArgs) Handles txtID.MouseHover
        ToolTip1.SetToolTip(txtID, "Ingrese el ID")
        ToolTip1.ToolTipTitle = "ID"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt1Nom_MouseHover(sender As Object, e As EventArgs) Handles txt1Nom.MouseHover
        ToolTip1.SetToolTip(txt1Nom, "Ingrese el primer Nombre del beneficiado")
        ToolTip1.ToolTipTitle = "Nombres"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt2Nom_MouseHover(sender As Object, e As EventArgs) Handles txt2Nom.MouseHover
        ToolTip1.SetToolTip(txt2Nom, "Ingrese el segundo Nombre del beneficiado")
        ToolTip1.ToolTipTitle = "Nombres"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt1Apellido_MouseHover(sender As Object, e As EventArgs) Handles txt1Apellido.MouseHover
        ToolTip1.SetToolTip(txt1Apellido, "Ingrese el primer apellido del beneficiado")
        ToolTip1.ToolTipTitle = "Apellidos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txt2Apellido_MouseHover(sender As Object, e As EventArgs) Handles txt2Apellido.MouseHover
        ToolTip1.SetToolTip(txt2Apellido, "Ingrese el segundo apellido del beneficiado")
        ToolTip1.ToolTipTitle = "Apellidos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles mtxtIntegrantes.MouseHover
        ToolTip1.SetToolTip(mtxtIntegrantes, "Ingrese la cantidad de integrantes en la familia del beneficiado")
        ToolTip1.ToolTipTitle = "Integrantes"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip1.SetToolTip(txtDireccion, "Ingrese la dirección del beneficiado")
        ToolTip1.ToolTipTitle = "IDirección"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbDepa_MouseHover(sender As Object, e As EventArgs) Handles cmbDepa.MouseHover
        ToolTip1.SetToolTip(cmbDepa, "Ingrese el Departamento del beneficiado")
        ToolTip1.ToolTipTitle = "Departamento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbEstado_MouseHover(sender As Object, e As EventArgs) Handles cmbEstado.MouseHover
        ToolTip1.SetToolTip(cmbEstado, "Ingrese el estado del beneficiado")
        ToolTip1.ToolTipTitle = "Estado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbBolsa_MouseHover(sender As Object, e As EventArgs) Handles cmbBolsa.MouseHover
        ToolTip1.SetToolTip(cmbBolsa, "Ingrese el Tipo de bolsa que se entregara al beneficiado")
        ToolTip1.ToolTipTitle = "Bolsa"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtID.Validating
        If DirectCast(sender, TextBox).Text.Length = 13 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub txt1Nom_Validating(sender As Object, e As CancelEventArgs) Handles txt1Nom.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txt2Nom_Validating(sender As Object, e As CancelEventArgs) Handles txt2Nom.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub txt1Apellido_Validating(sender As Object, e As CancelEventArgs) Handles txt1Apellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub txt2Apellido_Validating(sender As Object, e As CancelEventArgs) Handles txt2Apellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub mtxtIntegrantes_Validating(sender As Object, e As CancelEventArgs) Handles mtxtIntegrantes.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValid.SetError(sender, "")
        Else
            Me.ErrorValid.SetError(sender, "Ingrese los datos correctamente")
        End If
    End Sub

    Private Sub dgtv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgtv.CellContentClick

    End Sub

    Private Sub cmbBolsa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBolsa.SelectedIndexChanged
        If cmbBolsa.SelectedIndex = 0 Then
            LBbolsa.Items.Clear()
            LBbolsa.Items.Add("Arroz")
            LBbolsa.Items.Add("Frijoles")
            LBbolsa.Items.Add("Manteca")
        Else
            LBbolsa.Items.Clear()
            LBbolsa.Items.Add("Maseca")
            LBbolsa.Items.Add("Arroz")
            LBbolsa.Items.Add("Frijoles")
            LBbolsa.Items.Add("Manteca")
            LBbolsa.Items.Add("Café")
        End If
    End Sub
End Class

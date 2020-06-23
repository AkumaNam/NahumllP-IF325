Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As MySqlConnection = New MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=bolsasolidaria")
    Private cmb As MySqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As MySqlDataAdapter
    Public comando As MySqlCommand
    Public coma As MySqlCommand
    Public dv As New DataView
    Public adap As MySqlDataAdapter
    Public datos As DataSet
    Public adap2 As MySqlDataAdapter
    Public datos2 As DataSet

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexion Exitosa")
        Catch ex As Exception
            MessageBox.Show("No se ha podido conectar al servidor")
            Principal.Close()

        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub llenar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New MySqlDataAdapter(sql, conexion)
        cmb = New MySqlCommandBuilder(da)
        da.Fill(ds, tabla)

        dv.Table = ds.Tables(0)

    End Sub
    Public Sub llenarcmbEstado()
        conexion.Open()
        adap = New MySqlDataAdapter("Select * from estado", conexion)
        datos = New DataSet
        datos.Tables.Add("estado")
        adap.Fill(datos.Tables("estado"))
        conexion.Close()

    End Sub
    Public Sub llenarcmbBolsa()
        conexion.Open()
        adap2 = New MySqlDataAdapter("Select * from bolsa", conexion)
        datos2 = New DataSet
        datos2.Tables.Add("bolsa")
        adap2.Fill(datos2.Tables("bolsa"))
        conexion.Close()


    End Sub
    Public Sub llenarcmbDepa()
        conexion.Open()
        adap2 = New MySqlDataAdapter("Select * from departamento", conexion)
        datos2 = New DataSet
        datos2.Tables.Add("departamento")
        adap2.Fill(datos2.Tables("departamento"))
        conexion.Close()
    End Sub
    Function insert(ByRef sql, ByVal ID)
        Dim READER As MySqlDataReader
        Dim cont As Int32 = 0
        conexion.Open()
        coma = New MySqlCommand("Select * from informacion where Identidad='" + ID + "'", conexion)
        READER = coma.ExecuteReader
        While READER.Read
            cont = cont + 1
        End While
        READER.Close()
        If cont = 0 Then
            comando = New MySqlCommand(sql, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            End If
        Else
            conexion.Close()
            Return False

        End If


    End Function
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnelim = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.mtxtID = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.mtxtFechaVenta = New System.Windows.Forms.MaskedTextBox()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(696, 35)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'btnmod
        '
        Me.btnmod.Location = New System.Drawing.Point(696, 132)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(75, 23)
        Me.btnmod.TabIndex = 1
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(696, 225)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 2
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(696, 314)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtg
        '
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(3, 16)
        Me.dtg.Name = "dtg"
        Me.dtg.Size = New System.Drawing.Size(377, 329)
        Me.dtg.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtg)
        Me.GroupBox1.Location = New System.Drawing.Point(301, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 348)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.mtxtFechaVenta)
        Me.GroupBox2.Controls.Add(Me.cbProducto)
        Me.GroupBox2.Controls.Add(Me.cbCliente)
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.mtxtID)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(279, 345)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de Ventas"
        '
        'ErrorProvid
        '
        Me.ErrorProvid.ContainerControl = Me
        '
        'mtxtID
        '
        Me.mtxtID.Location = New System.Drawing.Point(7, 41)
        Me.mtxtID.Mask = "00000"
        Me.mtxtID.Name = "mtxtID"
        Me.mtxtID.Size = New System.Drawing.Size(100, 20)
        Me.mtxtID.TabIndex = 0
        Me.mtxtID.ValidatingType = GetType(Integer)
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(7, 134)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 2
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(7, 186)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(6, 238)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cbCliente.TabIndex = 4
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(7, 290)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cbProducto.TabIndex = 5
        '
        'mtxtFechaVenta
        '
        Me.mtxtFechaVenta.Location = New System.Drawing.Point(7, 87)
        Me.mtxtFechaVenta.Mask = "00/00/0000"
        Me.mtxtFechaVenta.Name = "mtxtFechaVenta"
        Me.mtxtFechaVenta.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFechaVenta.TabIndex = 6
        Me.mtxtFechaVenta.ValidatingType = GetType(Date)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 372)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtg As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents mtxtID As MaskedTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvid As ErrorProvider
    Friend WithEvents mtxtFechaVenta As MaskedTextBox
End Class

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
        Me.dtg = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.mtxtFechaVenta = New System.Windows.Forms.MaskedTextBox()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.mtxtID = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.btncliente = New System.Windows.Forms.Button()
        Me.btnproducto = New System.Windows.Forms.Button()
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnmod.Location = New System.Drawing.Point(696, 85)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(75, 23)
        Me.btnmod.TabIndex = 1
        Me.btnmod.Text = "Modificar"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnelim
        '
        Me.btnelim.Location = New System.Drawing.Point(696, 134)
        Me.btnelim.Name = "btnelim"
        Me.btnelim.Size = New System.Drawing.Size(75, 23)
        Me.btnelim.TabIndex = 2
        Me.btnelim.Text = "Eliminar"
        Me.btnelim.UseVisualStyleBackColor = True
        '
        'dtg
        '
        Me.dtg.AllowUserToDeleteRows = False
        Me.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtg.Location = New System.Drawing.Point(3, 16)
        Me.dtg.Name = "dtg"
        Me.dtg.ReadOnly = True
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
        Me.GroupBox2.Controls.Add(Me.txtapellido)
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
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(12, 363)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 8
        Me.txtProducto.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(12, 363)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 7
        Me.txtCliente.Visible = False
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
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(7, 290)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cbProducto.TabIndex = 5
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(6, 238)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cbCliente.TabIndex = 4
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(7, 186)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtcantidad.TabIndex = 3
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(7, 134)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 2
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
        'ErrorValid
        '
        Me.ErrorValid.ContainerControl = Me
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(146, 238)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.ReadOnly = True
        Me.txtapellido.Size = New System.Drawing.Size(114, 20)
        Me.txtapellido.TabIndex = 9
        '
        'btncliente
        '
        Me.btncliente.Location = New System.Drawing.Point(696, 254)
        Me.btncliente.Name = "btncliente"
        Me.btncliente.Size = New System.Drawing.Size(75, 42)
        Me.btncliente.TabIndex = 7
        Me.btncliente.Text = "Agregar Cliente"
        Me.btncliente.UseVisualStyleBackColor = True
        '
        'btnproducto
        '
        Me.btnproducto.Location = New System.Drawing.Point(696, 302)
        Me.btnproducto.Name = "btnproducto"
        Me.btnproducto.Size = New System.Drawing.Size(75, 43)
        Me.btnproducto.TabIndex = 8
        Me.btnproducto.Text = "Agregar Producto"
        Me.btnproducto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 362)
        Me.Controls.Add(Me.btnproducto)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.btncliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnelim)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregar As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents btnelim As Button
    Friend WithEvents dtg As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents mtxtID As MaskedTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorValid As ErrorProvider
    Friend WithEvents mtxtFechaVenta As MaskedTextBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents btnproducto As Button
    Friend WithEvents btncliente As Button
End Class

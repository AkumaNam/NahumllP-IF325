<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.cmbDepa = New System.Windows.Forms.ComboBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.cmbBolsa = New System.Windows.Forms.ComboBox()
        Me.dgtv = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txt1Nom = New System.Windows.Forms.TextBox()
        Me.txt2Nom = New System.Windows.Forms.TextBox()
        Me.txt1Apellido = New System.Windows.Forms.TextBox()
        Me.txt2Apellido = New System.Windows.Forms.TextBox()
        Me.mtxtIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnEntregado = New System.Windows.Forms.Button()
        Me.ErrorValid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBbolsa = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgtv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDepa
        '
        Me.cmbDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepa.FormattingEnabled = True
        Me.cmbDepa.Location = New System.Drawing.Point(230, 181)
        Me.cmbDepa.Name = "cmbDepa"
        Me.cmbDepa.Size = New System.Drawing.Size(121, 21)
        Me.cmbDepa.TabIndex = 0
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(80, 248)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstado.TabIndex = 1
        '
        'cmbBolsa
        '
        Me.cmbBolsa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBolsa.FormattingEnabled = True
        Me.cmbBolsa.Location = New System.Drawing.Point(230, 30)
        Me.cmbBolsa.Name = "cmbBolsa"
        Me.cmbBolsa.Size = New System.Drawing.Size(121, 21)
        Me.cmbBolsa.TabIndex = 2
        '
        'dgtv
        '
        Me.dgtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgtv.Location = New System.Drawing.Point(3, 16)
        Me.dgtv.Name = "dgtv"
        Me.dgtv.Size = New System.Drawing.Size(381, 289)
        Me.dgtv.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(80, 22)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'txt1Nom
        '
        Me.txt1Nom.Location = New System.Drawing.Point(80, 57)
        Me.txt1Nom.Name = "txt1Nom"
        Me.txt1Nom.Size = New System.Drawing.Size(100, 20)
        Me.txt1Nom.TabIndex = 5
        '
        'txt2Nom
        '
        Me.txt2Nom.Location = New System.Drawing.Point(80, 94)
        Me.txt2Nom.Name = "txt2Nom"
        Me.txt2Nom.Size = New System.Drawing.Size(100, 20)
        Me.txt2Nom.TabIndex = 6
        '
        'txt1Apellido
        '
        Me.txt1Apellido.Location = New System.Drawing.Point(80, 131)
        Me.txt1Apellido.Name = "txt1Apellido"
        Me.txt1Apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt1Apellido.TabIndex = 7
        '
        'txt2Apellido
        '
        Me.txt2Apellido.Location = New System.Drawing.Point(80, 169)
        Me.txt2Apellido.Name = "txt2Apellido"
        Me.txt2Apellido.Size = New System.Drawing.Size(100, 20)
        Me.txt2Apellido.TabIndex = 8
        '
        'mtxtIntegrantes
        '
        Me.mtxtIntegrantes.Location = New System.Drawing.Point(80, 206)
        Me.mtxtIntegrantes.Mask = "0"
        Me.mtxtIntegrantes.Name = "mtxtIntegrantes"
        Me.mtxtIntegrantes.Size = New System.Drawing.Size(100, 20)
        Me.mtxtIntegrantes.TabIndex = 9
        Me.mtxtIntegrantes.ValidatingType = GetType(Integer)
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(230, 208)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(121, 60)
        Me.txtDireccion.TabIndex = 10
        '
        'btnEntregado
        '
        Me.btnEntregado.Location = New System.Drawing.Point(302, 277)
        Me.btnEntregado.Name = "btnEntregado"
        Me.btnEntregado.Size = New System.Drawing.Size(75, 23)
        Me.btnEntregado.TabIndex = 11
        Me.btnEntregado.Text = "Entregado"
        Me.btnEntregado.UseVisualStyleBackColor = True
        '
        'ErrorValid
        '
        Me.ErrorValid.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.LBbolsa)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.btnEntregado)
        Me.GroupBox1.Controls.Add(Me.cmbDepa)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.cmbBolsa)
        Me.GroupBox1.Controls.Add(Me.mtxtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.txt1Nom)
        Me.GroupBox1.Controls.Add(Me.txt2Apellido)
        Me.GroupBox1.Controls.Add(Me.txt2Nom)
        Me.GroupBox1.Controls.Add(Me.txt1Apellido)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 308)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(230, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Dirección"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Bolsa"
        '
        'LBbolsa
        '
        Me.LBbolsa.FormattingEnabled = True
        Me.LBbolsa.Location = New System.Drawing.Point(230, 57)
        Me.LBbolsa.Name = "LBbolsa"
        Me.LBbolsa.Size = New System.Drawing.Size(120, 95)
        Me.LBbolsa.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = " Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = " Integrantes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = " 2do Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = " 1er Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = " 2do Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = " 1er Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = " Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgtv)
        Me.GroupBox2.Location = New System.Drawing.Point(398, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 308)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 341)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgtv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbDepa As ComboBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents cmbBolsa As ComboBox
    Friend WithEvents dgtv As DataGridView
    Friend WithEvents txtID As TextBox
    Friend WithEvents txt1Nom As TextBox
    Friend WithEvents txt2Nom As TextBox
    Friend WithEvents txt1Apellido As TextBox
    Friend WithEvents txt2Apellido As TextBox
    Friend WithEvents mtxtIntegrantes As MaskedTextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnEntregado As Button
    Friend WithEvents ErrorValid As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBbolsa As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturación
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
        Me.Gbx_Datosclientes = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt_nome = New System.Windows.Forms.TextBox()
        Me.Txt_Numero = New System.Windows.Forms.TextBox()
        Me.Cbo_TipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.Btn_Limpar = New System.Windows.Forms.Button()
        Me.Cbo_Serviço = New System.Windows.Forms.ComboBox()
        Me.Txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_Precio = New System.Windows.Forms.Label()
        Me.Cbo_Codigo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.Lbx_SubTotal = New System.Windows.Forms.ListBox()
        Me.Lbx_quant = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbx_Preco = New System.Windows.Forms.ListBox()
        Me.Lbx_Serviço = New System.Windows.Forms.ListBox()
        Me.Lbx_Item = New System.Windows.Forms.ListBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnFactura = New System.Windows.Forms.RadioButton()
        Me.btnRecibo = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Btn_Limpardados = New System.Windows.Forms.Button()
        Me.Gbx_Datosclientes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datosclientes
        '
        Me.Gbx_Datosclientes.Controls.Add(Me.Label18)
        Me.Gbx_Datosclientes.Controls.Add(Me.Btn_Limpardados)
        Me.Gbx_Datosclientes.Controls.Add(Me.Txt_nome)
        Me.Gbx_Datosclientes.Controls.Add(Me.Txt_Numero)
        Me.Gbx_Datosclientes.Controls.Add(Me.Cbo_TipoDocu)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label2)
        Me.Gbx_Datosclientes.Controls.Add(Me.Label1)
        Me.Gbx_Datosclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Datosclientes.Location = New System.Drawing.Point(32, 68)
        Me.Gbx_Datosclientes.Margin = New System.Windows.Forms.Padding(4)
        Me.Gbx_Datosclientes.Name = "Gbx_Datosclientes"
        Me.Gbx_Datosclientes.Padding = New System.Windows.Forms.Padding(4)
        Me.Gbx_Datosclientes.Size = New System.Drawing.Size(657, 158)
        Me.Gbx_Datosclientes.TabIndex = 0
        Me.Gbx_Datosclientes.TabStop = False
        Me.Gbx_Datosclientes.Text = "Datos de Clientes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(337, 46)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Número"
        '
        'Txt_nome
        '
        Me.Txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nome.Location = New System.Drawing.Point(149, 89)
        Me.Txt_nome.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_nome.Name = "Txt_nome"
        Me.Txt_nome.Size = New System.Drawing.Size(251, 26)
        Me.Txt_nome.TabIndex = 4
        '
        'Txt_Numero
        '
        Me.Txt_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Numero.Location = New System.Drawing.Point(415, 42)
        Me.Txt_Numero.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Numero.Name = "Txt_Numero"
        Me.Txt_Numero.Size = New System.Drawing.Size(209, 26)
        Me.Txt_Numero.TabIndex = 3
        '
        'Cbo_TipoDocu
        '
        Me.Cbo_TipoDocu.BackColor = System.Drawing.Color.White
        Me.Cbo_TipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_TipoDocu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_TipoDocu.FormattingEnabled = True
        Me.Cbo_TipoDocu.Items.AddRange(New Object() {"Elegir", "DNI", "RUC"})
        Me.Cbo_TipoDocu.Location = New System.Drawing.Point(156, 39)
        Me.Cbo_TipoDocu.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_TipoDocu.Name = "Cbo_TipoDocu"
        Me.Cbo_TipoDocu.Size = New System.Drawing.Size(160, 28)
        Me.Cbo_TipoDocu.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_add)
        Me.GroupBox2.Controls.Add(Me.Btn_Limpar)
        Me.GroupBox2.Controls.Add(Me.Cbo_Serviço)
        Me.GroupBox2.Controls.Add(Me.Txt_Cantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Lbl_Precio)
        Me.GroupBox2.Controls.Add(Me.Cbo_Codigo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 233)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(852, 123)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Producto"
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_add.ForeColor = System.Drawing.Color.White
        Me.Btn_add.Location = New System.Drawing.Point(735, 65)
        Me.Btn_add.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(109, 42)
        Me.Btn_add.TabIndex = 9
        Me.Btn_add.Text = "Adicionar"
        Me.Btn_add.UseVisualStyleBackColor = False
        '
        'Btn_Limpar
        '
        Me.Btn_Limpar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Limpar.ForeColor = System.Drawing.Color.White
        Me.Btn_Limpar.Location = New System.Drawing.Point(735, 20)
        Me.Btn_Limpar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Limpar.Name = "Btn_Limpar"
        Me.Btn_Limpar.Size = New System.Drawing.Size(109, 42)
        Me.Btn_Limpar.TabIndex = 8
        Me.Btn_Limpar.Text = "Limpar"
        Me.Btn_Limpar.UseVisualStyleBackColor = False
        '
        'Cbo_Serviço
        '
        Me.Cbo_Serviço.BackColor = System.Drawing.Color.White
        Me.Cbo_Serviço.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Serviço.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Serviço.FormattingEnabled = True
        Me.Cbo_Serviço.Location = New System.Drawing.Point(467, 32)
        Me.Cbo_Serviço.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Serviço.Name = "Cbo_Serviço"
        Me.Cbo_Serviço.Size = New System.Drawing.Size(248, 28)
        Me.Cbo_Serviço.TabIndex = 7
        '
        'Txt_Cantidad
        '
        Me.Txt_Cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cantidad.Location = New System.Drawing.Point(364, 73)
        Me.Txt_Cantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Cantidad.Name = "Txt_Cantidad"
        Me.Txt_Cantidad.Size = New System.Drawing.Size(116, 26)
        Me.Txt_Cantidad.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(273, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Quantidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Serviço"
        '
        'Lbl_Precio
        '
        Me.Lbl_Precio.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Precio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Precio.Location = New System.Drawing.Point(115, 71)
        Me.Lbl_Precio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Precio.Name = "Lbl_Precio"
        Me.Lbl_Precio.Size = New System.Drawing.Size(133, 28)
        Me.Lbl_Precio.TabIndex = 3
        '
        'Cbo_Codigo
        '
        Me.Cbo_Codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Codigo.FormattingEnabled = True
        Me.Cbo_Codigo.Items.AddRange(New Object() {"Seleccione una Categoria", "Lacteos", "Licores", "Detergentes", "Carnes y Embutidos", "Bebidas"})
        Me.Cbo_Codigo.Location = New System.Drawing.Point(115, 32)
        Me.Cbo_Codigo.Margin = New System.Windows.Forms.Padding(4)
        Me.Cbo_Codigo.Name = "Cbo_Codigo"
        Me.Cbo_Codigo.Size = New System.Drawing.Size(252, 28)
        Me.Cbo_Codigo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 73)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Preço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Btn_Nuevo)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Lbl_Total)
        Me.GroupBox3.Controls.Add(Me.Lbx_SubTotal)
        Me.GroupBox3.Controls.Add(Me.Lbx_quant)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Lbx_Preco)
        Me.GroupBox3.Controls.Add(Me.Lbx_Serviço)
        Me.GroupBox3.Controls.Add(Me.Lbx_Item)
        Me.GroupBox3.Controls.Add(Me.Btn_Eliminar)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(32, 363)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(897, 362)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Detalle"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(680, 36)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 20)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Sub_Total"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(577, 36)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Cantidad"
        '
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.Btn_Nuevo.Location = New System.Drawing.Point(779, 299)
        Me.Btn_Nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(109, 42)
        Me.Btn_Nuevo.TabIndex = 4
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(471, 36)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Precio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(84, 36)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 20)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Producto"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Item"
        '
        'Lbl_Total
        '
        Me.Lbl_Total.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(531, 309)
        Me.Lbl_Total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(121, 28)
        Me.Lbl_Total.TabIndex = 10
        '
        'Lbx_SubTotal
        '
        Me.Lbx_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_SubTotal.FormattingEnabled = True
        Me.Lbx_SubTotal.ItemHeight = 17
        Me.Lbx_SubTotal.Location = New System.Drawing.Point(684, 59)
        Me.Lbx_SubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbx_SubTotal.Name = "Lbx_SubTotal"
        Me.Lbx_SubTotal.Size = New System.Drawing.Size(112, 225)
        Me.Lbx_SubTotal.TabIndex = 4
        '
        'Lbx_quant
        '
        Me.Lbx_quant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_quant.FormattingEnabled = True
        Me.Lbx_quant.ItemHeight = 17
        Me.Lbx_quant.Location = New System.Drawing.Point(581, 59)
        Me.Lbx_quant.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbx_quant.Name = "Lbx_quant"
        Me.Lbx_quant.Size = New System.Drawing.Size(93, 225)
        Me.Lbx_quant.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(463, 313)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total :"
        '
        'Lbx_Preco
        '
        Me.Lbx_Preco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Preco.FormattingEnabled = True
        Me.Lbx_Preco.ItemHeight = 17
        Me.Lbx_Preco.Location = New System.Drawing.Point(475, 59)
        Me.Lbx_Preco.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbx_Preco.Name = "Lbx_Preco"
        Me.Lbx_Preco.Size = New System.Drawing.Size(97, 225)
        Me.Lbx_Preco.TabIndex = 2
        '
        'Lbx_Serviço
        '
        Me.Lbx_Serviço.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Serviço.FormattingEnabled = True
        Me.Lbx_Serviço.ItemHeight = 17
        Me.Lbx_Serviço.Location = New System.Drawing.Point(88, 59)
        Me.Lbx_Serviço.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbx_Serviço.Name = "Lbx_Serviço"
        Me.Lbx_Serviço.Size = New System.Drawing.Size(377, 225)
        Me.Lbx_Serviço.TabIndex = 1
        '
        'Lbx_Item
        '
        Me.Lbx_Item.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbx_Item.FormattingEnabled = True
        Me.Lbx_Item.ItemHeight = 17
        Me.Lbx_Item.Location = New System.Drawing.Point(8, 59)
        Me.Lbx_Item.Margin = New System.Windows.Forms.Padding(4)
        Me.Lbx_Item.Name = "Lbx_Item"
        Me.Lbx_Item.Size = New System.Drawing.Size(71, 225)
        Me.Lbx_Item.TabIndex = 0
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.Red
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.White
        Me.Btn_Eliminar.Location = New System.Drawing.Point(661, 299)
        Me.Btn_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(109, 42)
        Me.Btn_Eliminar.TabIndex = 4
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.btnFactura)
        Me.GroupBox1.Controls.Add(Me.btnRecibo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(697, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(187, 158)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(16, 17)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(157, 28)
        Me.lblFecha.TabIndex = 3
        '
        'btnFactura
        '
        Me.btnFactura.AutoSize = True
        Me.btnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactura.Location = New System.Drawing.Point(19, 126)
        Me.btnFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFactura.Name = "btnFactura"
        Me.btnFactura.Size = New System.Drawing.Size(87, 24)
        Me.btnFactura.TabIndex = 2
        Me.btnFactura.Text = "Factura"
        Me.btnFactura.UseVisualStyleBackColor = True
        '
        'btnRecibo
        '
        Me.btnRecibo.AutoSize = True
        Me.btnRecibo.Checked = True
        Me.btnRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo.Location = New System.Drawing.Point(19, 95)
        Me.btnRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRecibo.Name = "btnRecibo"
        Me.btnRecibo.Size = New System.Drawing.Size(82, 24)
        Me.btnRecibo.TabIndex = 1
        Me.btnRecibo.TabStop = True
        Me.btnRecibo.Text = "Recibo"
        Me.btnRecibo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 60)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Tipo Documento"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(-5, -4)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(969, 55)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Facturación"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Red
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans Unicode", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(908, -1)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 53)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "X"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Limpardados
        '
        Me.Btn_Limpardados.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Limpardados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Limpardados.ForeColor = System.Drawing.Color.White
        Me.Btn_Limpardados.Location = New System.Drawing.Point(427, 86)
        Me.Btn_Limpardados.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_Limpardados.Name = "Btn_Limpardados"
        Me.Btn_Limpardados.Size = New System.Drawing.Size(139, 41)
        Me.Btn_Limpardados.TabIndex = 5
        Me.Btn_Limpardados.Text = "Limpar"
        Me.Btn_Limpardados.UseVisualStyleBackColor = False
        '
        'Facturación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(964, 759)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gbx_Datosclientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Facturación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Gbx_Datosclientes.ResumeLayout(False)
        Me.Gbx_Datosclientes.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Datosclientes As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_nome As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_TipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Btn_Limpar As System.Windows.Forms.Button
    Friend WithEvents Cbo_Serviço As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Precio As System.Windows.Forms.Label
    Friend WithEvents Cbo_Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbx_SubTotal As System.Windows.Forms.ListBox
    Friend WithEvents Lbx_quant As System.Windows.Forms.ListBox
    Friend WithEvents Lbx_Preco As System.Windows.Forms.ListBox
    Friend WithEvents Lbx_Serviço As System.Windows.Forms.ListBox
    Friend WithEvents Lbx_Item As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFactura As System.Windows.Forms.RadioButton
    Friend WithEvents btnRecibo As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Btn_Limpardados As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_Clientes))
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.TXT_FPAGO = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_MAIL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_DNI = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_LC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_FONO1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_DIREC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_RUC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_COD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DESC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblAnulado = New System.Windows.Forms.Label()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTCAPCHA = New System.Windows.Forms.TextBox()
        Me.BTONCAPCHA = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PICTURE = New System.Windows.Forms.PictureBox()
        Me.Group_SUNAT = New System.Windows.Forms.GroupBox()
        Me.TXT_CONDICION = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBL_ESTADO = New System.Windows.Forms.Label()
        Me.TXT_ESTADO = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PICTURE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_SUNAT.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 40)
        '
        'TXT_FPAGO
        '
        Me.TXT_FPAGO.Location = New System.Drawing.Point(87, 260)
        Me.TXT_FPAGO.Name = "TXT_FPAGO"
        Me.TXT_FPAGO.ReadOnly = True
        Me.TXT_FPAGO.Size = New System.Drawing.Size(226, 20)
        Me.TXT_FPAGO.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_MAIL)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT_DNI)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_LC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.picturebox1)
        Me.GroupBox1.Controls.Add(Me.TXT_FPAGO)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_FONO1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_DIREC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_RUC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_COD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_DESC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LblAnulado)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 334)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'TXT_MAIL
        '
        Me.TXT_MAIL.Location = New System.Drawing.Point(87, 290)
        Me.TXT_MAIL.Name = "TXT_MAIL"
        Me.TXT_MAIL.Size = New System.Drawing.Size(298, 20)
        Me.TXT_MAIL.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(34, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Mail :"
        '
        'TXT_DNI
        '
        Me.TXT_DNI.Location = New System.Drawing.Point(295, 106)
        Me.TXT_DNI.Name = "TXT_DNI"
        Me.TXT_DNI.Size = New System.Drawing.Size(90, 20)
        Me.TXT_DNI.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(255, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Dni :"
        '
        'TXT_LC
        '
        Me.TXT_LC.Location = New System.Drawing.Point(296, 223)
        Me.TXT_LC.MaxLength = 11
        Me.TXT_LC.Name = "TXT_LC"
        Me.TXT_LC.Size = New System.Drawing.Size(89, 20)
        Me.TXT_LC.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(185, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Limite de Credito :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button1.Location = New System.Drawing.Point(327, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(207, 18)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 18
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "F. de Pago :"
        '
        'TXT_FONO1
        '
        Me.TXT_FONO1.Location = New System.Drawing.Point(87, 224)
        Me.TXT_FONO1.Name = "TXT_FONO1"
        Me.TXT_FONO1.Size = New System.Drawing.Size(92, 20)
        Me.TXT_FONO1.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Telefono 1 :"
        '
        'TXT_DIREC
        '
        Me.TXT_DIREC.Location = New System.Drawing.Point(87, 143)
        Me.TXT_DIREC.MaxLength = 850
        Me.TXT_DIREC.Multiline = True
        Me.TXT_DIREC.Name = "TXT_DIREC"
        Me.TXT_DIREC.Size = New System.Drawing.Size(298, 60)
        Me.TXT_DIREC.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion :"
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Location = New System.Drawing.Point(87, 107)
        Me.TXT_RUC.MaxLength = 11
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(121, 20)
        Me.TXT_RUC.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ruc :"
        '
        'TXT_COD
        '
        Me.TXT_COD.Location = New System.Drawing.Point(87, 26)
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(111, 20)
        Me.TXT_COD.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Codigo :"
        '
        'TXT_DESC
        '
        Me.TXT_DESC.Location = New System.Drawing.Point(87, 64)
        Me.TXT_DESC.Name = "TXT_DESC"
        Me.TXT_DESC.Size = New System.Drawing.Size(272, 20)
        Me.TXT_DESC.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion :"
        '
        'LblAnulado
        '
        Me.LblAnulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnulado.ForeColor = System.Drawing.Color.Red
        Me.LblAnulado.Location = New System.Drawing.Point(258, 20)
        Me.LblAnulado.Name = "LblAnulado"
        Me.LblAnulado.Size = New System.Drawing.Size(101, 26)
        Me.LblAnulado.TabIndex = 3
        Me.LblAnulado.Text = "ANULADO"
        Me.LblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolStripSeparator13, Me.ToolGrabar, Me.ToolStripSeparator14, Me.ToolModificar, Me.ToolStripSeparator15, Me.ToolAnular, Me.ToolStripSeparator16, Me.ToolCancelar, Me.ToolStripSeparator17, Me.ToolPrint, Me.ToolStripSeparator18, Me.ToolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(635, 40)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolNuevo
        '
        Me.ToolNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolNuevo.Image = Global.Market.My.Resources.Resources.Nuevo
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(46, 37)
        Me.ToolNuevo.Text = "Nuevo"
        Me.ToolNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolNuevo.ToolTipText = "Nuevo"
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolGrabar.Image = Global.Market.My.Resources.Resources.Grabar
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(50, 37)
        Me.ToolGrabar.Text = "Grabar"
        Me.ToolGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolModificar
        '
        Me.ToolModificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolModificar.Image = Global.Market.My.Resources.Resources.Foldrs03
        Me.ToolModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolModificar.Name = "ToolModificar"
        Me.ToolModificar.Size = New System.Drawing.Size(63, 37)
        Me.ToolModificar.Text = "Modificar"
        Me.ToolModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolAnular
        '
        Me.ToolAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolAnular.Image = Global.Market.My.Resources.Resources.Elim002
        Me.ToolAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolAnular.Name = "ToolAnular"
        Me.ToolAnular.Size = New System.Drawing.Size(48, 37)
        Me.ToolAnular.Text = "Anular"
        Me.ToolAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Image = Global.Market.My.Resources.Resources.cancelar
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(60, 37)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolPrint
        '
        Me.ToolPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolPrint.Image = Global.Market.My.Resources.Resources.Imprimir
        Me.ToolPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolPrint.Name = "ToolPrint"
        Me.ToolPrint.Size = New System.Drawing.Size(61, 37)
        Me.ToolPrint.Text = "Imprimir"
        Me.ToolPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 40)
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(36, 37)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTCAPCHA)
        Me.GroupBox2.Controls.Add(Me.BTONCAPCHA)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.PICTURE)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(441, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(182, 301)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sunat"
        '
        'TXTCAPCHA
        '
        Me.TXTCAPCHA.Location = New System.Drawing.Point(16, 126)
        Me.TXTCAPCHA.MaxLength = 11
        Me.TXTCAPCHA.Name = "TXTCAPCHA"
        Me.TXTCAPCHA.Size = New System.Drawing.Size(148, 20)
        Me.TXTCAPCHA.TabIndex = 119
        '
        'BTONCAPCHA
        '
        Me.BTONCAPCHA.BackColor = System.Drawing.Color.White
        Me.BTONCAPCHA.Location = New System.Drawing.Point(6, 90)
        Me.BTONCAPCHA.Name = "BTONCAPCHA"
        Me.BTONCAPCHA.Size = New System.Drawing.Size(167, 26)
        Me.BTONCAPCHA.TabIndex = 118
        Me.BTONCAPCHA.Text = "Actualizar Captcha"
        Me.BTONCAPCHA.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(31, 180)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 26)
        Me.Button9.TabIndex = 117
        Me.Button9.Text = "Consultar Sunat"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PICTURE
        '
        Me.PICTURE.Location = New System.Drawing.Point(6, 23)
        Me.PICTURE.Name = "PICTURE"
        Me.PICTURE.Size = New System.Drawing.Size(167, 50)
        Me.PICTURE.TabIndex = 0
        Me.PICTURE.TabStop = False
        '
        'Group_SUNAT
        '
        Me.Group_SUNAT.Controls.Add(Me.TXT_CONDICION)
        Me.Group_SUNAT.Controls.Add(Me.Label9)
        Me.Group_SUNAT.Controls.Add(Me.LBL_ESTADO)
        Me.Group_SUNAT.Controls.Add(Me.TXT_ESTADO)
        Me.Group_SUNAT.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_SUNAT.Location = New System.Drawing.Point(12, 392)
        Me.Group_SUNAT.Name = "Group_SUNAT"
        Me.Group_SUNAT.Size = New System.Drawing.Size(468, 48)
        Me.Group_SUNAT.TabIndex = 124
        Me.Group_SUNAT.TabStop = False
        Me.Group_SUNAT.Text = "Sunat"
        '
        'TXT_CONDICION
        '
        Me.TXT_CONDICION.Enabled = False
        Me.TXT_CONDICION.Location = New System.Drawing.Point(299, 15)
        Me.TXT_CONDICION.Name = "TXT_CONDICION"
        Me.TXT_CONDICION.Size = New System.Drawing.Size(143, 20)
        Me.TXT_CONDICION.TabIndex = 121
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(227, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Condicion :"
        '
        'LBL_ESTADO
        '
        Me.LBL_ESTADO.AutoSize = True
        Me.LBL_ESTADO.Location = New System.Drawing.Point(21, 18)
        Me.LBL_ESTADO.Name = "LBL_ESTADO"
        Me.LBL_ESTADO.Size = New System.Drawing.Size(47, 13)
        Me.LBL_ESTADO.TabIndex = 118
        Me.LBL_ESTADO.Text = "Estado :"
        '
        'TXT_ESTADO
        '
        Me.TXT_ESTADO.Enabled = False
        Me.TXT_ESTADO.Location = New System.Drawing.Point(76, 15)
        Me.TXT_ESTADO.Name = "TXT_ESTADO"
        Me.TXT_ESTADO.Size = New System.Drawing.Size(145, 20)
        Me.TXT_ESTADO.TabIndex = 119
        '
        'Mant_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(635, 443)
        Me.Controls.Add(Me.Group_SUNAT)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mant_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PICTURE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_SUNAT.ResumeLayout(False)
        Me.Group_SUNAT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents TXT_FPAGO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_FONO1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIREC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_RUC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_COD As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_DESC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblAnulado As System.Windows.Forms.Label
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXT_LC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_DNI As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXTCAPCHA As System.Windows.Forms.TextBox
    Friend WithEvents BTONCAPCHA As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents PICTURE As System.Windows.Forms.PictureBox
    Friend WithEvents Group_SUNAT As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_CONDICION As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LBL_ESTADO As System.Windows.Forms.Label
    Friend WithEvents TXT_ESTADO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_MAIL As TextBox
    Friend WithEvents Label10 As Label
End Class

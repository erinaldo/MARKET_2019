<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.TXT_ESTADO = New System.Windows.Forms.ToolStripTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DT_VCTO = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NUMERO = New System.Windows.Forms.TextBox()
        Me.TXT_SERIE = New System.Windows.Forms.TextBox()
        Me.Combo_DOC = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHK_IGV = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_FPAGO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OPT_DOLARES = New System.Windows.Forms.RadioButton()
        Me.OPT_SOLES = New System.Windows.Forms.RadioButton()
        Me.TXT_PROV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TXT_COMENTARIO = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_IGV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_VVENTA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TXT_ALMACEN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_PORC_PERCEP = New System.Windows.Forms.TextBox()
        Me.Group_PERCEP = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_NRO_PERCEPCION = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_PERCEPCION = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.Group_PERCEP.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolStripSeparator13, Me.ToolGrabar, Me.ToolStripSeparator14, Me.ToolModificar, Me.ToolStripSeparator15, Me.ToolAnular, Me.ToolStripSeparator16, Me.ToolCancelar, Me.ToolStripSeparator17, Me.ToolPrint, Me.ToolStripSeparator18, Me.ToolSalir, Me.TXT_ESTADO})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(664, 40)
        Me.ToolStrip1.TabIndex = 9
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
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 40)
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
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 40)
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
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
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
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 40)
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
        'TXT_ESTADO
        '
        Me.TXT_ESTADO.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TXT_ESTADO.ForeColor = System.Drawing.Color.Red
        Me.TXT_ESTADO.Name = "TXT_ESTADO"
        Me.TXT_ESTADO.ReadOnly = True
        Me.TXT_ESTADO.Size = New System.Drawing.Size(100, 40)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picturebox1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TXT_NUMERO)
        Me.GroupBox1.Controls.Add(Me.TXT_SERIE)
        Me.GroupBox1.Controls.Add(Me.Combo_DOC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(432, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 149)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(177, 35)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 21
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DT_VCTO)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DT_FECHA)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 73)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'DT_VCTO
        '
        Me.DT_VCTO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_VCTO.Location = New System.Drawing.Point(72, 41)
        Me.DT_VCTO.Name = "DT_VCTO"
        Me.DT_VCTO.Size = New System.Drawing.Size(93, 20)
        Me.DT_VCTO.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Vcto. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Emision :"
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(72, 15)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(93, 20)
        Me.DT_FECHA.TabIndex = 4
        '
        'TXT_NUMERO
        '
        Me.TXT_NUMERO.Location = New System.Drawing.Point(76, 43)
        Me.TXT_NUMERO.Name = "TXT_NUMERO"
        Me.TXT_NUMERO.Size = New System.Drawing.Size(95, 20)
        Me.TXT_NUMERO.TabIndex = 2
        Me.TXT_NUMERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_SERIE
        '
        Me.TXT_SERIE.Location = New System.Drawing.Point(6, 43)
        Me.TXT_SERIE.Name = "TXT_SERIE"
        Me.TXT_SERIE.Size = New System.Drawing.Size(64, 20)
        Me.TXT_SERIE.TabIndex = 1
        Me.TXT_SERIE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Combo_DOC
        '
        Me.Combo_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_DOC.FormattingEnabled = True
        Me.Combo_DOC.Location = New System.Drawing.Point(6, 16)
        Me.Combo_DOC.Name = "Combo_DOC"
        Me.Combo_DOC.Size = New System.Drawing.Size(165, 21)
        Me.Combo_DOC.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Group_PERCEP)
        Me.GroupBox3.Controls.Add(Me.TXT_PORC_PERCEP)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CHK_IGV)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TXT_TC)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TXT_FPAGO)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.TXT_PROV)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 158)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'CHK_IGV
        '
        Me.CHK_IGV.AutoSize = True
        Me.CHK_IGV.Location = New System.Drawing.Point(330, 57)
        Me.CHK_IGV.Name = "CHK_IGV"
        Me.CHK_IGV.Size = New System.Drawing.Size(69, 17)
        Me.CHK_IGV.TabIndex = 31
        Me.CHK_IGV.Text = "Inc IGV"
        Me.CHK_IGV.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button2.Location = New System.Drawing.Point(366, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 28)
        Me.Button2.TabIndex = 30
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button1.Location = New System.Drawing.Point(364, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(173, 58)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.Size = New System.Drawing.Size(55, 20)
        Me.TXT_TC.TabIndex = 27
        Me.TXT_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "T.C. "
        '
        'TXT_FPAGO
        '
        Me.TXT_FPAGO.Location = New System.Drawing.Point(112, 88)
        Me.TXT_FPAGO.Name = "TXT_FPAGO"
        Me.TXT_FPAGO.ReadOnly = True
        Me.TXT_FPAGO.Size = New System.Drawing.Size(246, 20)
        Me.TXT_FPAGO.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Forma de Pago :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OPT_DOLARES)
        Me.GroupBox4.Controls.Add(Me.OPT_SOLES)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 43)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(151, 39)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'OPT_DOLARES
        '
        Me.OPT_DOLARES.AutoSize = True
        Me.OPT_DOLARES.Location = New System.Drawing.Point(68, 14)
        Me.OPT_DOLARES.Name = "OPT_DOLARES"
        Me.OPT_DOLARES.Size = New System.Drawing.Size(68, 17)
        Me.OPT_DOLARES.TabIndex = 1
        Me.OPT_DOLARES.Text = "Dolares"
        Me.OPT_DOLARES.UseVisualStyleBackColor = True
        '
        'OPT_SOLES
        '
        Me.OPT_SOLES.AutoSize = True
        Me.OPT_SOLES.Checked = True
        Me.OPT_SOLES.Location = New System.Drawing.Point(6, 15)
        Me.OPT_SOLES.Name = "OPT_SOLES"
        Me.OPT_SOLES.Size = New System.Drawing.Size(56, 17)
        Me.OPT_SOLES.TabIndex = 0
        Me.OPT_SOLES.TabStop = True
        Me.OPT_SOLES.Text = "Soles"
        Me.OPT_SOLES.UseVisualStyleBackColor = True
        '
        'TXT_PROV
        '
        Me.TXT_PROV.Location = New System.Drawing.Point(85, 16)
        Me.TXT_PROV.Name = "TXT_PROV"
        Me.TXT_PROV.ReadOnly = True
        Me.TXT_PROV.Size = New System.Drawing.Size(273, 20)
        Me.TXT_PROV.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Proveedor :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DBLISTAR)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 207)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(640, 193)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'DBLISTAR
        '
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "6,0,0,0,0,85,Columns:"
        Me.DBLISTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(9, 19)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.Size = New System.Drawing.Size(621, 168)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 10
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TXT_COMENTARIO)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(387, 74)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Comentario"
        '
        'TXT_COMENTARIO
        '
        Me.TXT_COMENTARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COMENTARIO.Location = New System.Drawing.Point(9, 20)
        Me.TXT_COMENTARIO.Multiline = True
        Me.TXT_COMENTARIO.Name = "TXT_COMENTARIO"
        Me.TXT_COMENTARIO.Size = New System.Drawing.Size(366, 48)
        Me.TXT_COMENTARIO.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TXT_PERCEPCION)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.TXT_IGV)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.TXT_VVENTA)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(39, 480)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(569, 66)
        Me.GroupBox7.TabIndex = 14
        Me.GroupBox7.TabStop = False
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTAL.Location = New System.Drawing.Point(435, 39)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(110, 21)
        Me.TXT_TOTAL.TabIndex = 5
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(464, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Total"
        '
        'TXT_IGV
        '
        Me.TXT_IGV.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_IGV.Location = New System.Drawing.Point(148, 39)
        Me.TXT_IGV.Name = "TXT_IGV"
        Me.TXT_IGV.ReadOnly = True
        Me.TXT_IGV.Size = New System.Drawing.Size(110, 21)
        Me.TXT_IGV.TabIndex = 3
        Me.TXT_IGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(190, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Igv "
        '
        'TXT_VVENTA
        '
        Me.TXT_VVENTA.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_VVENTA.Location = New System.Drawing.Point(15, 39)
        Me.TXT_VVENTA.Name = "TXT_VVENTA"
        Me.TXT_VVENTA.ReadOnly = True
        Me.TXT_VVENTA.Size = New System.Drawing.Size(110, 21)
        Me.TXT_VVENTA.TabIndex = 1
        Me.TXT_VVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Valor Venta "
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button3)
        Me.GroupBox9.Controls.Add(Me.TXT_ALMACEN)
        Me.GroupBox9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(405, 415)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(247, 53)
        Me.GroupBox9.TabIndex = 26
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Almacen"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button3.Location = New System.Drawing.Point(209, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 34)
        Me.Button3.TabIndex = 58
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TXT_ALMACEN
        '
        Me.TXT_ALMACEN.Location = New System.Drawing.Point(9, 20)
        Me.TXT_ALMACEN.Name = "TXT_ALMACEN"
        Me.TXT_ALMACEN.Size = New System.Drawing.Size(194, 21)
        Me.TXT_ALMACEN.TabIndex = 5
        Me.TXT_ALMACEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(247, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "% Percep"
        '
        'TXT_PORC_PERCEP
        '
        Me.TXT_PORC_PERCEP.Location = New System.Drawing.Point(252, 58)
        Me.TXT_PORC_PERCEP.Name = "TXT_PORC_PERCEP"
        Me.TXT_PORC_PERCEP.ReadOnly = True
        Me.TXT_PORC_PERCEP.Size = New System.Drawing.Size(55, 20)
        Me.TXT_PORC_PERCEP.TabIndex = 33
        Me.TXT_PORC_PERCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Group_PERCEP
        '
        Me.Group_PERCEP.Controls.Add(Me.Label10)
        Me.Group_PERCEP.Controls.Add(Me.TXT_NRO_PERCEPCION)
        Me.Group_PERCEP.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_PERCEP.Location = New System.Drawing.Point(112, 110)
        Me.Group_PERCEP.Name = "Group_PERCEP"
        Me.Group_PERCEP.Size = New System.Drawing.Size(197, 36)
        Me.Group_PERCEP.TabIndex = 83
        Me.Group_PERCEP.TabStop = False
        Me.Group_PERCEP.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Nro Percepcion :"
        '
        'TXT_NRO_PERCEPCION
        '
        Me.TXT_NRO_PERCEPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NRO_PERCEPCION.Location = New System.Drawing.Point(105, 13)
        Me.TXT_NRO_PERCEPCION.Name = "TXT_NRO_PERCEPCION"
        Me.TXT_NRO_PERCEPCION.Size = New System.Drawing.Size(86, 20)
        Me.TXT_NRO_PERCEPCION.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(311, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Percepcion"
        '
        'TXT_PERCEPCION
        '
        Me.TXT_PERCEPCION.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PERCEPCION.Location = New System.Drawing.Point(289, 38)
        Me.TXT_PERCEPCION.Name = "TXT_PERCEPCION"
        Me.TXT_PERCEPCION.ReadOnly = True
        Me.TXT_PERCEPCION.Size = New System.Drawing.Size(110, 21)
        Me.TXT_PERCEPCION.TabIndex = 7
        Me.TXT_PERCEPCION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(664, 558)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.Group_PERCEP.ResumeLayout(False)
        Me.Group_PERCEP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_NUMERO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_SERIE As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_TC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FPAGO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_DOLARES As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_SOLES As System.Windows.Forms.RadioButton
    Friend WithEvents TXT_PROV As System.Windows.Forms.TextBox
    Friend WithEvents DT_VCTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_COMENTARIO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_IGV As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_VVENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_ESTADO As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents CHK_IGV As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TXT_ALMACEN As TextBox
    Friend WithEvents TXT_PORC_PERCEP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Group_PERCEP As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_NRO_PERCEPCION As TextBox
    Friend WithEvents TXT_PERCEPCION As TextBox
    Friend WithEvents Label11 As Label
End Class

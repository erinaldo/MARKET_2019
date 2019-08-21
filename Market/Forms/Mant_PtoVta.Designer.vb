<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_PtoVta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_PtoVta))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.TXT_ESTADO = New System.Windows.Forms.ToolStripTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_REG = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_TERMINAL = New System.Windows.Forms.TextBox()
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CHK_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.CHK_EDITAR = New System.Windows.Forms.CheckBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.TXT_COD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_NRO_PAPEL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_PUERTO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_CORR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Combo_DOC = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_ALMACEN = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolStripSeparator13, Me.ToolGrabar, Me.ToolStripSeparator14, Me.ToolModificar, Me.ToolStripSeparator15, Me.ToolAnular, Me.ToolStripSeparator16, Me.ToolCancelar, Me.ToolStripSeparator17, Me.ToolPrint, Me.ToolStripSeparator18, Me.ToolSalir, Me.TXT_ESTADO})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(525, 40)
        Me.ToolStrip1.TabIndex = 10
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
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 40)
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
        Me.ToolAnular.Visible = False
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator16.Visible = False
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
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TXT_ALMACEN)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXT_REG)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_TERMINAL)
        Me.GroupBox1.Controls.Add(Me.DT_FECHA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CHK_ACTIVO)
        Me.GroupBox1.Controls.Add(Me.CHK_EDITAR)
        Me.GroupBox1.Controls.Add(Me.picturebox1)
        Me.GroupBox1.Controls.Add(Me.TXT_COD)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 148)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'TXT_REG
        '
        Me.TXT_REG.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_REG.Location = New System.Drawing.Point(114, 85)
        Me.TXT_REG.Name = "TXT_REG"
        Me.TXT_REG.Size = New System.Drawing.Size(100, 20)
        Me.TXT_REG.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Maq.Reg. :"
        '
        'TXT_TERMINAL
        '
        Me.TXT_TERMINAL.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TERMINAL.Location = New System.Drawing.Point(113, 42)
        Me.TXT_TERMINAL.Name = "TXT_TERMINAL"
        Me.TXT_TERMINAL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_TERMINAL.TabIndex = 28
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(114, 120)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(99, 20)
        Me.DT_FECHA.TabIndex = 27
        Me.DT_FECHA.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Fecha de Proceso:"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Terminal :"
        '
        'CHK_ACTIVO
        '
        Me.CHK_ACTIVO.AutoSize = True
        Me.CHK_ACTIVO.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CHK_ACTIVO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ACTIVO.Location = New System.Drawing.Point(387, 53)
        Me.CHK_ACTIVO.Name = "CHK_ACTIVO"
        Me.CHK_ACTIVO.Size = New System.Drawing.Size(58, 17)
        Me.CHK_ACTIVO.TabIndex = 24
        Me.CHK_ACTIVO.Text = "Activo"
        Me.CHK_ACTIVO.UseVisualStyleBackColor = False
        '
        'CHK_EDITAR
        '
        Me.CHK_EDITAR.AutoSize = True
        Me.CHK_EDITAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_EDITAR.Location = New System.Drawing.Point(263, 53)
        Me.CHK_EDITAR.Name = "CHK_EDITAR"
        Me.CHK_EDITAR.Size = New System.Drawing.Size(93, 17)
        Me.CHK_EDITAR.TabIndex = 23
        Me.CHK_EDITAR.Text = "Editar Precio"
        Me.CHK_EDITAR.UseVisualStyleBackColor = True
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(412, 11)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 22
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_COD
        '
        Me.TXT_COD.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COD.Location = New System.Drawing.Point(301, 16)
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(105, 20)
        Me.TXT_COD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_NRO_PAPEL)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXT_PUERTO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TXT_CORR)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Combo_DOC)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.DBLISTAR)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 197)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 262)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'TXT_NRO_PAPEL
        '
        Me.TXT_NRO_PAPEL.Location = New System.Drawing.Point(346, 40)
        Me.TXT_NRO_PAPEL.MaxLength = 8
        Me.TXT_NRO_PAPEL.Name = "TXT_NRO_PAPEL"
        Me.TXT_NRO_PAPEL.Size = New System.Drawing.Size(60, 20)
        Me.TXT_NRO_PAPEL.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Nro Papel :"
        '
        'TXT_PUERTO
        '
        Me.TXT_PUERTO.Location = New System.Drawing.Point(346, 13)
        Me.TXT_PUERTO.Name = "TXT_PUERTO"
        Me.TXT_PUERTO.Size = New System.Drawing.Size(138, 20)
        Me.TXT_PUERTO.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Puerto Imp. :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(263, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 25)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(154, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 25)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TXT_CORR
        '
        Me.TXT_CORR.Location = New System.Drawing.Point(94, 40)
        Me.TXT_CORR.MaxLength = 8
        Me.TXT_CORR.Name = "TXT_CORR"
        Me.TXT_CORR.Size = New System.Drawing.Size(138, 20)
        Me.TXT_CORR.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Correlativo :"
        '
        'Combo_DOC
        '
        Me.Combo_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_DOC.FormattingEnabled = True
        Me.Combo_DOC.Location = New System.Drawing.Point(94, 13)
        Me.Combo_DOC.Name = "Combo_DOC"
        Me.Combo_DOC.Size = New System.Drawing.Size(138, 21)
        Me.Combo_DOC.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Documento :"
        '
        'DBLISTAR
        '
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "5,0,0,0,0,85,Columns:"
        Me.DBLISTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(6, 106)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.Size = New System.Drawing.Size(486, 150)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(232, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Almacen Venta :"
        '
        'TXT_ALMACEN
        '
        Me.TXT_ALMACEN.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ALMACEN.Location = New System.Drawing.Point(322, 117)
        Me.TXT_ALMACEN.Name = "TXT_ALMACEN"
        Me.TXT_ALMACEN.ReadOnly = True
        Me.TXT_ALMACEN.Size = New System.Drawing.Size(135, 20)
        Me.TXT_ALMACEN.TabIndex = 32
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button3.Location = New System.Drawing.Point(459, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 28)
        Me.Button3.TabIndex = 33
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Mant_PtoVta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(525, 463)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "Mant_PtoVta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Punto de Venta"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolGrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolAnular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TXT_ESTADO As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_COD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHK_ACTIVO As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_EDITAR As System.Windows.Forms.CheckBox
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents TXT_TERMINAL As System.Windows.Forms.TextBox
    Friend WithEvents DT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TXT_CORR As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Combo_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXT_REG As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_PUERTO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_NRO_PAPEL As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TXT_ALMACEN As TextBox
    Friend WithEvents Label9 As Label
End Class

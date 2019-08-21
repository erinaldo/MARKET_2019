<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Ventas))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_CLIENTE = New System.Windows.Forms.TextBox()
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Combo_TIPO = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.OPT_FECHA_PROCESO = New System.Windows.Forms.RadioButton()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.OPT_FECHA_DOCUMENTO = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CHK_DETALLE = New System.Windows.Forms.CheckBox()
        Me.TXT_TURNO = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Combo_FPAGO = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.OPT_LISTAR_LIQUIDACION = New System.Windows.Forms.RadioButton()
        Me.OPT_LISTAR_CAJA = New System.Windows.Forms.RadioButton()
        Me.OPT_LISTAR_DOC = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LIST_TIPO_DOC = New System.Windows.Forms.ListBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TXT_USER = New System.Windows.Forms.TextBox()
        Me.Combo_PTOVTA = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupPROGRESS = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupPROGRESS.SuspendLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_CLIENTE)
        Me.GroupBox4.Controls.Add(Me.picturebox1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(441, 62)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'TXT_CLIENTE
        '
        Me.TXT_CLIENTE.Location = New System.Drawing.Point(6, 28)
        Me.TXT_CLIENTE.Name = "TXT_CLIENTE"
        Me.TXT_CLIENTE.ReadOnly = True
        Me.TXT_CLIENTE.Size = New System.Drawing.Size(361, 20)
        Me.TXT_CLIENTE.TabIndex = 4
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(138, 26)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(123, 20)
        Me.TXT_NRO_DOC.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nro de Documento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Turno :"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(299, 297)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(111, 297)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Consultar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Combo_TIPO
        '
        Me.Combo_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TIPO.FormattingEnabled = True
        Me.Combo_TIPO.Items.AddRange(New Object() {"Todos", "Normal", "Anulado"})
        Me.Combo_TIPO.Location = New System.Drawing.Point(61, 19)
        Me.Combo_TIPO.Name = "Combo_TIPO"
        Me.Combo_TIPO.Size = New System.Drawing.Size(148, 21)
        Me.Combo_TIPO.TabIndex = 75
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OPT_FECHA_PROCESO)
        Me.GroupBox5.Controls.Add(Me.DT_FIN)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.DT_INI)
        Me.GroupBox5.Controls.Add(Me.OPT_FECHA_DOCUMENTO)
        Me.GroupBox5.Location = New System.Drawing.Point(45, 62)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 88)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'OPT_FECHA_PROCESO
        '
        Me.OPT_FECHA_PROCESO.AutoSize = True
        Me.OPT_FECHA_PROCESO.Checked = True
        Me.OPT_FECHA_PROCESO.Location = New System.Drawing.Point(158, 19)
        Me.OPT_FECHA_PROCESO.Name = "OPT_FECHA_PROCESO"
        Me.OPT_FECHA_PROCESO.Size = New System.Drawing.Size(113, 17)
        Me.OPT_FECHA_PROCESO.TabIndex = 5
        Me.OPT_FECHA_PROCESO.TabStop = True
        Me.OPT_FECHA_PROCESO.Text = "Fecha de Proceso"
        Me.OPT_FECHA_PROCESO.UseVisualStyleBackColor = True
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(146, 53)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(119, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(15, 53)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
        '
        'OPT_FECHA_DOCUMENTO
        '
        Me.OPT_FECHA_DOCUMENTO.AutoSize = True
        Me.OPT_FECHA_DOCUMENTO.Checked = True
        Me.OPT_FECHA_DOCUMENTO.Location = New System.Drawing.Point(9, 19)
        Me.OPT_FECHA_DOCUMENTO.Name = "OPT_FECHA_DOCUMENTO"
        Me.OPT_FECHA_DOCUMENTO.Size = New System.Drawing.Size(132, 17)
        Me.OPT_FECHA_DOCUMENTO.TabIndex = 0
        Me.OPT_FECHA_DOCUMENTO.TabStop = True
        Me.OPT_FECHA_DOCUMENTO.Text = "Fecha de Documento"
        Me.OPT_FECHA_DOCUMENTO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.GroupPROGRESS)
        Me.GroupBox2.Controls.Add(Me.C1_DETALLE)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1050, 467)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.Controls.Add(Me.CHK_DETALLE)
        Me.Panel1.Controls.Add(Me.TXT_TURNO)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.Combo_PTOVTA)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.TXT_NRO_DOC)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(20, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 390)
        Me.Panel1.TabIndex = 24
        Me.Panel1.Visible = False
        '
        'CHK_DETALLE
        '
        Me.CHK_DETALLE.AutoSize = True
        Me.CHK_DETALLE.Location = New System.Drawing.Point(69, 247)
        Me.CHK_DETALLE.Name = "CHK_DETALLE"
        Me.CHK_DETALLE.Size = New System.Drawing.Size(127, 17)
        Me.CHK_DETALLE.TabIndex = 85
        Me.CHK_DETALLE.Text = "Consulta Detallada"
        Me.CHK_DETALLE.UseVisualStyleBackColor = True
        '
        'TXT_TURNO
        '
        Me.TXT_TURNO.Location = New System.Drawing.Point(363, 26)
        Me.TXT_TURNO.Name = "TXT_TURNO"
        Me.TXT_TURNO.Size = New System.Drawing.Size(56, 20)
        Me.TXT_TURNO.TabIndex = 84
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Combo_FPAGO)
        Me.GroupBox9.Location = New System.Drawing.Point(497, 316)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(229, 50)
        Me.GroupBox9.TabIndex = 83
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Forma de Pago"
        '
        'Combo_FPAGO
        '
        Me.Combo_FPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_FPAGO.FormattingEnabled = True
        Me.Combo_FPAGO.Items.AddRange(New Object() {"Todos", "Efectivo", "Tarjeta"})
        Me.Combo_FPAGO.Location = New System.Drawing.Point(8, 19)
        Me.Combo_FPAGO.Name = "Combo_FPAGO"
        Me.Combo_FPAGO.Size = New System.Drawing.Size(215, 21)
        Me.Combo_FPAGO.TabIndex = 75
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.OPT_LISTAR_LIQUIDACION)
        Me.GroupBox8.Controls.Add(Me.OPT_LISTAR_CAJA)
        Me.GroupBox8.Controls.Add(Me.OPT_LISTAR_DOC)
        Me.GroupBox8.Controls.Add(Me.GroupBox3)
        Me.GroupBox8.Location = New System.Drawing.Point(475, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(359, 137)
        Me.GroupBox8.TabIndex = 82
        Me.GroupBox8.TabStop = False
        '
        'OPT_LISTAR_LIQUIDACION
        '
        Me.OPT_LISTAR_LIQUIDACION.AutoSize = True
        Me.OPT_LISTAR_LIQUIDACION.Location = New System.Drawing.Point(263, 91)
        Me.OPT_LISTAR_LIQUIDACION.Name = "OPT_LISTAR_LIQUIDACION"
        Me.OPT_LISTAR_LIQUIDACION.Size = New System.Drawing.Size(87, 17)
        Me.OPT_LISTAR_LIQUIDACION.TabIndex = 41
        Me.OPT_LISTAR_LIQUIDACION.Text = "Liquidacion"
        Me.OPT_LISTAR_LIQUIDACION.UseVisualStyleBackColor = True
        Me.OPT_LISTAR_LIQUIDACION.Visible = False
        '
        'OPT_LISTAR_CAJA
        '
        Me.OPT_LISTAR_CAJA.AutoSize = True
        Me.OPT_LISTAR_CAJA.Location = New System.Drawing.Point(263, 59)
        Me.OPT_LISTAR_CAJA.Name = "OPT_LISTAR_CAJA"
        Me.OPT_LISTAR_CAJA.Size = New System.Drawing.Size(50, 17)
        Me.OPT_LISTAR_CAJA.TabIndex = 40
        Me.OPT_LISTAR_CAJA.Text = "Caja"
        Me.OPT_LISTAR_CAJA.UseVisualStyleBackColor = True
        '
        'OPT_LISTAR_DOC
        '
        Me.OPT_LISTAR_DOC.AutoSize = True
        Me.OPT_LISTAR_DOC.Checked = True
        Me.OPT_LISTAR_DOC.Location = New System.Drawing.Point(263, 28)
        Me.OPT_LISTAR_DOC.Name = "OPT_LISTAR_DOC"
        Me.OPT_LISTAR_DOC.Size = New System.Drawing.Size(89, 17)
        Me.OPT_LISTAR_DOC.TabIndex = 39
        Me.OPT_LISTAR_DOC.TabStop = True
        Me.OPT_LISTAR_DOC.Text = "Documentos"
        Me.OPT_LISTAR_DOC.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LIST_TIPO_DOC)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(221, 112)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Documento"
        '
        'LIST_TIPO_DOC
        '
        Me.LIST_TIPO_DOC.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIST_TIPO_DOC.FormattingEnabled = True
        Me.LIST_TIPO_DOC.Location = New System.Drawing.Point(12, 16)
        Me.LIST_TIPO_DOC.Name = "LIST_TIPO_DOC"
        Me.LIST_TIPO_DOC.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.LIST_TIPO_DOC.Size = New System.Drawing.Size(209, 82)
        Me.LIST_TIPO_DOC.TabIndex = 66
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button2)
        Me.GroupBox7.Controls.Add(Me.TXT_USER)
        Me.GroupBox7.Location = New System.Drawing.Point(497, 260)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(306, 47)
        Me.GroupBox7.TabIndex = 81
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Usuario"
        '
        'TXT_USER
        '
        Me.TXT_USER.Location = New System.Drawing.Point(8, 15)
        Me.TXT_USER.Name = "TXT_USER"
        Me.TXT_USER.ReadOnly = True
        Me.TXT_USER.Size = New System.Drawing.Size(240, 20)
        Me.TXT_USER.TabIndex = 5
        '
        'Combo_PTOVTA
        '
        Me.Combo_PTOVTA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_PTOVTA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_PTOVTA.FormattingEnabled = True
        Me.Combo_PTOVTA.Items.AddRange(New Object() {"Programado", "Aperturado", "Cerrado", "Anulado"})
        Me.Combo_PTOVTA.Location = New System.Drawing.Point(601, 222)
        Me.Combo_PTOVTA.Name = "Combo_PTOVTA"
        Me.Combo_PTOVTA.Size = New System.Drawing.Size(194, 23)
        Me.Combo_PTOVTA.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(500, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Punto de Venta :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Combo_TIPO)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Location = New System.Drawing.Point(497, 146)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(229, 50)
        Me.GroupBox6.TabIndex = 76
        Me.GroupBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Tipo :"
        '
        'GroupPROGRESS
        '
        Me.GroupPROGRESS.BackColor = System.Drawing.Color.LightYellow
        Me.GroupPROGRESS.Controls.Add(Me.ProgressBar1)
        Me.GroupPROGRESS.Location = New System.Drawing.Point(49, 407)
        Me.GroupPROGRESS.Name = "GroupPROGRESS"
        Me.GroupPROGRESS.Size = New System.Drawing.Size(905, 38)
        Me.GroupPROGRESS.TabIndex = 27
        Me.GroupPROGRESS.TabStop = False
        Me.GroupPROGRESS.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(871, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'C1_DETALLE
        '
        Me.C1_DETALLE.BackColor = System.Drawing.Color.White
        Me.C1_DETALLE.ColumnInfo = resources.GetString("C1_DETALLE.ColumnInfo")
        Me.C1_DETALLE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_DETALLE.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1_DETALLE.ForeColor = System.Drawing.Color.Black
        Me.C1_DETALLE.Location = New System.Drawing.Point(3, 16)
        Me.C1_DETALLE.Name = "C1_DETALLE"
        Me.C1_DETALLE.Rows.DefaultSize = 18
        Me.C1_DETALLE.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1_DETALLE.Size = New System.Drawing.Size(1044, 448)
        Me.C1_DETALLE.StyleInfo = resources.GetString("C1_DETALLE.StyleInfo")
        Me.C1_DETALLE.TabIndex = 26
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 59)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button2.Location = New System.Drawing.Point(254, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 34)
        Me.Button2.TabIndex = 38
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(391, 19)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 37
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Market.My.Resources.Resources.excel
        Me.Button4.Location = New System.Drawing.Point(493, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 43)
        Me.Button4.TabIndex = 87
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = Global.Market.My.Resources.Resources.TEXT_EDITOR2___copia
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(276, 10)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 49)
        Me.Button9.TabIndex = 86
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button9, "Generar Txt")
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Market.My.Resources.Resources.view
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(181, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(76, 49)
        Me.Button5.TabIndex = 84
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Vista Previa")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Market.My.Resources.Resources.Imprimir
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(89, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 49)
        Me.Button3.TabIndex = 34
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button3, "Reimprimir")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Market.My.Resources.Resources.FOLDER
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(7, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Filtros")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Consultar_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1059, 537)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consultar_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Ventas"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupPROGRESS.ResumeLayout(False)
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_CLIENTE As TextBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents TXT_NRO_DOC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Combo_TIPO As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents OPT_FECHA_DOCUMENTO As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Combo_FPAGO As ComboBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents OPT_LISTAR_LIQUIDACION As RadioButton
    Friend WithEvents OPT_LISTAR_CAJA As RadioButton
    Friend WithEvents OPT_LISTAR_DOC As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LIST_TIPO_DOC As ListBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TXT_USER As TextBox
    Friend WithEvents Combo_PTOVTA As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupPROGRESS As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TXT_TURNO As TextBox
    Friend WithEvents OPT_FECHA_PROCESO As RadioButton
    Friend WithEvents CHK_DETALLE As CheckBox
    Friend WithEvents Button4 As Button
End Class

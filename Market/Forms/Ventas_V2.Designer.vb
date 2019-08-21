<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_V2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas_V2))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirGavetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinDeDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TXT_NRODOC = New System.Windows.Forms.TextBox()
        Me.Combo_DOC = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_OPERADOR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DT_PROC = New System.Windows.Forms.DateTimePicker()
        Me.DT_DOC = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_TURNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox_CLIENTE = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_DIRECCION = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_CLIENTE = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TXT_RUC_CLIENTE = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.TXT_COD_CLIENTE = New System.Windows.Forms.TextBox()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_CODART = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.TXT_IGV = New System.Windows.Forms.TextBox()
        Me.TXT_DSCTO = New System.Windows.Forms.TextBox()
        Me.TXT_SUBTOTAL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBL_IGV = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBL_SUBTOTAL = New System.Windows.Forms.Label()
        Me.TXT_CANT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_EFECTIVO = New C1.Win.C1Input.C1Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button_mULTIPAGO = New C1.Win.C1Input.C1Button()
        Me.Button_TARJETA = New C1.Win.C1Input.C1Button()
        Me.Button_CREDITO = New C1.Win.C1Input.C1Button()
        Me.Button2 = New C1.Win.C1Input.C1Button()
        Me.C1_AGREGAR = New C1.Win.C1Input.C1Button()
        Me.C1_RESTAR = New C1.Win.C1Input.C1Button()
        Me.C1_QUITAR = New C1.Win.C1Input.C1Button()
        Me.Button_CANCELAR = New C1.Win.C1Input.C1Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button_CAJA = New C1.Win.C1Input.C1Button()
        Me.C1Button1 = New C1.Win.C1Input.C1Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument_FACT_BOL = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox_CLIENTE.SuspendLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Button_EFECTIVO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_mULTIPAGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_TARJETA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_CREDITO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_AGREGAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_RESTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_QUITAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_CANCELAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_CAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(818, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambioDeTurnoToolStripMenuItem, Me.AbrirGavetaToolStripMenuItem, Me.CierreXToolStripMenuItem, Me.CierreZToolStripMenuItem, Me.FinDeDiaToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'CambioDeTurnoToolStripMenuItem
        '
        Me.CambioDeTurnoToolStripMenuItem.Name = "CambioDeTurnoToolStripMenuItem"
        Me.CambioDeTurnoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CambioDeTurnoToolStripMenuItem.Text = "Cambio de Turno"
        '
        'AbrirGavetaToolStripMenuItem
        '
        Me.AbrirGavetaToolStripMenuItem.Name = "AbrirGavetaToolStripMenuItem"
        Me.AbrirGavetaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AbrirGavetaToolStripMenuItem.Text = "Abrir Gaveta"
        Me.AbrirGavetaToolStripMenuItem.Visible = False
        '
        'CierreXToolStripMenuItem
        '
        Me.CierreXToolStripMenuItem.Name = "CierreXToolStripMenuItem"
        Me.CierreXToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CierreXToolStripMenuItem.Text = "Cierre X"
        '
        'CierreZToolStripMenuItem
        '
        Me.CierreZToolStripMenuItem.Name = "CierreZToolStripMenuItem"
        Me.CierreZToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CierreZToolStripMenuItem.Text = "Cierre Z"
        '
        'FinDeDiaToolStripMenuItem
        '
        Me.FinDeDiaToolStripMenuItem.Name = "FinDeDiaToolStripMenuItem"
        Me.FinDeDiaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FinDeDiaToolStripMenuItem.Text = "Fin de Dia"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TXT_NRODOC)
        Me.GroupBox12.Controls.Add(Me.Combo_DOC)
        Me.GroupBox12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(283, 27)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(231, 92)
        Me.GroupBox12.TabIndex = 23
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Documento"
        '
        'TXT_NRODOC
        '
        Me.TXT_NRODOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NRODOC.Location = New System.Drawing.Point(33, 59)
        Me.TXT_NRODOC.Name = "TXT_NRODOC"
        Me.TXT_NRODOC.ReadOnly = True
        Me.TXT_NRODOC.Size = New System.Drawing.Size(162, 26)
        Me.TXT_NRODOC.TabIndex = 27
        '
        'Combo_DOC
        '
        Me.Combo_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_DOC.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_DOC.FormattingEnabled = True
        Me.Combo_DOC.Location = New System.Drawing.Point(6, 23)
        Me.Combo_DOC.Name = "Combo_DOC"
        Me.Combo_DOC.Size = New System.Drawing.Size(210, 30)
        Me.Combo_DOC.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_TC)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXT_OPERADOR)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 80)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'TXT_TC
        '
        Me.TXT_TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TC.Location = New System.Drawing.Point(103, 44)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.ReadOnly = True
        Me.TXT_TC.Size = New System.Drawing.Size(115, 21)
        Me.TXT_TC.TabIndex = 6
        Me.TXT_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "T.C. :"
        '
        'TXT_OPERADOR
        '
        Me.TXT_OPERADOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OPERADOR.Location = New System.Drawing.Point(103, 17)
        Me.TXT_OPERADOR.Name = "TXT_OPERADOR"
        Me.TXT_OPERADOR.ReadOnly = True
        Me.TXT_OPERADOR.Size = New System.Drawing.Size(115, 21)
        Me.TXT_OPERADOR.TabIndex = 4
        Me.TXT_OPERADOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Operador :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DT_PROC)
        Me.GroupBox2.Controls.Add(Me.DT_DOC)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXT_TURNO)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(554, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 102)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'DT_PROC
        '
        Me.DT_PROC.Enabled = False
        Me.DT_PROC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_PROC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_PROC.Location = New System.Drawing.Point(105, 71)
        Me.DT_PROC.Name = "DT_PROC"
        Me.DT_PROC.Size = New System.Drawing.Size(113, 21)
        Me.DT_PROC.TabIndex = 8
        '
        'DT_DOC
        '
        Me.DT_DOC.Enabled = False
        Me.DT_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_DOC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_DOC.Location = New System.Drawing.Point(103, 44)
        Me.DT_DOC.Name = "DT_DOC"
        Me.DT_DOC.Size = New System.Drawing.Size(113, 21)
        Me.DT_DOC.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Proc.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fecha Doc.:"
        '
        'TXT_TURNO
        '
        Me.TXT_TURNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TURNO.Location = New System.Drawing.Point(103, 17)
        Me.TXT_TURNO.Name = "TXT_TURNO"
        Me.TXT_TURNO.ReadOnly = True
        Me.TXT_TURNO.Size = New System.Drawing.Size(115, 21)
        Me.TXT_TURNO.TabIndex = 4
        Me.TXT_TURNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Turno :"
        '
        'GroupBox_CLIENTE
        '
        Me.GroupBox_CLIENTE.Controls.Add(Me.Label15)
        Me.GroupBox_CLIENTE.Controls.Add(Me.TXT_DIRECCION)
        Me.GroupBox_CLIENTE.Controls.Add(Me.Label13)
        Me.GroupBox_CLIENTE.Controls.Add(Me.TXT_CLIENTE)
        Me.GroupBox_CLIENTE.Controls.Add(Me.LinkLabel1)
        Me.GroupBox_CLIENTE.Controls.Add(Me.TXT_RUC_CLIENTE)
        Me.GroupBox_CLIENTE.Controls.Add(Me.LinkLabel2)
        Me.GroupBox_CLIENTE.Controls.Add(Me.TXT_COD_CLIENTE)
        Me.GroupBox_CLIENTE.Location = New System.Drawing.Point(92, 135)
        Me.GroupBox_CLIENTE.Name = "GroupBox_CLIENTE"
        Me.GroupBox_CLIENTE.Size = New System.Drawing.Size(594, 144)
        Me.GroupBox_CLIENTE.TabIndex = 34
        Me.GroupBox_CLIENTE.TabStop = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 30)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Direccion :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_DIRECCION
        '
        Me.TXT_DIRECCION.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DIRECCION.Location = New System.Drawing.Point(111, 82)
        Me.TXT_DIRECCION.Multiline = True
        Me.TXT_DIRECCION.Name = "TXT_DIRECCION"
        Me.TXT_DIRECCION.ReadOnly = True
        Me.TXT_DIRECCION.Size = New System.Drawing.Size(465, 49)
        Me.TXT_DIRECCION.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 30)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Cliente :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_CLIENTE
        '
        Me.TXT_CLIENTE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CLIENTE.Location = New System.Drawing.Point(111, 53)
        Me.TXT_CLIENTE.Name = "TXT_CLIENTE"
        Me.TXT_CLIENTE.ReadOnly = True
        Me.TXT_CLIENTE.Size = New System.Drawing.Size(465, 26)
        Me.TXT_CLIENTE.TabIndex = 48
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 16)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 30)
        Me.LinkLabel1.TabIndex = 47
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Codigo :"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_RUC_CLIENTE
        '
        Me.TXT_RUC_CLIENTE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RUC_CLIENTE.Location = New System.Drawing.Point(344, 16)
        Me.TXT_RUC_CLIENTE.MaxLength = 11
        Me.TXT_RUC_CLIENTE.Name = "TXT_RUC_CLIENTE"
        Me.TXT_RUC_CLIENTE.Size = New System.Drawing.Size(232, 26)
        Me.TXT_RUC_CLIENTE.TabIndex = 44
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(258, 13)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(80, 30)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Ruc :"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_COD_CLIENTE
        '
        Me.TXT_COD_CLIENTE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_COD_CLIENTE.Location = New System.Drawing.Point(113, 17)
        Me.TXT_COD_CLIENTE.Name = "TXT_COD_CLIENTE"
        Me.TXT_COD_CLIENTE.Size = New System.Drawing.Size(98, 26)
        Me.TXT_COD_CLIENTE.TabIndex = 45
        '
        'C1_DETALLE
        '
        Me.C1_DETALLE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1_DETALLE.BackColor = System.Drawing.Color.LightGray
        Me.C1_DETALLE.ColumnInfo = resources.GetString("C1_DETALLE.ColumnInfo")
        Me.C1_DETALLE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1_DETALLE.Location = New System.Drawing.Point(12, 291)
        Me.C1_DETALLE.Name = "C1_DETALLE"
        Me.C1_DETALLE.Rows.DefaultSize = 21
        Me.C1_DETALLE.Size = New System.Drawing.Size(722, 248)
        Me.C1_DETALLE.StyleInfo = resources.GetString("C1_DETALLE.StyleInfo")
        Me.C1_DETALLE.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_CODART)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 544)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 65)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Codigo de Barras o Codigo de Producto"
        '
        'TXT_CODART
        '
        Me.TXT_CODART.Location = New System.Drawing.Point(6, 25)
        Me.TXT_CODART.Name = "TXT_CODART"
        Me.TXT_CODART.Size = New System.Drawing.Size(324, 26)
        Me.TXT_CODART.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(358, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 54)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Agregar Producto"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "articulos.png")
        Me.ImageList1.Images.SetKeyName(1, "flecha_abajo.jpg")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox4.Controls.Add(Me.TXT_IGV)
        Me.GroupBox4.Controls.Add(Me.TXT_DSCTO)
        Me.GroupBox4.Controls.Add(Me.TXT_SUBTOTAL)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.LBL_IGV)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.LBL_SUBTOTAL)
        Me.GroupBox4.Controls.Add(Me.TXT_CANT_TOTAL)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(521, 535)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 175)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTAL.Location = New System.Drawing.Point(136, 141)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(132, 29)
        Me.TXT_TOTAL.TabIndex = 59
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_IGV
        '
        Me.TXT_IGV.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_IGV.Location = New System.Drawing.Point(136, 111)
        Me.TXT_IGV.Name = "TXT_IGV"
        Me.TXT_IGV.ReadOnly = True
        Me.TXT_IGV.Size = New System.Drawing.Size(132, 29)
        Me.TXT_IGV.TabIndex = 58
        Me.TXT_IGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_DSCTO
        '
        Me.TXT_DSCTO.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DSCTO.Location = New System.Drawing.Point(136, 50)
        Me.TXT_DSCTO.Name = "TXT_DSCTO"
        Me.TXT_DSCTO.ReadOnly = True
        Me.TXT_DSCTO.Size = New System.Drawing.Size(132, 29)
        Me.TXT_DSCTO.TabIndex = 57
        Me.TXT_DSCTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_SUBTOTAL
        '
        Me.TXT_SUBTOTAL.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SUBTOTAL.Location = New System.Drawing.Point(136, 82)
        Me.TXT_SUBTOTAL.Name = "TXT_SUBTOTAL"
        Me.TXT_SUBTOTAL.ReadOnly = True
        Me.TXT_SUBTOTAL.Size = New System.Drawing.Size(132, 29)
        Me.TXT_SUBTOTAL.TabIndex = 56
        Me.TXT_SUBTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 30)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Total :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_IGV
        '
        Me.LBL_IGV.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBL_IGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_IGV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IGV.Location = New System.Drawing.Point(6, 108)
        Me.LBL_IGV.Name = "LBL_IGV"
        Me.LBL_IGV.Size = New System.Drawing.Size(97, 30)
        Me.LBL_IGV.TabIndex = 54
        Me.LBL_IGV.Text = "Igv :"
        Me.LBL_IGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 30)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Dscto :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_SUBTOTAL
        '
        Me.LBL_SUBTOTAL.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBL_SUBTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_SUBTOTAL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SUBTOTAL.Location = New System.Drawing.Point(6, 78)
        Me.LBL_SUBTOTAL.Name = "LBL_SUBTOTAL"
        Me.LBL_SUBTOTAL.Size = New System.Drawing.Size(97, 30)
        Me.LBL_SUBTOTAL.TabIndex = 52
        Me.LBL_SUBTOTAL.Text = "SubTotal :"
        Me.LBL_SUBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_CANT_TOTAL
        '
        Me.TXT_CANT_TOTAL.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CANT_TOTAL.Location = New System.Drawing.Point(136, 18)
        Me.TXT_CANT_TOTAL.Name = "TXT_CANT_TOTAL"
        Me.TXT_CANT_TOTAL.ReadOnly = True
        Me.TXT_CANT_TOTAL.Size = New System.Drawing.Size(132, 29)
        Me.TXT_CANT_TOTAL.TabIndex = 51
        Me.TXT_CANT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_EFECTIVO
        '
        Me.Button_EFECTIVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button_EFECTIVO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EFECTIVO.ImageIndex = 0
        Me.Button_EFECTIVO.ImageList = Me.ImageList2
        Me.Button_EFECTIVO.Location = New System.Drawing.Point(12, 615)
        Me.Button_EFECTIVO.Name = "Button_EFECTIVO"
        Me.Button_EFECTIVO.Size = New System.Drawing.Size(91, 85)
        Me.Button_EFECTIVO.TabIndex = 39
        Me.Button_EFECTIVO.Text = "Efectivo"
        Me.Button_EFECTIVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_EFECTIVO.UseVisualStyleBackColor = True
        Me.Button_EFECTIVO.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_EFECTIVO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "EFECTIVO - copia.jpg")
        Me.ImageList2.Images.SetKeyName(1, "multipago.png")
        Me.ImageList2.Images.SetKeyName(2, "tarjeta.jpg")
        Me.ImageList2.Images.SetKeyName(3, "credito.png")
        Me.ImageList2.Images.SetKeyName(4, "vales.jpg")
        Me.ImageList2.Images.SetKeyName(5, "caja.jpeg")
        Me.ImageList2.Images.SetKeyName(6, "cancelar.jpg")
        Me.ImageList2.Images.SetKeyName(7, "salir.jpg")
        Me.ImageList2.Images.SetKeyName(8, "registros.jpg")
        Me.ImageList2.Images.SetKeyName(9, "listado.jpg")
        Me.ImageList2.Images.SetKeyName(10, "teclado_windows.jpg")
        Me.ImageList2.Images.SetKeyName(11, "TECLADO_V2.jpg")
        Me.ImageList2.Images.SetKeyName(12, "Eliminar_V3.jpg")
        Me.ImageList2.Images.SetKeyName(13, "articulos.png")
        Me.ImageList2.Images.SetKeyName(14, "MAS.jpg")
        Me.ImageList2.Images.SetKeyName(15, "MENOS.jpg")
        Me.ImageList2.Images.SetKeyName(16, "MODIF.jpg")
        Me.ImageList2.Images.SetKeyName(17, "flecha_abajo.jpg")
        '
        'Button_mULTIPAGO
        '
        Me.Button_mULTIPAGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_mULTIPAGO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_mULTIPAGO.ImageIndex = 1
        Me.Button_mULTIPAGO.ImageList = Me.ImageList2
        Me.Button_mULTIPAGO.Location = New System.Drawing.Point(109, 615)
        Me.Button_mULTIPAGO.Name = "Button_mULTIPAGO"
        Me.Button_mULTIPAGO.Size = New System.Drawing.Size(91, 85)
        Me.Button_mULTIPAGO.TabIndex = 40
        Me.Button_mULTIPAGO.Text = "MultiPago"
        Me.Button_mULTIPAGO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_mULTIPAGO.UseVisualStyleBackColor = True
        Me.Button_mULTIPAGO.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_mULTIPAGO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Button_TARJETA
        '
        Me.Button_TARJETA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_TARJETA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_TARJETA.ImageIndex = 2
        Me.Button_TARJETA.ImageList = Me.ImageList2
        Me.Button_TARJETA.Location = New System.Drawing.Point(207, 615)
        Me.Button_TARJETA.Name = "Button_TARJETA"
        Me.Button_TARJETA.Size = New System.Drawing.Size(95, 85)
        Me.Button_TARJETA.TabIndex = 41
        Me.Button_TARJETA.Text = "Tarjeta"
        Me.Button_TARJETA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_TARJETA.UseVisualStyleBackColor = True
        Me.Button_TARJETA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_TARJETA.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Button_CREDITO
        '
        Me.Button_CREDITO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_CREDITO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CREDITO.ImageIndex = 3
        Me.Button_CREDITO.ImageList = Me.ImageList2
        Me.Button_CREDITO.Location = New System.Drawing.Point(308, 615)
        Me.Button_CREDITO.Name = "Button_CREDITO"
        Me.Button_CREDITO.Size = New System.Drawing.Size(95, 85)
        Me.Button_CREDITO.TabIndex = 42
        Me.Button_CREDITO.Text = "Creditos"
        Me.Button_CREDITO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_CREDITO.UseVisualStyleBackColor = True
        Me.Button_CREDITO.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_CREDITO.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.ImageIndex = 9
        Me.Button2.ImageList = Me.ImageList2
        Me.Button2.Location = New System.Drawing.Point(709, 135)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 63)
        Me.Button2.TabIndex = 43
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button2, "Listar")
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1_AGREGAR
        '
        Me.C1_AGREGAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1_AGREGAR.ImageKey = "MAS.jpg"
        Me.C1_AGREGAR.ImageList = Me.ImageList2
        Me.C1_AGREGAR.Location = New System.Drawing.Point(743, 291)
        Me.C1_AGREGAR.Name = "C1_AGREGAR"
        Me.C1_AGREGAR.Size = New System.Drawing.Size(61, 63)
        Me.C1_AGREGAR.TabIndex = 44
        Me.C1_AGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.C1_AGREGAR, "Sumar")
        Me.C1_AGREGAR.UseVisualStyleBackColor = True
        Me.C1_AGREGAR.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1_AGREGAR.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1_RESTAR
        '
        Me.C1_RESTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1_RESTAR.ImageKey = "MENOS.jpg"
        Me.C1_RESTAR.ImageList = Me.ImageList2
        Me.C1_RESTAR.Location = New System.Drawing.Point(743, 360)
        Me.C1_RESTAR.Name = "C1_RESTAR"
        Me.C1_RESTAR.Size = New System.Drawing.Size(61, 63)
        Me.C1_RESTAR.TabIndex = 45
        Me.C1_RESTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.C1_RESTAR, "Restar")
        Me.C1_RESTAR.UseVisualStyleBackColor = True
        Me.C1_RESTAR.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1_RESTAR.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1_QUITAR
        '
        Me.C1_QUITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1_QUITAR.ImageIndex = 12
        Me.C1_QUITAR.ImageList = Me.ImageList2
        Me.C1_QUITAR.Location = New System.Drawing.Point(743, 429)
        Me.C1_QUITAR.Name = "C1_QUITAR"
        Me.C1_QUITAR.Size = New System.Drawing.Size(61, 63)
        Me.C1_QUITAR.TabIndex = 46
        Me.C1_QUITAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.C1_QUITAR, "Quitar")
        Me.C1_QUITAR.UseVisualStyleBackColor = True
        Me.C1_QUITAR.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1_QUITAR.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Button_CANCELAR
        '
        Me.Button_CANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_CANCELAR.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CANCELAR.ImageIndex = 6
        Me.Button_CANCELAR.ImageList = Me.ImageList2
        Me.Button_CANCELAR.Location = New System.Drawing.Point(409, 615)
        Me.Button_CANCELAR.Name = "Button_CANCELAR"
        Me.Button_CANCELAR.Size = New System.Drawing.Size(95, 85)
        Me.Button_CANCELAR.TabIndex = 47
        Me.Button_CANCELAR.Text = "Cancelar"
        Me.Button_CANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_CANCELAR.UseVisualStyleBackColor = True
        Me.Button_CANCELAR.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_CANCELAR.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "teclado_windows.jpg"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(18, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 60)
        Me.Button3.TabIndex = 48
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button3, "Teclado")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button_CAJA
        '
        Me.Button_CAJA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_CAJA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CAJA.ImageIndex = 5
        Me.Button_CAJA.ImageList = Me.ImageList2
        Me.Button_CAJA.Location = New System.Drawing.Point(11, 191)
        Me.Button_CAJA.Name = "Button_CAJA"
        Me.Button_CAJA.Size = New System.Drawing.Size(75, 85)
        Me.Button_CAJA.TabIndex = 49
        Me.Button_CAJA.Text = "Caja"
        Me.Button_CAJA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button_CAJA, "Caja")
        Me.Button_CAJA.UseVisualStyleBackColor = True
        Me.Button_CAJA.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.Button_CAJA.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'C1Button1
        '
        Me.C1Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.C1Button1.ImageIndex = 17
        Me.C1Button1.ImageList = Me.ImageList2
        Me.C1Button1.Location = New System.Drawing.Point(711, 204)
        Me.C1Button1.Name = "C1Button1"
        Me.C1Button1.Size = New System.Drawing.Size(61, 63)
        Me.C1Button1.TabIndex = 50
        Me.C1Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.C1Button1, "Descuento")
        Me.C1Button1.UseVisualStyleBackColor = True
        Me.C1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.C1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'PrintDocument_FACT_BOL
        '
        '
        'Ventas_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(818, 722)
        Me.Controls.Add(Me.C1Button1)
        Me.Controls.Add(Me.Button_CAJA)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button_CANCELAR)
        Me.Controls.Add(Me.C1_QUITAR)
        Me.Controls.Add(Me.C1_RESTAR)
        Me.Controls.Add(Me.C1_AGREGAR)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button_CREDITO)
        Me.Controls.Add(Me.Button_TARJETA)
        Me.Controls.Add(Me.Button_mULTIPAGO)
        Me.Controls.Add(Me.Button_EFECTIVO)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1_DETALLE)
        Me.Controls.Add(Me.GroupBox_CLIENTE)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Ventas_V2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox_CLIENTE.ResumeLayout(False)
        Me.GroupBox_CLIENTE.PerformLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Button_EFECTIVO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button_mULTIPAGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button_TARJETA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button_CREDITO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_AGREGAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_RESTAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_QUITAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button_CANCELAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button_CAJA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Button1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OperacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambioDeTurnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirGavetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CierreZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinDeDiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Combo_DOC As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_TC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_OPERADOR As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DT_PROC As DateTimePicker
    Friend WithEvents DT_DOC As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TURNO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NRODOC As TextBox
    Friend WithEvents GroupBox_CLIENTE As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_DIRECCION As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_CLIENTE As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TXT_RUC_CLIENTE As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents TXT_COD_CLIENTE As TextBox
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_CODART As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_CANT_TOTAL As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents TXT_IGV As TextBox
    Friend WithEvents TXT_DSCTO As TextBox
    Friend WithEvents TXT_SUBTOTAL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBL_IGV As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBL_SUBTOTAL As Label
    Friend WithEvents Button_EFECTIVO As C1.Win.C1Input.C1Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents Button_mULTIPAGO As C1.Win.C1Input.C1Button
    Friend WithEvents Button_TARJETA As C1.Win.C1Input.C1Button
    Friend WithEvents Button_CREDITO As C1.Win.C1Input.C1Button
    Friend WithEvents Button2 As C1.Win.C1Input.C1Button
    Friend WithEvents C1_AGREGAR As C1.Win.C1Input.C1Button
    Friend WithEvents C1_RESTAR As C1.Win.C1Input.C1Button
    Friend WithEvents C1_QUITAR As C1.Win.C1Input.C1Button
    Friend WithEvents Button_CANCELAR As C1.Win.C1Input.C1Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button_CAJA As C1.Win.C1Input.C1Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents C1Button1 As C1.Win.C1Input.C1Button
    Friend WithEvents PrintDocument_FACT_BOL As Printing.PrintDocument
End Class

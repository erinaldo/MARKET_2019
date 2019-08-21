<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.COMBO_DOC = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DT_PROC = New System.Windows.Forms.DateTimePicker
        Me.DT_DOC = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_TURNO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TXT_TC = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_OPERADOR = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambioDeTurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirGavetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CierreXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CierreZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FinDeDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TXT_DIRECCION = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT_RAZON = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TXT_RUC = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_CODCLIE = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXT_NRODOC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TXT_PU = New System.Windows.Forms.TextBox
        Me.TXT_CANT = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TXT_DESCART = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.TXT_CODART = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button_ANULAR = New System.Windows.Forms.Button
        Me.Button_CANCELAR = New System.Windows.Forms.Button
        Me.Button_CAJA = New System.Windows.Forms.Button
        Me.Button_CREDITO = New System.Windows.Forms.Button
        Me.Button_TARJETA = New System.Windows.Forms.Button
        Me.Button_EFECTIVO = New System.Windows.Forms.Button
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TXT_VVENTA = New System.Windows.Forms.TextBox
        Me.TXT_IGV = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox
        Me.TXT_TOTAL1 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TXT_IGV1 = New System.Windows.Forms.TextBox
        Me.Label151 = New System.Windows.Forms.Label
        Me.TXT_VVENTA1 = New System.Windows.Forms.TextBox
        Me.Label161 = New System.Windows.Forms.Label
        Me.picturebox1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.COMBO_DOC)
        Me.GroupBox1.Location = New System.Drawing.Point(242, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'COMBO_DOC
        '
        Me.COMBO_DOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_DOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBO_DOC.FormattingEnabled = True
        Me.COMBO_DOC.Location = New System.Drawing.Point(45, 19)
        Me.COMBO_DOC.Name = "COMBO_DOC"
        Me.COMBO_DOC.Size = New System.Drawing.Size(167, 32)
        Me.COMBO_DOC.TabIndex = 0
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
        Me.GroupBox2.Location = New System.Drawing.Point(511, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 102)
        Me.GroupBox2.TabIndex = 3
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha Proc.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
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
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Turno :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_TC)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXT_OPERADOR)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 102)
        Me.GroupBox3.TabIndex = 4
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
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
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
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Operador :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperacionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(747, 24)
        Me.MenuStrip1.TabIndex = 5
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_DIRECCION)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TXT_RAZON)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TXT_RUC)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TXT_CODCLIE)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 129)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(726, 83)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'TXT_DIRECCION
        '
        Me.TXT_DIRECCION.Location = New System.Drawing.Point(97, 55)
        Me.TXT_DIRECCION.Name = "TXT_DIRECCION"
        Me.TXT_DIRECCION.ReadOnly = True
        Me.TXT_DIRECCION.Size = New System.Drawing.Size(623, 22)
        Me.TXT_DIRECCION.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Direccion :"
        '
        'TXT_RAZON
        '
        Me.TXT_RAZON.Location = New System.Drawing.Point(395, 22)
        Me.TXT_RAZON.Name = "TXT_RAZON"
        Me.TXT_RAZON.ReadOnly = True
        Me.TXT_RAZON.Size = New System.Drawing.Size(325, 22)
        Me.TXT_RAZON.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(342, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Razon :"
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Location = New System.Drawing.Point(233, 22)
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(103, 22)
        Me.TXT_RUC.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button1.Location = New System.Drawing.Point(151, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 28)
        Me.Button1.TabIndex = 25
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Ruc :"
        '
        'TXT_CODCLIE
        '
        Me.TXT_CODCLIE.Location = New System.Drawing.Point(50, 22)
        Me.TXT_CODCLIE.Name = "TXT_CODCLIE"
        Me.TXT_CODCLIE.Size = New System.Drawing.Size(95, 22)
        Me.TXT_CODCLIE.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Cod. :"
        '
        'TXT_NRODOC
        '
        Me.TXT_NRODOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NRODOC.Location = New System.Drawing.Point(336, 98)
        Me.TXT_NRODOC.Name = "TXT_NRODOC"
        Me.TXT_NRODOC.ReadOnly = True
        Me.TXT_NRODOC.Size = New System.Drawing.Size(115, 21)
        Me.TXT_NRODOC.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(255, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nro. Doc. :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Button4)
        Me.GroupBox5.Controls.Add(Me.TXT_PU)
        Me.GroupBox5.Controls.Add(Me.TXT_CANT)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.TXT_DESCART)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.TXT_CODART)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 212)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(726, 67)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button5.Location = New System.Drawing.Point(608, 38)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 26)
        Me.Button5.TabIndex = 35
        Me.Button5.Text = "Dscto al Total"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button4.Location = New System.Drawing.Point(513, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(84, 26)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Dscto x Item"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TXT_PU
        '
        Me.TXT_PU.Location = New System.Drawing.Point(278, 42)
        Me.TXT_PU.Name = "TXT_PU"
        Me.TXT_PU.Size = New System.Drawing.Size(115, 20)
        Me.TXT_PU.TabIndex = 33
        '
        'TXT_CANT
        '
        Me.TXT_CANT.Location = New System.Drawing.Point(81, 42)
        Me.TXT_CANT.Name = "TXT_CANT"
        Me.TXT_CANT.Size = New System.Drawing.Size(102, 20)
        Me.TXT_CANT.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Precio :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 45)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Cantidad :"
        '
        'TXT_DESCART
        '
        Me.TXT_DESCART.Enabled = False
        Me.TXT_DESCART.Location = New System.Drawing.Point(224, 13)
        Me.TXT_DESCART.Name = "TXT_DESCART"
        Me.TXT_DESCART.ReadOnly = True
        Me.TXT_DESCART.Size = New System.Drawing.Size(496, 20)
        Me.TXT_DESCART.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button2.Location = New System.Drawing.Point(185, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 28)
        Me.Button2.TabIndex = 28
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TXT_CODART
        '
        Me.TXT_CODART.Location = New System.Drawing.Point(80, 13)
        Me.TXT_CODART.Name = "TXT_CODART"
        Me.TXT_CODART.Size = New System.Drawing.Size(103, 20)
        Me.TXT_CODART.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Articulo :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DBLISTAR)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 280)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(726, 164)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "6,0,0,0,0,85,Columns:"
        Me.DBLISTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(9, 9)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.Size = New System.Drawing.Size(709, 149)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 11
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.Button9)
        Me.GroupBox8.Controls.Add(Me.Button_ANULAR)
        Me.GroupBox8.Controls.Add(Me.Button_CANCELAR)
        Me.GroupBox8.Controls.Add(Me.Button_CAJA)
        Me.GroupBox8.Controls.Add(Me.Button_CREDITO)
        Me.GroupBox8.Controls.Add(Me.Button_TARJETA)
        Me.GroupBox8.Controls.Add(Me.Button_EFECTIVO)
        Me.GroupBox8.Location = New System.Drawing.Point(9, 491)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(723, 45)
        Me.GroupBox8.TabIndex = 27
        Me.GroupBox8.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Location = New System.Drawing.Point(405, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 26)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Consultar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button9.Location = New System.Drawing.Point(480, 16)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 26)
        Me.Button9.TabIndex = 6
        Me.Button9.Text = "Reimprimir"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button_ANULAR
        '
        Me.Button_ANULAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_ANULAR.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_ANULAR.FlatAppearance.BorderSize = 5
        Me.Button_ANULAR.Location = New System.Drawing.Point(555, 16)
        Me.Button_ANULAR.Name = "Button_ANULAR"
        Me.Button_ANULAR.Size = New System.Drawing.Size(75, 26)
        Me.Button_ANULAR.TabIndex = 5
        Me.Button_ANULAR.Text = "Anular"
        Me.Button_ANULAR.UseVisualStyleBackColor = False
        '
        'Button_CANCELAR
        '
        Me.Button_CANCELAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_CANCELAR.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button_CANCELAR.Location = New System.Drawing.Point(630, 16)
        Me.Button_CANCELAR.Name = "Button_CANCELAR"
        Me.Button_CANCELAR.Size = New System.Drawing.Size(90, 26)
        Me.Button_CANCELAR.TabIndex = 4
        Me.Button_CANCELAR.Text = "Cancelar (F12)"
        Me.Button_CANCELAR.UseVisualStyleBackColor = False
        '
        'Button_CAJA
        '
        Me.Button_CAJA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_CAJA.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_CAJA.Location = New System.Drawing.Point(235, 16)
        Me.Button_CAJA.Name = "Button_CAJA"
        Me.Button_CAJA.Size = New System.Drawing.Size(88, 26)
        Me.Button_CAJA.TabIndex = 3
        Me.Button_CAJA.Text = "Mov Caja (F6)"
        Me.Button_CAJA.UseVisualStyleBackColor = False
        '
        'Button_CREDITO
        '
        Me.Button_CREDITO.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_CREDITO.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_CREDITO.Location = New System.Drawing.Point(160, 16)
        Me.Button_CREDITO.Name = "Button_CREDITO"
        Me.Button_CREDITO.Size = New System.Drawing.Size(75, 26)
        Me.Button_CREDITO.TabIndex = 2
        Me.Button_CREDITO.Text = "Credito (F9)"
        Me.Button_CREDITO.UseVisualStyleBackColor = False
        '
        'Button_TARJETA
        '
        Me.Button_TARJETA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_TARJETA.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_TARJETA.Location = New System.Drawing.Point(85, 16)
        Me.Button_TARJETA.Name = "Button_TARJETA"
        Me.Button_TARJETA.Size = New System.Drawing.Size(75, 26)
        Me.Button_TARJETA.TabIndex = 1
        Me.Button_TARJETA.Text = "Tarjeta (F8)"
        Me.Button_TARJETA.UseVisualStyleBackColor = False
        '
        'Button_EFECTIVO
        '
        Me.Button_EFECTIVO.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_EFECTIVO.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button_EFECTIVO.Location = New System.Drawing.Point(3, 16)
        Me.Button_EFECTIVO.Name = "Button_EFECTIVO"
        Me.Button_EFECTIVO.Size = New System.Drawing.Size(82, 26)
        Me.Button_EFECTIVO.TabIndex = 0
        Me.Button_EFECTIVO.Text = "Efectivo (F7)"
        Me.Button_EFECTIVO.UseVisualStyleBackColor = False
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(81, 42)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(102, 20)
        Me.TextBox11.TabIndex = 32
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(278, 42)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(115, 20)
        Me.TextBox12.TabIndex = 33
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TXT_VVENTA)
        Me.GroupBox7.Controls.Add(Me.TXT_IGV)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(40, 444)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(666, 47)
        Me.GroupBox7.TabIndex = 28
        Me.GroupBox7.TabStop = False
        '
        'TXT_VVENTA
        '
        Me.TXT_VVENTA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_VVENTA.Location = New System.Drawing.Point(102, 20)
        Me.TXT_VVENTA.Name = "TXT_VVENTA"
        Me.TXT_VVENTA.ReadOnly = True
        Me.TXT_VVENTA.Size = New System.Drawing.Size(117, 21)
        Me.TXT_VVENTA.TabIndex = 5
        Me.TXT_VVENTA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_IGV
        '
        Me.TXT_IGV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_IGV.Location = New System.Drawing.Point(297, 20)
        Me.TXT_IGV.Name = "TXT_IGV"
        Me.TXT_IGV.ReadOnly = True
        Me.TXT_IGV.Size = New System.Drawing.Size(117, 21)
        Me.TXT_IGV.TabIndex = 4
        Me.TXT_IGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(257, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Igv :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 15)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Sub.Total :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(479, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(47, 15)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Total :"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_TOTAL.Location = New System.Drawing.Point(539, 20)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(117, 21)
        Me.TXT_TOTAL.TabIndex = 0
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TOTAL1
        '
        Me.TXT_TOTAL1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_TOTAL1.Location = New System.Drawing.Point(496, 20)
        Me.TXT_TOTAL1.Name = "TXT_TOTAL1"
        Me.TXT_TOTAL1.ReadOnly = True
        Me.TXT_TOTAL1.Size = New System.Drawing.Size(109, 20)
        Me.TXT_TOTAL1.TabIndex = 5
        Me.TXT_TOTAL1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(443, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Total :"
        '
        'TXT_IGV1
        '
        Me.TXT_IGV1.Location = New System.Drawing.Point(135, 462)
        Me.TXT_IGV1.Name = "TXT_IGV1"
        Me.TXT_IGV1.ReadOnly = True
        Me.TXT_IGV1.Size = New System.Drawing.Size(109, 20)
        Me.TXT_IGV1.TabIndex = 3
        Me.TXT_IGV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label151
        '
        Me.Label151.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label151.AutoSize = True
        Me.Label151.Location = New System.Drawing.Point(249, 20)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(33, 15)
        Me.Label151.TabIndex = 2
        Me.Label151.Text = "Igv :"
        '
        'TXT_VVENTA1
        '
        Me.TXT_VVENTA1.Location = New System.Drawing.Point(259, 17)
        Me.TXT_VVENTA1.Name = "TXT_VVENTA1"
        Me.TXT_VVENTA1.ReadOnly = True
        Me.TXT_VVENTA1.Size = New System.Drawing.Size(109, 20)
        Me.TXT_VVENTA1.TabIndex = 1
        Me.TXT_VVENTA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label161
        '
        Me.Label161.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label161.AutoSize = True
        Me.Label161.Location = New System.Drawing.Point(6, 20)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(88, 15)
        Me.Label161.TabIndex = 0
        Me.Label161.Text = "Valor Venta :"
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.White
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(462, 95)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 23
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(747, 543)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.picturebox1)
        Me.Controls.Add(Me.TXT_NRODOC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox7)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents COMBO_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_TURNO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DT_PROC As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_DOC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXT_OPERADOR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_TC As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_NRODOC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_RUC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_CODCLIE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_RAZON As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PU As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CANT As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXT_DESCART As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CODART As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_TARJETA As System.Windows.Forms.Button
    Friend WithEvents Button_EFECTIVO As System.Windows.Forms.Button
    Friend WithEvents Button_CAJA As System.Windows.Forms.Button
    Friend WithEvents Button_CREDITO As System.Windows.Forms.Button
    Friend WithEvents Button_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button_ANULAR As System.Windows.Forms.Button
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_TOTAL1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TXT_IGV1 As System.Windows.Forms.TextBox
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents TXT_VVENTA1 As System.Windows.Forms.TextBox
    Friend WithEvents Label161 As System.Windows.Forms.Label
    Friend WithEvents CambioDeTurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirGavetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreZToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinDeDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents TXT_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TXT_IGV As System.Windows.Forms.TextBox
    Friend WithEvents TXT_VVENTA As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mov_Banco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mov_Banco))
        Me.TXT_PAGO_VARIOS = New System.Windows.Forms.TextBox()
        Me.TXT_MONTO_G = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Combo_FV = New System.Windows.Forms.ComboBox()
        Me.OPT_VENC = New System.Windows.Forms.RadioButton()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.OPT_OPER = New System.Windows.Forms.RadioButton()
        Me.OPT_GIRO = New System.Windows.Forms.RadioButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TXT_MONTO_L = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_MONTO_O = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBANCO = New System.Windows.Forms.GroupBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_SALDO_L = New System.Windows.Forms.TextBox()
        Me.TXT_SALDO_O = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_SALDO_G = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_BANCO = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DT_OPERACION = New System.Windows.Forms.DateTimePicker()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBANCO.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_PAGO_VARIOS
        '
        Me.TXT_PAGO_VARIOS.Location = New System.Drawing.Point(391, 10)
        Me.TXT_PAGO_VARIOS.Name = "TXT_PAGO_VARIOS"
        Me.TXT_PAGO_VARIOS.ReadOnly = True
        Me.TXT_PAGO_VARIOS.Size = New System.Drawing.Size(86, 20)
        Me.TXT_PAGO_VARIOS.TabIndex = 46
        Me.TXT_PAGO_VARIOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_MONTO_G
        '
        Me.TXT_MONTO_G.Location = New System.Drawing.Point(655, 10)
        Me.TXT_MONTO_G.Name = "TXT_MONTO_G"
        Me.TXT_MONTO_G.ReadOnly = True
        Me.TXT_MONTO_G.Size = New System.Drawing.Size(86, 20)
        Me.TXT_MONTO_G.TabIndex = 36
        Me.TXT_MONTO_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(269, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 13)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Total Pago Varios :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(558, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total Contable :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(549, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 13)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Total Disponible :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(13, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "F2 - Agregar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(104, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "F3 - Quitar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(101, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 123)
        Me.Panel1.TabIndex = 39
        Me.Panel1.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(344, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(165, 97)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Consultar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Combo_FV)
        Me.GroupBox5.Controls.Add(Me.OPT_VENC)
        Me.GroupBox5.Controls.Add(Me.DT_FIN)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.DT_INI)
        Me.GroupBox5.Controls.Add(Me.OPT_OPER)
        Me.GroupBox5.Controls.Add(Me.OPT_GIRO)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(547, 72)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(247, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Del"
        '
        'Combo_FV
        '
        Me.Combo_FV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_FV.FormattingEnabled = True
        Me.Combo_FV.Items.AddRange(New Object() {"Todos", "Pendientes", "Cobrados"})
        Me.Combo_FV.Location = New System.Drawing.Point(203, 48)
        Me.Combo_FV.Name = "Combo_FV"
        Me.Combo_FV.Size = New System.Drawing.Size(109, 21)
        Me.Combo_FV.TabIndex = 6
        '
        'OPT_VENC
        '
        Me.OPT_VENC.AutoSize = True
        Me.OPT_VENC.Location = New System.Drawing.Point(57, 49)
        Me.OPT_VENC.Name = "OPT_VENC"
        Me.OPT_VENC.Size = New System.Drawing.Size(105, 17)
        Me.OPT_VENC.TabIndex = 5
        Me.OPT_VENC.Text = "Fecha de Cobro"
        Me.OPT_VENC.UseVisualStyleBackColor = True
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(447, 18)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(286, 18)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
        '
        'OPT_OPER
        '
        Me.OPT_OPER.AutoSize = True
        Me.OPT_OPER.Location = New System.Drawing.Point(358, 52)
        Me.OPT_OPER.Name = "OPT_OPER"
        Me.OPT_OPER.Size = New System.Drawing.Size(128, 17)
        Me.OPT_OPER.TabIndex = 1
        Me.OPT_OPER.Text = "Fecha de Operacion"
        Me.OPT_OPER.UseVisualStyleBackColor = True
        Me.OPT_OPER.Visible = False
        '
        'OPT_GIRO
        '
        Me.OPT_GIRO.AutoSize = True
        Me.OPT_GIRO.Checked = True
        Me.OPT_GIRO.Location = New System.Drawing.Point(57, 20)
        Me.OPT_GIRO.Name = "OPT_GIRO"
        Me.OPT_GIRO.Size = New System.Drawing.Size(97, 17)
        Me.OPT_GIRO.TabIndex = 0
        Me.OPT_GIRO.TabStop = True
        Me.OPT_GIRO.Text = "Fecha de Giro"
        Me.OPT_GIRO.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.Market.My.Resources.Resources.excel
        Me.Button11.Location = New System.Drawing.Point(738, 13)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 43)
        Me.Button11.TabIndex = 41
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Market.My.Resources.Resources.Imprimir
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(647, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 49)
        Me.Button2.TabIndex = 40
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TXT_MONTO_L
        '
        Me.TXT_MONTO_L.Location = New System.Drawing.Point(655, 52)
        Me.TXT_MONTO_L.Name = "TXT_MONTO_L"
        Me.TXT_MONTO_L.ReadOnly = True
        Me.TXT_MONTO_L.Size = New System.Drawing.Size(86, 20)
        Me.TXT_MONTO_L.TabIndex = 43
        Me.TXT_MONTO_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_MONTO_L.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_PAGO_VARIOS)
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_G)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_L)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_MONTO_O)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 626)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 84)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'TXT_MONTO_O
        '
        Me.TXT_MONTO_O.Location = New System.Drawing.Point(655, 31)
        Me.TXT_MONTO_O.Name = "TXT_MONTO_O"
        Me.TXT_MONTO_O.ReadOnly = True
        Me.TXT_MONTO_O.Size = New System.Drawing.Size(86, 20)
        Me.TXT_MONTO_O.TabIndex = 42
        Me.TXT_MONTO_O.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(13, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "F4 - Modificar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Total Bancario :"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(104, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "F5 - Fecha de Operacion"
        '
        'GroupBANCO
        '
        Me.GroupBANCO.Controls.Add(Me.picturebox1)
        Me.GroupBANCO.Controls.Add(Me.GroupBox4)
        Me.GroupBANCO.Controls.Add(Me.Label1)
        Me.GroupBANCO.Controls.Add(Me.TXT_BANCO)
        Me.GroupBANCO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBANCO.Location = New System.Drawing.Point(206, 1)
        Me.GroupBANCO.Name = "GroupBANCO"
        Me.GroupBANCO.Size = New System.Drawing.Size(390, 110)
        Me.GroupBANCO.TabIndex = 36
        Me.GroupBANCO.TabStop = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(352, 12)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 22
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TXT_SALDO_L)
        Me.GroupBox4.Controls.Add(Me.TXT_SALDO_O)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.TXT_SALDO_G)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(46, 41)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 63)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saldos Iniciales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(123, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Disponible "
        '
        'TXT_SALDO_L
        '
        Me.TXT_SALDO_L.Location = New System.Drawing.Point(196, 37)
        Me.TXT_SALDO_L.Name = "TXT_SALDO_L"
        Me.TXT_SALDO_L.ReadOnly = True
        Me.TXT_SALDO_L.Size = New System.Drawing.Size(87, 20)
        Me.TXT_SALDO_L.TabIndex = 32
        Me.TXT_SALDO_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_SALDO_L.Visible = False
        '
        'TXT_SALDO_O
        '
        Me.TXT_SALDO_O.Location = New System.Drawing.Point(103, 37)
        Me.TXT_SALDO_O.Name = "TXT_SALDO_O"
        Me.TXT_SALDO_O.ReadOnly = True
        Me.TXT_SALDO_O.Size = New System.Drawing.Size(87, 20)
        Me.TXT_SALDO_O.TabIndex = 31
        Me.TXT_SALDO_O.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Bancario"
        Me.Label9.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Contable"
        '
        'TXT_SALDO_G
        '
        Me.TXT_SALDO_G.Location = New System.Drawing.Point(10, 37)
        Me.TXT_SALDO_G.Name = "TXT_SALDO_G"
        Me.TXT_SALDO_G.ReadOnly = True
        Me.TXT_SALDO_G.Size = New System.Drawing.Size(87, 20)
        Me.TXT_SALDO_G.TabIndex = 28
        Me.TXT_SALDO_G.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Banco :"
        '
        'TXT_BANCO
        '
        Me.TXT_BANCO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BANCO.Location = New System.Drawing.Point(70, 18)
        Me.TXT_BANCO.Name = "TXT_BANCO"
        Me.TXT_BANCO.ReadOnly = True
        Me.TXT_BANCO.Size = New System.Drawing.Size(265, 20)
        Me.TXT_BANCO.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(270, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(268, 86)
        Me.Panel2.TabIndex = 32
        Me.Panel2.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(95, 50)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(176, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(14, 50)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Grabar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DT_OPERACION)
        Me.GroupBox3.Location = New System.Drawing.Point(50, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 41)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fecha de Operacion"
        '
        'DT_OPERACION
        '
        Me.DT_OPERACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_OPERACION.Location = New System.Drawing.Point(32, 15)
        Me.DT_OPERACION.Name = "DT_OPERACION"
        Me.DT_OPERACION.Size = New System.Drawing.Size(94, 20)
        Me.DT_OPERACION.TabIndex = 2
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = resources.GetString("DBLISTAR.ColumnInfo")
        Me.DBLISTAR.Font = New System.Drawing.Font("Times New Roman", 8.25!)
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(9, 10)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DBLISTAR.Size = New System.Drawing.Size(773, 487)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Market.My.Resources.Resources.FOLDER
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(26, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 68)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Filtros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.DBLISTAR)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(788, 503)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'Mov_Banco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(812, 710)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBANCO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Mov_Banco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bancos"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBANCO.ResumeLayout(False)
        Me.GroupBANCO.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TXT_PAGO_VARIOS As TextBox
    Friend WithEvents TXT_MONTO_G As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Combo_FV As ComboBox
    Friend WithEvents OPT_VENC As RadioButton
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents OPT_OPER As RadioButton
    Friend WithEvents OPT_GIRO As RadioButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button11 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TXT_MONTO_L As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_MONTO_O As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBANCO As GroupBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_SALDO_L As TextBox
    Friend WithEvents TXT_SALDO_O As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_SALDO_G As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_BANCO As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DT_OPERACION As DateTimePicker
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movi_Banco
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
        Me.TXT_GIRADO = New System.Windows.Forms.TextBox()
        Me.Group_BANCO_DESTINO = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TXT_BANCO_DEST = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GROUP_TC = New System.Windows.Forms.GroupBox()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.CHK_COMITE = New System.Windows.Forms.CheckBox()
        Me.Group_COMITE = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_COMITE = New System.Windows.Forms.TextBox()
        Me.Combo_FPAGO = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_REFERENCIA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.OPT_NINGUNO = New System.Windows.Forms.RadioButton()
        Me.OPT_OTROS = New System.Windows.Forms.RadioButton()
        Me.OPT_PROV = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OPT_SAL = New System.Windows.Forms.RadioButton()
        Me.OPT_ING = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DT_COBRO = New System.Windows.Forms.DateTimePicker()
        Me.DT_OPERACION = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DT = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Group_Ing = New System.Windows.Forms.GroupBox()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.TXT_CONCEPTO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_OBS = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Group_BANCO_DESTINO.SuspendLayout()
        Me.GROUP_TC.SuspendLayout()
        Me.Group_COMITE.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Group_Ing.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_GIRADO
        '
        Me.TXT_GIRADO.AcceptsReturn = True
        Me.TXT_GIRADO.Location = New System.Drawing.Point(71, 35)
        Me.TXT_GIRADO.Name = "TXT_GIRADO"
        Me.TXT_GIRADO.ReadOnly = True
        Me.TXT_GIRADO.Size = New System.Drawing.Size(216, 21)
        Me.TXT_GIRADO.TabIndex = 12
        '
        'Group_BANCO_DESTINO
        '
        Me.Group_BANCO_DESTINO.Controls.Add(Me.Label10)
        Me.Group_BANCO_DESTINO.Controls.Add(Me.Button4)
        Me.Group_BANCO_DESTINO.Controls.Add(Me.TXT_BANCO_DEST)
        Me.Group_BANCO_DESTINO.Location = New System.Drawing.Point(9, 371)
        Me.Group_BANCO_DESTINO.Name = "Group_BANCO_DESTINO"
        Me.Group_BANCO_DESTINO.Size = New System.Drawing.Size(331, 50)
        Me.Group_BANCO_DESTINO.TabIndex = 18
        Me.Group_BANCO_DESTINO.TabStop = False
        Me.Group_BANCO_DESTINO.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Destino :"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button4.Location = New System.Drawing.Point(293, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 34)
        Me.Button4.TabIndex = 13
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TXT_BANCO_DEST
        '
        Me.TXT_BANCO_DEST.AcceptsReturn = True
        Me.TXT_BANCO_DEST.Location = New System.Drawing.Point(71, 21)
        Me.TXT_BANCO_DEST.Name = "TXT_BANCO_DEST"
        Me.TXT_BANCO_DEST.ReadOnly = True
        Me.TXT_BANCO_DEST.Size = New System.Drawing.Size(216, 21)
        Me.TXT_BANCO_DEST.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Girado a :"
        '
        'GROUP_TC
        '
        Me.GROUP_TC.Controls.Add(Me.TXT_TC)
        Me.GROUP_TC.Location = New System.Drawing.Point(102, 328)
        Me.GROUP_TC.Name = "GROUP_TC"
        Me.GROUP_TC.Size = New System.Drawing.Size(121, 43)
        Me.GROUP_TC.TabIndex = 17
        Me.GROUP_TC.TabStop = False
        Me.GROUP_TC.Text = "TC"
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(13, 16)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.Size = New System.Drawing.Size(86, 21)
        Me.TXT_TC.TabIndex = 15
        Me.TXT_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CHK_COMITE
        '
        Me.CHK_COMITE.AutoSize = True
        Me.CHK_COMITE.Enabled = False
        Me.CHK_COMITE.Location = New System.Drawing.Point(245, 344)
        Me.CHK_COMITE.Name = "CHK_COMITE"
        Me.CHK_COMITE.Size = New System.Drawing.Size(65, 19)
        Me.CHK_COMITE.TabIndex = 22
        Me.CHK_COMITE.Text = "Comite"
        Me.CHK_COMITE.UseVisualStyleBackColor = True
        '
        'Group_COMITE
        '
        Me.Group_COMITE.Controls.Add(Me.Button5)
        Me.Group_COMITE.Controls.Add(Me.Label11)
        Me.Group_COMITE.Controls.Add(Me.TXT_COMITE)
        Me.Group_COMITE.Location = New System.Drawing.Point(6, 377)
        Me.Group_COMITE.Name = "Group_COMITE"
        Me.Group_COMITE.Size = New System.Drawing.Size(331, 50)
        Me.Group_COMITE.TabIndex = 21
        Me.Group_COMITE.TabStop = False
        Me.Group_COMITE.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button5.Location = New System.Drawing.Point(293, 10)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 34)
        Me.Button5.TabIndex = 15
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Comite :"
        '
        'TXT_COMITE
        '
        Me.TXT_COMITE.AcceptsReturn = True
        Me.TXT_COMITE.Location = New System.Drawing.Point(61, 21)
        Me.TXT_COMITE.Name = "TXT_COMITE"
        Me.TXT_COMITE.ReadOnly = True
        Me.TXT_COMITE.Size = New System.Drawing.Size(226, 21)
        Me.TXT_COMITE.TabIndex = 12
        '
        'Combo_FPAGO
        '
        Me.Combo_FPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_FPAGO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_FPAGO.FormattingEnabled = True
        Me.Combo_FPAGO.Location = New System.Drawing.Point(93, 262)
        Me.Combo_FPAGO.Name = "Combo_FPAGO"
        Me.Combo_FPAGO.Size = New System.Drawing.Size(69, 21)
        Me.Combo_FPAGO.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Forma de Pago :"
        '
        'TXT_REFERENCIA
        '
        Me.TXT_REFERENCIA.Location = New System.Drawing.Point(245, 262)
        Me.TXT_REFERENCIA.Name = "TXT_REFERENCIA"
        Me.TXT_REFERENCIA.Size = New System.Drawing.Size(86, 21)
        Me.TXT_REFERENCIA.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Referencia :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OPT_NINGUNO)
        Me.GroupBox4.Controls.Add(Me.OPT_OTROS)
        Me.GroupBox4.Controls.Add(Me.OPT_PROV)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.TXT_GIRADO)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 188)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(331, 71)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'OPT_NINGUNO
        '
        Me.OPT_NINGUNO.AutoSize = True
        Me.OPT_NINGUNO.Checked = True
        Me.OPT_NINGUNO.Location = New System.Drawing.Point(223, 9)
        Me.OPT_NINGUNO.Name = "OPT_NINGUNO"
        Me.OPT_NINGUNO.Size = New System.Drawing.Size(71, 19)
        Me.OPT_NINGUNO.TabIndex = 16
        Me.OPT_NINGUNO.TabStop = True
        Me.OPT_NINGUNO.Text = "Ninguno"
        Me.OPT_NINGUNO.UseVisualStyleBackColor = True
        '
        'OPT_OTROS
        '
        Me.OPT_OTROS.AutoSize = True
        Me.OPT_OTROS.Location = New System.Drawing.Point(140, 9)
        Me.OPT_OTROS.Name = "OPT_OTROS"
        Me.OPT_OTROS.Size = New System.Drawing.Size(55, 19)
        Me.OPT_OTROS.TabIndex = 15
        Me.OPT_OTROS.Text = "Otros"
        Me.OPT_OTROS.UseVisualStyleBackColor = True
        '
        'OPT_PROV
        '
        Me.OPT_PROV.AutoSize = True
        Me.OPT_PROV.Location = New System.Drawing.Point(34, 9)
        Me.OPT_PROV.Name = "OPT_PROV"
        Me.OPT_PROV.Size = New System.Drawing.Size(88, 19)
        Me.OPT_PROV.TabIndex = 14
        Me.OPT_PROV.Text = "Proveedores"
        Me.OPT_PROV.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button3.Location = New System.Drawing.Point(293, 28)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 34)
        Me.Button3.TabIndex = 13
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_SAL)
        Me.GroupBox1.Controls.Add(Me.OPT_ING)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 43)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'OPT_SAL
        '
        Me.OPT_SAL.AutoSize = True
        Me.OPT_SAL.Checked = True
        Me.OPT_SAL.Location = New System.Drawing.Point(199, 18)
        Me.OPT_SAL.Name = "OPT_SAL"
        Me.OPT_SAL.Size = New System.Drawing.Size(59, 19)
        Me.OPT_SAL.TabIndex = 1
        Me.OPT_SAL.TabStop = True
        Me.OPT_SAL.Text = "Salida"
        Me.OPT_SAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OPT_SAL.UseVisualStyleBackColor = True
        '
        'OPT_ING
        '
        Me.OPT_ING.AutoSize = True
        Me.OPT_ING.Location = New System.Drawing.Point(64, 18)
        Me.OPT_ING.Name = "OPT_ING"
        Me.OPT_ING.Size = New System.Drawing.Size(64, 19)
        Me.OPT_ING.TabIndex = 0
        Me.OPT_ING.Text = "Ingreso"
        Me.OPT_ING.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(63, 478)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(206, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 32)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de Cobro :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DT_COBRO)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DT_OPERACION)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DT)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(331, 94)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'DT_COBRO
        '
        Me.DT_COBRO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_COBRO.Location = New System.Drawing.Point(153, 66)
        Me.DT_COBRO.Name = "DT_COBRO"
        Me.DT_COBRO.Size = New System.Drawing.Size(99, 21)
        Me.DT_COBRO.TabIndex = 12
        '
        'DT_OPERACION
        '
        Me.DT_OPERACION.Enabled = False
        Me.DT_OPERACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_OPERACION.Location = New System.Drawing.Point(153, 39)
        Me.DT_OPERACION.Name = "DT_OPERACION"
        Me.DT_OPERACION.Size = New System.Drawing.Size(99, 21)
        Me.DT_OPERACION.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha de Operacion :"
        '
        'DT
        '
        Me.DT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT.Location = New System.Drawing.Point(153, 12)
        Me.DT.Name = "DT"
        Me.DT.Size = New System.Drawing.Size(99, 21)
        Me.DT.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Movimiento :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHK_COMITE)
        Me.GroupBox2.Controls.Add(Me.Group_BANCO_DESTINO)
        Me.GroupBox2.Controls.Add(Me.GROUP_TC)
        Me.GroupBox2.Controls.Add(Me.Combo_FPAGO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_REFERENCIA)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Group_Ing)
        Me.GroupBox2.Controls.Add(Me.TXT_OBS)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Group_COMITE)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 427)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'Group_Ing
        '
        Me.Group_Ing.Controls.Add(Me.TXT_MONTO)
        Me.Group_Ing.Controls.Add(Me.Label2)
        Me.Group_Ing.Controls.Add(Me.picturebox1)
        Me.Group_Ing.Controls.Add(Me.TXT_CONCEPTO)
        Me.Group_Ing.Controls.Add(Me.Label7)
        Me.Group_Ing.Location = New System.Drawing.Point(6, 13)
        Me.Group_Ing.Name = "Group_Ing"
        Me.Group_Ing.Size = New System.Drawing.Size(331, 81)
        Me.Group_Ing.TabIndex = 10
        Me.Group_Ing.TabStop = False
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Location = New System.Drawing.Point(128, 48)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(140, 21)
        Me.TXT_MONTO.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Monto :"
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(293, 13)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 13
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_CONCEPTO
        '
        Me.TXT_CONCEPTO.AcceptsReturn = True
        Me.TXT_CONCEPTO.Location = New System.Drawing.Point(71, 20)
        Me.TXT_CONCEPTO.Name = "TXT_CONCEPTO"
        Me.TXT_CONCEPTO.ReadOnly = True
        Me.TXT_CONCEPTO.Size = New System.Drawing.Size(216, 21)
        Me.TXT_CONCEPTO.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Concepto :"
        '
        'TXT_OBS
        '
        Me.TXT_OBS.Location = New System.Drawing.Point(69, 294)
        Me.TXT_OBS.Multiline = True
        Me.TXT_OBS.Name = "TXT_OBS"
        Me.TXT_OBS.Size = New System.Drawing.Size(262, 33)
        Me.TXT_OBS.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Observ"
        '
        'Movi_Banco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(360, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "Movi_Banco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Banco"
        Me.Group_BANCO_DESTINO.ResumeLayout(False)
        Me.Group_BANCO_DESTINO.PerformLayout()
        Me.GROUP_TC.ResumeLayout(False)
        Me.GROUP_TC.PerformLayout()
        Me.Group_COMITE.ResumeLayout(False)
        Me.Group_COMITE.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Group_Ing.ResumeLayout(False)
        Me.Group_Ing.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TXT_GIRADO As TextBox
    Friend WithEvents Group_BANCO_DESTINO As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TXT_BANCO_DEST As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GROUP_TC As GroupBox
    Friend WithEvents TXT_TC As TextBox
    Friend WithEvents CHK_COMITE As CheckBox
    Friend WithEvents Group_COMITE As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_COMITE As TextBox
    Friend WithEvents Combo_FPAGO As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_REFERENCIA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents OPT_NINGUNO As RadioButton
    Friend WithEvents OPT_OTROS As RadioButton
    Friend WithEvents OPT_PROV As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OPT_SAL As RadioButton
    Friend WithEvents OPT_ING As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DT_COBRO As DateTimePicker
    Friend WithEvents DT_OPERACION As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DT As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Group_Ing As GroupBox
    Friend WithEvents TXT_MONTO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picturebox1 As Button
    Friend WithEvents TXT_CONCEPTO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_OBS As TextBox
    Friend WithEvents Label3 As Label
End Class

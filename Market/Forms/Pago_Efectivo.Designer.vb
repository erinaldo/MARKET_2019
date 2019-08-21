<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago_Efectivo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pago_Efectivo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_MON = New System.Windows.Forms.Label()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_MONTO = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_SOLES = New System.Windows.Forms.TextBox()
        Me.TXT_DOLAR = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_TOTAL_TARJETA_D = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL_TARJETA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_MONTO_TARJETA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_TARJETA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Combo_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.COMBO_TARJETA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.C1_TARJETA = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LBL_VUELTO_MON = New System.Windows.Forms.Label()
        Me.TXT_VUELTO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LBL_VUELTO_O = New System.Windows.Forms.Label()
        Me.TXT_VUELTO_O = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1_TARJETA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.lbl_MON)
        Me.GroupBox1.Controls.Add(Me.TXT_TC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LBL_MONTO)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monto a Pagar"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "teclado_windows.jpg"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(425, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 51)
        Me.Button3.TabIndex = 49
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
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
        '
        'lbl_MON
        '
        Me.lbl_MON.AutoSize = True
        Me.lbl_MON.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_MON.Location = New System.Drawing.Point(38, 29)
        Me.lbl_MON.Name = "lbl_MON"
        Me.lbl_MON.Size = New System.Drawing.Size(22, 19)
        Me.lbl_MON.TabIndex = 4
        Me.lbl_MON.Text = "S/"
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(269, 26)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.ReadOnly = True
        Me.TXT_TC.Size = New System.Drawing.Size(107, 26)
        Me.TXT_TC.TabIndex = 3
        Me.TXT_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(212, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T.C. :"
        '
        'LBL_MONTO
        '
        Me.LBL_MONTO.AutoSize = True
        Me.LBL_MONTO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_MONTO.Location = New System.Drawing.Point(75, 29)
        Me.LBL_MONTO.Name = "LBL_MONTO"
        Me.LBL_MONTO.Size = New System.Drawing.Size(55, 19)
        Me.LBL_MONTO.TabIndex = 0
        Me.LBL_MONTO.Text = "Label1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_SOLES)
        Me.GroupBox2.Controls.Add(Me.TXT_DOLAR)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Efectivo"
        '
        'TXT_SOLES
        '
        Me.TXT_SOLES.Location = New System.Drawing.Point(107, 29)
        Me.TXT_SOLES.Name = "TXT_SOLES"
        Me.TXT_SOLES.Size = New System.Drawing.Size(107, 26)
        Me.TXT_SOLES.TabIndex = 2
        Me.TXT_SOLES.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_DOLAR
        '
        Me.TXT_DOLAR.Location = New System.Drawing.Point(392, 29)
        Me.TXT_DOLAR.Name = "TXT_DOLAR"
        Me.TXT_DOLAR.Size = New System.Drawing.Size(107, 26)
        Me.TXT_DOLAR.TabIndex = 2
        Me.TXT_DOLAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(332, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "US$ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(60, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "S/ :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL_TARJETA_D)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL_TARJETA)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TXT_MONTO_TARJETA)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TXT_TARJETA)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Combo_MONEDA)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.COMBO_TARJETA)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.C1_TARJETA)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(12, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(539, 232)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tarjeta"
        '
        'TXT_TOTAL_TARJETA_D
        '
        Me.TXT_TOTAL_TARJETA_D.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTAL_TARJETA_D.Location = New System.Drawing.Point(249, 205)
        Me.TXT_TOTAL_TARJETA_D.Name = "TXT_TOTAL_TARJETA_D"
        Me.TXT_TOTAL_TARJETA_D.ReadOnly = True
        Me.TXT_TOTAL_TARJETA_D.Size = New System.Drawing.Size(108, 22)
        Me.TXT_TOTAL_TARJETA_D.TabIndex = 13
        Me.TXT_TOTAL_TARJETA_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(199, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 19)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "US$"
        '
        'TXT_TOTAL_TARJETA
        '
        Me.TXT_TOTAL_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTAL_TARJETA.Location = New System.Drawing.Point(425, 205)
        Me.TXT_TOTAL_TARJETA.Name = "TXT_TOTAL_TARJETA"
        Me.TXT_TOTAL_TARJETA.ReadOnly = True
        Me.TXT_TOTAL_TARJETA.Size = New System.Drawing.Size(108, 22)
        Me.TXT_TOTAL_TARJETA.TabIndex = 11
        Me.TXT_TOTAL_TARJETA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(379, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "S/"
        '
        'TXT_MONTO_TARJETA
        '
        Me.TXT_MONTO_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MONTO_TARJETA.Location = New System.Drawing.Point(444, 41)
        Me.TXT_MONTO_TARJETA.Name = "TXT_MONTO_TARJETA"
        Me.TXT_MONTO_TARJETA.Size = New System.Drawing.Size(89, 22)
        Me.TXT_MONTO_TARJETA.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(461, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Monto"
        '
        'TXT_TARJETA
        '
        Me.TXT_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TARJETA.Location = New System.Drawing.Point(281, 41)
        Me.TXT_TARJETA.Name = "TXT_TARJETA"
        Me.TXT_TARJETA.Size = New System.Drawing.Size(145, 22)
        Me.TXT_TARJETA.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(295, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nro. de Tarjeta"
        '
        'Combo_MONEDA
        '
        Me.Combo_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_MONEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_MONEDA.FormattingEnabled = True
        Me.Combo_MONEDA.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.Combo_MONEDA.Location = New System.Drawing.Point(180, 40)
        Me.Combo_MONEDA.Name = "Combo_MONEDA"
        Me.Combo_MONEDA.Size = New System.Drawing.Size(83, 23)
        Me.Combo_MONEDA.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(190, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Moneda"
        '
        'COMBO_TARJETA
        '
        Me.COMBO_TARJETA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMBO_TARJETA.FormattingEnabled = True
        Me.COMBO_TARJETA.Location = New System.Drawing.Point(6, 40)
        Me.COMBO_TARJETA.Name = "COMBO_TARJETA"
        Me.COMBO_TARJETA.Size = New System.Drawing.Size(142, 23)
        Me.COMBO_TARJETA.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(49, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tarjeta"
        '
        'C1_TARJETA
        '
        Me.C1_TARJETA.AllowEditing = False
        Me.C1_TARJETA.BackColor = System.Drawing.Color.White
        Me.C1_TARJETA.ColumnInfo = resources.GetString("C1_TARJETA.ColumnInfo")
        Me.C1_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.C1_TARJETA.ForeColor = System.Drawing.Color.Black
        Me.C1_TARJETA.Location = New System.Drawing.Point(6, 69)
        Me.C1_TARJETA.Name = "C1_TARJETA"
        Me.C1_TARJETA.Rows.DefaultSize = 19
        Me.C1_TARJETA.Size = New System.Drawing.Size(527, 123)
        Me.C1_TARJETA.StyleInfo = resources.GetString("C1_TARJETA.StyleInfo")
        Me.C1_TARJETA.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_VUELTO_O)
        Me.GroupBox4.Controls.Add(Me.LBL_VUELTO_O)
        Me.GroupBox4.Controls.Add(Me.LBL_VUELTO_MON)
        Me.GroupBox4.Controls.Add(Me.TXT_VUELTO)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 58)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vuelto"
        '
        'LBL_VUELTO_MON
        '
        Me.LBL_VUELTO_MON.AutoSize = True
        Me.LBL_VUELTO_MON.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_VUELTO_MON.Location = New System.Drawing.Point(17, 25)
        Me.LBL_VUELTO_MON.Name = "LBL_VUELTO_MON"
        Me.LBL_VUELTO_MON.Size = New System.Drawing.Size(31, 19)
        Me.LBL_VUELTO_MON.TabIndex = 13
        Me.LBL_VUELTO_MON.Text = "S/ :"
        '
        'TXT_VUELTO
        '
        Me.TXT_VUELTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_VUELTO.Location = New System.Drawing.Point(54, 22)
        Me.TXT_VUELTO.Name = "TXT_VUELTO"
        Me.TXT_VUELTO.ReadOnly = True
        Me.TXT_VUELTO.Size = New System.Drawing.Size(105, 24)
        Me.TXT_VUELTO.TabIndex = 12
        Me.TXT_VUELTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(351, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar (F7)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(456, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LBL_VUELTO_O
        '
        Me.LBL_VUELTO_O.AutoSize = True
        Me.LBL_VUELTO_O.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_VUELTO_O.Location = New System.Drawing.Point(165, 25)
        Me.LBL_VUELTO_O.Name = "LBL_VUELTO_O"
        Me.LBL_VUELTO_O.Size = New System.Drawing.Size(46, 19)
        Me.LBL_VUELTO_O.TabIndex = 14
        Me.LBL_VUELTO_O.Text = "US$ :"
        '
        'TXT_VUELTO_O
        '
        Me.TXT_VUELTO_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_VUELTO_O.Location = New System.Drawing.Point(210, 22)
        Me.TXT_VUELTO_O.Name = "TXT_VUELTO_O"
        Me.TXT_VUELTO_O.ReadOnly = True
        Me.TXT_VUELTO_O.Size = New System.Drawing.Size(105, 24)
        Me.TXT_VUELTO_O.TabIndex = 15
        Me.TXT_VUELTO_O.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pago_Efectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(563, 433)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Pago_Efectivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.C1_TARJETA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_MONTO As System.Windows.Forms.Label
    Friend WithEvents TXT_TC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_SOLES As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DOLAR As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_TARJETA As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Combo_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents COMBO_TARJETA As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_MONTO_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_TOTAL_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_VUELTO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lbl_MON As System.Windows.Forms.Label
    Friend WithEvents LBL_VUELTO_MON As System.Windows.Forms.Label
    Friend WithEvents TXT_TOTAL_TARJETA_D As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents TXT_VUELTO_O As TextBox
    Friend WithEvents LBL_VUELTO_O As Label
End Class

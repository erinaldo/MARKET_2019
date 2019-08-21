<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuentas_Pagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuentas_Pagar))
        Me.Button11 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OPT_EMISION = New System.Windows.Forms.RadioButton()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.CHK_DETALLE = New System.Windows.Forms.CheckBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Combo_FPAGO = New System.Windows.Forms.ComboBox()
        Me.OPT_VCTO = New System.Windows.Forms.RadioButton()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LIST_TIPO_DOC = New System.Windows.Forms.ListBox()
        Me.TXT_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Combo_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Image = Global.Market.My.Resources.Resources.excel
        Me.Button11.Location = New System.Drawing.Point(981, 10)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(56, 43)
        Me.Button11.TabIndex = 33
        Me.Button11.UseVisualStyleBackColor = False
        '
        'OPT_EMISION
        '
        Me.OPT_EMISION.AutoSize = True
        Me.OPT_EMISION.Checked = True
        Me.OPT_EMISION.Location = New System.Drawing.Point(12, 23)
        Me.OPT_EMISION.Name = "OPT_EMISION"
        Me.OPT_EMISION.Size = New System.Drawing.Size(67, 17)
        Me.OPT_EMISION.TabIndex = 5
        Me.OPT_EMISION.TabStop = True
        Me.OPT_EMISION.Text = "Emision"
        Me.OPT_EMISION.UseVisualStyleBackColor = True
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(331, 19)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(200, 19)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
        '
        'CHK_DETALLE
        '
        Me.CHK_DETALLE.AutoSize = True
        Me.CHK_DETALLE.Location = New System.Drawing.Point(514, 210)
        Me.CHK_DETALLE.Name = "CHK_DETALLE"
        Me.CHK_DETALLE.Size = New System.Drawing.Size(127, 17)
        Me.CHK_DETALLE.TabIndex = 84
        Me.CHK_DETALLE.Text = "Consulta Detallada"
        Me.CHK_DETALLE.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Combo_FPAGO)
        Me.GroupBox9.Location = New System.Drawing.Point(250, 192)
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
        Me.Combo_FPAGO.Location = New System.Drawing.Point(8, 19)
        Me.Combo_FPAGO.Name = "Combo_FPAGO"
        Me.Combo_FPAGO.Size = New System.Drawing.Size(215, 21)
        Me.Combo_FPAGO.TabIndex = 75
        '
        'OPT_VCTO
        '
        Me.OPT_VCTO.AutoSize = True
        Me.OPT_VCTO.Location = New System.Drawing.Point(85, 22)
        Me.OPT_VCTO.Name = "OPT_VCTO"
        Me.OPT_VCTO.Size = New System.Drawing.Size(91, 17)
        Me.OPT_VCTO.TabIndex = 6
        Me.OPT_VCTO.Text = "Vencimiento"
        Me.OPT_VCTO.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox3)
        Me.GroupBox8.Location = New System.Drawing.Point(475, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(251, 137)
        Me.GroupBox8.TabIndex = 82
        Me.GroupBox8.TabStop = False
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
        'TXT_PROVEEDOR
        '
        Me.TXT_PROVEEDOR.Location = New System.Drawing.Point(6, 19)
        Me.TXT_PROVEEDOR.Name = "TXT_PROVEEDOR"
        Me.TXT_PROVEEDOR.ReadOnly = True
        Me.TXT_PROVEEDOR.Size = New System.Drawing.Size(361, 20)
        Me.TXT_PROVEEDOR.TabIndex = 4
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(385, 11)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 37
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Combo_TIPO)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Location = New System.Drawing.Point(15, 192)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(229, 50)
        Me.GroupBox6.TabIndex = 76
        Me.GroupBox6.TabStop = False
        '
        'Combo_TIPO
        '
        Me.Combo_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TIPO.FormattingEnabled = True
        Me.Combo_TIPO.Items.AddRange(New Object() {"Todos", "Pendientes", "Cancelados"})
        Me.Combo_TIPO.Location = New System.Drawing.Point(61, 19)
        Me.Combo_TIPO.Name = "Combo_TIPO"
        Me.Combo_TIPO.Size = New System.Drawing.Size(148, 21)
        Me.Combo_TIPO.TabIndex = 75
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 59)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Market.My.Resources.Resources.kardex_val
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(96, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 49)
        Me.Button2.TabIndex = 34
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Pagos")
        Me.Button2.UseVisualStyleBackColor = False
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_PROVEEDOR)
        Me.GroupBox4.Controls.Add(Me.picturebox1)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 130)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(441, 56)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedor"
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(140, 35)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(123, 20)
        Me.TXT_NRO_DOC.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nro de Documento :"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(357, 274)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(164, 274)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Consultar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OPT_VCTO)
        Me.GroupBox5.Controls.Add(Me.OPT_EMISION)
        Me.GroupBox5.Controls.Add(Me.DT_FIN)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.DT_INI)
        Me.GroupBox5.Location = New System.Drawing.Point(25, 66)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(431, 54)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.Controls.Add(Me.CHK_DETALLE)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.TXT_NRO_DOC)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(20, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(749, 316)
        Me.Panel1.TabIndex = 24
        Me.Panel1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.C1_DETALLE)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1050, 467)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'C1_DETALLE
        '
        Me.C1_DETALLE.AllowEditing = False
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
        'Cuentas_Pagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1059, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Cuentas_Pagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas por Pagar"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button11 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OPT_EMISION As RadioButton
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents CHK_DETALLE As CheckBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Combo_FPAGO As ComboBox
    Friend WithEvents OPT_VCTO As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LIST_TIPO_DOC As ListBox
    Friend WithEvents TXT_PROVEEDOR As TextBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Combo_TIPO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_NRO_DOC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
End Class

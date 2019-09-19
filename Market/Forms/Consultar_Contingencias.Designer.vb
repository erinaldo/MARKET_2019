<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Contingencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Contingencias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupPROGRESS = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CHK_DETALLE = New System.Windows.Forms.CheckBox()
        Me.TXT_SERIE_DOC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LIST_TIPO_DOC = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Combo_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_CLIENTE = New System.Windows.Forms.TextBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.TXT_NRO_DOC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupPROGRESS.SuspendLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1059, 59)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Market.My.Resources.Resources.TEXT_EDITOR2___copia
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(495, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 49)
        Me.Button2.TabIndex = 87
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.Market.My.Resources.Resources.Nuevo
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(89, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 49)
        Me.Button3.TabIndex = 34
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Eliminar.jpg")
        Me.ImageList1.Images.SetKeyName(1, "impresora.png")
        Me.ImageList1.Images.SetKeyName(2, "liq.jpg")
        Me.ImageList1.Images.SetKeyName(3, "filtros.jpg")
        Me.ImageList1.Images.SetKeyName(4, "seleccionar.jpg")
        Me.ImageList1.Images.SetKeyName(5, "fpago.png")
        Me.ImageList1.Images.SetKeyName(6, "fp.jpg")
        Me.ImageList1.Images.SetKeyName(7, "se.jpg")
        Me.ImageList1.Images.SetKeyName(8, "lupa.jpg")
        Me.ImageList1.Images.SetKeyName(9, "editar_V2.png")
        Me.ImageList1.Images.SetKeyName(10, "sunat-logo.jpg")
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupPROGRESS)
        Me.GroupBox2.Controls.Add(Me.C1_DETALLE)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1066, 484)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'GroupPROGRESS
        '
        Me.GroupPROGRESS.BackColor = System.Drawing.Color.LightYellow
        Me.GroupPROGRESS.Controls.Add(Me.ProgressBar1)
        Me.GroupPROGRESS.Location = New System.Drawing.Point(55, 405)
        Me.GroupPROGRESS.Name = "GroupPROGRESS"
        Me.GroupPROGRESS.Size = New System.Drawing.Size(905, 38)
        Me.GroupPROGRESS.TabIndex = 28
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
        Me.C1_DETALLE.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1_DETALLE.BackColor = System.Drawing.Color.White
        Me.C1_DETALLE.ColumnInfo = resources.GetString("C1_DETALLE.ColumnInfo")
        Me.C1_DETALLE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_DETALLE.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1_DETALLE.ForeColor = System.Drawing.Color.Black
        Me.C1_DETALLE.Location = New System.Drawing.Point(3, 16)
        Me.C1_DETALLE.Name = "C1_DETALLE"
        Me.C1_DETALLE.Rows.DefaultSize = 18
        Me.C1_DETALLE.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1_DETALLE.Size = New System.Drawing.Size(1060, 465)
        Me.C1_DETALLE.StyleInfo = resources.GetString("C1_DETALLE.StyleInfo")
        Me.C1_DETALLE.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.CHK_DETALLE)
        Me.Panel1.Controls.Add(Me.TXT_SERIE_DOC)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.TXT_NRO_DOC)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(23, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 292)
        Me.Panel1.TabIndex = 28
        Me.Panel1.Visible = False
        '
        'CHK_DETALLE
        '
        Me.CHK_DETALLE.AutoSize = True
        Me.CHK_DETALLE.Location = New System.Drawing.Point(45, 213)
        Me.CHK_DETALLE.Name = "CHK_DETALLE"
        Me.CHK_DETALLE.Size = New System.Drawing.Size(108, 17)
        Me.CHK_DETALLE.TabIndex = 86
        Me.CHK_DETALLE.Text = "Mostrar Detalle"
        Me.CHK_DETALLE.UseVisualStyleBackColor = True
        '
        'TXT_SERIE_DOC
        '
        Me.TXT_SERIE_DOC.Location = New System.Drawing.Point(147, 13)
        Me.TXT_SERIE_DOC.Name = "TXT_SERIE_DOC"
        Me.TXT_SERIE_DOC.Size = New System.Drawing.Size(56, 20)
        Me.TXT_SERIE_DOC.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Serie de Documento :"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Tipo :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_CLIENTE)
        Me.GroupBox4.Controls.Add(Me.picturebox1)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 147)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(441, 49)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cliente"
        '
        'TXT_CLIENTE
        '
        Me.TXT_CLIENTE.Location = New System.Drawing.Point(11, 19)
        Me.TXT_CLIENTE.Name = "TXT_CLIENTE"
        Me.TXT_CLIENTE.ReadOnly = True
        Me.TXT_CLIENTE.Size = New System.Drawing.Size(361, 20)
        Me.TXT_CLIENTE.TabIndex = 4
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(393, 11)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 37
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_NRO_DOC
        '
        Me.TXT_NRO_DOC.Location = New System.Drawing.Point(147, 38)
        Me.TXT_NRO_DOC.Name = "TXT_NRO_DOC"
        Me.TXT_NRO_DOC.Size = New System.Drawing.Size(118, 20)
        Me.TXT_NRO_DOC.TabIndex = 43
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Nro de Documento :"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.SkyBlue
        Me.Button7.Location = New System.Drawing.Point(351, 252)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.SkyBlue
        Me.Button6.Location = New System.Drawing.Point(175, 252)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Consultar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DT_FIN)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.DT_INI)
        Me.GroupBox5.Location = New System.Drawing.Point(25, 87)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 47)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(150, 19)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(123, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(19, 19)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
        '
        'Consultar_Contingencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1075, 556)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consultar_Contingencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Contingencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupPROGRESS.ResumeLayout(False)
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupPROGRESS As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CHK_DETALLE As CheckBox
    Friend WithEvents TXT_SERIE_DOC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LIST_TIPO_DOC As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Combo_TIPO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_CLIENTE As TextBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents TXT_NRO_DOC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

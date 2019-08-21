<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Compras_Pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Compras_Pagos))
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Combo_TIPO = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupPROGRESS = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_PROVEEDOR = New System.Windows.Forms.TextBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6.SuspendLayout()
        Me.GroupPROGRESS.SuspendLayout()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Combo_TIPO)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Location = New System.Drawing.Point(352, 29)
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
        Me.C1_DETALLE.AllowEditing = False
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
        Me.C1_DETALLE.Size = New System.Drawing.Size(1044, 448)
        Me.C1_DETALLE.StyleInfo = resources.GetString("C1_DETALLE.StyleInfo")
        Me.C1_DETALLE.TabIndex = 26
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
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1043, 59)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_PROVEEDOR)
        Me.GroupBox4.Controls.Add(Me.picturebox1)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 87)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(441, 62)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proveedores"
        '
        'TXT_PROVEEDOR
        '
        Me.TXT_PROVEEDOR.Location = New System.Drawing.Point(6, 28)
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
        Me.picturebox1.Location = New System.Drawing.Point(391, 19)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 37
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(311, 172)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(107, 172)
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
        Me.GroupBox5.Location = New System.Drawing.Point(29, 30)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 49)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Fecha"
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(161, 19)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(30, 19)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
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
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightYellow
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(20, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 213)
        Me.Panel1.TabIndex = 24
        Me.Panel1.Visible = False
        '
        'Consultar_Compras_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1059, 537)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Consultar_Compras_Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Compras"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupPROGRESS.ResumeLayout(False)
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Combo_TIPO As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupPROGRESS As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_PROVEEDOR As TextBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuadro_Ajustes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuadro_Ajustes))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.LBL_CANT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LBL_TOTAL_S = New System.Windows.Forms.Label()
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DT_INI = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TXT_TANQUE = New System.Windows.Forms.TextBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Image = Global.Market.My.Resources.Resources.excel
        Me.Button11.Location = New System.Drawing.Point(921, 16)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(51, 36)
        Me.Button11.TabIndex = 33
        Me.Button11.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DBLISTAR)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(993, 355)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = resources.GetString("DBLISTAR.ColumnInfo")
        Me.DBLISTAR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DBLISTAR.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(3, 16)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DBLISTAR.Size = New System.Drawing.Size(987, 336)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 12
        '
        'LBL_CANT
        '
        Me.LBL_CANT.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LBL_CANT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_CANT.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CANT.Location = New System.Drawing.Point(628, 32)
        Me.LBL_CANT.Name = "LBL_CANT"
        Me.LBL_CANT.Size = New System.Drawing.Size(90, 19)
        Me.LBL_CANT.TabIndex = 48
        Me.LBL_CANT.Text = "0.0"
        Me.LBL_CANT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(628, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Cantidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LBL_CANT)
        Me.GroupBox12.Controls.Add(Me.Label1)
        Me.GroupBox12.Controls.Add(Me.Label22)
        Me.GroupBox12.Controls.Add(Me.LBL_TOTAL_S)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox12.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(0, 433)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1010, 81)
        Me.GroupBox12.TabIndex = 74
        Me.GroupBox12.TabStop = False
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(719, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(90, 16)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Total"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_TOTAL_S
        '
        Me.LBL_TOTAL_S.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.LBL_TOTAL_S.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_TOTAL_S.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTAL_S.Location = New System.Drawing.Point(719, 32)
        Me.LBL_TOTAL_S.Name = "LBL_TOTAL_S"
        Me.LBL_TOTAL_S.Size = New System.Drawing.Size(90, 19)
        Me.LBL_TOTAL_S.TabIndex = 33
        Me.LBL_TOTAL_S.Text = "0.0"
        Me.LBL_TOTAL_S.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(151, 19)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(94, 20)
        Me.DT_FIN.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(122, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Al"
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(22, 19)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(94, 20)
        Me.DT_INI.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Market.My.Resources.Resources.FOLDER
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(7, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Filtros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(252, 185)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Cancelar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(79, 185)
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
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(267, 47)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Rango"
        '
        'TXT_TANQUE
        '
        Me.TXT_TANQUE.Location = New System.Drawing.Point(6, 19)
        Me.TXT_TANQUE.Name = "TXT_TANQUE"
        Me.TXT_TANQUE.ReadOnly = True
        Me.TXT_TANQUE.Size = New System.Drawing.Size(379, 20)
        Me.TXT_TANQUE.TabIndex = 4
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(391, 11)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 37
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_TANQUE)
        Me.GroupBox4.Controls.Add(Me.picturebox1)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 85)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(429, 56)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Articulo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(15, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 218)
        Me.Panel1.TabIndex = 73
        Me.Panel1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 59)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button16.Location = New System.Drawing.Point(102, 9)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(76, 43)
        Me.Button16.TabIndex = 41
        Me.Button16.Text = "Consultar"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Cuadro_Ajustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1010, 514)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Cuadro_Ajustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadro de Ajustes"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button16 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents LBL_CANT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents LBL_TOTAL_S As Label
    Friend WithEvents DT_FIN As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents DT_INI As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TXT_TANQUE As TextBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
End Class

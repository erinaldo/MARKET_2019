<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Articulos))
        Me.CHK_SALDO = New System.Windows.Forms.CheckBox()
        Me.COMBO_SUBF = New System.Windows.Forms.ComboBox()
        Me.Combo_FAMILIA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DLG = New System.Windows.Forms.SaveFileDialog()
        Me.C1_ALMACEN = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TXT_PROV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXT_LINEA = New System.Windows.Forms.TextBox()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CmbCriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDatoBuscado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button_Almacen = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1_ALMACEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CHK_SALDO
        '
        Me.CHK_SALDO.AutoSize = True
        Me.CHK_SALDO.Checked = True
        Me.CHK_SALDO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_SALDO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SALDO.Location = New System.Drawing.Point(774, 60)
        Me.CHK_SALDO.Name = "CHK_SALDO"
        Me.CHK_SALDO.Size = New System.Drawing.Size(102, 17)
        Me.CHK_SALDO.TabIndex = 33
        Me.CHK_SALDO.Text = "Solo con Saldo"
        Me.CHK_SALDO.UseVisualStyleBackColor = True
        '
        'COMBO_SUBF
        '
        Me.COMBO_SUBF.FormattingEnabled = True
        Me.COMBO_SUBF.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.COMBO_SUBF.Location = New System.Drawing.Point(449, 12)
        Me.COMBO_SUBF.Name = "COMBO_SUBF"
        Me.COMBO_SUBF.Size = New System.Drawing.Size(276, 22)
        Me.COMBO_SUBF.TabIndex = 63
        '
        'Combo_FAMILIA
        '
        Me.Combo_FAMILIA.FormattingEnabled = True
        Me.Combo_FAMILIA.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.Combo_FAMILIA.Location = New System.Drawing.Point(97, 12)
        Me.Combo_FAMILIA.Name = "Combo_FAMILIA"
        Me.Combo_FAMILIA.Size = New System.Drawing.Size(237, 22)
        Me.Combo_FAMILIA.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "SubFam :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Familia :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.COMBO_SUBF)
        Me.GroupBox2.Controls.Add(Me.Combo_FAMILIA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(163, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(795, 38)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'C1_ALMACEN
        '
        Me.C1_ALMACEN.AllowEditing = False
        Me.C1_ALMACEN.BackColor = System.Drawing.Color.White
        Me.C1_ALMACEN.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me.C1_ALMACEN.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.C1_ALMACEN.ForeColor = System.Drawing.Color.Black
        Me.C1_ALMACEN.Location = New System.Drawing.Point(6, 16)
        Me.C1_ALMACEN.Name = "C1_ALMACEN"
        Me.C1_ALMACEN.Rows.DefaultSize = 17
        Me.C1_ALMACEN.Size = New System.Drawing.Size(225, 365)
        Me.C1_ALMACEN.StyleInfo = resources.GetString("C1_ALMACEN.StyleInfo")
        Me.C1_ALMACEN.TabIndex = 12
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.C1_ALMACEN)
        Me.GroupBox6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(10, 85)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(237, 387)
        Me.GroupBox6.TabIndex = 29
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stock x Almacen"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(384, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(178, 20)
        Me.TextBox1.TabIndex = 25
        '
        'TXT_PROV
        '
        Me.TXT_PROV.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PROV.Location = New System.Drawing.Point(72, 16)
        Me.TXT_PROV.Name = "TXT_PROV"
        Me.TXT_PROV.ReadOnly = True
        Me.TXT_PROV.Size = New System.Drawing.Size(287, 20)
        Me.TXT_PROV.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Proveedor :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_Almacen)
        Me.GroupBox4.Controls.Add(Me.TXT_PROV)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 478)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(418, 49)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'TXT_LINEA
        '
        Me.TXT_LINEA.Location = New System.Drawing.Point(56, 10)
        Me.TXT_LINEA.Name = "TXT_LINEA"
        Me.TXT_LINEA.ReadOnly = True
        Me.TXT_LINEA.Size = New System.Drawing.Size(123, 20)
        Me.TXT_LINEA.TabIndex = 24
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "10,0,0,0,0,75,Columns:"
        Me.DBLISTAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.DBLISTAR.Font = New System.Drawing.Font("Arial", 6.75!)
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(253, 89)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 15
        Me.DBLISTAR.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DBLISTAR.Size = New System.Drawing.Size(705, 383)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 26
        '
        'CmbCriterioBusqueda
        '
        Me.CmbCriterioBusqueda.FormattingEnabled = True
        Me.CmbCriterioBusqueda.Location = New System.Drawing.Point(264, 11)
        Me.CmbCriterioBusqueda.Name = "CmbCriterioBusqueda"
        Me.CmbCriterioBusqueda.Size = New System.Drawing.Size(158, 21)
        Me.CmbCriterioBusqueda.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(199, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Criterio :"
        '
        'TxtDatoBuscado
        '
        Me.TxtDatoBuscado.Location = New System.Drawing.Point(61, 14)
        Me.TxtDatoBuscado.Name = "TxtDatoBuscado"
        Me.TxtDatoBuscado.Size = New System.Drawing.Size(132, 20)
        Me.TxtDatoBuscado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCriterioBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDatoBuscado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(304, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 38)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Market.My.Resources.Resources.excel
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(873, 489)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 51)
        Me.Button6.TabIndex = 30
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button_Almacen
        '
        Me.Button_Almacen.BackColor = System.Drawing.Color.Transparent
        Me.Button_Almacen.FlatAppearance.BorderSize = 0
        Me.Button_Almacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Almacen.Image = CType(resources.GetObject("Button_Almacen.Image"), System.Drawing.Image)
        Me.Button_Almacen.Location = New System.Drawing.Point(379, 11)
        Me.Button_Almacen.Name = "Button_Almacen"
        Me.Button_Almacen.Size = New System.Drawing.Size(33, 32)
        Me.Button_Almacen.TabIndex = 23
        Me.Button_Almacen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button_Almacen.UseVisualStyleBackColor = False
        '
        'Consultar_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(969, 541)
        Me.Controls.Add(Me.CHK_SALDO)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TXT_LINEA)
        Me.Controls.Add(Me.DBLISTAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Consultar_Articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Articulos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1_ALMACEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CHK_SALDO As CheckBox
    Friend WithEvents COMBO_SUBF As ComboBox
    Friend WithEvents Combo_FAMILIA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DLG As SaveFileDialog
    Friend WithEvents Button6 As Button
    Friend WithEvents C1_ALMACEN As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button_Almacen As Button
    Friend WithEvents TXT_PROV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXT_LINEA As TextBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CmbCriterioBusqueda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDatoBuscado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class

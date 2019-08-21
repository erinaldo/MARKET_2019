<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar_Doc_Emitidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Listar_Doc_Emitidos))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lbl_tot = New System.Windows.Forms.Label()
        Me.lbl_tot_moneda = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OPT_BOLETAS = New System.Windows.Forms.RadioButton()
        Me.OPT_ORDENES = New System.Windows.Forms.RadioButton()
        Me.OPT_CAJA = New System.Windows.Forms.RadioButton()
        Me.OPT_TARJETA = New System.Windows.Forms.RadioButton()
        Me.OPT_LIQ = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OPT_FACTURAS = New System.Windows.Forms.RadioButton()
        Me.C1_DOC = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1_DETALLE = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.OPT_ARTICULOS = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1_DOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'lbl_tot
        '
        Me.lbl_tot.BackColor = System.Drawing.Color.LightGray
        Me.lbl_tot.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot.Location = New System.Drawing.Point(139, 2)
        Me.lbl_tot.Name = "lbl_tot"
        Me.lbl_tot.Size = New System.Drawing.Size(109, 18)
        Me.lbl_tot.TabIndex = 4
        Me.lbl_tot.Text = "0000000.00"
        Me.lbl_tot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tot_moneda
        '
        Me.lbl_tot_moneda.BackColor = System.Drawing.Color.LightGray
        Me.lbl_tot_moneda.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot_moneda.Location = New System.Drawing.Point(99, 0)
        Me.lbl_tot_moneda.Name = "lbl_tot_moneda"
        Me.lbl_tot_moneda.Size = New System.Drawing.Size(56, 18)
        Me.lbl_tot_moneda.TabIndex = 2
        Me.lbl_tot_moneda.Text = "S/."
        Me.lbl_tot_moneda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total   "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_tot)
        Me.Panel1.Controls.Add(Me.lbl_tot_moneda)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(517, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 27)
        Me.Panel1.TabIndex = 31
        '
        'PrintDocument2
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Market.My.Resources.Resources.Imprimir
        Me.Button1.Location = New System.Drawing.Point(962, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 43)
        Me.Button1.TabIndex = 38
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button1, "Reimprimir")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Market.My.Resources.Resources.ANULAR_L
        Me.Button2.Location = New System.Drawing.Point(913, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 43)
        Me.Button2.TabIndex = 37
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.Button2, "Anular")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'OPT_BOLETAS
        '
        Me.OPT_BOLETAS.AutoSize = True
        Me.OPT_BOLETAS.Checked = True
        Me.OPT_BOLETAS.Location = New System.Drawing.Point(6, 21)
        Me.OPT_BOLETAS.Name = "OPT_BOLETAS"
        Me.OPT_BOLETAS.Size = New System.Drawing.Size(89, 26)
        Me.OPT_BOLETAS.TabIndex = 0
        Me.OPT_BOLETAS.TabStop = True
        Me.OPT_BOLETAS.Text = "Boletas"
        Me.OPT_BOLETAS.UseVisualStyleBackColor = True
        '
        'OPT_ORDENES
        '
        Me.OPT_ORDENES.AutoSize = True
        Me.OPT_ORDENES.Location = New System.Drawing.Point(282, 21)
        Me.OPT_ORDENES.Name = "OPT_ORDENES"
        Me.OPT_ORDENES.Size = New System.Drawing.Size(98, 26)
        Me.OPT_ORDENES.TabIndex = 3
        Me.OPT_ORDENES.Text = "Creditos"
        Me.OPT_ORDENES.UseVisualStyleBackColor = True
        '
        'OPT_CAJA
        '
        Me.OPT_CAJA.AutoSize = True
        Me.OPT_CAJA.Location = New System.Drawing.Point(408, 21)
        Me.OPT_CAJA.Name = "OPT_CAJA"
        Me.OPT_CAJA.Size = New System.Drawing.Size(68, 26)
        Me.OPT_CAJA.TabIndex = 2
        Me.OPT_CAJA.Text = "Caja"
        Me.OPT_CAJA.UseVisualStyleBackColor = True
        '
        'OPT_TARJETA
        '
        Me.OPT_TARJETA.AutoSize = True
        Me.OPT_TARJETA.Location = New System.Drawing.Point(649, 21)
        Me.OPT_TARJETA.Name = "OPT_TARJETA"
        Me.OPT_TARJETA.Size = New System.Drawing.Size(96, 26)
        Me.OPT_TARJETA.TabIndex = 6
        Me.OPT_TARJETA.Text = "Tarjetas"
        Me.OPT_TARJETA.UseVisualStyleBackColor = True
        '
        'OPT_LIQ
        '
        Me.OPT_LIQ.AutoSize = True
        Me.OPT_LIQ.Location = New System.Drawing.Point(505, 21)
        Me.OPT_LIQ.Name = "OPT_LIQ"
        Me.OPT_LIQ.Size = New System.Drawing.Size(124, 26)
        Me.OPT_LIQ.TabIndex = 5
        Me.OPT_LIQ.Text = "Liquidacion"
        Me.OPT_LIQ.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 639)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 36)
        Me.Panel2.TabIndex = 40
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_ARTICULOS)
        Me.GroupBox1.Controls.Add(Me.OPT_TARJETA)
        Me.GroupBox1.Controls.Add(Me.OPT_LIQ)
        Me.GroupBox1.Controls.Add(Me.OPT_ORDENES)
        Me.GroupBox1.Controls.Add(Me.OPT_CAJA)
        Me.GroupBox1.Controls.Add(Me.OPT_FACTURAS)
        Me.GroupBox1.Controls.Add(Me.OPT_BOLETAS)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 57)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'OPT_FACTURAS
        '
        Me.OPT_FACTURAS.AutoSize = True
        Me.OPT_FACTURAS.Location = New System.Drawing.Point(141, 21)
        Me.OPT_FACTURAS.Name = "OPT_FACTURAS"
        Me.OPT_FACTURAS.Size = New System.Drawing.Size(101, 26)
        Me.OPT_FACTURAS.TabIndex = 1
        Me.OPT_FACTURAS.Text = "Facturas"
        Me.OPT_FACTURAS.UseVisualStyleBackColor = True
        '
        'C1_DOC
        '
        Me.C1_DOC.AllowEditing = False
        Me.C1_DOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1_DOC.BackColor = System.Drawing.Color.White
        Me.C1_DOC.ColumnInfo = "1,0,0,0,0,115,Columns:0{StyleFixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1_DOC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C1_DOC.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.C1_DOC.Location = New System.Drawing.Point(12, 69)
        Me.C1_DOC.Name = "C1_DOC"
        Me.C1_DOC.Rows.DefaultSize = 23
        Me.C1_DOC.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1_DOC.ShowSortPosition = C1.Win.C1FlexGrid.ShowSortPositionEnum.None
        Me.C1_DOC.Size = New System.Drawing.Size(1004, 558)
        Me.C1_DOC.StyleInfo = resources.GetString("C1_DOC.StyleInfo")
        Me.C1_DOC.TabIndex = 39
        '
        'C1_DETALLE
        '
        Me.C1_DETALLE.AllowEditing = False
        Me.C1_DETALLE.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.C1_DETALLE.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1_DETALLE.BackColor = System.Drawing.Color.Transparent
        Me.C1_DETALLE.ColumnInfo = resources.GetString("C1_DETALLE.ColumnInfo")
        Me.C1_DETALLE.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.C1_DETALLE.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.C1_DETALLE.Location = New System.Drawing.Point(11, 69)
        Me.C1_DETALLE.Name = "C1_DETALLE"
        Me.C1_DETALLE.Rows.DefaultSize = 23
        Me.C1_DETALLE.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.C1_DETALLE.Size = New System.Drawing.Size(1006, 559)
        Me.C1_DETALLE.StyleInfo = resources.GetString("C1_DETALLE.StyleInfo")
        Me.C1_DETALLE.TabIndex = 36
        '
        'OPT_ARTICULOS
        '
        Me.OPT_ARTICULOS.AutoSize = True
        Me.OPT_ARTICULOS.Location = New System.Drawing.Point(774, 21)
        Me.OPT_ARTICULOS.Name = "OPT_ARTICULOS"
        Me.OPT_ARTICULOS.Size = New System.Drawing.Size(102, 26)
        Me.OPT_ARTICULOS.TabIndex = 7
        Me.OPT_ARTICULOS.Text = "Articulos"
        Me.OPT_ARTICULOS.UseVisualStyleBackColor = True
        '
        'Listar_Doc_Emitidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 675)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1_DOC)
        Me.Controls.Add(Me.C1_DETALLE)
        Me.Name = "Listar_Doc_Emitidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Documentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1_DOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1_DETALLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents lbl_tot As Label
    Friend WithEvents lbl_tot_moneda As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OPT_BOLETAS As RadioButton
    Friend WithEvents OPT_ORDENES As RadioButton
    Friend WithEvents OPT_CAJA As RadioButton
    Friend WithEvents OPT_TARJETA As RadioButton
    Friend WithEvents OPT_LIQ As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OPT_FACTURAS As RadioButton
    Friend WithEvents C1_DOC As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1_DETALLE As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents OPT_ARTICULOS As RadioButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pago_Tarjeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pago_Tarjeta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_mon = New System.Windows.Forms.Label()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_MONTO = New System.Windows.Forms.Label()
        Me.List_TARJETA = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_TARJETA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combo_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_mon)
        Me.GroupBox1.Controls.Add(Me.TXT_TC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LBL_MONTO)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(185, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 61)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monto a Pagar"
        '
        'lbl_mon
        '
        Me.lbl_mon.AutoSize = True
        Me.lbl_mon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_mon.Location = New System.Drawing.Point(17, 29)
        Me.lbl_mon.Name = "lbl_mon"
        Me.lbl_mon.Size = New System.Drawing.Size(22, 19)
        Me.lbl_mon.TabIndex = 4
        Me.lbl_mon.Text = "S/"
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(207, 29)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.ReadOnly = True
        Me.TXT_TC.Size = New System.Drawing.Size(84, 26)
        Me.TXT_TC.TabIndex = 3
        Me.TXT_TC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(161, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "T.C. :"
        '
        'LBL_MONTO
        '
        Me.LBL_MONTO.AutoSize = True
        Me.LBL_MONTO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_MONTO.Location = New System.Drawing.Point(54, 29)
        Me.LBL_MONTO.Name = "LBL_MONTO"
        Me.LBL_MONTO.Size = New System.Drawing.Size(55, 19)
        Me.LBL_MONTO.TabIndex = 0
        Me.LBL_MONTO.Text = "Label1"
        '
        'List_TARJETA
        '
        Me.List_TARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_TARJETA.FormattingEnabled = True
        Me.List_TARJETA.ItemHeight = 16
        Me.List_TARJETA.Location = New System.Drawing.Point(1, 3)
        Me.List_TARJETA.Name = "List_TARJETA"
        Me.List_TARJETA.Size = New System.Drawing.Size(178, 276)
        Me.List_TARJETA.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_TARJETA)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Combo_MONEDA)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(185, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 119)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'TXT_TARJETA
        '
        Me.TXT_TARJETA.Location = New System.Drawing.Point(64, 65)
        Me.TXT_TARJETA.Name = "TXT_TARJETA"
        Me.TXT_TARJETA.Size = New System.Drawing.Size(226, 26)
        Me.TXT_TARJETA.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nro. :"
        '
        'Combo_MONEDA
        '
        Me.Combo_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_MONEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_MONEDA.FormattingEnabled = True
        Me.Combo_MONEDA.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.Combo_MONEDA.Location = New System.Drawing.Point(95, 22)
        Me.Combo_MONEDA.Name = "Combo_MONEDA"
        Me.Combo_MONEDA.Size = New System.Drawing.Size(168, 28)
        Me.Combo_MONEDA.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Moneda :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(367, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 32)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(233, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aceptar (F7)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "teclado_windows.jpg"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(408, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 51)
        Me.Button3.TabIndex = 50
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
        'Pago_Tarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(494, 312)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.List_TARJETA)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Pago_Tarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago con Tarjeta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_mon As System.Windows.Forms.Label
    Friend WithEvents TXT_TC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBL_MONTO As System.Windows.Forms.Label
    Friend WithEvents List_TARJETA As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Combo_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_TARJETA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList2 As ImageList
End Class

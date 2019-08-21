<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capital
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_VALORIZADO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_XPAGAR = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_XCOBRAR = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CAJAS = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_BANCOS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_VTA_PCOMPRA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(303, 153)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(22, 15)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "(+)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(303, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 15)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "(-)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(300, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "(+)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(300, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "(+)"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(154, 231)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(130, 22)
        Me.TXT_TOTAL.TabIndex = 14
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(93, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total :"
        '
        'TXT_VALORIZADO
        '
        Me.TXT_VALORIZADO.Location = New System.Drawing.Point(154, 150)
        Me.TXT_VALORIZADO.Name = "TXT_VALORIZADO"
        Me.TXT_VALORIZADO.ReadOnly = True
        Me.TXT_VALORIZADO.Size = New System.Drawing.Size(130, 22)
        Me.TXT_VALORIZADO.TabIndex = 12
        Me.TXT_VALORIZADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Inv. Valorizado :"
        '
        'TXT_XPAGAR
        '
        Me.TXT_XPAGAR.Location = New System.Drawing.Point(154, 119)
        Me.TXT_XPAGAR.Name = "TXT_XPAGAR"
        Me.TXT_XPAGAR.ReadOnly = True
        Me.TXT_XPAGAR.Size = New System.Drawing.Size(130, 22)
        Me.TXT_XPAGAR.TabIndex = 10
        Me.TXT_XPAGAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "x Pagar :"
        '
        'TXT_XCOBRAR
        '
        Me.TXT_XCOBRAR.Location = New System.Drawing.Point(154, 84)
        Me.TXT_XCOBRAR.Name = "TXT_XCOBRAR"
        Me.TXT_XCOBRAR.ReadOnly = True
        Me.TXT_XCOBRAR.Size = New System.Drawing.Size(130, 22)
        Me.TXT_XCOBRAR.TabIndex = 8
        Me.TXT_XCOBRAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "x Cobrar :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DT_FECHA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 59)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(230, 19)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(100, 22)
        Me.DT_FECHA.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(180, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha :"
        '
        'TXT_CAJAS
        '
        Me.TXT_CAJAS.Location = New System.Drawing.Point(154, 56)
        Me.TXT_CAJAS.Name = "TXT_CAJAS"
        Me.TXT_CAJAS.ReadOnly = True
        Me.TXT_CAJAS.Size = New System.Drawing.Size(130, 22)
        Me.TXT_CAJAS.TabIndex = 4
        Me.TXT_CAJAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cajas :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TXT_VTA_PCOMPRA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXT_BANCOS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_VALORIZADO)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXT_XPAGAR)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TXT_XCOBRAR)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TXT_CAJAS)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 274)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(300, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "(+)"
        '
        'TXT_BANCOS
        '
        Me.TXT_BANCOS.Location = New System.Drawing.Point(154, 27)
        Me.TXT_BANCOS.Name = "TXT_BANCOS"
        Me.TXT_BANCOS.ReadOnly = True
        Me.TXT_BANCOS.Size = New System.Drawing.Size(130, 22)
        Me.TXT_BANCOS.TabIndex = 22
        Me.TXT_BANCOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Bancos :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Vtas x PCompra :"
        '
        'TXT_VTA_PCOMPRA
        '
        Me.TXT_VTA_PCOMPRA.Location = New System.Drawing.Point(154, 181)
        Me.TXT_VTA_PCOMPRA.Name = "TXT_VTA_PCOMPRA"
        Me.TXT_VTA_PCOMPRA.ReadOnly = True
        Me.TXT_VTA_PCOMPRA.Size = New System.Drawing.Size(130, 22)
        Me.TXT_VTA_PCOMPRA.TabIndex = 25
        Me.TXT_VTA_PCOMPRA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(303, 184)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "(+)"
        '
        'Capital
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(439, 374)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Capital"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capital"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TXT_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_VALORIZADO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_XPAGAR As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_XCOBRAR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_CAJAS As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_BANCOS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_VTA_PCOMPRA As TextBox
    Friend WithEvents Label5 As Label
End Class

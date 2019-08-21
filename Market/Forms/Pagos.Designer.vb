<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagos))
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TXT_OBS = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_SALDO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TXT_TC = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.OPT_SOLES = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Combo_FPAGO = New System.Windows.Forms.ComboBox()
        Me.Combo_BANCO = New System.Windows.Forms.ComboBox()
        Me.Combo_CTA_BANCARIA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_REFERENCIA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OPT_DOLARES = New System.Windows.Forms.RadioButton()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.TXT_DOC = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TXT_OBS)
        Me.GroupBox8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(9, 173)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(616, 47)
        Me.GroupBox8.TabIndex = 44
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Observacion"
        '
        'TXT_OBS
        '
        Me.TXT_OBS.Location = New System.Drawing.Point(6, 19)
        Me.TXT_OBS.Name = "TXT_OBS"
        Me.TXT_OBS.Size = New System.Drawing.Size(596, 20)
        Me.TXT_OBS.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXT_SALDO)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 47)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Deuda"
        '
        'TXT_SALDO
        '
        Me.TXT_SALDO.ForeColor = System.Drawing.Color.Red
        Me.TXT_SALDO.Location = New System.Drawing.Point(229, 16)
        Me.TXT_SALDO.Name = "TXT_SALDO"
        Me.TXT_SALDO.ReadOnly = True
        Me.TXT_SALDO.Size = New System.Drawing.Size(105, 20)
        Me.TXT_SALDO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total :"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(52, 16)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(105, 20)
        Me.TXT_TOTAL.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TXT_TC)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(467, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(158, 47)
        Me.GroupBox5.TabIndex = 41
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo de Cambio"
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(28, 19)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.Size = New System.Drawing.Size(105, 20)
        Me.TXT_TC.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DBLISTAR)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(10, 246)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(615, 159)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'DBLISTAR
        '
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "3,0,0,0,0,85,Columns:0{Caption:""Codigo"";StyleFixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{" &
    "Caption:""OT"";StyleFixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Porcentaje"";Style" &
    "Fixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.DBLISTAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold)
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(6, 14)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DBLISTAR.Size = New System.Drawing.Size(603, 134)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 29
        '
        'OPT_SOLES
        '
        Me.OPT_SOLES.AutoSize = True
        Me.OPT_SOLES.Checked = True
        Me.OPT_SOLES.Location = New System.Drawing.Point(15, 20)
        Me.OPT_SOLES.Name = "OPT_SOLES"
        Me.OPT_SOLES.Size = New System.Drawing.Size(53, 17)
        Me.OPT_SOLES.TabIndex = 4
        Me.OPT_SOLES.TabStop = True
        Me.OPT_SOLES.Text = "Soles"
        Me.OPT_SOLES.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(178, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(378, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Combo_FPAGO)
        Me.GroupBox7.Controls.Add(Me.Combo_BANCO)
        Me.GroupBox7.Controls.Add(Me.Combo_CTA_BANCARIA)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.TXT_REFERENCIA)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(9, 111)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(616, 59)
        Me.GroupBox7.TabIndex = 43
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Forma de Pago"
        '
        'Combo_FPAGO
        '
        Me.Combo_FPAGO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_FPAGO.FormattingEnabled = True
        Me.Combo_FPAGO.Location = New System.Drawing.Point(10, 29)
        Me.Combo_FPAGO.Name = "Combo_FPAGO"
        Me.Combo_FPAGO.Size = New System.Drawing.Size(148, 21)
        Me.Combo_FPAGO.TabIndex = 0
        '
        'Combo_BANCO
        '
        Me.Combo_BANCO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_BANCO.FormattingEnabled = True
        Me.Combo_BANCO.Items.AddRange(New Object() {"Efectivo", "Cheque", "Deposito", "Nota de Credito"})
        Me.Combo_BANCO.Location = New System.Drawing.Point(164, 29)
        Me.Combo_BANCO.Name = "Combo_BANCO"
        Me.Combo_BANCO.Size = New System.Drawing.Size(150, 21)
        Me.Combo_BANCO.TabIndex = 1
        '
        'Combo_CTA_BANCARIA
        '
        Me.Combo_CTA_BANCARIA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_CTA_BANCARIA.FormattingEnabled = True
        Me.Combo_CTA_BANCARIA.Items.AddRange(New Object() {"Efectivo", "Cheque", "Deposito", "Nota de Credito"})
        Me.Combo_CTA_BANCARIA.Location = New System.Drawing.Point(320, 28)
        Me.Combo_CTA_BANCARIA.Name = "Combo_CTA_BANCARIA"
        Me.Combo_CTA_BANCARIA.Size = New System.Drawing.Size(190, 21)
        Me.Combo_CTA_BANCARIA.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(394, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cuenta"
        '
        'TXT_REFERENCIA
        '
        Me.TXT_REFERENCIA.ForeColor = System.Drawing.Color.Red
        Me.TXT_REFERENCIA.Location = New System.Drawing.Point(516, 29)
        Me.TXT_REFERENCIA.Name = "TXT_REFERENCIA"
        Me.TXT_REFERENCIA.Size = New System.Drawing.Size(94, 20)
        Me.TXT_REFERENCIA.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nro. Referencia"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(227, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Banco"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OPT_DOLARES)
        Me.GroupBox6.Controls.Add(Me.OPT_SOLES)
        Me.GroupBox6.Controls.Add(Me.TXT_MONTO)
        Me.GroupBox6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(363, 58)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(262, 47)
        Me.GroupBox6.TabIndex = 42
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Monto a Pagar"
        '
        'OPT_DOLARES
        '
        Me.OPT_DOLARES.AutoSize = True
        Me.OPT_DOLARES.Location = New System.Drawing.Point(74, 20)
        Me.OPT_DOLARES.Name = "OPT_DOLARES"
        Me.OPT_DOLARES.Size = New System.Drawing.Size(65, 17)
        Me.OPT_DOLARES.TabIndex = 5
        Me.OPT_DOLARES.Text = "Dolares"
        Me.OPT_DOLARES.UseVisualStyleBackColor = True
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.ForeColor = System.Drawing.Color.Red
        Me.TXT_MONTO.Location = New System.Drawing.Point(143, 19)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(105, 20)
        Me.TXT_MONTO.TabIndex = 3
        '
        'TXT_DOC
        '
        Me.TXT_DOC.Location = New System.Drawing.Point(6, 19)
        Me.TXT_DOC.Name = "TXT_DOC"
        Me.TXT_DOC.ReadOnly = True
        Me.TXT_DOC.Size = New System.Drawing.Size(142, 20)
        Me.TXT_DOC.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DT_FECHA)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(246, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 47)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fecha de Pago"
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(27, 18)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(105, 20)
        Me.DT_FECHA.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_DOC)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 47)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(635, 410)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TXT_OBS As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_SALDO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TXT_TC As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents OPT_SOLES As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Combo_FPAGO As ComboBox
    Friend WithEvents Combo_BANCO As ComboBox
    Friend WithEvents Combo_CTA_BANCARIA As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_REFERENCIA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents OPT_DOLARES As RadioButton
    Friend WithEvents TXT_MONTO As TextBox
    Friend WithEvents TXT_DOC As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DT_FECHA As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
End Class

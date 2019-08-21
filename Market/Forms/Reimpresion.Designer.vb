<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reimpresion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.TXT_NUM_FIN = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXT_IGV = New System.Windows.Forms.TextBox
        Me.TXT_VVENTA = New System.Windows.Forms.TextBox
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXT_DIRECCION = New System.Windows.Forms.TextBox
        Me.TXT_RAZON = New System.Windows.Forms.TextBox
        Me.TXT_RUC = New System.Windows.Forms.TextBox
        Me.TXT_CODCLIE = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.TXT_NUM = New System.Windows.Forms.TextBox
        Me.Combo_DOC = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker
        Me.TXT_CAJA = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TXT_TURNO = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.picturebox1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Opt_Impresora = New System.Windows.Forms.RadioButton
        Me.Opt_Pantalla = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.TXT_NUM_FIN)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_IGV)
        Me.GroupBox1.Controls.Add(Me.TXT_VVENTA)
        Me.GroupBox1.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_DIRECCION)
        Me.GroupBox1.Controls.Add(Me.TXT_RAZON)
        Me.GroupBox1.Controls.Add(Me.TXT_RUC)
        Me.GroupBox1.Controls.Add(Me.TXT_CODCLIE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TXT_NUM)
        Me.GroupBox1.Controls.Add(Me.Combo_DOC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 205)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documento"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button5.Location = New System.Drawing.Point(298, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 28)
        Me.Button5.TabIndex = 48
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TXT_NUM_FIN
        '
        Me.TXT_NUM_FIN.Enabled = False
        Me.TXT_NUM_FIN.Location = New System.Drawing.Point(177, 53)
        Me.TXT_NUM_FIN.Name = "TXT_NUM_FIN"
        Me.TXT_NUM_FIN.Size = New System.Drawing.Size(115, 20)
        Me.TXT_NUM_FIN.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Igv"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Base"
        '
        'TXT_IGV
        '
        Me.TXT_IGV.Enabled = False
        Me.TXT_IGV.Location = New System.Drawing.Point(157, 179)
        Me.TXT_IGV.Name = "TXT_IGV"
        Me.TXT_IGV.Size = New System.Drawing.Size(87, 20)
        Me.TXT_IGV.TabIndex = 44
        '
        'TXT_VVENTA
        '
        Me.TXT_VVENTA.Enabled = False
        Me.TXT_VVENTA.Location = New System.Drawing.Point(64, 179)
        Me.TXT_VVENTA.Name = "TXT_VVENTA"
        Me.TXT_VVENTA.Size = New System.Drawing.Size(87, 20)
        Me.TXT_VVENTA.TabIndex = 43
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Enabled = False
        Me.TXT_TOTAL.Location = New System.Drawing.Point(250, 179)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(87, 20)
        Me.TXT_TOTAL.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(273, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Total "
        '
        'TXT_DIRECCION
        '
        Me.TXT_DIRECCION.Enabled = False
        Me.TXT_DIRECCION.Location = New System.Drawing.Point(64, 140)
        Me.TXT_DIRECCION.Name = "TXT_DIRECCION"
        Me.TXT_DIRECCION.Size = New System.Drawing.Size(273, 20)
        Me.TXT_DIRECCION.TabIndex = 40
        '
        'TXT_RAZON
        '
        Me.TXT_RAZON.Enabled = False
        Me.TXT_RAZON.Location = New System.Drawing.Point(64, 114)
        Me.TXT_RAZON.Name = "TXT_RAZON"
        Me.TXT_RAZON.Size = New System.Drawing.Size(273, 20)
        Me.TXT_RAZON.TabIndex = 39
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Enabled = False
        Me.TXT_RUC.Location = New System.Drawing.Point(138, 88)
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(132, 20)
        Me.TXT_RUC.TabIndex = 38
        '
        'TXT_CODCLIE
        '
        Me.TXT_CODCLIE.Enabled = False
        Me.TXT_CODCLIE.Location = New System.Drawing.Point(64, 88)
        Me.TXT_CODCLIE.Name = "TXT_CODCLIE"
        Me.TXT_CODCLIE.Size = New System.Drawing.Size(68, 20)
        Me.TXT_CODCLIE.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Cliente :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 35
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button3.Location = New System.Drawing.Point(126, 48)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(33, 28)
        Me.Button3.TabIndex = 34
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TXT_NUM
        '
        Me.TXT_NUM.Enabled = False
        Me.TXT_NUM.Location = New System.Drawing.Point(9, 53)
        Me.TXT_NUM.Name = "TXT_NUM"
        Me.TXT_NUM.Size = New System.Drawing.Size(111, 20)
        Me.TXT_NUM.TabIndex = 30
        '
        'Combo_DOC
        '
        Me.Combo_DOC.FormattingEnabled = True
        Me.Combo_DOC.Location = New System.Drawing.Point(94, 19)
        Me.Combo_DOC.Name = "Combo_DOC"
        Me.Combo_DOC.Size = New System.Drawing.Size(176, 21)
        Me.Combo_DOC.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Caja :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Turno :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(127, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(143, 55)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(119, 20)
        Me.TXT_FECHA.TabIndex = 46
        '
        'TXT_CAJA
        '
        Me.TXT_CAJA.Enabled = False
        Me.TXT_CAJA.Location = New System.Drawing.Point(143, 12)
        Me.TXT_CAJA.Name = "TXT_CAJA"
        Me.TXT_CAJA.Size = New System.Drawing.Size(119, 20)
        Me.TXT_CAJA.TabIndex = 41
        Me.TXT_CAJA.Text = "MARKET"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(21, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TXT_TURNO
        '
        Me.TXT_TURNO.Location = New System.Drawing.Point(143, 98)
        Me.TXT_TURNO.Name = "TXT_TURNO"
        Me.TXT_TURNO.Size = New System.Drawing.Size(119, 20)
        Me.TXT_TURNO.TabIndex = 42
        Me.TXT_TURNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(238, 390)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 27)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Anular"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(277, 12)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 45
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Opt_Impresora)
        Me.GroupBox2.Controls.Add(Me.Opt_Pantalla)
        Me.GroupBox2.Location = New System.Drawing.Point(58, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 49)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        '
        'Opt_Impresora
        '
        Me.Opt_Impresora.AutoSize = True
        Me.Opt_Impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Impresora.Location = New System.Drawing.Point(133, 20)
        Me.Opt_Impresora.Name = "Opt_Impresora"
        Me.Opt_Impresora.Size = New System.Drawing.Size(80, 17)
        Me.Opt_Impresora.TabIndex = 1
        Me.Opt_Impresora.Text = "Impresora"
        Me.Opt_Impresora.UseVisualStyleBackColor = True
        '
        'Opt_Pantalla
        '
        Me.Opt_Pantalla.AutoSize = True
        Me.Opt_Pantalla.Checked = True
        Me.Opt_Pantalla.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Pantalla.Location = New System.Drawing.Point(26, 20)
        Me.Opt_Pantalla.Name = "Opt_Pantalla"
        Me.Opt_Pantalla.Size = New System.Drawing.Size(71, 17)
        Me.Opt_Pantalla.TabIndex = 0
        Me.Opt_Pantalla.TabStop = True
        Me.Opt_Pantalla.Text = "Pantalla"
        Me.Opt_Pantalla.UseVisualStyleBackColor = True
        '
        'Reimpresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(361, 429)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.picturebox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.TXT_CAJA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_TURNO)
        Me.Controls.Add(Me.Button4)
        Me.MaximizeBox = False
        Me.Name = "Reimpresion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimpresion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TXT_NUM_FIN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_IGV As System.Windows.Forms.TextBox
    Friend WithEvents TXT_VVENTA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TXT_RAZON As System.Windows.Forms.TextBox
    Friend WithEvents TXT_RUC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CODCLIE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TXT_NUM As System.Windows.Forms.TextBox
    Friend WithEvents Combo_DOC As System.Windows.Forms.ComboBox
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TXT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_CAJA As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TXT_TURNO As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Opt_Impresora As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Pantalla As System.Windows.Forms.RadioButton
End Class

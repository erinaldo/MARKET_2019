<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movi_Caja
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
        Me.GroupBox_TIPO = New System.Windows.Forms.GroupBox()
        Me.OPT_SAL = New System.Windows.Forms.RadioButton()
        Me.OPT_ING = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_MOTIVO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_MONTO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Combo_MONEDA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CHK_TRANSF = New System.Windows.Forms.CheckBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox_TIPO.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox_TIPO
        '
        Me.GroupBox_TIPO.Controls.Add(Me.OPT_SAL)
        Me.GroupBox_TIPO.Controls.Add(Me.OPT_ING)
        Me.GroupBox_TIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_TIPO.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox_TIPO.Name = "GroupBox_TIPO"
        Me.GroupBox_TIPO.Size = New System.Drawing.Size(346, 54)
        Me.GroupBox_TIPO.TabIndex = 0
        Me.GroupBox_TIPO.TabStop = False
        Me.GroupBox_TIPO.Visible = False
        '
        'OPT_SAL
        '
        Me.OPT_SAL.AutoSize = True
        Me.OPT_SAL.Checked = True
        Me.OPT_SAL.Location = New System.Drawing.Point(184, 20)
        Me.OPT_SAL.Name = "OPT_SAL"
        Me.OPT_SAL.Size = New System.Drawing.Size(119, 19)
        Me.OPT_SAL.TabIndex = 1
        Me.OPT_SAL.TabStop = True
        Me.OPT_SAL.Text = "Salida de Caja"
        Me.OPT_SAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OPT_SAL.UseVisualStyleBackColor = True
        '
        'OPT_ING
        '
        Me.OPT_ING.AutoSize = True
        Me.OPT_ING.Location = New System.Drawing.Point(6, 20)
        Me.OPT_ING.Name = "OPT_ING"
        Me.OPT_ING.Size = New System.Drawing.Size(118, 19)
        Me.OPT_ING.TabIndex = 0
        Me.OPT_ING.Text = "Ingreso a Caja"
        Me.OPT_ING.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_MOTIVO)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TXT_MONTO)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Combo_MONEDA)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TXT_MOTIVO
        '
        Me.TXT_MOTIVO.Location = New System.Drawing.Point(116, 88)
        Me.TXT_MOTIVO.Multiline = True
        Me.TXT_MOTIVO.Name = "TXT_MOTIVO"
        Me.TXT_MOTIVO.Size = New System.Drawing.Size(224, 58)
        Me.TXT_MOTIVO.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Motivo :"
        '
        'TXT_MONTO
        '
        Me.TXT_MONTO.Location = New System.Drawing.Point(116, 48)
        Me.TXT_MONTO.Name = "TXT_MONTO"
        Me.TXT_MONTO.Size = New System.Drawing.Size(140, 21)
        Me.TXT_MONTO.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto :"
        '
        'Combo_MONEDA
        '
        Me.Combo_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_MONEDA.FormattingEnabled = True
        Me.Combo_MONEDA.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.Combo_MONEDA.Location = New System.Drawing.Point(116, 14)
        Me.Combo_MONEDA.Name = "Combo_MONEDA"
        Me.Combo_MONEDA.Size = New System.Drawing.Size(140, 23)
        Me.Combo_MONEDA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Moneda :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(77, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(216, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CHK_TRANSF
        '
        Me.CHK_TRANSF.AutoSize = True
        Me.CHK_TRANSF.Checked = True
        Me.CHK_TRANSF.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHK_TRANSF.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_TRANSF.Location = New System.Drawing.Point(18, 233)
        Me.CHK_TRANSF.Name = "CHK_TRANSF"
        Me.CHK_TRANSF.Size = New System.Drawing.Size(140, 17)
        Me.CHK_TRANSF.TabIndex = 4
        Me.CHK_TRANSF.Text = "Transferencia Oficina"
        Me.CHK_TRANSF.UseVisualStyleBackColor = True
        Me.CHK_TRANSF.Visible = False
        '
        'PrintDocument1
        '
        '
        'Movi_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(370, 314)
        Me.Controls.Add(Me.CHK_TRANSF)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_TIPO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Movi_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Caja"
        Me.GroupBox_TIPO.ResumeLayout(False)
        Me.GroupBox_TIPO.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox_TIPO As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_SAL As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_ING As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_MOTIVO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_MONTO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CHK_TRANSF As System.Windows.Forms.CheckBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

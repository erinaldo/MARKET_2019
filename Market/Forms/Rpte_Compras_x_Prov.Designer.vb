<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpte_Compras_x_Prov
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
        Me.Button4 = New System.Windows.Forms.Button
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker
        Me.DT_INI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OPT_VENC = New System.Windows.Forms.RadioButton
        Me.OPT_COMPRA = New System.Windows.Forms.RadioButton
        Me.List_clie_orig = New System.Windows.Forms.ListBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.List_clie_destino = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OPT_DOLARES = New System.Windows.Forms.RadioButton
        Me.Opt_Soles = New System.Windows.Forms.RadioButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(288, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 35)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(204, 47)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(95, 20)
        Me.DT_FIN.TabIndex = 3
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(54, 50)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(95, 20)
        Me.DT_INI.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde :"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(385, 473)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 32)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Aceptar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_VENC)
        Me.GroupBox1.Controls.Add(Me.OPT_COMPRA)
        Me.GroupBox1.Controls.Add(Me.DT_FIN)
        Me.GroupBox1.Controls.Add(Me.DT_INI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 416)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 86)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'OPT_VENC
        '
        Me.OPT_VENC.AutoSize = True
        Me.OPT_VENC.Location = New System.Drawing.Point(158, 19)
        Me.OPT_VENC.Name = "OPT_VENC"
        Me.OPT_VENC.Size = New System.Drawing.Size(131, 17)
        Me.OPT_VENC.TabIndex = 5
        Me.OPT_VENC.Text = "Fecha de Vencimiento"
        Me.OPT_VENC.UseVisualStyleBackColor = True
        '
        'OPT_COMPRA
        '
        Me.OPT_COMPRA.AutoSize = True
        Me.OPT_COMPRA.Checked = True
        Me.OPT_COMPRA.Location = New System.Drawing.Point(21, 19)
        Me.OPT_COMPRA.Name = "OPT_COMPRA"
        Me.OPT_COMPRA.Size = New System.Drawing.Size(109, 17)
        Me.OPT_COMPRA.TabIndex = 4
        Me.OPT_COMPRA.TabStop = True
        Me.OPT_COMPRA.Text = "Fecha de Compra"
        Me.OPT_COMPRA.UseVisualStyleBackColor = True
        '
        'List_clie_orig
        '
        Me.List_clie_orig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_clie_orig.FormattingEnabled = True
        Me.List_clie_orig.Location = New System.Drawing.Point(6, 14)
        Me.List_clie_orig.Name = "List_clie_orig"
        Me.List_clie_orig.Size = New System.Drawing.Size(251, 368)
        Me.List_clie_orig.TabIndex = 1
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(500, 473)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 32)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(288, 195)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 35)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(288, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 35)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(288, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.List_clie_destino)
        Me.GroupBox3.Location = New System.Drawing.Point(358, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 406)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'List_clie_destino
        '
        Me.List_clie_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_clie_destino.FormattingEnabled = True
        Me.List_clie_destino.Location = New System.Drawing.Point(6, 14)
        Me.List_clie_destino.Name = "List_clie_destino"
        Me.List_clie_destino.Size = New System.Drawing.Size(251, 368)
        Me.List_clie_destino.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.List_clie_orig)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 406)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OPT_DOLARES)
        Me.GroupBox4.Controls.Add(Me.Opt_Soles)
        Me.GroupBox4.Location = New System.Drawing.Point(376, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(228, 51)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'OPT_DOLARES
        '
        Me.OPT_DOLARES.AutoSize = True
        Me.OPT_DOLARES.Location = New System.Drawing.Point(145, 20)
        Me.OPT_DOLARES.Name = "OPT_DOLARES"
        Me.OPT_DOLARES.Size = New System.Drawing.Size(61, 17)
        Me.OPT_DOLARES.TabIndex = 1
        Me.OPT_DOLARES.Text = "Dolares"
        Me.OPT_DOLARES.UseVisualStyleBackColor = True
        '
        'Opt_Soles
        '
        Me.Opt_Soles.AutoSize = True
        Me.Opt_Soles.Checked = True
        Me.Opt_Soles.Location = New System.Drawing.Point(20, 19)
        Me.Opt_Soles.Name = "Opt_Soles"
        Me.Opt_Soles.Size = New System.Drawing.Size(51, 17)
        Me.Opt_Soles.TabIndex = 0
        Me.Opt_Soles.TabStop = True
        Me.Opt_Soles.Text = "Soles"
        Me.Opt_Soles.UseVisualStyleBackColor = True
        '
        'Rpte_Compras_x_Prov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(627, 514)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Rpte_Compras_x_Prov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras x Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DT_FIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_INI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents List_clie_orig As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents List_clie_destino As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_DOLARES As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Soles As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_VENC As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_COMPRA As System.Windows.Forms.RadioButton
End Class

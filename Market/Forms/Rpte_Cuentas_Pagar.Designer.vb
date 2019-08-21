<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpte_Cuentas_Pagar
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
        Me.OPT_SOLES = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OPT_DETALLADO = New System.Windows.Forms.RadioButton
        Me.OPT_NORMAL = New System.Windows.Forms.RadioButton
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.List_clie_orig = New System.Windows.Forms.ListBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.OPT_DOLARES = New System.Windows.Forms.RadioButton
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.List_clie_destino = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OPT_SOLES
        '
        Me.OPT_SOLES.AutoSize = True
        Me.OPT_SOLES.Checked = True
        Me.OPT_SOLES.Location = New System.Drawing.Point(42, 20)
        Me.OPT_SOLES.Name = "OPT_SOLES"
        Me.OPT_SOLES.Size = New System.Drawing.Size(61, 19)
        Me.OPT_SOLES.TabIndex = 0
        Me.OPT_SOLES.TabStop = True
        Me.OPT_SOLES.Text = "Soles"
        Me.OPT_SOLES.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OPT_DETALLADO)
        Me.GroupBox4.Controls.Add(Me.OPT_NORMAL)
        Me.GroupBox4.Location = New System.Drawing.Point(316, 335)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(305, 58)
        Me.GroupBox4.TabIndex = 48
        Me.GroupBox4.TabStop = False
        '
        'OPT_DETALLADO
        '
        Me.OPT_DETALLADO.AutoSize = True
        Me.OPT_DETALLADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPT_DETALLADO.Location = New System.Drawing.Point(214, 21)
        Me.OPT_DETALLADO.Name = "OPT_DETALLADO"
        Me.OPT_DETALLADO.Size = New System.Drawing.Size(79, 17)
        Me.OPT_DETALLADO.TabIndex = 2
        Me.OPT_DETALLADO.Text = "Detallado"
        Me.OPT_DETALLADO.UseVisualStyleBackColor = True
        '
        'OPT_NORMAL
        '
        Me.OPT_NORMAL.AutoSize = True
        Me.OPT_NORMAL.Checked = True
        Me.OPT_NORMAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPT_NORMAL.Location = New System.Drawing.Point(51, 21)
        Me.OPT_NORMAL.Name = "OPT_NORMAL"
        Me.OPT_NORMAL.Size = New System.Drawing.Size(64, 17)
        Me.OPT_NORMAL.TabIndex = 0
        Me.OPT_NORMAL.TabStop = True
        Me.OPT_NORMAL.Text = "Normal"
        Me.OPT_NORMAL.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 316)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "Todo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'List_clie_orig
        '
        Me.List_clie_orig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_clie_orig.FormattingEnabled = True
        Me.List_clie_orig.Location = New System.Drawing.Point(6, 14)
        Me.List_clie_orig.Name = "List_clie_orig"
        Me.List_clie_orig.Size = New System.Drawing.Size(251, 277)
        Me.List_clie_orig.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.OPT_DOLARES)
        Me.GroupBox5.Controls.Add(Me.OPT_SOLES)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(5, 339)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(305, 54)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Moneda"
        '
        'OPT_DOLARES
        '
        Me.OPT_DOLARES.AutoSize = True
        Me.OPT_DOLARES.Location = New System.Drawing.Point(182, 17)
        Me.OPT_DOLARES.Name = "OPT_DOLARES"
        Me.OPT_DOLARES.Size = New System.Drawing.Size(75, 19)
        Me.OPT_DOLARES.TabIndex = 1
        Me.OPT_DOLARES.Text = "Dolares"
        Me.OPT_DOLARES.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(291, 244)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 35)
        Me.Button4.TabIndex = 45
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button6.Location = New System.Drawing.Point(337, 404)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(82, 32)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "Salir"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Location = New System.Drawing.Point(201, 404)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 32)
        Me.Button5.TabIndex = 46
        Me.Button5.Text = "Aceptar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(291, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 35)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(291, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 35)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 35)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.List_clie_destino)
        Me.GroupBox3.Location = New System.Drawing.Point(361, -4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 314)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        '
        'List_clie_destino
        '
        Me.List_clie_destino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_clie_destino.FormattingEnabled = True
        Me.List_clie_destino.Location = New System.Drawing.Point(6, 14)
        Me.List_clie_destino.Name = "List_clie_destino"
        Me.List_clie_destino.Size = New System.Drawing.Size(251, 277)
        Me.List_clie_destino.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.List_clie_orig)
        Me.GroupBox2.Location = New System.Drawing.Point(5, -4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 314)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        '
        'Rpte_Cuentas_Pagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(628, 450)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "Rpte_Cuentas_Pagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas x Pagar"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OPT_SOLES As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_DETALLADO As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_NORMAL As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents List_clie_orig As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_DOLARES As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents List_clie_destino As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class

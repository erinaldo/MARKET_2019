<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rpte_Reg_Ventas
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker
        Me.DT_INI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OPT_PRODUCTO = New System.Windows.Forms.RadioButton
        Me.OPT_DETALLADO = New System.Windows.Forms.RadioButton
        Me.OPT_GENERAL = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.OPT_DOLARES = New System.Windows.Forms.RadioButton
        Me.OPT_SOLES = New System.Windows.Forms.RadioButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(267, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(116, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DT_FIN)
        Me.GroupBox2.Controls.Add(Me.DT_INI)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 57)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de Fechas"
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(269, 25)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(119, 21)
        Me.DT_FIN.TabIndex = 3
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(82, 25)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(119, 21)
        Me.DT_INI.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_PRODUCTO)
        Me.GroupBox1.Controls.Add(Me.OPT_DETALLADO)
        Me.GroupBox1.Controls.Add(Me.OPT_GENERAL)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 57)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de Fechas"
        '
        'OPT_PRODUCTO
        '
        Me.OPT_PRODUCTO.AutoSize = True
        Me.OPT_PRODUCTO.Location = New System.Drawing.Point(301, 20)
        Me.OPT_PRODUCTO.Name = "OPT_PRODUCTO"
        Me.OPT_PRODUCTO.Size = New System.Drawing.Size(108, 19)
        Me.OPT_PRODUCTO.TabIndex = 2
        Me.OPT_PRODUCTO.Text = "Por Producto"
        Me.OPT_PRODUCTO.UseVisualStyleBackColor = True
        '
        'OPT_DETALLADO
        '
        Me.OPT_DETALLADO.AutoSize = True
        Me.OPT_DETALLADO.Location = New System.Drawing.Point(163, 20)
        Me.OPT_DETALLADO.Name = "OPT_DETALLADO"
        Me.OPT_DETALLADO.Size = New System.Drawing.Size(87, 19)
        Me.OPT_DETALLADO.TabIndex = 1
        Me.OPT_DETALLADO.Text = "Detallado"
        Me.OPT_DETALLADO.UseVisualStyleBackColor = True
        '
        'OPT_GENERAL
        '
        Me.OPT_GENERAL.AutoSize = True
        Me.OPT_GENERAL.Checked = True
        Me.OPT_GENERAL.Location = New System.Drawing.Point(24, 20)
        Me.OPT_GENERAL.Name = "OPT_GENERAL"
        Me.OPT_GENERAL.Size = New System.Drawing.Size(76, 19)
        Me.OPT_GENERAL.TabIndex = 0
        Me.OPT_GENERAL.TabStop = True
        Me.OPT_GENERAL.Text = "General"
        Me.OPT_GENERAL.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.OPT_DOLARES)
        Me.GroupBox3.Controls.Add(Me.OPT_SOLES)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(445, 57)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Moneda"
        '
        'OPT_DOLARES
        '
        Me.OPT_DOLARES.AutoSize = True
        Me.OPT_DOLARES.Location = New System.Drawing.Point(255, 20)
        Me.OPT_DOLARES.Name = "OPT_DOLARES"
        Me.OPT_DOLARES.Size = New System.Drawing.Size(75, 19)
        Me.OPT_DOLARES.TabIndex = 1
        Me.OPT_DOLARES.Text = "Dolares"
        Me.OPT_DOLARES.UseVisualStyleBackColor = True
        '
        'OPT_SOLES
        '
        Me.OPT_SOLES.AutoSize = True
        Me.OPT_SOLES.Checked = True
        Me.OPT_SOLES.Location = New System.Drawing.Point(76, 20)
        Me.OPT_SOLES.Name = "OPT_SOLES"
        Me.OPT_SOLES.Size = New System.Drawing.Size(61, 19)
        Me.OPT_SOLES.TabIndex = 0
        Me.OPT_SOLES.TabStop = True
        Me.OPT_SOLES.Text = "Soles"
        Me.OPT_SOLES.UseVisualStyleBackColor = True
        '
        'Rpte_Reg_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 221)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Rpte_Reg_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_INI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_PRODUCTO As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_DETALLADO As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_GENERAL As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_DOLARES As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_SOLES As System.Windows.Forms.RadioButton
End Class

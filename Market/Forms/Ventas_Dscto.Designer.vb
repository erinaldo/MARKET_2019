<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_Dscto
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
        Me.OPT_VALOR = New System.Windows.Forms.RadioButton
        Me.OPT_PORC = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox
        Me.TXT_DSCTO = New System.Windows.Forms.TextBox
        Me.TXT_TOT_APLICADO = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.LBLCORRELATIVO = New System.Windows.Forms.Label
        Me.LBLIDDETALLE = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_VALOR)
        Me.GroupBox1.Controls.Add(Me.OPT_PORC)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Descuento"
        '
        'OPT_VALOR
        '
        Me.OPT_VALOR.AutoSize = True
        Me.OPT_VALOR.Checked = True
        Me.OPT_VALOR.Location = New System.Drawing.Point(19, 72)
        Me.OPT_VALOR.Name = "OPT_VALOR"
        Me.OPT_VALOR.Size = New System.Drawing.Size(83, 17)
        Me.OPT_VALOR.TabIndex = 3
        Me.OPT_VALOR.TabStop = True
        Me.OPT_VALOR.Text = "Por Monto"
        Me.OPT_VALOR.UseVisualStyleBackColor = True
        '
        'OPT_PORC
        '
        Me.OPT_PORC.AutoSize = True
        Me.OPT_PORC.Location = New System.Drawing.Point(18, 33)
        Me.OPT_PORC.Name = "OPT_PORC"
        Me.OPT_PORC.Size = New System.Drawing.Size(109, 17)
        Me.OPT_PORC.TabIndex = 2
        Me.OPT_PORC.Text = "Por Porcentaje"
        Me.OPT_PORC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(288, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descuento :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Aplicado con Descuento :"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(366, 20)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(85, 20)
        Me.TXT_TOTAL.TabIndex = 4
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DSCTO
        '
        Me.TXT_DSCTO.Location = New System.Drawing.Point(366, 54)
        Me.TXT_DSCTO.Name = "TXT_DSCTO"
        Me.TXT_DSCTO.Size = New System.Drawing.Size(85, 20)
        Me.TXT_DSCTO.TabIndex = 5
        Me.TXT_DSCTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_TOT_APLICADO
        '
        Me.TXT_TOT_APLICADO.Location = New System.Drawing.Point(366, 87)
        Me.TXT_TOT_APLICADO.Name = "TXT_TOT_APLICADO"
        Me.TXT_TOT_APLICADO.ReadOnly = True
        Me.TXT_TOT_APLICADO.Size = New System.Drawing.Size(85, 20)
        Me.TXT_TOT_APLICADO.TabIndex = 6
        Me.TXT_TOT_APLICADO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(202, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(313, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LBLCORRELATIVO
        '
        Me.LBLCORRELATIVO.AutoSize = True
        Me.LBLCORRELATIVO.Location = New System.Drawing.Point(192, 13)
        Me.LBLCORRELATIVO.Name = "LBLCORRELATIVO"
        Me.LBLCORRELATIVO.Size = New System.Drawing.Size(39, 13)
        Me.LBLCORRELATIVO.TabIndex = 9
        Me.LBLCORRELATIVO.Text = "Label4"
        Me.LBLCORRELATIVO.Visible = False
        '
        'LBLIDDETALLE
        '
        Me.LBLIDDETALLE.AutoSize = True
        Me.LBLIDDETALLE.Location = New System.Drawing.Point(190, 41)
        Me.LBLIDDETALLE.Name = "LBLIDDETALLE"
        Me.LBLIDDETALLE.Size = New System.Drawing.Size(39, 13)
        Me.LBLIDDETALLE.TabIndex = 10
        Me.LBLIDDETALLE.Text = "Label5"
        Me.LBLIDDETALLE.Visible = False
        '
        'Ventas_Dscto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(469, 152)
        Me.Controls.Add(Me.LBLIDDETALLE)
        Me.Controls.Add(Me.LBLCORRELATIVO)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_TOT_APLICADO)
        Me.Controls.Add(Me.TXT_DSCTO)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ventas_Dscto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuento a Efectuar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_VALOR As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_PORC As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DSCTO As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TOT_APLICADO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LBLCORRELATIVO As System.Windows.Forms.Label
    Friend WithEvents LBLIDDETALLE As System.Windows.Forms.Label
End Class

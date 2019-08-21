<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fin_Dia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fin_Dia))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_FECHA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TXT_NUEVO = New System.Windows.Forms.TextBox()
        Me.TXT_ACTUAL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de Proceso :"
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FECHA.Location = New System.Drawing.Point(204, 34)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.ReadOnly = True
        Me.TXT_FECHA.Size = New System.Drawing.Size(175, 26)
        Me.TXT_FECHA.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 65)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(73, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(270, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TXT_NUEVO
        '
        Me.TXT_NUEVO.Enabled = False
        Me.TXT_NUEVO.Location = New System.Drawing.Point(204, 105)
        Me.TXT_NUEVO.Name = "TXT_NUEVO"
        Me.TXT_NUEVO.Size = New System.Drawing.Size(82, 20)
        Me.TXT_NUEVO.TabIndex = 8
        '
        'TXT_ACTUAL
        '
        Me.TXT_ACTUAL.Enabled = False
        Me.TXT_ACTUAL.Location = New System.Drawing.Point(204, 73)
        Me.TXT_ACTUAL.Name = "TXT_ACTUAL"
        Me.TXT_ACTUAL.Size = New System.Drawing.Size(82, 20)
        Me.TXT_ACTUAL.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nuevo Turno :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Turno Actual :"
        '
        'Fin_Dia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(442, 250)
        Me.Controls.Add(Me.TXT_NUEVO)
        Me.Controls.Add(Me.TXT_ACTUAL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Fin_Dia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fin de Dia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FECHA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TXT_NUEVO As TextBox
    Friend WithEvents TXT_ACTUAL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

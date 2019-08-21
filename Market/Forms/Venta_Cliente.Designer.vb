<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta_Cliente
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.TXT_DIREC = New System.Windows.Forms.TextBox
        Me.TXT_RUC = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TXT_DESC = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_CODCLIE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button_ANULAR = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_DIREC)
        Me.GroupBox1.Controls.Add(Me.TXT_RUC)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_DESC)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODCLIE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Direccion :"
        '
        'TXT_DIREC
        '
        Me.TXT_DIREC.Location = New System.Drawing.Point(96, 128)
        Me.TXT_DIREC.MaxLength = 11
        Me.TXT_DIREC.Multiline = True
        Me.TXT_DIREC.Name = "TXT_DIREC"
        Me.TXT_DIREC.Size = New System.Drawing.Size(308, 60)
        Me.TXT_DIREC.TabIndex = 17
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Location = New System.Drawing.Point(96, 92)
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(145, 20)
        Me.TXT_RUC.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ruc :"
        '
        'TXT_DESC
        '
        Me.TXT_DESC.Location = New System.Drawing.Point(96, 53)
        Me.TXT_DESC.Name = "TXT_DESC"
        Me.TXT_DESC.Size = New System.Drawing.Size(308, 20)
        Me.TXT_DESC.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Descripcion :"
        '
        'TXT_CODCLIE
        '
        Me.TXT_CODCLIE.Location = New System.Drawing.Point(96, 16)
        Me.TXT_CODCLIE.Name = "TXT_CODCLIE"
        Me.TXT_CODCLIE.Size = New System.Drawing.Size(145, 20)
        Me.TXT_CODCLIE.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Codigo :"
        '
        'Button_ANULAR
        '
        Me.Button_ANULAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button_ANULAR.FlatAppearance.BorderSize = 5
        Me.Button_ANULAR.Location = New System.Drawing.Point(125, 214)
        Me.Button_ANULAR.Name = "Button_ANULAR"
        Me.Button_ANULAR.Size = New System.Drawing.Size(75, 26)
        Me.Button_ANULAR.TabIndex = 6
        Me.Button_ANULAR.Text = "Grabar"
        Me.Button_ANULAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.Location = New System.Drawing.Point(233, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Venta_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(430, 250)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_ANULAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Venta_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_CODCLIE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DESC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_RUC As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TXT_DIREC As System.Windows.Forms.TextBox
    Friend WithEvents Button_ANULAR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

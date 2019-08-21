<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cierre_X
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OPT_IMPRESORA = New System.Windows.Forms.RadioButton()
        Me.OPT_PANTALLA = New System.Windows.Forms.RadioButton()
        Me.TXT_CAJA = New System.Windows.Forms.TextBox()
        Me.TXT_TURNO = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.TXT_FECHA = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Turno :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_IMPRESORA)
        Me.GroupBox1.Controls.Add(Me.OPT_PANTALLA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 87)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destino"
        '
        'OPT_IMPRESORA
        '
        Me.OPT_IMPRESORA.AutoSize = True
        Me.OPT_IMPRESORA.Location = New System.Drawing.Point(30, 47)
        Me.OPT_IMPRESORA.Name = "OPT_IMPRESORA"
        Me.OPT_IMPRESORA.Size = New System.Drawing.Size(96, 20)
        Me.OPT_IMPRESORA.TabIndex = 1
        Me.OPT_IMPRESORA.Text = "Impresora"
        Me.OPT_IMPRESORA.UseVisualStyleBackColor = True
        '
        'OPT_PANTALLA
        '
        Me.OPT_PANTALLA.AutoSize = True
        Me.OPT_PANTALLA.Checked = True
        Me.OPT_PANTALLA.Location = New System.Drawing.Point(30, 21)
        Me.OPT_PANTALLA.Name = "OPT_PANTALLA"
        Me.OPT_PANTALLA.Size = New System.Drawing.Size(83, 20)
        Me.OPT_PANTALLA.TabIndex = 0
        Me.OPT_PANTALLA.TabStop = True
        Me.OPT_PANTALLA.Text = "Pantalla"
        Me.OPT_PANTALLA.UseVisualStyleBackColor = True
        '
        'TXT_CAJA
        '
        Me.TXT_CAJA.Enabled = False
        Me.TXT_CAJA.Location = New System.Drawing.Point(169, 25)
        Me.TXT_CAJA.Name = "TXT_CAJA"
        Me.TXT_CAJA.Size = New System.Drawing.Size(119, 22)
        Me.TXT_CAJA.TabIndex = 4
        '
        'TXT_TURNO
        '
        Me.TXT_TURNO.Enabled = False
        Me.TXT_TURNO.Location = New System.Drawing.Point(169, 111)
        Me.TXT_TURNO.Name = "TXT_TURNO"
        Me.TXT_TURNO.Size = New System.Drawing.Size(119, 22)
        Me.TXT_TURNO.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(208, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(208, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(308, 25)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 23
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_FECHA
        '
        Me.TXT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_FECHA.Location = New System.Drawing.Point(169, 68)
        Me.TXT_FECHA.Name = "TXT_FECHA"
        Me.TXT_FECHA.Size = New System.Drawing.Size(119, 22)
        Me.TXT_FECHA.TabIndex = 24
        '
        'PrintDocument1
        '
        '
        'Cierre_X
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(365, 252)
        Me.Controls.Add(Me.TXT_FECHA)
        Me.Controls.Add(Me.picturebox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_TURNO)
        Me.Controls.Add(Me.TXT_CAJA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Cierre_X"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre X"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_IMPRESORA As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_PANTALLA As System.Windows.Forms.RadioButton
    Friend WithEvents TXT_CAJA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TURNO As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents TXT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class

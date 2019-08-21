<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_Cliente_Venta
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TXT_CAPTCHA = New System.Windows.Forms.TextBox()
        Me.BTONCAPCHA = New System.Windows.Forms.Button()
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.TXT_MAIL = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_CONDICION = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_ESTADO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DIRECCION = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_RUC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button_EFECTIVO = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TXT_CAPTCHA)
        Me.GroupBox2.Controls.Add(Me.BTONCAPCHA)
        Me.GroupBox2.Controls.Add(Me.Picture)
        Me.GroupBox2.Location = New System.Drawing.Point(540, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 239)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(21, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 34)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Consultar Sunat"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TXT_CAPTCHA
        '
        Me.TXT_CAPTCHA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CAPTCHA.Location = New System.Drawing.Point(6, 117)
        Me.TXT_CAPTCHA.Name = "TXT_CAPTCHA"
        Me.TXT_CAPTCHA.Size = New System.Drawing.Size(150, 22)
        Me.TXT_CAPTCHA.TabIndex = 31
        '
        'BTONCAPCHA
        '
        Me.BTONCAPCHA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BTONCAPCHA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTONCAPCHA.Location = New System.Drawing.Point(21, 79)
        Me.BTONCAPCHA.Name = "BTONCAPCHA"
        Me.BTONCAPCHA.Size = New System.Drawing.Size(118, 34)
        Me.BTONCAPCHA.TabIndex = 1
        Me.BTONCAPCHA.Text = "Actualizar Captcha"
        Me.BTONCAPCHA.UseVisualStyleBackColor = False
        '
        'Picture
        '
        Me.Picture.Location = New System.Drawing.Point(6, 9)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(150, 64)
        Me.Picture.TabIndex = 0
        Me.Picture.TabStop = False
        '
        'TXT_MAIL
        '
        Me.TXT_MAIL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_MAIL.Location = New System.Drawing.Point(94, 138)
        Me.TXT_MAIL.Name = "TXT_MAIL"
        Me.TXT_MAIL.Size = New System.Drawing.Size(239, 26)
        Me.TXT_MAIL.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Mail :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_CONDICION
        '
        Me.TXT_CONDICION.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CONDICION.Location = New System.Drawing.Point(365, 205)
        Me.TXT_CONDICION.Name = "TXT_CONDICION"
        Me.TXT_CONDICION.ReadOnly = True
        Me.TXT_CONDICION.Size = New System.Drawing.Size(145, 26)
        Me.TXT_CONDICION.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Condicion :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_ESTADO
        '
        Me.TXT_ESTADO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ESTADO.Location = New System.Drawing.Point(94, 206)
        Me.TXT_ESTADO.Name = "TXT_ESTADO"
        Me.TXT_ESTADO.ReadOnly = True
        Me.TXT_ESTADO.Size = New System.Drawing.Size(145, 26)
        Me.TXT_ESTADO.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 19)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Estado :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_DIRECCION
        '
        Me.TXT_DIRECCION.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DIRECCION.Location = New System.Drawing.Point(94, 90)
        Me.TXT_DIRECCION.Multiline = True
        Me.TXT_DIRECCION.Name = "TXT_DIRECCION"
        Me.TXT_DIRECCION.Size = New System.Drawing.Size(409, 39)
        Me.TXT_DIRECCION.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Direccion :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_DESCRIPCION
        '
        Me.TXT_DESCRIPCION.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DESCRIPCION.Location = New System.Drawing.Point(94, 56)
        Me.TXT_DESCRIPCION.Name = "TXT_DESCRIPCION"
        Me.TXT_DESCRIPCION.Size = New System.Drawing.Size(409, 26)
        Me.TXT_DESCRIPCION.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Descripcion :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_RUC
        '
        Me.TXT_RUC.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RUC.Location = New System.Drawing.Point(94, 17)
        Me.TXT_RUC.Name = "TXT_RUC"
        Me.TXT_RUC.Size = New System.Drawing.Size(145, 26)
        Me.TXT_RUC.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Ruc :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_MAIL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_CONDICION)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_ESTADO)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_DIRECCION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_RUC)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(517, 239)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Market.My.Resources.Resources.keyboard_4316
        Me.Button5.Location = New System.Drawing.Point(105, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 39)
        Me.Button5.TabIndex = 50
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Market.My.Resources.Resources.Cancelar_v2_32
        Me.Button1.Location = New System.Drawing.Point(373, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 42)
        Me.Button1.TabIndex = 46
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button_EFECTIVO
        '
        Me.Button_EFECTIVO.BackColor = System.Drawing.Color.Transparent
        Me.Button_EFECTIVO.FlatAppearance.BorderSize = 0
        Me.Button_EFECTIVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_EFECTIVO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EFECTIVO.Image = Global.Market.My.Resources.Resources.Aceptar
        Me.Button_EFECTIVO.Location = New System.Drawing.Point(292, 251)
        Me.Button_EFECTIVO.Name = "Button_EFECTIVO"
        Me.Button_EFECTIVO.Size = New System.Drawing.Size(63, 42)
        Me.Button_EFECTIVO.TabIndex = 45
        Me.Button_EFECTIVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button_EFECTIVO.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Market.My.Resources.Resources.Exit_32
        Me.Button2.Location = New System.Drawing.Point(451, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 42)
        Me.Button2.TabIndex = 47
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(264, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "El codigo del Cliente sera el Ruc"
        '
        'Mant_Cliente_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(712, 299)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button_EFECTIVO)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Mant_Cliente_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Creacion de Cliente"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TXT_CAPTCHA As TextBox
    Friend WithEvents BTONCAPCHA As Button
    Friend WithEvents Picture As PictureBox
    Friend WithEvents TXT_MAIL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_CONDICION As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_ESTADO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DIRECCION As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_DESCRIPCION As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button_EFECTIVO As Button
    Friend WithEvents TXT_RUC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
End Class

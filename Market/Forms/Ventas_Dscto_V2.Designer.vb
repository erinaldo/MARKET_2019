<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas_Dscto_V2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas_Dscto_V2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OPT_TODOS = New System.Windows.Forms.RadioButton()
        Me.OPT_PRODUCTO = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_PORCENTAJE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TXT_CANT = New System.Windows.Forms.TextBox()
        Me.TXT_CANT_TOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OPT_TODOS)
        Me.GroupBox1.Controls.Add(Me.OPT_PRODUCTO)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 115)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Descuento"
        '
        'OPT_TODOS
        '
        Me.OPT_TODOS.AutoSize = True
        Me.OPT_TODOS.Location = New System.Drawing.Point(19, 72)
        Me.OPT_TODOS.Name = "OPT_TODOS"
        Me.OPT_TODOS.Size = New System.Drawing.Size(81, 23)
        Me.OPT_TODOS.TabIndex = 3
        Me.OPT_TODOS.Text = "A Todos"
        Me.OPT_TODOS.UseVisualStyleBackColor = True
        '
        'OPT_PRODUCTO
        '
        Me.OPT_PRODUCTO.AutoSize = True
        Me.OPT_PRODUCTO.Checked = True
        Me.OPT_PRODUCTO.Location = New System.Drawing.Point(18, 33)
        Me.OPT_PRODUCTO.Name = "OPT_PRODUCTO"
        Me.OPT_PRODUCTO.Size = New System.Drawing.Size(105, 23)
        Me.OPT_PRODUCTO.TabIndex = 2
        Me.OPT_PRODUCTO.TabStop = True
        Me.OPT_PRODUCTO.Text = "Al Producto"
        Me.OPT_PRODUCTO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_PORCENTAJE)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TXT_CANTIDAD)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(190, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 115)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'TXT_PORCENTAJE
        '
        Me.TXT_PORCENTAJE.Location = New System.Drawing.Point(138, 61)
        Me.TXT_PORCENTAJE.Name = "TXT_PORCENTAJE"
        Me.TXT_PORCENTAJE.Size = New System.Drawing.Size(100, 26)
        Me.TXT_PORCENTAJE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descuento % :"
        '
        'TXT_CANTIDAD
        '
        Me.TXT_CANTIDAD.Location = New System.Drawing.Point(138, 25)
        Me.TXT_CANTIDAD.Name = "TXT_CANTIDAD"
        Me.TXT_CANTIDAD.Size = New System.Drawing.Size(100, 26)
        Me.TXT_CANTIDAD.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monto :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(256, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(120, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "teclado_windows.jpg"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(12, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 57)
        Me.Button3.TabIndex = 49
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "EFECTIVO - copia.jpg")
        Me.ImageList2.Images.SetKeyName(1, "multipago.png")
        Me.ImageList2.Images.SetKeyName(2, "tarjeta.jpg")
        Me.ImageList2.Images.SetKeyName(3, "credito.png")
        Me.ImageList2.Images.SetKeyName(4, "vales.jpg")
        Me.ImageList2.Images.SetKeyName(5, "caja.jpeg")
        Me.ImageList2.Images.SetKeyName(6, "cancelar.jpg")
        Me.ImageList2.Images.SetKeyName(7, "salir.jpg")
        Me.ImageList2.Images.SetKeyName(8, "registros.jpg")
        Me.ImageList2.Images.SetKeyName(9, "listado.jpg")
        Me.ImageList2.Images.SetKeyName(10, "teclado_windows.jpg")
        Me.ImageList2.Images.SetKeyName(11, "TECLADO_V2.jpg")
        Me.ImageList2.Images.SetKeyName(12, "Eliminar_V3.jpg")
        Me.ImageList2.Images.SetKeyName(13, "articulos.png")
        Me.ImageList2.Images.SetKeyName(14, "MAS.jpg")
        Me.ImageList2.Images.SetKeyName(15, "MENOS.jpg")
        Me.ImageList2.Images.SetKeyName(16, "MODIF.jpg")
        Me.ImageList2.Images.SetKeyName(17, "flecha_abajo.jpg")
        '
        'TXT_CANT
        '
        Me.TXT_CANT.Location = New System.Drawing.Point(339, 133)
        Me.TXT_CANT.Name = "TXT_CANT"
        Me.TXT_CANT.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CANT.TabIndex = 50
        '
        'TXT_CANT_TOTAL
        '
        Me.TXT_CANT_TOTAL.Location = New System.Drawing.Point(339, 159)
        Me.TXT_CANT_TOTAL.Name = "TXT_CANT_TOTAL"
        Me.TXT_CANT_TOTAL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CANT_TOTAL.TabIndex = 51
        '
        'Ventas_Dscto_V2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(461, 183)
        Me.Controls.Add(Me.TXT_CANT_TOTAL)
        Me.Controls.Add(Me.TXT_CANT)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Ventas_Dscto_V2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descuento"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OPT_TODOS As RadioButton
    Friend WithEvents OPT_PRODUCTO As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXT_CANTIDAD As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PORCENTAJE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents TXT_CANT As TextBox
    Friend WithEvents TXT_CANT_TOTAL As TextBox
End Class

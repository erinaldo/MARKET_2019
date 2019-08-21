<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_Rubros
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
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CHK_ACTIVO = New System.Windows.Forms.CheckBox()
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.TXT_DESC = New System.Windows.Forms.TextBox()
        Me.TXT_CODIGO = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolSalir.Image = Global.Market.My.Resources.Resources.Exit_32
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(36, 37)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'ToolAnular
        '
        Me.ToolAnular.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolAnular.Image = Global.Market.My.Resources.Resources.Elim002
        Me.ToolAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolAnular.Name = "ToolAnular"
        Me.ToolAnular.Size = New System.Drawing.Size(48, 37)
        Me.ToolAnular.Text = "Anular"
        Me.ToolAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolModificar
        '
        Me.ToolModificar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolModificar.Image = Global.Market.My.Resources.Resources.Foldrs03
        Me.ToolModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolModificar.Name = "ToolModificar"
        Me.ToolModificar.Size = New System.Drawing.Size(63, 37)
        Me.ToolModificar.Text = "Modificar"
        Me.ToolModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolGrabar
        '
        Me.ToolGrabar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolGrabar.Image = Global.Market.My.Resources.Resources.Grabar
        Me.ToolGrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolGrabar.Name = "ToolGrabar"
        Me.ToolGrabar.Size = New System.Drawing.Size(50, 37)
        Me.ToolGrabar.Text = "Grabar"
        Me.ToolGrabar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolNuevo
        '
        Me.ToolNuevo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolNuevo.Image = Global.Market.My.Resources.Resources.Nuevo
        Me.ToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolNuevo.Name = "ToolNuevo"
        Me.ToolNuevo.Size = New System.Drawing.Size(46, 37)
        Me.ToolNuevo.Text = "Nuevo"
        Me.ToolNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolNuevo.ToolTipText = "Nuevo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolStripSeparator13, Me.ToolGrabar, Me.ToolStripSeparator14, Me.ToolModificar, Me.ToolStripSeparator15, Me.ToolAnular, Me.ToolStripSeparator16, Me.ToolCancelar, Me.ToolStripSeparator17, Me.ToolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(419, 40)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
        '
        'ToolCancelar
        '
        Me.ToolCancelar.Image = Global.Market.My.Resources.Resources.cancelar
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(60, 37)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 40)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button1.Location = New System.Drawing.Point(177, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(32, 34)
        Me.Button1.TabIndex = 29
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Descripcion :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Codigo :"
        '
        'CHK_ACTIVO
        '
        Me.CHK_ACTIVO.AutoSize = True
        Me.CHK_ACTIVO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ACTIVO.Location = New System.Drawing.Point(278, 24)
        Me.CHK_ACTIVO.Name = "CHK_ACTIVO"
        Me.CHK_ACTIVO.Size = New System.Drawing.Size(67, 17)
        Me.CHK_ACTIVO.TabIndex = 22
        Me.CHK_ACTIVO.Text = "Inactivo"
        Me.CHK_ACTIVO.UseVisualStyleBackColor = True
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.Color.Transparent
        Me.picturebox1.FlatAppearance.BorderSize = 0
        Me.picturebox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picturebox1.Location = New System.Drawing.Point(215, 14)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 20
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_DESC
        '
        Me.TXT_DESC.Location = New System.Drawing.Point(102, 54)
        Me.TXT_DESC.Name = "TXT_DESC"
        Me.TXT_DESC.Size = New System.Drawing.Size(243, 20)
        Me.TXT_DESC.TabIndex = 2
        '
        'TXT_CODIGO
        '
        Me.TXT_CODIGO.Location = New System.Drawing.Point(102, 22)
        Me.TXT_CODIGO.Name = "TXT_CODIGO"
        Me.TXT_CODIGO.Size = New System.Drawing.Size(57, 20)
        Me.TXT_CODIGO.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CHK_ACTIVO)
        Me.GroupBox1.Controls.Add(Me.picturebox1)
        Me.GroupBox1.Controls.Add(Me.TXT_DESC)
        Me.GroupBox1.Controls.Add(Me.TXT_CODIGO)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 89)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'Mant_Rubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(419, 159)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Mant_Rubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rubros"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolSalir As ToolStripButton
    Friend WithEvents ToolAnular As ToolStripButton
    Friend WithEvents ToolModificar As ToolStripButton
    Friend WithEvents ToolGrabar As ToolStripButton
    Friend WithEvents ToolNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ToolCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CHK_ACTIVO As CheckBox
    Friend WithEvents picturebox1 As Button
    Friend WithEvents TXT_DESC As TextBox
    Friend WithEvents TXT_CODIGO As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

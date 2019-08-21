<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mant_Almacenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mant_Almacenes))
        Me.picturebox1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DESC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_COD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolGrabar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolCancelar = New System.Windows.Forms.ToolStripButton()
        Me.CHK_ANULADO = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(204, 19)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(32, 34)
        Me.picturebox1.TabIndex = 8
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Codigo :"
        '
        'TXT_DESC
        '
        Me.TXT_DESC.Location = New System.Drawing.Point(87, 64)
        Me.TXT_DESC.Name = "TXT_DESC"
        Me.TXT_DESC.Size = New System.Drawing.Size(272, 20)
        Me.TXT_DESC.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHK_ANULADO)
        Me.GroupBox1.Controls.Add(Me.picturebox1)
        Me.GroupBox1.Controls.Add(Me.TXT_COD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_DESC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 119)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'TXT_COD
        '
        Me.TXT_COD.Enabled = False
        Me.TXT_COD.Location = New System.Drawing.Point(87, 26)
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(111, 20)
        Me.TXT_COD.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion :"
        '
        'ToolSalir
        '
        Me.ToolSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolSalir.Image = CType(resources.GetObject("ToolSalir.Image"), System.Drawing.Image)
        Me.ToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolSalir.Name = "ToolSalir"
        Me.ToolSalir.Size = New System.Drawing.Size(36, 37)
        Me.ToolSalir.Text = "Salir"
        Me.ToolSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolSalir.ToolTipText = "Salir"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 40)
        Me.ToolStripSeparator18.Visible = False
        '
        'ToolPrint
        '
        Me.ToolPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolPrint.Image = Global.Market.My.Resources.Resources.Imprimir
        Me.ToolPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolPrint.Name = "ToolPrint"
        Me.ToolPrint.Size = New System.Drawing.Size(61, 37)
        Me.ToolPrint.Text = "Imprimir"
        Me.ToolPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolPrint.Visible = False
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 40)
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 40)
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
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 40)
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
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolNuevo, Me.ToolStripSeparator13, Me.ToolGrabar, Me.ToolStripSeparator14, Me.ToolModificar, Me.ToolStripSeparator15, Me.ToolAnular, Me.ToolStripSeparator16, Me.ToolCancelar, Me.ToolStripSeparator17, Me.ToolPrint, Me.ToolStripSeparator18, Me.ToolSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(422, 40)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolCancelar
        '
        Me.ToolCancelar.Image = Global.Market.My.Resources.Resources.cancelar
        Me.ToolCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolCancelar.Name = "ToolCancelar"
        Me.ToolCancelar.Size = New System.Drawing.Size(60, 37)
        Me.ToolCancelar.Text = "Cancelar"
        Me.ToolCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CHK_ANULADO
        '
        Me.CHK_ANULADO.AutoSize = True
        Me.CHK_ANULADO.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ANULADO.ForeColor = System.Drawing.Color.Red
        Me.CHK_ANULADO.Location = New System.Drawing.Point(262, 28)
        Me.CHK_ANULADO.Name = "CHK_ANULADO"
        Me.CHK_ANULADO.Size = New System.Drawing.Size(71, 19)
        Me.CHK_ANULADO.TabIndex = 9
        Me.CHK_ANULADO.Text = "Anulado"
        Me.CHK_ANULADO.UseVisualStyleBackColor = True
        '
        'Mant_Almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(422, 172)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mant_Almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Almacenes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picturebox1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_DESC As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_COD As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolSalir As ToolStripButton
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents ToolPrint As ToolStripButton
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents ToolAnular As ToolStripButton
    Friend WithEvents ToolModificar As ToolStripButton
    Friend WithEvents ToolGrabar As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolCancelar As ToolStripButton
    Friend WithEvents CHK_ANULADO As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.Menu_Mant = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Mant_Articulos = New System.Windows.Forms.ToolStripMenuItem
        Me.Menu_Mant_Familias = New System.Windows.Forms.ToolStripMenuItem
        Me.MF_Familias = New System.Windows.Forms.ToolStripMenuItem
        Me.MF_Subfamilias = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Mant})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(717, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu_Mant
        '
        Me.Menu_Mant.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu_Mant_Familias, Me.Menu_Mant_Articulos})
        Me.Menu_Mant.Name = "Menu_Mant"
        Me.Menu_Mant.Size = New System.Drawing.Size(105, 20)
        Me.Menu_Mant.Text = "Mantenimiento"
        '
        'Menu_Mant_Articulos
        '
        Me.Menu_Mant_Articulos.Image = Global.Market.My.Resources.Resources.Foldrs04
        Me.Menu_Mant_Articulos.Name = "Menu_Mant_Articulos"
        Me.Menu_Mant_Articulos.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Mant_Articulos.Text = "Articulos"
        '
        'Menu_Mant_Familias
        '
        Me.Menu_Mant_Familias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MF_Familias, Me.MF_Subfamilias})
        Me.Menu_Mant_Familias.Image = Global.Market.My.Resources.Resources.Box_Full
        Me.Menu_Mant_Familias.Name = "Menu_Mant_Familias"
        Me.Menu_Mant_Familias.Size = New System.Drawing.Size(152, 22)
        Me.Menu_Mant_Familias.Text = "Familias"
        '
        'MF_Familias
        '
        Me.MF_Familias.Name = "MF_Familias"
        Me.MF_Familias.Size = New System.Drawing.Size(144, 22)
        Me.MF_Familias.Text = "Familia"
        '
        'MF_Subfamilias
        '
        Me.MF_Subfamilias.Name = "MF_Subfamilias"
        Me.MF_Subfamilias.Size = New System.Drawing.Size(144, 22)
        Me.MF_Subfamilias.Text = "Subfamilia"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(717, 452)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Menu_Mant As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Mant_Articulos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Menu_Mant_Familias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MF_Familias As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MF_Subfamilias As System.Windows.Forms.ToolStripMenuItem

End Class

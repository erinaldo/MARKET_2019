<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaMaestra
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaMaestra))
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbCriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDatoBuscado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "10,0,0,0,0,125,Columns:0{StyleFixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{StyleFixed:""Tex" &
    "tAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{StyleFixed:""TextAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{StyleFixed:""T" &
    "extAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.DBLISTAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.DBLISTAR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(12, 58)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 25
        Me.DBLISTAR.Size = New System.Drawing.Size(765, 453)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbCriterioBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtDatoBuscado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 49)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'CmbCriterioBusqueda
        '
        Me.CmbCriterioBusqueda.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbCriterioBusqueda.FormattingEnabled = True
        Me.CmbCriterioBusqueda.Location = New System.Drawing.Point(322, 11)
        Me.CmbCriterioBusqueda.Name = "CmbCriterioBusqueda"
        Me.CmbCriterioBusqueda.Size = New System.Drawing.Size(179, 27)
        Me.CmbCriterioBusqueda.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(246, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Criterio :"
        '
        'TxtDatoBuscado
        '
        Me.TxtDatoBuscado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDatoBuscado.Location = New System.Drawing.Point(61, 12)
        Me.TxtDatoBuscado.Name = "TxtDatoBuscado"
        Me.TxtDatoBuscado.Size = New System.Drawing.Size(132, 26)
        Me.TxtDatoBuscado.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dato :"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageKey = "teclado_windows.jpg"
        Me.Button3.ImageList = Me.ImageList2
        Me.Button3.Location = New System.Drawing.Point(609, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 55)
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
        '
        'BusquedaMaestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(789, 512)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DBLISTAR)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusquedaMaestra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusquedaMaestra"
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbCriterioBusqueda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDatoBuscado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList2 As ImageList
End Class

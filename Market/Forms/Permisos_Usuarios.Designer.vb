<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Permisos_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permisos_Usuarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Combo_USUARIOS = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1_PERMISOS = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1_PERMISOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DBLISTAR)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 462)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "4,0,0,0,0,90,Columns:1{Caption:""Nivel 1"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Nivel 2"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Caption:""Nivel" & _
            " 3"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.DBLISTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(6, 10)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.DefaultSize = 18
        Me.DBLISTAR.Size = New System.Drawing.Size(382, 446)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Combo_USUARIOS)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.C1_PERMISOS)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 462)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Combo_USUARIOS
        '
        Me.Combo_USUARIOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_USUARIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_USUARIOS.FormattingEnabled = True
        Me.Combo_USUARIOS.Location = New System.Drawing.Point(97, 16)
        Me.Combo_USUARIOS.Name = "Combo_USUARIOS"
        Me.Combo_USUARIOS.Size = New System.Drawing.Size(234, 23)
        Me.Combo_USUARIOS.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario :"
        '
        'C1_PERMISOS
        '
        Me.C1_PERMISOS.BackColor = System.Drawing.Color.White
        Me.C1_PERMISOS.ColumnInfo = "4,0,0,0,0,90,Columns:1{Caption:""Nivel 1"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Nivel 2"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Caption:""Nivel" & _
            " 3"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1_PERMISOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1_PERMISOS.ForeColor = System.Drawing.Color.Black
        Me.C1_PERMISOS.Location = New System.Drawing.Point(6, 45)
        Me.C1_PERMISOS.Name = "C1_PERMISOS"
        Me.C1_PERMISOS.Rows.DefaultSize = 18
        Me.C1_PERMISOS.Size = New System.Drawing.Size(383, 411)
        Me.C1_PERMISOS.StyleInfo = resources.GetString("C1_PERMISOS.StyleInfo")
        Me.C1_PERMISOS.TabIndex = 11
        '
        'Permisos_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(813, 476)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Permisos_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Permisos de Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1_PERMISOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_USUARIOS As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1_PERMISOS As C1.Win.C1FlexGrid.C1FlexGrid
End Class

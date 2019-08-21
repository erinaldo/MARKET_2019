<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ver_Detalle_Comite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ver_Detalle_Comite))
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.C1_PRECIOS = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1_PRECIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.Location = New System.Drawing.Point(392, 392)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.ReadOnly = True
        Me.TXT_TOTAL.Size = New System.Drawing.Size(100, 20)
        Me.TXT_TOTAL.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(336, 395)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Total :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(119, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 21)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'C1_PRECIOS
        '
        Me.C1_PRECIOS.AllowEditing = False
        Me.C1_PRECIOS.BackColor = System.Drawing.Color.White
        Me.C1_PRECIOS.ColumnInfo = "10,0,0,0,0,85,Columns:"
        Me.C1_PRECIOS.Font = New System.Drawing.Font("Times New Roman", 8.25!)
        Me.C1_PRECIOS.ForeColor = System.Drawing.Color.Black
        Me.C1_PRECIOS.Location = New System.Drawing.Point(12, 13)
        Me.C1_PRECIOS.Name = "C1_PRECIOS"
        Me.C1_PRECIOS.Rows.DefaultSize = 17
        Me.C1_PRECIOS.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1_PRECIOS.Size = New System.Drawing.Size(533, 368)
        Me.C1_PRECIOS.StyleInfo = resources.GetString("C1_PRECIOS.StyleInfo")
        Me.C1_PRECIOS.TabIndex = 14
        '
        'Ver_Detalle_Comite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(557, 428)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.C1_PRECIOS)
        Me.MaximizeBox = False
        Me.Name = "Ver_Detalle_Comite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Detalle"
        CType(Me.C1_PRECIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents C1_PRECIOS As C1.Win.C1FlexGrid.C1FlexGrid
End Class

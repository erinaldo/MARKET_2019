<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAJA_OFICINA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CAJA_OFICINA))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button_MODIFICAR = New System.Windows.Forms.Button
        Me.Button_ANULAR = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DT_FIN = New System.Windows.Forms.DateTimePicker
        Me.DT_INI = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DBLISTAR = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TXT_TC = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.LblAnulado = New System.Windows.Forms.Label
        Me.DT_FECHA = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button_CANCELAR = New System.Windows.Forms.Button
        Me.Button_GRABAR = New System.Windows.Forms.Button
        Me.Button_NUEVO = New System.Windows.Forms.Button
        Me.TXT_OBSERV = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TXT_IMPORTE = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXT_ENTREGAMOS = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TXT_COD_SUBCUENTA = New System.Windows.Forms.TextBox
        Me.TXT_COD_CUENTA = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.picturebox1 = New System.Windows.Forms.Button
        Me.TXT_SUBCUENTA = New System.Windows.Forms.TextBox
        Me.TXT_CUENTA = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TXT_NRO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.OPT_SAL = New System.Windows.Forms.RadioButton
        Me.OPT_ING = New System.Windows.Forms.RadioButton
        Me.Combo_MONEDA = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(652, 379)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button_MODIFICAR)
        Me.TabPage1.Controls.Add(Me.Button_ANULAR)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DBLISTAR)
        Me.TabPage1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 31)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(644, 344)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "          Consultas          "
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Market.My.Resources.Resources.Imprimir2
        Me.Button4.Location = New System.Drawing.Point(565, 218)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(73, 42)
        Me.Button4.TabIndex = 16
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button_MODIFICAR
        '
        Me.Button_MODIFICAR.BackColor = System.Drawing.Color.White
        Me.Button_MODIFICAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MODIFICAR.Image = Global.Market.My.Resources.Resources.Foldrs031
        Me.Button_MODIFICAR.Location = New System.Drawing.Point(565, 155)
        Me.Button_MODIFICAR.Name = "Button_MODIFICAR"
        Me.Button_MODIFICAR.Size = New System.Drawing.Size(73, 45)
        Me.Button_MODIFICAR.TabIndex = 15
        Me.Button_MODIFICAR.UseVisualStyleBackColor = False
        '
        'Button_ANULAR
        '
        Me.Button_ANULAR.BackColor = System.Drawing.Color.White
        Me.Button_ANULAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ANULAR.Image = Global.Market.My.Resources.Resources.Elim0021
        Me.Button_ANULAR.Location = New System.Drawing.Point(565, 92)
        Me.Button_ANULAR.Name = "Button_ANULAR"
        Me.Button_ANULAR.Size = New System.Drawing.Size(73, 42)
        Me.Button_ANULAR.TabIndex = 14
        Me.Button_ANULAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(461, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 27)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DT_FIN)
        Me.GroupBox1.Controls.Add(Me.DT_INI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(197, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 40)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'DT_FIN
        '
        Me.DT_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FIN.Location = New System.Drawing.Point(167, 13)
        Me.DT_FIN.Name = "DT_FIN"
        Me.DT_FIN.Size = New System.Drawing.Size(81, 20)
        Me.DT_FIN.TabIndex = 3
        '
        'DT_INI
        '
        Me.DT_INI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_INI.Location = New System.Drawing.Point(48, 13)
        Me.DT_INI.Name = "DT_INI"
        Me.DT_INI.Size = New System.Drawing.Size(81, 20)
        Me.DT_INI.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Al :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Del :"
        '
        'DBLISTAR
        '
        Me.DBLISTAR.AllowEditing = False
        Me.DBLISTAR.BackColor = System.Drawing.Color.White
        Me.DBLISTAR.ColumnInfo = "6,0,0,0,0,85,Columns:"
        Me.DBLISTAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBLISTAR.ForeColor = System.Drawing.Color.Black
        Me.DBLISTAR.Location = New System.Drawing.Point(5, 60)
        Me.DBLISTAR.Name = "DBLISTAR"
        Me.DBLISTAR.Rows.Count = 1
        Me.DBLISTAR.Rows.DefaultSize = 17
        Me.DBLISTAR.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.DBLISTAR.Size = New System.Drawing.Size(556, 287)
        Me.DBLISTAR.StyleInfo = resources.GetString("DBLISTAR.StyleInfo")
        Me.DBLISTAR.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.TXT_TC)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.LblAnulado)
        Me.TabPage2.Controls.Add(Me.DT_FECHA)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.TXT_NRO)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.Combo_MONEDA)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 31)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(644, 344)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "          Recibos          "
        '
        'TXT_TC
        '
        Me.TXT_TC.Location = New System.Drawing.Point(338, 72)
        Me.TXT_TC.Name = "TXT_TC"
        Me.TXT_TC.Size = New System.Drawing.Size(45, 20)
        Me.TXT_TC.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(297, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "T.C. :"
        '
        'LblAnulado
        '
        Me.LblAnulado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAnulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAnulado.ForeColor = System.Drawing.Color.Red
        Me.LblAnulado.Location = New System.Drawing.Point(537, 68)
        Me.LblAnulado.Name = "LblAnulado"
        Me.LblAnulado.Size = New System.Drawing.Size(101, 26)
        Me.LblAnulado.TabIndex = 8
        Me.LblAnulado.Text = "ANULADO"
        Me.LblAnulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DT_FECHA
        '
        Me.DT_FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_FECHA.Location = New System.Drawing.Point(347, 29)
        Me.DT_FECHA.Name = "DT_FECHA"
        Me.DT_FECHA.Size = New System.Drawing.Size(81, 20)
        Me.DT_FECHA.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(297, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fecha :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_CANCELAR)
        Me.GroupBox3.Controls.Add(Me.Button_GRABAR)
        Me.GroupBox3.Controls.Add(Me.Button_NUEVO)
        Me.GroupBox3.Controls.Add(Me.TXT_OBSERV)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TXT_IMPORTE)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TXT_ENTREGAMOS)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TXT_COD_SUBCUENTA)
        Me.GroupBox3.Controls.Add(Me.TXT_COD_CUENTA)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.picturebox1)
        Me.GroupBox3.Controls.Add(Me.TXT_SUBCUENTA)
        Me.GroupBox3.Controls.Add(Me.TXT_CUENTA)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(619, 227)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Button_CANCELAR
        '
        Me.Button_CANCELAR.BackColor = System.Drawing.Color.White
        Me.Button_CANCELAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CANCELAR.Image = Global.Market.My.Resources.Resources.cancelar2
        Me.Button_CANCELAR.Location = New System.Drawing.Point(524, 127)
        Me.Button_CANCELAR.Name = "Button_CANCELAR"
        Me.Button_CANCELAR.Size = New System.Drawing.Size(73, 42)
        Me.Button_CANCELAR.TabIndex = 35
        Me.Button_CANCELAR.UseVisualStyleBackColor = False
        '
        'Button_GRABAR
        '
        Me.Button_GRABAR.BackColor = System.Drawing.Color.White
        Me.Button_GRABAR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_GRABAR.Image = Global.Market.My.Resources.Resources.Grabar
        Me.Button_GRABAR.Location = New System.Drawing.Point(524, 72)
        Me.Button_GRABAR.Name = "Button_GRABAR"
        Me.Button_GRABAR.Size = New System.Drawing.Size(73, 42)
        Me.Button_GRABAR.TabIndex = 34
        Me.Button_GRABAR.UseVisualStyleBackColor = False
        '
        'Button_NUEVO
        '
        Me.Button_NUEVO.BackColor = System.Drawing.Color.White
        Me.Button_NUEVO.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_NUEVO.Image = Global.Market.My.Resources.Resources.Nuevo
        Me.Button_NUEVO.Location = New System.Drawing.Point(524, 19)
        Me.Button_NUEVO.Name = "Button_NUEVO"
        Me.Button_NUEVO.Size = New System.Drawing.Size(73, 42)
        Me.Button_NUEVO.TabIndex = 33
        Me.Button_NUEVO.UseVisualStyleBackColor = False
        '
        'TXT_OBSERV
        '
        Me.TXT_OBSERV.Location = New System.Drawing.Point(109, 170)
        Me.TXT_OBSERV.Multiline = True
        Me.TXT_OBSERV.Name = "TXT_OBSERV"
        Me.TXT_OBSERV.Size = New System.Drawing.Size(378, 51)
        Me.TXT_OBSERV.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Comentario :"
        '
        'TXT_IMPORTE
        '
        Me.TXT_IMPORTE.Location = New System.Drawing.Point(109, 139)
        Me.TXT_IMPORTE.Name = "TXT_IMPORTE"
        Me.TXT_IMPORTE.Size = New System.Drawing.Size(76, 20)
        Me.TXT_IMPORTE.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Importe :"
        '
        'TXT_ENTREGAMOS
        '
        Me.TXT_ENTREGAMOS.Location = New System.Drawing.Point(109, 105)
        Me.TXT_ENTREGAMOS.Name = "TXT_ENTREGAMOS"
        Me.TXT_ENTREGAMOS.Size = New System.Drawing.Size(378, 20)
        Me.TXT_ENTREGAMOS.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Entregamos a :"
        '
        'TXT_COD_SUBCUENTA
        '
        Me.TXT_COD_SUBCUENTA.Enabled = False
        Me.TXT_COD_SUBCUENTA.Location = New System.Drawing.Point(92, 69)
        Me.TXT_COD_SUBCUENTA.Name = "TXT_COD_SUBCUENTA"
        Me.TXT_COD_SUBCUENTA.Size = New System.Drawing.Size(54, 20)
        Me.TXT_COD_SUBCUENTA.TabIndex = 26
        '
        'TXT_COD_CUENTA
        '
        Me.TXT_COD_CUENTA.Enabled = False
        Me.TXT_COD_CUENTA.Location = New System.Drawing.Point(92, 28)
        Me.TXT_COD_CUENTA.Name = "TXT_COD_CUENTA"
        Me.TXT_COD_CUENTA.Size = New System.Drawing.Size(54, 20)
        Me.TXT_COD_CUENTA.TabIndex = 25
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button5.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.Button5.Location = New System.Drawing.Point(152, 24)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(33, 28)
        Me.Button5.TabIndex = 24
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button5.UseVisualStyleBackColor = False
        '
        'picturebox1
        '
        Me.picturebox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.picturebox1.Image = Global.Market.My.Resources.Resources.WinXPSetV4_Icon_12
        Me.picturebox1.Location = New System.Drawing.Point(152, 65)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(33, 28)
        Me.picturebox1.TabIndex = 23
        Me.picturebox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.picturebox1.UseVisualStyleBackColor = False
        '
        'TXT_SUBCUENTA
        '
        Me.TXT_SUBCUENTA.Enabled = False
        Me.TXT_SUBCUENTA.Location = New System.Drawing.Point(191, 69)
        Me.TXT_SUBCUENTA.Name = "TXT_SUBCUENTA"
        Me.TXT_SUBCUENTA.Size = New System.Drawing.Size(296, 20)
        Me.TXT_SUBCUENTA.TabIndex = 4
        '
        'TXT_CUENTA
        '
        Me.TXT_CUENTA.Enabled = False
        Me.TXT_CUENTA.Location = New System.Drawing.Point(191, 28)
        Me.TXT_CUENTA.Name = "TXT_CUENTA"
        Me.TXT_CUENTA.Size = New System.Drawing.Size(296, 20)
        Me.TXT_CUENTA.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SubCuenta :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cuenta :"
        '
        'TXT_NRO
        '
        Me.TXT_NRO.Enabled = False
        Me.TXT_NRO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NRO.Location = New System.Drawing.Point(561, 24)
        Me.TXT_NRO.Name = "TXT_NRO"
        Me.TXT_NRO.Size = New System.Drawing.Size(77, 26)
        Me.TXT_NRO.TabIndex = 4
        Me.TXT_NRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(507, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nro. :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OPT_SAL)
        Me.GroupBox2.Controls.Add(Me.OPT_ING)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 40)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'OPT_SAL
        '
        Me.OPT_SAL.AutoSize = True
        Me.OPT_SAL.Checked = True
        Me.OPT_SAL.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPT_SAL.Location = New System.Drawing.Point(134, 16)
        Me.OPT_SAL.Name = "OPT_SAL"
        Me.OPT_SAL.Size = New System.Drawing.Size(58, 17)
        Me.OPT_SAL.TabIndex = 1
        Me.OPT_SAL.TabStop = True
        Me.OPT_SAL.Text = "Salida"
        Me.OPT_SAL.UseVisualStyleBackColor = True
        '
        'OPT_ING
        '
        Me.OPT_ING.AutoSize = True
        Me.OPT_ING.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPT_ING.Location = New System.Drawing.Point(16, 16)
        Me.OPT_ING.Name = "OPT_ING"
        Me.OPT_ING.Size = New System.Drawing.Size(64, 17)
        Me.OPT_ING.TabIndex = 0
        Me.OPT_ING.Text = "Ingreso"
        Me.OPT_ING.UseVisualStyleBackColor = True
        '
        'Combo_MONEDA
        '
        Me.Combo_MONEDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_MONEDA.FormattingEnabled = True
        Me.Combo_MONEDA.Items.AddRange(New Object() {"Soles", "Dolares"})
        Me.Combo_MONEDA.Location = New System.Drawing.Point(98, 29)
        Me.Combo_MONEDA.Name = "Combo_MONEDA"
        Me.Combo_MONEDA.Size = New System.Drawing.Size(176, 22)
        Me.Combo_MONEDA.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Moneda :"
        '
        'CAJA_OFICINA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(677, 394)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CAJA_OFICINA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DBLISTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button_MODIFICAR As System.Windows.Forms.Button
    Friend WithEvents Button_ANULAR As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DT_FIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents DT_INI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DBLISTAR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OPT_SAL As System.Windows.Forms.RadioButton
    Friend WithEvents OPT_ING As System.Windows.Forms.RadioButton
    Friend WithEvents Combo_MONEDA As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_NRO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TXT_SUBCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents picturebox1 As System.Windows.Forms.Button
    Friend WithEvents TXT_OBSERV As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_IMPORTE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_ENTREGAMOS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TXT_COD_SUBCUENTA As System.Windows.Forms.TextBox
    Friend WithEvents TXT_COD_CUENTA As System.Windows.Forms.TextBox
    Friend WithEvents Button_CANCELAR As System.Windows.Forms.Button
    Friend WithEvents Button_GRABAR As System.Windows.Forms.Button
    Friend WithEvents Button_NUEVO As System.Windows.Forms.Button
    Friend WithEvents DT_FECHA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblAnulado As System.Windows.Forms.Label
    Friend WithEvents TXT_TC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class

Public Class Rpte_Seleccion_Articulo

    Private Sub picturebox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picturebox1.Click
        'Lineas que llaman al Formulario de Búsqueda
        Try
            Dim arraybusqueda(3, 3) As Object
            arraybusqueda(1, 1) = "COD_ART"
            arraybusqueda(1, 2) = "Codigo"
            arraybusqueda(1, 3) = 1500
            arraybusqueda(2, 1) = "Desc_ART"
            arraybusqueda(2, 2) = "Descripcion "
            arraybusqueda(2, 3) = 3000
            arraybusqueda(3, 1) = "Stock_ART"
            arraybusqueda(3, 2) = "Stock "
            arraybusqueda(3, 3) = 1500

            ''
            With BusquedaMaestra
                .ACT = "Consultar_Articulos"
                .STATINI = 0
                .CARGAR_COMBO(arraybusqueda, 3, 2)
                .TIPO = 0

                .ShowDialog()

                ''
                If .GrecibeColumnaID <> "" Then
                    Me.TXT_COD.Tag = .GrecibeColumnaID
                    Me.TXT_COD.Text = .GrecibeColumnaOpcional
                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Rpte_Seleccion_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LIMPIAR()
    End Sub
    Sub LIMPIAR()
        Me.TXT_COD.Text = ""
        Me.TXT_COD.Tag = ""
        Me.DT_INI.Value = Date.Now
        Me.DT_FIN.Value = Date.Now
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            If Me.Tag = "K" Or Me.Tag = "KV" Then Kardex()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub KARDEX()
        Dim CAD As String = ""
        Dim TOT As Double
        ''GENERAR
        If Me.TXT_COD.Text = "" Then CAD = "" Else CAD = Me.TXT_COD.Tag
        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "GENERAR_KARDEX"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.CommandTimeout = 0
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@PC", SqlDbType.VarChar)
        CMN.Parameters("@PC").Value = SystemInformation.ComputerName
        CMN.Parameters.Add("@ART", SqlDbType.VarChar)
        CMN.Parameters("@ART").Value = CAD
        CMN.Parameters.Add("@FECHA", SqlDbType.VarChar)
        CMN.Parameters("@FECHA").Value = Format(Me.DT_INI.Value, "dd/MM/yyyy")
        CMN.Parameters.Add("@FECHA_FIN", SqlDbType.VarChar)
        CMN.Parameters("@FECHA_FIN").Value = Format(Me.DT_FIN.Value, "dd/MM/yyyy")
        CMN.Parameters.Add("@TOTALG", SqlDbType.Float)
        CMN.Parameters("@TOTALG").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        TOT = CMN.Parameters("@TOTALG").Value
        CNN.Close()
        With Impresion
            .FORM = "Rpte_Seleccion_Articulo"
            .MON = Me.Tag
            .TITULO = "Del : " & Format(Me.DT_INI.Value, "dd/MM/yyyy") & " Al  " & Format(Me.DT_FIN.Value, "dd/MM/yyyy")
            .Show()

        End With
    End Sub
End Class
Public Class Recalc_Stock

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
                    Me.TXT_ART.Tag = .GrecibeColumnaID
                    Me.TXT_ART.Text = .GrecibeColumnaOpcional
                End If
                .Close()
            End With
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Recalc_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DT_INI.Value = Date.Now

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RECALCULO_STOCK()
    End Sub
    Sub RECALCULO_STOCK()
        Dim cod As String
        If Me.CheckBox1.Checked = False Then cod = "" Else cod = Me.TXT_ART.Tag

        On Error GoTo TrataError

        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand

        CNN = New SqlClient.SqlConnection(CAD_CON)
        CMN.CommandText = "IAM_CALCULAR_COSTO"
        CMN.CommandTimeout = 0
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CNN
        ''
        CMN.Parameters.Add("@CODIGO", SqlDbType.VarChar)
        CMN.Parameters("@CODIGO").Value = cod
        CMN.Parameters.Add("@FECHA", SqlDbType.DateTime)
        CMN.Parameters("@FECHA").Value = Format(Me.DT_INI.Value, "dd/MM/yyyy")
        CMN.Parameters.Add("@SW", SqlDbType.Int)
        CMN.Parameters("@SW").Direction = ParameterDirection.Output

        CNN.Open()

        CMN.ExecuteNonQuery()

        If CMN.Parameters("@SW").Value = 1 Then MsgBox("Error al Recalcular Stock", MsgBoxStyle.Information)
        If CMN.Parameters("@SW").Value = 0 Then MsgBox("Recalculo Satisfactoriamente", MsgBoxStyle.Information)
TrataError:
        CMN = Nothing
        CNN.Close()
        If Err.Number <> 0 Then Err.Raise(Err.Number, "STOCK INICIAL", Err.Description)
    End Sub

End Class
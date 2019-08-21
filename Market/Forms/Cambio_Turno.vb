Public Class Cambio_Turno

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Cambio_Turno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TXT_ACTUAL.Text = TURNO
        If TURNO = 1 Then
            Me.TXT_NUEVO.Text = 2 ' 1
        Else
            If CONFIG_TURNO = 3 Then
                If TURNO = 2 Then
                    Me.TXT_NUEVO.Text = 3
                Else
                    Me.TXT_NUEVO.Text = 1
                End If
            Else
                If TURNO = 2 Then
                    Me.TXT_NUEVO.Text = 1
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            GENERAR_CAMBIO()
            End
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Sub GENERAR_CAMBIO()
        On Error GoTo TrataError


        Dim CNN As SqlClient.SqlConnection
        Dim CMN As New SqlClient.SqlCommand
        'Dim da As New SqlClient.SqlDataAdapter(PROC, CN_NET)
        'CNN = New SqlClient.SqlConnection(Cnscb.cadcon)
        CMN.CommandText = "CAMBIO_TURNO"
        CMN.CommandType = CommandType.StoredProcedure
        CMN.Connection = CN_NET
        ''
        CMN.Parameters.Add("@TURNO", SqlDbType.Int)
        CMN.Parameters("@TURNO").Value = Me.TXT_NUEVO.Text
        CMN.Parameters.Add("@FECHA", SqlDbType.SmallDateTime)
        CMN.Parameters("@FECHA").Value = GFechaProceso
        CMN.Parameters.Add("@APTOCODI", SqlDbType.NVarChar)
        CMN.Parameters("@APTOCODI").Value = GPTOVTA
        CMN.Parameters.Add("@SW", SqlDbType.Int)
        CMN.Parameters("@SW").Direction = ParameterDirection.Output

        CN_NET.Open()

        CMN.ExecuteNonQuery()

        If CMN.Parameters("@SW").Value = 1 Then
            MsgBox("Debe generar cierre Z, antes de cambiar de turno ", MsgBoxStyle.Information)
        Else
            MsgBox("Cambio de turno generado correctamente", MsgBoxStyle.Information)
            TURNO = Me.TXT_NUEVO.Text
            If Me.Tag = "V" Then Ventas.TXT_TURNO.Text = TURNO
            CMN = Nothing
            Me.Close()
        End If
        CN_NET.Close()
TrataError:
        CMN = Nothing
        If Err.Number <> 0 Then Err.Raise(Err.Number, "STOCK INICIAL", Err.Description)
    End Sub
End Class
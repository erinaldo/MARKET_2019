Public Class Permisos_Usuarios
    Dim OBJUSER As ClsUsu
    Private Sub Permisos_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OBJUSER = New ClsUsu
        OBJUSER.LLENAR_USUARIOS(Me.Combo_USUARIOS)
        LLENAR_GRID()
    End Sub
    Sub LLENAR_GRID()
        Dim SQL As String
        Dim SQL1 As String
        Dim RS As SqlDataReader 'New ADODB.Recordset
        Dim FIL As Integer
        Dim F As Integer
        Dim OCOMANDO As SqlCommand
        SQL = "select * from sistema order by nivel1 asc"
        SQL1 = "select COUNT(*) from sistema "
        'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        OCOMANDO = New SqlCommand(SQL1, CN_NET)
        CN_NET.Open()
        FIL = CInt(OCOMANDO.ExecuteScalar)
        OCOMANDO = New SqlCommand(SQL, CN_NET)
        RS = OCOMANDO.ExecuteReader

        If RS.HasRows = True Then
            Me.DBLISTAR.Rows.Count = FIL + 1
            F = 1
            While RS.Read
                DBLISTAR.Item(F, 0) = RS("nivel1")
                Select Case Len(RS("nivel1"))
                    Case 2
                        Me.DBLISTAR.Item(F, 1) = RS("descripcion")
                    Case 4
                        Me.DBLISTAR.Item(F, 2) = RS("descripcion")
                    Case 6
                        Me.DBLISTAR.Item(F, 3) = RS("descripcion")
                End Select
                F = F + 1
            End While
        End If
        RS.Close()
        CN_NET.Close()
        Me.DBLISTAR.Cols(0).Visible = False
        Me.DBLISTAR.AutoSizeCols(1)
        Me.DBLISTAR.AutoSizeCols(2)
        Me.DBLISTAR.AutoSizeCols(3)
    End Sub

    Private Sub DBLISTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DBLISTAR.Click

    End Sub

    Private Sub DBLISTAR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DBLISTAR.DoubleClick
        Try
            Dim l As Integer
            Dim F As Integer
            Dim SQL As String
            Dim RS As SqlDataReader 'New ADODB.Recordset
            Dim OCOMANDO As SqlCommand
            Dim CNN As SqlConnection
            CNN = New SqlClient.SqlConnection(CAD_CON)
            If Me.Combo_USUARIOS.Text = "" Then MsgBox("Debe seleccionar al Usuario") : Exit Sub
            For F = 1 To Me.C1_PERMISOS.Rows.Count - 1
                If Me.DBLISTAR.Item(Me.DBLISTAR.Row, 0) = Me.C1_PERMISOS.Item(F, 0) Then
                    MsgBox("Este Nivel de Acceso ya esta asignado a este usuario")
                    Exit Sub
                End If
            Next
            ''''
            CN_NET.Open()
            l = Len(Me.DBLISTAR.Item(DBLISTAR.Row, 0))
            SQL = "delete from permisos where nivel1='" & Strings.Left(Me.DBLISTAR.Item(DBLISTAR.Row, 0), 2) & "' and cod_user='" & Me.Combo_USUARIOS.SelectedValue & "'"
            'Cnscb.conexion.Execute(SQL)
            OCOMANDO = New SqlCommand(SQL, CN_NET)
            OCOMANDO.ExecuteNonQuery()
            SQL = "delete from permisos where left(nivel1," & l & ")='" & Me.DBLISTAR.Item(DBLISTAR.Row, 0) & "' and cod_user='" & Me.Combo_USUARIOS.SelectedValue & "'"
            'Cnscb.conexion.Execute(SQL)
            OCOMANDO = New SqlCommand(SQL, CN_NET)
            OCOMANDO.ExecuteNonQuery()
            If l > 2 Then
                SQL = "insert into permisos values('" & Me.Combo_USUARIOS.SelectedValue & "','" & Strings.Left(Me.DBLISTAR.Item(DBLISTAR.Row, 0), 2) & "')"
                'Cnscb.conexion.Execute(SQL)
                OCOMANDO = New SqlCommand(SQL, CN_NET)
                OCOMANDO.ExecuteNonQuery()
            End If
            SQL = "select * from sistema where left(nivel1," & l & ")='" & Me.DBLISTAR.Item(DBLISTAR.Row, 0) & "'"
            OCOMANDO = New SqlCommand(SQL, CN_NET)
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            RS = OCOMANDO.ExecuteReader
            CNN.Open()
            While RS.Read
                SQL = "insert into permisos values('" & Me.Combo_USUARIOS.SelectedValue & "','" & RS("nivel1") & "')"
                Dim OCOMANDO1 As New SqlCommand(SQL, CNN)
                OCOMANDO1.ExecuteNonQuery()
            End While

            RS.Close()
            CNN.Close()
            CN_NET.Close()
            Call Combo_USUARIOS_SelectedIndexChanged(Combo_USUARIOS, EventArgs.Empty)

        Catch ex As Exception
            CN_NET.Close()
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub Combo_USUARIOS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo_USUARIOS.Click
      
    End Sub

    Private Sub Combo_USUARIOS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo_USUARIOS.SelectedIndexChanged
        Try
            Dim RS As SqlDataReader ' New ADODB.Recordset
            Dim SQL As String
            Dim SQL1 As String
            Dim F As Integer
            Dim FIL As Integer
            Dim OCOMANDO As SqlCommand
            Me.C1_PERMISOS.Rows.Count = 1
            SQL = "SELECT dbo.Permisos.cod_user, dbo.Permisos.nivel1, dbo.Sistema.descripcion FROM dbo.Sistema INNER JOIN  dbo.Permisos ON dbo.Sistema.nivel1 = dbo.Permisos.nivel1 where permisos.cod_user='" & Me.Combo_USUARIOS.SelectedValue & "' order by permisos.nivel1 asc"
            SQL1 = "SELECT COUNT(*) FROM dbo.Sistema INNER JOIN  dbo.Permisos ON dbo.Sistema.nivel1 = dbo.Permisos.nivel1 where permisos.cod_user='" & Me.Combo_USUARIOS.SelectedValue & "'"
            'RS.Open(SQL, Cnscb.conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            OCOMANDO = New SqlCommand(SQL1, CN_NET)
            CN_NET.Open()
            FIL = CInt(OCOMANDO.ExecuteScalar)
            OCOMANDO = New SqlCommand(SQL, CN_NET)
            RS = OCOMANDO.ExecuteReader
            If RS.HasRows = True Then
                Me.C1_PERMISOS.Rows.Count = FIL + 1
                F = 1
                While RS.Read
                    Me.C1_PERMISOS.Item(F, 0) = RS("nivel1")
                    Select Case Len(RS("nivel1"))
                        Case 2
                            Me.C1_PERMISOS.Item(F, 1) = RS("descripcion")
                        Case 4
                            Me.C1_PERMISOS.Item(F, 2) = RS("descripcion")
                        Case 6
                            Me.C1_PERMISOS.Item(F, 3) = RS("descripcion")
                    End Select
                    F = F + 1
                End While
            End If
            RS.Close()
            CN_NET.Close()
            Me.C1_PERMISOS.Cols(0).Visible = False
            Me.C1_PERMISOS.AutoSizeCols(1)
            Me.C1_PERMISOS.AutoSizeCols(2)
            Me.C1_PERMISOS.AutoSizeCols(3)
        Catch ex As Exception

            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub C1_PERMISOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1_PERMISOS.Click

    End Sub

    Private Sub C1_PERMISOS_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1_PERMISOS.DoubleClick
        Try
            Dim l As Integer
            Dim sql As String
            l = Len(Me.C1_PERMISOS.Item(Me.C1_PERMISOS.Row, 0))
            sql = "delete from permisos where left(nivel1," & l & ")='" & Me.C1_PERMISOS.Item(Me.C1_PERMISOS.Row, 0) & "' and cod_user='" & Me.Combo_USUARIOS.SelectedValue & "'"
            'Cnscb.conexion.Execute(sql)
            Dim OCOMANDO As New SqlCommand(sql, CN_NET)
            CN_NET.Open()
            OCOMANDO.ExecuteNonQuery()
            CN_NET.Close()
            Combo_USUARIOS_SelectedIndexChanged(Combo_USUARIOS, EventArgs.Empty)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class
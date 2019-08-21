Imports System.Net
Imports Tesseract
Imports MSXML2
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text.RegularExpressions
Imports System.Web

Namespace Libreria
    Public Class ClsSunat

        Public Enum Resul
            Ok = 0
            NoResul = 1
            ErrorCapcha = 2
            '' Error = 3,
        End Enum

        Private state As Resul
        Private _Nombres As String
        Private _ApePaterno As String
        Private _ApeMaterno As String
        Private _Estado As String
        Private _Condicion As String


        Private myCookie As CookieContainer

        Public ReadOnly Property GetCapcha() As Image
            Get
                Return ReadCapcha()
            End Get
        End Property
        Public ReadOnly Property Estado() As String
            Get
                Return _Estado
            End Get
        End Property
        Public ReadOnly Property Condicion() As String
            Get
                Return _Condicion
            End Get
        End Property
        Public ReadOnly Property Nombres() As String
            Get
                Return _Nombres
            End Get
        End Property
        Public ReadOnly Property ApePaterno() As String
            Get
                Return _ApePaterno
            End Get
        End Property
        Public ReadOnly Property ApeMaterno() As String
            Get
                Return _ApeMaterno
            End Get
        End Property

        Public ReadOnly Property GetResul() As Resul
            Get
                Return state
            End Get
        End Property

        Public Sub New()
            Try
                myCookie = Nothing
                myCookie = New CookieContainer()
                ServicePointManager.Expect100Continue = True
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3

                ReadCapcha()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Function ValidarCertificado(ByVal sender As Object, ByVal certificate As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As [Boolean]
            Return True
        End Function

        Private Function ReadCapcha() As Image
            Try
                System.Net.ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf ValidarCertificado)
                'Esta es la direccion que les pase en el grupo de facebook para obtener el captcha
                Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create("http://www.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image&magic=2"), HttpWebRequest)
                myWebRequest.CookieContainer = myCookie
                myWebRequest.Proxy = Nothing
                myWebRequest.Credentials = CredentialCache.DefaultCredentials
                Dim myWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
                Dim myImgStream As Stream = myWebResponse.GetResponseStream()
                'Modificación 1 ... Esta fue la primera modificación ... cree un mapa de bits que utilizaré como
                'parámetro para en fin ... mejor se los muestro xd
                Dim bm As New Bitmap(Image.FromStream(myImgStream))
                'quitamos el color a nuestro mapa de bits 
                qutarColor(bm)
                'Procesamos la imagen (separación de carácteres, alineación etc)
                'Y se devuelve la imagen lista para ser procesada por el OCR
                Return DirectCast(PreProcessImage(bm), Image)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Private Shared Function PreProcessImage(ByVal memStream As Bitmap) As Bitmap
            Dim bm As Bitmap = memStream
            ' Flatten Image to Black and White
            qutarColor(bm)

            ' We have a know 6 charcter captcha
            Dim charcters As New List(Of Rectangle)()
            Dim blackin_x As New List(Of Integer)()

            Dim x_max As Integer = bm.Width - 1
            Dim y_max As Integer = bm.Height - 1

            ' Here we are going to scan through the columns to determine if there in any black in them (charcter)
            For temp_x As Integer = 0 To x_max
                For temp_y As Integer = 0 To y_max
                    If bm.GetPixel(temp_x, temp_y).Name <> "ffffffff" Then
                        blackin_x.Add(temp_x)
                        Exit For
                    End If
                Next
            Next

            ' Building inital rectangles with X Boundaries
            ' This is where we are using our previous results to build the horiztonal boundaries of our charcters
            Dim temp_start As Integer = blackin_x(0)
            For temp_x As Integer = 0 To blackin_x.Count - 2
                If temp_x = blackin_x.Count - 2 Then
                    ' handles the last iteration
                    Dim r As New Rectangle()
                    r.X = temp_start
                    r.Width = blackin_x(temp_x) - r.X + 2

                    charcters.Add(r)
                End If
                If blackin_x(temp_x) - blackin_x(temp_x + 1) = -1 Then
                    Continue For
                Else
                    Dim r As New Rectangle()
                    r.X = temp_start
                    r.Width = blackin_x(temp_x) - r.X + 1
                    temp_start = blackin_x(temp_x + 1)
                    charcters.Add(r)

                End If
            Next

            ' Finish out by getting y boundaries
            For i As Integer = 0 To charcters.Count - 1
                Dim r As Rectangle = charcters(i)

                For temp_y As Integer = 0 To y_max - 1
                    If r.Y = 0 Then
                        If Not IsRowWhite(bm, temp_y, r.X, r.X + r.Width - 1) Then
                            r.Y = temp_y
                        End If
                    ElseIf r.Height = 0 Then
                        If IsRowWhite(bm, temp_y, r.X, r.X + r.Width - 1) Then
                            r.Height = temp_y - r.Y + 1
                        End If
                    Else
                        Exit For

                    End If
                Next

                ' have to do this as rectangle is struct
                charcters(i) = r
            Next



            Dim totalWidth As Integer = 1 + charcters.Sum(Function(o) o.Width) + (charcters.Count * 2)
            ' we need padding
            Dim totalHeight As Integer = charcters.Max(Function(o) o.Height) + 2
            ' padding here too 
            Dim current_x As Integer = 1
            ' start off the left edge 1px
            Dim bmp As New Bitmap(totalWidth, totalHeight)
            Dim g As Graphics = Graphics.FromImage(bmp)

            ' the following four lines are added to help image quality
            g.Clear(Color.White)
            g.InterpolationMode = InterpolationMode.High
            g.CompositingQuality = CompositingQuality.HighQuality
            g.SmoothingMode = SmoothingMode.AntiAlias

            ' take our four charcters and move them into a new bitmap 
            For Each r As Rectangle In charcters
                g.DrawImage(bm, current_x, 1, r, GraphicsUnit.Pixel)
                current_x += r.Width + 2
            Next

            '  bmp.Save(@"C:\postprocess.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            Return bmp
        End Function

        ''/// <summary>
        ''  /// Determines whether the specified row in the bitmap contains white.
        ''/// </summary>
        ''/// <param name="bm">The Image.</param>
        ''/// <param name="temp_y">The temp_y.</param>
        ''  /// <param name="x">The x.</param>
        ''/// <param name="width">The width.</param>
        ''/// <returns></returns>
        Private Shared Function IsRowWhite(ByVal bm As Bitmap, ByVal temp_y As Integer, ByVal x As Integer, ByVal width As Integer) As Boolean
            For i As Integer = x To width - 1
                If bm.GetPixel(i, temp_y).Name <> "ffffffff" Then
                    Return False
                End If
            Next
            Return True
        End Function
        ''// Aqui quitamos el color ... lo dejamos en blanco y negro (El captcha)
        Public Shared Sub qutarColor(ByVal bm As Bitmap)
            For x As Integer = 0 To bm.Width - 1
                For y As Integer = 0 To bm.Height - 1
                    Dim pix As Color = bm.GetPixel(x, y)
                    'Aqui puedes jugar con los valores del brillo yo he probado poco pero tu puedes cambiarlo
                    If pix.GetBrightness() > 0.87F Then
                        bm.SetPixel(x, y, Color.White)
                    Else
                        bm.SetPixel(x, y, Color.Black)
                    End If
                Next
            Next
        End Sub

        Public Sub GetInfo(ByVal numDni As String, ByVal ImgCapcha As String)
            Dim xRazSoc As String = ""
            Dim xEst As String = ""
            Dim xCon As String = ""
            Dim xDir As String = ""
            Dim xAg As String = ""
            Dim xEstado As String = ""
            Dim xCondicion As String = ""
            Try
                'A este link le pasamos los datos , RUC y valor del captcha
                Dim myUrl As String = [String].Format("http://www.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={0}&codigo={1}", numDni, ImgCapcha)
                Dim myWebRequest As HttpWebRequest = DirectCast(WebRequest.Create(myUrl), HttpWebRequest)
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0"
                myWebRequest.CookieContainer = myCookie
                myWebRequest.Credentials = CredentialCache.DefaultCredentials
                myWebRequest.Proxy = Nothing
                Dim myHttpWebResponse As HttpWebResponse = DirectCast(myWebRequest.GetResponse(), HttpWebResponse)
                Dim myStream As Stream = myHttpWebResponse.GetResponseStream()
                Dim myStreamReader As New StreamReader(myStream)
                'Leemos los datos
                Dim xDat As String = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd())
                If xDat.Length <= 635 Then
                    Return
                End If
                Dim tabla As String()
                xDat = xDat.Replace("     ", " ")
                xDat = xDat.Replace("    ", " ")
                xDat = xDat.Replace("   ", " ")
                xDat = xDat.Replace("  ", " ")
                xDat = xDat.Replace("( ", "(")
                xDat = xDat.Replace(" )", ")")
                'Lo convertimos a tabla o mejor dicho a un arreglo de string como se ve declarado arriba
                tabla = Regex.Split(xDat, "<td class")
                'separamos el arreglo que hasta ese momento tenia 1 solo item , y lo dividimos por la etiqueta tdclass
                'Esto lo hice porque cuando es persona el ruc empieza con 1 
                'y tiene un resultado distinto a cuando es empresa ...
                If numDni.StartsWith("1") Then
                    'hacemos el parseo 
                    tabla(1) = tabla(1).Replace((Convert.ToString("=""bg"" colspan=3>") & numDni) + " - ", "")
                    tabla(1) = tabla(1).Replace("</td>" & vbCr & vbLf & " </tr>" & vbCr & vbLf & " <tr>" & vbCr & vbLf, "")
                    tabla(12) = tabla(12).Replace("=""bg"" colspan=1>", "")
                    tabla(12) = tabla(12).Replace("</td>", "")
                    tabla(15) = tabla(15).Replace("=""bg"" colspan=3>", "").Trim
                    tabla(15) = tabla(15).Replace("</td>", "")
                    tabla(15) = tabla(15).Replace("</tr>", "")
                    tabla(15) = tabla(15).Replace(" <tr>", "")
                    tabla(17) = tabla(17).Replace("=""bg"" colspan=3>", "")
                    tabla(17) = tabla(17).Replace("</td>" & vbCr & vbLf & " </tr>" & vbCr & vbLf & "<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->" & vbCr & vbLf & "<!-- <tr> -->" & vbCr & vbLf & "<!-- ", "")
                    xEstado = DirectCast(tabla(12), String)
                    xCondicion = DirectCast(tabla(15), String)
                    xRazSoc = DirectCast(tabla(1), String)
                    xDir = DirectCast(tabla(17), String)
                ElseIf numDni.StartsWith("2") Then
                    'bueno aqui es empresa ...
                    tabla(1) = tabla(1).Replace((Convert.ToString("=""bg"" colspan=3>") & numDni) + " - ", "")
                    tabla(1) = tabla(1).Replace("</td>" & vbCr & vbLf & " </tr>" & vbCr & vbLf & " <tr>" & vbCr & vbLf, "")
                    tabla(15) = tabla(15).Replace("=""bg"" colspan=3>", "")
                    tabla(15) = tabla(15).Replace("</td>" & vbCr & vbLf & " </tr>" & vbCr & vbLf & "<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->" & vbCr & vbLf & "<!-- <tr> -->" & vbCr & vbLf & "<!-- ", "")
                    'tabla(17) = tabla(17).Replace("=""bg"" colspan=3>", "")
                    'tabla(17) = tabla(17).Replace("</td>" & vbCr & vbLf & " </tr>" & vbCr & vbLf & "<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->" & vbCr & vbLf & "<!-- <tr> -->" & vbCr & vbLf & "<!-- ", "")
                    ''
                    tabla(10) = tabla(10).Replace("=""bg"" colspan=1>", "")
                    tabla(10) = tabla(10).Replace("</td>", "")
                    tabla(13) = tabla(13).Replace("=""bg"" colspan=3>", "").Trim
                    tabla(13) = tabla(13).Replace("</td>", "")
                    tabla(13) = tabla(13).Replace("</tr>", "")
                    tabla(13) = tabla(13).Replace(" <tr>", "")
                    ''
                    xEstado = DirectCast(tabla(10), String)
                    xCondicion = DirectCast(tabla(13), String)
                    xRazSoc = DirectCast(tabla(1), String)
                    xDir = DirectCast(tabla(15), String)
                End If

                'los resultados
                'Como ven en el arreglo se pueden obtener mas datos pero yaa pues el parseo lo hacen uds...
                _Nombres = xRazSoc
                _ApeMaterno = xDir
                _Estado = xEstado
                _Condicion = xCondicion
            Catch ex As Exception
                ' throw ex;
                _Nombres = "Error!"
            End Try
        End Sub


    End Class
End Namespace
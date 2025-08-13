Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.exceptions

Public Class PdfWatermark
    Public Shared Function AddWatermark(inputPdfPath As String, outputPdfPath As String, watermarkText As String) As Boolean
        Try
            ' Validación básica de parámetros
            If String.IsNullOrEmpty(inputPdfPath) Then
                Throw New ArgumentNullException("inputPdfPath", "La ruta del PDF de entrada no puede estar vacía.")
            End If
            If String.IsNullOrEmpty(outputPdfPath) Then
                Throw New ArgumentNullException("outputPdfPath", "La ruta del PDF de salida no puede estar vacía.")
            End If
            If Not File.Exists(inputPdfPath) Then
                Throw New FileNotFoundException("El archivo PDF de entrada no existe en la ruta especificada.", inputPdfPath)
            End If

            ' Procesamiento del PDF
            Using reader As New PdfReader(inputPdfPath)
                Using fs As New FileStream(outputPdfPath, FileMode.Create, FileAccess.Write)
                    Dim stamper As New PdfStamper(reader, fs)
                    Dim totalPages As Integer = reader.NumberOfPages

                    For i As Integer = 1 To totalPages
                        Dim pdfContentByte As PdfContentByte = stamper.GetOverContent(i)
                        Dim font As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED)

                        ' Configuración de marca de agua
                        Dim fontSize As Single = 60
                        Dim x As Single = 300
                        Dim y As Single = 400
                        Dim angle As Single = 45

                        pdfContentByte.SaveState()
                        Dim gstate As New PdfGState() With {.FillOpacity = 0.3F}
                        pdfContentByte.SetGState(gstate)

                        pdfContentByte.BeginText()
                        pdfContentByte.SetColorFill(BaseColor.GRAY)
                        pdfContentByte.SetFontAndSize(font, fontSize)
                        pdfContentByte.ShowTextAligned(Element.ALIGN_CENTER, watermarkText, x, y, angle)
                        pdfContentByte.EndText()
                        pdfContentByte.RestoreState()
                    Next

                    stamper.Close()
                End Using
            End Using

            Return True

        Catch ex As ArgumentNullException
            ' Errores de parámetros nulos/vacíos
            Throw New Exception("Error en parámetros: " & ex.Message, ex)

        Catch ex As FileNotFoundException
            ' Archivo de entrada no encontrado
            Throw New Exception("Error de archivo: " & ex.Message, ex)

        Catch ex As BadPasswordException
            ' PDF protegido con contraseña
            Throw New Exception("El PDF está protegido con contraseña.", ex)

        Catch ex As IOException
            ' Errores de E/S (archivo en uso, permisos, etc.)
            Throw New Exception("Error de acceso al archivo: " & ex.Message, ex)

        Catch ex As PdfException
            ' Errores específicos de iTextSharp
            Throw New Exception("Error al procesar el PDF: " & ex.Message, ex)

        Catch ex As Exception
            ' Cualquier otro error inesperado
            Throw New Exception("Error inesperado al agregar marca de agua: " & ex.Message, ex)
        End Try
    End Function
End Class
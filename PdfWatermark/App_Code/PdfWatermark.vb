Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class PdfWatermark
    Public Shared Sub AddWatermark(inputPdfPath As String, outputPdfPath As String, watermarkText As String)
        ' Abre el PDF existente
        Using reader As New PdfReader(inputPdfPath)
            Using fs As New FileStream(outputPdfPath, FileMode.Create, FileAccess.Write)
                ' Crea un escritor para el nuevo PDF
                Dim stamper As New PdfStamper(reader, fs)
                Dim totalPages As Integer = reader.NumberOfPages

                For i As Integer = 1 To totalPages
                    ' Obtiene la página
                    Dim pdfContentByte As PdfContentByte = stamper.GetOverContent(i)

                    ' Configura la fuente
                    Dim font As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.WINANSI, BaseFont.NOT_EMBEDDED)

                    ' Configura el tamaño y la posición de la marca de agua
                    Dim fontSize As Single = 60
                    Dim x As Single = 300
                    Dim y As Single = 400

                    ' Guarda la posición y rotación
                    pdfContentByte.SaveState()

                    ' Configura la transparencia
                    Dim gstate As PdfGState = New PdfGState()
                    gstate.FillOpacity = 0.3F
                    pdfContentByte.SetGState(gstate)

                    ' Define el angulo y la rotación en grados
                    Dim angle As Single = 45

                    ' Aplica la rotación y la posicion
                    pdfContentByte.BeginText()
                    pdfContentByte.SetColorFill(BaseColor.GRAY)
                    pdfContentByte.SetFontAndSize(font, fontSize)
                    pdfContentByte.ShowTextAligned(Element.ALIGN_CENTER, watermarkText, x, y, angle)

                    pdfContentByte.RestoreState()
                Next

                stamper.Close()
            End Using
        End Using
    End Sub
End Class

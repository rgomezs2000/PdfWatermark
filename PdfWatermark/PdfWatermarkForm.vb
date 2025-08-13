Imports PdfWatermark
Imports System.IO

Public Class PdfWatermarkForm
    Dim FilePDF As String
    Dim PathPDF As String
    Dim FilenamePDF As String
    Dim FilenamePDF2 As String
    Dim ExtPDF As String
    Dim FilePDFNew As String
    Dim StrWatermark As String

    Private Sub BtnOpenPDF_Click(sender As Object, e As EventArgs) Handles BtnOpenPDF.Click
        Dim openPDFDialog As New OpenFileDialog()

        openPDFDialog.Title = "Abrir PDF"
        openPDFDialog.Filter = "PDF (*.pdf)|*.pdf"
        openPDFDialog.FilterIndex = 1
        openPDFDialog.RestoreDirectory = True

        If openPDFDialog.ShowDialog() = DialogResult.OK Then
            If openPDFDialog.FileName.ToLower().EndsWith(".pdf") Then
                ' Asignar la ruta completa al TextBox (como antes)
                TxtOpenPDF.Text = openPDFDialog.FileName

                ' --- DESGLOSE DEL ARCHIVO ---
                FilePDF = openPDFDialog.FileName
                PathPDF = Path.GetDirectoryName(FilePDF)  ' Ruta de la carpeta
                FilenamePDF2 = Path.GetFileName(FilePDF)  ' Nombre + extensión
                FilenamePDF = Path.GetFileNameWithoutExtension(FilePDF)  ' Nombre sin extensión
                ExtPDF = Path.GetExtension(FilePDF)  ' Extensión (incluye el punto, ej: ".pdf")
            Else
                MessageBox.Show("El archivo no es un PDF válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debes seleccionar un archivo PDF.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If TxtOpenPDF.Text = "" Then
                MessageBox.Show("Debes seleccionar un archivo PDF.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtWatermark.Text = "" Then
                MessageBox.Show("Debes colocar un texto para la marca de agua.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf Not (TxtOpenPDF.Text.ToLower().EndsWith(".pdf")) Then
                MessageBox.Show("El archivo no es un PDF válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not File.Exists(TxtOpenPDF.Text) Then
                MessageBox.Show("El archivo PDF no existe en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                FilePDF = TxtOpenPDF.Text
                PathPDF = Path.GetDirectoryName(FilePDF)  ' Ruta de la carpeta
                FilenamePDF2 = Path.GetFileName(FilePDF)  ' Nombre + extensión
                FilenamePDF = Path.GetFileNameWithoutExtension(FilePDF)  ' Nombre sin extensión
                ExtPDF = Path.GetExtension(FilePDF)  ' Extensión (incluye el punto, ej: ".pdf")
                FilePDFNew = PathPDF & "\" & FilenamePDF & "_nuevo" & ExtPDF
                StrWatermark = TxtWatermark.Text
                Dim pdfWatermark As PdfWatermark = New PdfWatermark()

                Dim success As Boolean = PdfWatermark.AddWatermark(FilePDF, FilePDFNew, StrWatermark)

                If success Then
                    MessageBox.Show("Marca de agua agregada exitosamente!", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("No se pudo acceder al archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

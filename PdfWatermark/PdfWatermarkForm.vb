Imports PdfWatermark

Public Class PdfWatermarkForm
    Private Sub BtnOpenPDF_Click(sender As Object, e As EventArgs) Handles BtnOpenPDF.Click
        ' Configurar el OpenFileDialog
        Dim openPDFDialog As New OpenFileDialog()

        ' Coloque un Titulo
        openPDFDialog.Title = "Abrir PDF"

        ' Solo que admita PDF
        openPDFDialog.Filter = "PDF (*.pdf)|*.pdf"

        ' Que sea PDF como el prncipal
        openPDFDialog.FilterIndex = 1

        ' Que tome la ultima ruta seleccionado
        openPDFDialog.RestoreDirectory = True

        ' Se valida si es PDF sino, no se selecciona
        If openPDFDialog.FileName.EndsWith(".pdf") Or openPDFDialog.FileName.EndsWith(".PDF") Then
            If openPDFDialog.ShowDialog() = DialogResult.OK Then
                TxtOpenPDF.Text = openPDFDialog.FileName
            Else
                MessageBox.Show("Debes seleccionar un archivo PDF.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("El archivo no es un PDF válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

    End Sub
End Class

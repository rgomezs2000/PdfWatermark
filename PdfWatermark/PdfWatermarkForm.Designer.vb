<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PdfWatermarkForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtOpenPDF = New System.Windows.Forms.TextBox()
        Me.BtnOpenPDF = New System.Windows.Forms.Button()
        Me.LblOpenPDF = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitulo, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.97196!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.02804!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(454, 214)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(3, 15)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(448, 31)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Coloque tu PDF una Marca de Agua"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAceptar.Location = New System.Drawing.Point(186, 89)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 1
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.53004!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.46996!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.LblOpenPDF, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnOpenPDF, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtOpenPDF, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(7, 13)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(434, 29)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TxtOpenPDF
        '
        Me.TxtOpenPDF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtOpenPDF.Location = New System.Drawing.Point(257, 4)
        Me.TxtOpenPDF.Name = "TxtOpenPDF"
        Me.TxtOpenPDF.Size = New System.Drawing.Size(174, 20)
        Me.TxtOpenPDF.TabIndex = 2
        '
        'BtnOpenPDF
        '
        Me.BtnOpenPDF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnOpenPDF.Location = New System.Drawing.Point(153, 4)
        Me.BtnOpenPDF.Name = "BtnOpenPDF"
        Me.BtnOpenPDF.Size = New System.Drawing.Size(75, 20)
        Me.BtnOpenPDF.TabIndex = 1
        Me.BtnOpenPDF.Text = "Abrir PDF"
        Me.BtnOpenPDF.UseVisualStyleBackColor = True
        '
        'LblOpenPDF
        '
        Me.LblOpenPDF.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblOpenPDF.AutoSize = True
        Me.LblOpenPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpenPDF.Location = New System.Drawing.Point(3, 6)
        Me.LblOpenPDF.Name = "LblOpenPDF"
        Me.LblOpenPDF.Size = New System.Drawing.Size(120, 16)
        Me.LblOpenPDF.TabIndex = 0
        Me.LblOpenPDF.Text = "Seleccione el PDF"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnAceptar, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 64)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.0411!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.9589!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(448, 146)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'PdfWatermarkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(477, 238)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "PdfWatermarkForm"
        Me.Text = "Marca de Agua PDF"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LblOpenPDF As Label
    Friend WithEvents BtnOpenPDF As Button
    Friend WithEvents TxtOpenPDF As TextBox
    Friend WithEvents BtnAceptar As Button
End Class

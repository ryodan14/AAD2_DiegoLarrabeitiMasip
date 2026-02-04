<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblTituloD = New System.Windows.Forms.Label()
        Me.lblAnioD = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblPrecioD = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblSipnosis = New System.Windows.Forms.Label()
        Me.lblSipnosisD = New System.Windows.Forms.Label()
        Me.btVenta = New System.Windows.Forms.Button()
        Me.btVolver = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(62, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 246)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(301, 61)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(73, 25)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Titulo:"
        '
        'lblTituloD
        '
        Me.lblTituloD.AutoSize = True
        Me.lblTituloD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloD.Location = New System.Drawing.Point(564, 61)
        Me.lblTituloD.Name = "lblTituloD"
        Me.lblTituloD.Size = New System.Drawing.Size(64, 25)
        Me.lblTituloD.TabIndex = 2
        Me.lblTituloD.Text = "label1"
        '
        'lblAnioD
        '
        Me.lblAnioD.AutoSize = True
        Me.lblAnioD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioD.Location = New System.Drawing.Point(564, 113)
        Me.lblAnioD.Name = "lblAnioD"
        Me.lblAnioD.Size = New System.Drawing.Size(64, 25)
        Me.lblAnioD.TabIndex = 4
        Me.lblAnioD.Text = "label2"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(301, 113)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(166, 25)
        Me.lblAño.TabIndex = 3
        Me.lblAño.Text = "Año de estreno:"
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.Location = New System.Drawing.Point(564, 184)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(64, 25)
        Me.lblDuracion.TabIndex = 6
        Me.lblDuracion.Text = "label3"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(301, 184)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(238, 25)
        Me.lblTiempo.TabIndex = 5
        Me.lblTiempo.Text = "Duración de la pelicula:"
        '
        'lblPrecioD
        '
        Me.lblPrecioD.AutoSize = True
        Me.lblPrecioD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioD.Location = New System.Drawing.Point(564, 245)
        Me.lblPrecioD.Name = "lblPrecioD"
        Me.lblPrecioD.Size = New System.Drawing.Size(64, 25)
        Me.lblPrecioD.TabIndex = 8
        Me.lblPrecioD.Text = "label4"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(301, 245)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(212, 25)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "Precio de la entrada:"
        '
        'lblSipnosis
        '
        Me.lblSipnosis.AutoSize = True
        Me.lblSipnosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSipnosis.Location = New System.Drawing.Point(301, 303)
        Me.lblSipnosis.Name = "lblSipnosis"
        Me.lblSipnosis.Size = New System.Drawing.Size(102, 25)
        Me.lblSipnosis.TabIndex = 9
        Me.lblSipnosis.Text = "Sipnosis:"
        '
        'lblSipnosisD
        '
        Me.lblSipnosisD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSipnosisD.Location = New System.Drawing.Point(445, 303)
        Me.lblSipnosisD.Name = "lblSipnosisD"
        Me.lblSipnosisD.Size = New System.Drawing.Size(603, 242)
        Me.lblSipnosisD.TabIndex = 10
        Me.lblSipnosisD.Text = "label5"
        '
        'btVenta
        '
        Me.btVenta.Location = New System.Drawing.Point(62, 449)
        Me.btVenta.Name = "btVenta"
        Me.btVenta.Size = New System.Drawing.Size(202, 39)
        Me.btVenta.TabIndex = 11
        Me.btVenta.Text = "Vender entradas"
        Me.btVenta.UseVisualStyleBackColor = True
        '
        'btVolver
        '
        Me.btVolver.Location = New System.Drawing.Point(973, 556)
        Me.btVolver.Name = "btVolver"
        Me.btVolver.Size = New System.Drawing.Size(75, 23)
        Me.btVolver.TabIndex = 12
        Me.btVolver.Text = "Volver"
        Me.btVolver.UseVisualStyleBackColor = True
        '
        'Pelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 591)
        Me.Controls.Add(Me.btVolver)
        Me.Controls.Add(Me.btVenta)
        Me.Controls.Add(Me.lblSipnosisD)
        Me.Controls.Add(Me.lblSipnosis)
        Me.Controls.Add(Me.lblPrecioD)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblAnioD)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.lblTituloD)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Pelicula"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTituloD As Label
    Friend WithEvents lblAnioD As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblPrecioD As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblSipnosis As Label
    Friend WithEvents lblSipnosisD As Label
    Friend WithEvents btVenta As Button
    Friend WithEvents btVolver As Button
End Class

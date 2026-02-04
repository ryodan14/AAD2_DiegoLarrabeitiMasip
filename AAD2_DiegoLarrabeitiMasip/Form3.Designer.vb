<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btCompra = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(59, 36)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(322, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Seleccione la cantidad de entradas:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(64, 91)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(317, 22)
        Me.NumericUpDown1.TabIndex = 1
        '
        'btCompra
        '
        Me.btCompra.Location = New System.Drawing.Point(64, 181)
        Me.btCompra.Name = "btCompra"
        Me.btCompra.Size = New System.Drawing.Size(108, 60)
        Me.btCompra.TabIndex = 2
        Me.btCompra.Text = "Comprar"
        Me.btCompra.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Location = New System.Drawing.Point(273, 181)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(108, 60)
        Me.btSalir.TabIndex = 3
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 378)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btCompra)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btCompra As Button
    Friend WithEvents btSalir As Button
End Class

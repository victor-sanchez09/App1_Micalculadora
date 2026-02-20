<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Suma = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Resta = New System.Windows.Forms.Button()
        Me.Division = New System.Windows.Forms.Button()
        Me.Multiplicacion = New System.Windows.Forms.Button()
        Me.Boton0 = New System.Windows.Forms.Button()
        Me.Boton6 = New System.Windows.Forms.Button()
        Me.Boton1 = New System.Windows.Forms.Button()
        Me.Boton2 = New System.Windows.Forms.Button()
        Me.Boton3 = New System.Windows.Forms.Button()
        Me.Boton7 = New System.Windows.Forms.Button()
        Me.Boton4 = New System.Windows.Forms.Button()
        Me.Boton5 = New System.Windows.Forms.Button()
        Me.Boton8 = New System.Windows.Forms.Button()
        Me.Boton9 = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Butonpunto = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.Enabled = False
        Me.Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.Location = New System.Drawing.Point(266, 103)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(100, 29)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        '
        'Suma
        '
        Me.Suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suma.Location = New System.Drawing.Point(870, 75)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(101, 76)
        Me.Suma.TabIndex = 1
        Me.Suma.Text = "+"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(110, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Etiqueta 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(110, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Etiqueta 2"
        '
        'Num2
        '
        Me.Num2.Enabled = False
        Me.Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.Location = New System.Drawing.Point(266, 141)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(100, 29)
        Me.Num2.TabIndex = 4
        Me.Num2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(110, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resultado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria Math", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(265, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 106)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "0"
        '
        'Resta
        '
        Me.Resta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resta.Location = New System.Drawing.Point(870, 166)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(101, 76)
        Me.Resta.TabIndex = 7
        Me.Resta.Text = "-"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Division.Location = New System.Drawing.Point(870, 350)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(101, 76)
        Me.Division.TabIndex = 8
        Me.Division.Text = "/"
        Me.Division.UseVisualStyleBackColor = True
        '
        'Multiplicacion
        '
        Me.Multiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicacion.Location = New System.Drawing.Point(870, 258)
        Me.Multiplicacion.Name = "Multiplicacion"
        Me.Multiplicacion.Size = New System.Drawing.Size(101, 76)
        Me.Multiplicacion.TabIndex = 9
        Me.Multiplicacion.Text = "x"
        Me.Multiplicacion.UseVisualStyleBackColor = True
        '
        'Boton0
        '
        Me.Boton0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton0.Location = New System.Drawing.Point(624, 350)
        Me.Boton0.Name = "Boton0"
        Me.Boton0.Size = New System.Drawing.Size(101, 75)
        Me.Boton0.TabIndex = 10
        Me.Boton0.Text = "0"
        Me.Boton0.UseVisualStyleBackColor = True
        '
        'Boton6
        '
        Me.Boton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton6.Location = New System.Drawing.Point(748, 166)
        Me.Boton6.Name = "Boton6"
        Me.Boton6.Size = New System.Drawing.Size(101, 75)
        Me.Boton6.TabIndex = 11
        Me.Boton6.Text = "6"
        Me.Boton6.UseVisualStyleBackColor = True
        '
        'Boton1
        '
        Me.Boton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton1.Location = New System.Drawing.Point(503, 258)
        Me.Boton1.Name = "Boton1"
        Me.Boton1.Size = New System.Drawing.Size(101, 75)
        Me.Boton1.TabIndex = 12
        Me.Boton1.Text = "1"
        Me.Boton1.UseVisualStyleBackColor = True
        '
        'Boton2
        '
        Me.Boton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton2.Location = New System.Drawing.Point(624, 258)
        Me.Boton2.Name = "Boton2"
        Me.Boton2.Size = New System.Drawing.Size(101, 75)
        Me.Boton2.TabIndex = 13
        Me.Boton2.Text = "2"
        Me.Boton2.UseVisualStyleBackColor = True
        '
        'Boton3
        '
        Me.Boton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton3.Location = New System.Drawing.Point(748, 258)
        Me.Boton3.Name = "Boton3"
        Me.Boton3.Size = New System.Drawing.Size(101, 75)
        Me.Boton3.TabIndex = 14
        Me.Boton3.Text = "3"
        Me.Boton3.UseVisualStyleBackColor = True
        '
        'Boton7
        '
        Me.Boton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton7.Location = New System.Drawing.Point(503, 75)
        Me.Boton7.Name = "Boton7"
        Me.Boton7.Size = New System.Drawing.Size(101, 75)
        Me.Boton7.TabIndex = 15
        Me.Boton7.Text = "7"
        Me.Boton7.UseVisualStyleBackColor = True
        '
        'Boton4
        '
        Me.Boton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton4.Location = New System.Drawing.Point(503, 166)
        Me.Boton4.Name = "Boton4"
        Me.Boton4.Size = New System.Drawing.Size(101, 75)
        Me.Boton4.TabIndex = 16
        Me.Boton4.Text = "4"
        Me.Boton4.UseVisualStyleBackColor = True
        '
        'Boton5
        '
        Me.Boton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton5.Location = New System.Drawing.Point(624, 166)
        Me.Boton5.Name = "Boton5"
        Me.Boton5.Size = New System.Drawing.Size(101, 75)
        Me.Boton5.TabIndex = 17
        Me.Boton5.Text = "5"
        Me.Boton5.UseVisualStyleBackColor = True
        '
        'Boton8
        '
        Me.Boton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton8.Location = New System.Drawing.Point(624, 76)
        Me.Boton8.Name = "Boton8"
        Me.Boton8.Size = New System.Drawing.Size(101, 75)
        Me.Boton8.TabIndex = 18
        Me.Boton8.Text = "8"
        Me.Boton8.UseVisualStyleBackColor = True
        '
        'Boton9
        '
        Me.Boton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boton9.Location = New System.Drawing.Point(748, 75)
        Me.Boton9.Name = "Boton9"
        Me.Boton9.Size = New System.Drawing.Size(101, 75)
        Me.Boton9.TabIndex = 19
        Me.Boton9.Text = "9"
        Me.Boton9.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eliminar.Location = New System.Drawing.Point(748, 350)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(101, 75)
        Me.Eliminar.TabIndex = 20
        Me.Eliminar.Text = "C"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Butonpunto
        '
        Me.Butonpunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butonpunto.Location = New System.Drawing.Point(503, 350)
        Me.Butonpunto.Name = "Butonpunto"
        Me.Butonpunto.Size = New System.Drawing.Size(101, 75)
        Me.Butonpunto.TabIndex = 21
        Me.Butonpunto.Text = "."
        Me.Butonpunto.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(389, 108)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 22
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(389, 150)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(1000, 604)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Butonpunto)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Boton9)
        Me.Controls.Add(Me.Boton8)
        Me.Controls.Add(Me.Boton5)
        Me.Controls.Add(Me.Boton4)
        Me.Controls.Add(Me.Boton7)
        Me.Controls.Add(Me.Boton3)
        Me.Controls.Add(Me.Boton2)
        Me.Controls.Add(Me.Boton1)
        Me.Controls.Add(Me.Boton6)
        Me.Controls.Add(Me.Boton0)
        Me.Controls.Add(Me.Multiplicacion)
        Me.Controls.Add(Me.Division)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.Num1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num1 As TextBox
    Friend WithEvents Suma As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Resta As Button
    Friend WithEvents Division As Button
    Friend WithEvents Multiplicacion As Button
    Friend WithEvents Boton0 As Button
    Friend WithEvents Boton6 As Button
    Friend WithEvents Boton1 As Button
    Friend WithEvents Boton2 As Button
    Friend WithEvents Boton3 As Button
    Friend WithEvents Boton7 As Button
    Friend WithEvents Boton4 As Button
    Friend WithEvents Boton5 As Button
    Friend WithEvents Boton8 As Button
    Friend WithEvents Boton9 As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Butonpunto As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class

Public Class Form1
    Dim activo

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Suma.Click
        Dim Numero1 As Double = Double.Parse(Me.Num1.Text)
        Dim Numero2 As Double = Double.Parse(Me.Num2.Text)

        Dim resultado As Double = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Num1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Resta.Click
        Dim Numero1 As Double = Double.Parse(Me.Num1.Text)
        Dim Numero2 As Double = Double.Parse(Me.Num2.Text)

        Dim resultado As Double = Numero1 - Numero2

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click
        Dim Numero1 As Double = Double.Parse(Me.Num1.Text)
        Dim Numero2 As Double = Double.Parse(Me.Num2.Text)

        Dim resultado As Double = Numero1 * Numero2

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Division.Click
        Dim resultado

        Dim Numero1 As Double = Double.Parse(Me.Num1.Text)
        Dim Numero2 As Double = Double.Parse(Me.Num2.Text)

        If Numero2 > 0 Then
            resultado = Numero1 / Numero2
        Else
            resultado = "No se puede"
        End If

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        activo.Text = activo.Text & "0"
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        activo.Text = activo.Text & "1"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        activo.Text = activo.Text & "2"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        activo.Text = activo.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        activo.Text = activo.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        activo.Text = activo.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        activo.Text = Num1.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        activo.Text = activo.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        activo.Text = activo.Text & "9"
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        activo.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = Num1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = Num2
    End Sub

    Private Sub Butonpunto_Click(sender As Object, e As EventArgs) Handles Butonpunto.Click
        activo.Text = activo.Text & "."
    End Sub
End Class

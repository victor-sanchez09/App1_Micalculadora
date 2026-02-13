Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Suma.Click
        Dim Numero1 As Integer = Integer.Parse(Me.Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.Num2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Num1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Resta.Click
        Dim Numero1 As Integer = Integer.Parse(Me.Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.Num2.Text)

        Dim resultado As Integer = Numero1 - Numero2

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Multiplicacion.Click
        Dim Numero1 As Integer = Integer.Parse(Me.Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.Num2.Text)

        Dim resultado As Integer = Numero1 * Numero2

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Division.Click
        Dim Numero1 As Integer = Integer.Parse(Me.Num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.Num2.Text)

        Dim resultado As Integer = Numero1 / Numero2

        Label4.Text = resultado.ToString
    End Sub

    Private Sub Boton0_Click(sender As Object, e As EventArgs) Handles Boton0.Click
        Num1.Text = Num1.Text & "0"
    End Sub

    Private Sub Boton1_Click(sender As Object, e As EventArgs) Handles Boton1.Click
        Num1.Text = Num1.Text & "1"
    End Sub

    Private Sub Boton2_Click(sender As Object, e As EventArgs) Handles Boton2.Click
        Num1.Text = Num1.Text & "2"
    End Sub

    Private Sub Boton3_Click(sender As Object, e As EventArgs) Handles Boton3.Click
        Num1.Text = Num1.Text & "3"
    End Sub

    Private Sub Boton4_Click(sender As Object, e As EventArgs) Handles Boton4.Click
        Num1.Text = Num1.Text & "4"
    End Sub

    Private Sub Boton5_Click(sender As Object, e As EventArgs) Handles Boton5.Click
        Num1.Text = Num1.Text & "5"
    End Sub

    Private Sub Boton6_Click(sender As Object, e As EventArgs) Handles Boton6.Click
        Num1.Text = Num1.Text & "6"
    End Sub

    Private Sub Boton7_Click(sender As Object, e As EventArgs) Handles Boton7.Click
        Num1.Text = Num1.Text & "7"
    End Sub

    Private Sub Boton8_Click(sender As Object, e As EventArgs) Handles Boton8.Click
        Num1.Text = Num1.Text & "8"
    End Sub

    Private Sub Boton9_Click(sender As Object, e As EventArgs) Handles Boton9.Click
        Num1.Text = Num1.Text & "9"
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Num1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

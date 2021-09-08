Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim sePrecionaOperador As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "1"
        txtValor.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "2"
        txtValor.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "3"
        txtValor.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "4"
        txtValor.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "5"
        txtValor.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "6"
        txtValor.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "7"
        txtValor.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "8"
        txtValor.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "9"
        txtValor.Text &= "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluaRestrinccionesParaConcatenar()
        txtResultado.Text &= "0"
        txtValor.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestrinccionesParaConcatenar()
        If InStr(txtResultado.Text, ".", CompareMethod.Text) = 0 Then
            txtResultado.Text &= "."
            txtValor.Text &= "."
        End If
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        txtValor.Text &= "="
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        txtResultado.Text = "0"
        txtValor.Text = Nothing
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonSumar_Click(sender As Object, e As EventArgs) Handles ButtonSumar.Click
        EvaluayHazOperacion()
        Operacion = "+"
        txtValor.Text &= "+"
    End Sub

    Private Sub ButtonRestar_Click(sender As Object, e As EventArgs) Handles ButtonRestar.Click
        EvaluayHazOperacion()
        Operacion = "-"
        txtValor.Text &= "-"
    End Sub

    Private Sub ButtonMultiplicacion_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicacion.Click
        EvaluayHazOperacion()
        Operacion = "*"
        txtValor.Text &= "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
        txtValor.Text &= "/"
    End Sub

    Public Sub EvaluayHazOperacion()
        sePrecionaOperador = True
        Valor2 = Val(txtResultado.Text)
        If (ValorResultado IsNot Nothing) Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            txtResultado.Text = ValorResultado
            txtValor.Text &= ValorResultado

        Else
            ValorResultado = Valor2
        End If

    End Sub

    Public Sub EvaluaRestrinccionesParaConcatenar()
        If (sePrecionaOperador = True) Then
            txtResultado.Text = ""
            sePrecionaOperador = False
        ElseIf (txtResultado.Text = "0") Then
            txtResultado.Text = ""
        End If
    End Sub
End Class

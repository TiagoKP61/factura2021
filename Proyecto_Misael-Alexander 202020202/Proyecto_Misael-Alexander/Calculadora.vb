Public Class Calculadora

    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "9"
    End Sub

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        EvaluaRestriccionesParaConcatenar()
        lblNumeros.Text &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(lblNumeros.Text, ".", CompareMethod.Text) = 0 Then
            lblNumeros.Text &= "."
        End If
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblNumeros.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Public Sub EvaluayHazOperacion()
        Bandera = True
        Valor2 = Val(lblNumeros.Text)
        If ValorResultado IsNot Nothing Then
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
            lblNumeros.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If Bandera = True Then
            lblNumeros.Text = ""
            Bandera = False
        ElseIf lblNumeros.Text = "0" Then
            lblNumeros.Text = ""
        End If
    End Sub

    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inabilitar(False)
    End Sub

    Private Sub inabilitar(estado)
        btn0.Enabled = estado
        btn1.Enabled = estado
        btn2.Enabled = estado
        btn3.Enabled = estado
        btn4.Enabled = estado
        btn5.Enabled = estado
        btn6.Enabled = estado
        btn7.Enabled = estado
        btn8.Enabled = estado
        btn9.Enabled = estado
        btnIgual.Enabled = estado
        btnPunto.Enabled = estado
        btnSumar.Enabled = estado
        btnRestar.Enabled = estado
        btnDividir.Enabled = estado
        btnMultiplicar.Enabled = estado
        btnC.Enabled = estado
        btnCE.Enabled = estado
        btnApagado.Enabled = estado

        If estado Then
            lblNumeros.Text = "0"
        Else
            lblNumeros.Text = ""
        End If

    End Sub

    Private Sub btnEncendido_Click(sender As Object, e As EventArgs) Handles btnEncendido.Click
        inabilitar(True)
    End Sub

    Private Sub btnApagado_Click(sender As Object, e As EventArgs) Handles btnApagado.Click
        inabilitar(False)
    End Sub
End Class
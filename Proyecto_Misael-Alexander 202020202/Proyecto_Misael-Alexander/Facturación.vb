Public Class Facturación

    Dim item As Integer
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Facturación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = Now.Date
        Cbo_Codigo.SelectedIndex = 0
        Cbo_TipoDocu.SelectedIndex = 0
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        If (MsgBox("Tem a certeza que quer sair?", vbCritical + vbYesNo) = vbYes) Then
            Me.Close()
        Else
            sender = 1
        End If
    End Sub

    Private Sub Cbo_TipoDocu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_TipoDocu.SelectedIndexChanged

        If (Cbo_TipoDocu.SelectedIndex = 0) Then
            Txt_Numero.Enabled = False
        ElseIf (Cbo_TipoDocu.SelectedIndex = 1) Then
            Txt_Numero.MaxLength = 8
            Txt_Numero.Enabled = True
        ElseIf (Cbo_TipoDocu.SelectedIndex = 2) Then
            Txt_Numero.MaxLength = 11
            Txt_Numero.Enabled = True
        End If
    End Sub

    Private Sub Txt_RazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_nome.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Introduzca solo letras", , "Aviso")
        End If
    End Sub

    Private Sub Txt_Numero_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Numero.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Error solo requiere numeros")
            Txt_Numero.Text = vbNullChar

        End If
    End Sub

    Private Sub Txt_Cantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Cantidad.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue >= 96 And e.KeyValue <= 105) OrElse (e.KeyValue = 8)) Then
            e.Handled = True
            MsgBox("Error solo requiere numeros")
            Txt_Cantidad.Text = vbNullChar

        End If
    End Sub

    Private Sub Cbo_Categoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Codigo.SelectedIndexChanged
        Dim pos As Integer
        pos = Cbo_Codigo.SelectedIndex
        Select Case (pos)
            Case 0
            Case 1 :  ()
            Case 2 : llenarLicores()
            Case 3 : llenarDetergentes()
            Case 4 : llenarEmbutidos()
            Case 5 : llenarBebidas()
        End Select
    End Sub
    Private Sub llenarLacteos()
        Cbo_Serviço.Items.Clear()
        Cbo_Serviço.Items.Add("Leche Gloria")
        Cbo_Serviço.Items.Add("Yogurt Gloria")
        Cbo_Serviço.Items.Add("Mantequilla Gloria")
    End Sub
    Private Sub llenarLicores()
        Cbo_Serviço.Items.Clear()
        Cbo_Serviço.Items.Add("Cerveza Cristal")
        Cbo_Serviço.Items.Add("Ron Pomalca")
        Cbo_Serviço.Items.Add("Pisco")
    End Sub
    Private Sub llenarDetergentes()
        Cbo_Serviço.Items.Clear()
        Cbo_Serviço.Items.Add("Ariel")
        Cbo_Serviço.Items.Add("Opal")
        Cbo_Serviço.Items.Add("Patito")
    End Sub
    Private Sub llenarEmbutidos()
        Cbo_Serviço.Items.Clear()
        Cbo_Serviço.Items.Add("Jamoda")
        Cbo_Serviço.Items.Add("Salchicha")
        Cbo_Serviço.Items.Add("Chorizo")
    End Sub
    Private Sub llenarBebidas()
        Cbo_Serviço.Items.Clear()
        Cbo_Serviço.Items.Add("Coca Cola")
        Cbo_Serviço.Items.Add("Sporade")
        Cbo_Serviço.Items.Add("Powerade")
    End Sub

    Public Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        Txt_Numero.Text = ""
        Cbo_TipoDocu.SelectedIndex = 0
        Txt_nome.Text = ""
    End Sub

    Private Sub Cbo_Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_Serviço.SelectedIndexChanged
        If (Cbo_Codigo.SelectedIndex = 1) Then
            If (Cbo_Serviço.SelectedIndex = 0) Then
                Lbl_Precio.Text = 3.6.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 1) Then
                Lbl_Precio.Text = 5.8.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 2) Then
                Lbl_Precio.Text = 4.6.ToString("c")
            End If
        End If

        If (Cbo_Codigo.SelectedIndex = 2) Then
            If (Cbo_Serviço.SelectedIndex = 0) Then
                Lbl_Precio.Text = 4.5.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 1) Then
                Lbl_Precio.Text = 18.0.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 2) Then
                Lbl_Precio.Text = 24.0.ToString("c")
            End If
        End If

        If (Cbo_Codigo.SelectedIndex = 3) Then
            If (Cbo_Serviço.SelectedIndex = 0) Then
                Lbl_Precio.Text = 5.8.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 1) Then
                Lbl_Precio.Text = 4.5.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 2) Then
                Lbl_Precio.Text = 1.0.ToString("c")
            End If
        End If

        If (Cbo_Codigo.SelectedIndex = 4) Then
            If (Cbo_Serviço.SelectedIndex = 0) Then
                Lbl_Precio.Text = 4.5.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 1) Then
                Lbl_Precio.Text = 5.0.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 2) Then
                Lbl_Precio.Text = 1.2.ToString("c")
            End If
        End If

        If (Cbo_Codigo.SelectedIndex = 5) Then
            If (Cbo_Serviço.SelectedIndex = 0) Then
                Lbl_Precio.Text = 2.0.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 1) Then
                Lbl_Precio.Text = 2.5.ToString("c")
            ElseIf (Cbo_Serviço.SelectedIndex = 2) Then
                Lbl_Precio.Text = 1.5.ToString("c")
            End If
        End If

    End Sub

    Private Sub Btn_Limpíar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        Cbo_Codigo.SelectedIndex = 0
        Cbo_Serviço.SelectedIndex = -1
        Lbl_Precio.Text = 0.0.ToString("c")
        Txt_Cantidad.Text = ""
    End Sub

    Private Sub Btn_Agregar_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        Dim categoria, producto As Integer
        'Dim cantidad As Integer
        'cantidad = Txt_Cantidad.Text
        categoria = Cbo_Codigo.SelectedIndex
        producto = Cbo_Serviço.SelectedIndex

        If (Cbo_Codigo.SelectedIndex = 0) Then
            MsgBox("Porfavor Seleccione una Categoria", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Cbo_Codigo.DroppedDown = True
        ElseIf (Cbo_Serviço.SelectedIndex = -1) Then
            MsgBox("Porfavor Seleccione un Producto", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Cbo_Serviço.DroppedDown = True
        ElseIf (Txt_Cantidad.Text = "") Then
            MsgBox("Ingrese la cantidad", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Txt_Cantidad.Focus()

        ElseIf (Txt_Cantidad.Text <> "0") Then
            item = item + 1
            Lbx_Item.Items.Add(item)
            Lbx_quant.Items.Add(Txt_Cantidad.Text)
            Lbx_Serviço.Items.Add(Cbo_Serviço.SelectedItem.ToString)
            Lbx_Preco.Items.Add(Lbl_Precio.Text).ToString("c")
            Lbx_SubTotal.Items.Add(CDbl(Lbl_Precio.Text) * Txt_Cantidad.Text)

            If (btnRecibo.Checked = True) Then
                Calcular()
            Else
                Impuesto()
            End If
        Else
            MsgBox("Ingrese cantidad válida!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Sistema")
            Txt_Cantidad.Focus()
        End If
    End Sub
    Private Sub Calcular()
        Dim total As Double
        For i = 0 To Lbx_SubTotal.Items.Count - 1
            total = total + Lbx_SubTotal.Items.Item(i)
        Next
        Lbl_Total.Text = "S/. " & total
        Lbl_IGV.Text = "S/.0.0"
        Lbl_BaseImponible.Text = "S/. " & total

    End Sub

    Private Sub Impuesto()
        Dim igv, baseImponible, total As Double
        For i = 0 To Lbx_SubTotal.Items.Count - 1
            total = total + Lbx_SubTotal.Items.Item(i)
        Next
        Lbl_Total.Text = total.ToString("c")
        baseImponible = (total / 1.18).ToString("c")
        igv = (total - baseImponible).ToString("c")
        Lbl_BaseImponible.Text = baseImponible.ToString("c")
        Lbl_IGV.Text = igv.ToString("c")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        'Limpiando Datos del Cliente
        Cbo_TipoDocu.SelectedIndex = 0
        Txt_Numero.Text = ""
        Txt_nome.Text = ""
        'Limpiando Datos de los Productos
        Cbo_Codigo.SelectedIndex = 0
        Cbo_Serviço.SelectedIndex = -1
        Txt_Cantidad.Text = ""
        Lbl_Precio.Text = ""
        'Limpiando Datos del Detalle
        Lbx_Item.Items.Clear()
        Lbx_Serviço.Items.Clear()
        Lbx_Preco.Items.Clear()
        Lbx_quant.Items.Clear()
        Lbx_SubTotal.Items.Clear()
        'Limpiando Costos
        Lbl_BaseImponible.Text = ""
        Lbl_IGV.Text = ""
        Lbl_Total.Text = ""

    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim i As Integer
        i = Lbx_Item.SelectedIndex()
        If (i >= 0) Then
            item = item - 1
            Lbx_Serviço.Items.RemoveAt(i)
            Lbx_Preco.Items.RemoveAt(i)
            Lbx_SubTotal.Items.RemoveAt(i)
            Lbx_quant.Items.RemoveAt(i)
            Lbx_Item.Items.RemoveAt(item)

            If (btnRecibo.Checked = True) Then
                Calcular()
            Else
                Impuesto()
            End If
        End If
    End Sub
End Class

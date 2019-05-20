Public Class frmCalcularCargaHoraria

  Dim t As New RnCalc.clsCalcularCargaHoraria()
  Private Property strEntrada As String
  Private Property strEntInt As String
  Private Property strSaidaInt As String
  Private Property dblIntFixo As Double
  Private Property dblCargaHoraria As Double
  Private Property strSaida As String

  Private Sub frmCalcularCargaHoraria_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    Try
      rdbSaida.Checked = True
      txtIntervaloFixo.Enabled = False
      rdb440.Checked = True
      txtCargaHorariaOutra.Enabled = False
      ckbIntervaloFixo.Checked = True
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try
  End Sub
  Private Sub bntCalcular_Click(sender As Object, e As EventArgs) Handles bntCalular.Click
    Dim strInto As String = String.Empty
    Try
      If Not ckbIntervaloFixo.Checked Then
        dblIntFixo = t.BreakTime(strEntInt, strSaidaInt)
      End If

      If rdbSaida.Checked Then
        strInto = strEntrada
        txtSaida.Text = t.TimeLoad(t.TimeToMinutes(strInto), dblIntFixo, dblCargaHoraria)
      Else
        strInto = strSaida
        txtEntrada.Text = t.TimeLoadReverse(t.TimeToMinutes(strInto), dblIntFixo, dblCargaHoraria)
      End If
    Catch ex As Exception
      MessageBox.Show("Tempo Inválido", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Sub txtEntrada_TextChanged(sender As Object, e As EventArgs) Handles txtEntrada.TextChanged
    strEntrada = txtEntrada.Text
  End Sub
  Private Sub txtEntIntervalo_TextChanged(sender As Object, e As EventArgs) Handles txtEntIntervalo.TextChanged
    strEntInt = txtEntIntervalo.Text
  End Sub
  Private Sub txtSaidaIntervalo_TextChanged(sender As Object, e As EventArgs) Handles txtSaidaIntervalo.TextChanged
    strSaidaInt = txtSaidaIntervalo.Text
  End Sub
  Private Sub txtSaida_TextChanged(sender As Object, e As EventArgs) Handles txtSaida.TextChanged
    strSaida = txtSaida.Text
  End Sub
  Private Sub txtIntervaloFixo_Leave(sender As Object, e As EventArgs) Handles txtIntervaloFixo.Leave
    Try
      If txtIntervaloFixo.Text <> "  :" Then
        dblIntFixo = t.TimeToMinutes(txtIntervaloFixo.Text)
      End If
    Catch ex As Exception
      MessageBox.Show("Hora Inválida!")
    End Try
  End Sub
  Private Sub txtCargaHorariaOutra_Leave(sender As Object, e As EventArgs) Handles txtCargaHorariaOutra.Leave
    Try
      If txtCargaHorariaOutra.Text <> "  :" Then
        dblCargaHoraria = t.TimeToMinutes(txtCargaHorariaOutra.Text)
      End If
    Catch ex As Exception
      MessageBox.Show("Hora Inválida!")
    End Try

  End Sub
  Private Sub rdbSaida_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSaida.CheckedChanged
    txtSaida.Enabled = Not (rdbSaida.Checked)
    If Not txtSaida.Enabled Then
      txtSaida.Clear()
    End If
  End Sub
  Private Sub rdbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEntrada.CheckedChanged
    txtEntrada.Enabled = Not (rdbEntrada.Checked)
    If Not txtEntrada.Enabled Then
      txtEntrada.Clear()
    End If
  End Sub
  Private Sub rdb440_CheckedChanged(sender As Object, e As EventArgs) Handles rdb440.CheckedChanged
    If rdb440.Checked Then
      dblCargaHoraria = 440
      Exit Sub
    End If
  End Sub
  Private Sub rdb500_CheckedChanged(sender As Object, e As EventArgs) Handles rdb500.CheckedChanged
    If rdb500.Checked Then
      dblCargaHoraria = 500
      Exit Sub
    End If
  End Sub
  Private Sub rdbIntervaloFixo_CheckedChanged(sender As Object, e As EventArgs) Handles ckbIntervaloFixo.CheckedChanged
    If ckbIntervaloFixo.Checked Then
      txtIntervaloFixo.Enabled = True
      txtEntIntervalo.Clear()
      txtEntIntervalo.Enabled = False
      txtSaidaIntervalo.Clear()
      txtSaidaIntervalo.Enabled = False
    Else
      txtIntervaloFixo.Clear()
      txtIntervaloFixo.Enabled = False
      txtEntIntervalo.Enabled = True
      txtSaidaIntervalo.Enabled = True
    End If
  End Sub
  Private Sub rdbOutra_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOutra.CheckedChanged
    If rdbOutra.Checked Then
      txtCargaHorariaOutra.Enabled = True
    Else
      txtCargaHorariaOutra.Clear()
      txtCargaHorariaOutra.Enabled = False
    End If
  End Sub
  Private Sub frmUI_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
    Try
      If e.KeyCode = Keys.Enter Then
        ProcessTabKey(True)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, "Erro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Sub textBox_GotFocus(sender As Object, e As EventArgs) Handles txtEntrada.GotFocus,
                                                                         txtEntIntervalo.GotFocus,
                                                                         txtSaidaIntervalo.GotFocus,
                                                                         txtSaida.GotFocus,
                                                                         txtIntervaloFixo.GotFocus,
                                                                         txtCargaHorariaOutra.GotFocus
    Dim txt As MaskedTextBox = CType(sender, MaskedTextBox)
    txt.SelectAll()
  End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcularCargaHoraria
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
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

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txtSaida = New System.Windows.Forms.MaskedTextBox()
    Me.txtSaidaIntervalo = New System.Windows.Forms.MaskedTextBox()
    Me.txtEntIntervalo = New System.Windows.Forms.MaskedTextBox()
    Me.txtEntrada = New System.Windows.Forms.MaskedTextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.bntCalular = New System.Windows.Forms.Button()
    Me.grbEntradaOuSaida = New System.Windows.Forms.GroupBox()
    Me.rdbEntrada = New System.Windows.Forms.RadioButton()
    Me.rdbSaida = New System.Windows.Forms.RadioButton()
    Me.gpbIntervalo = New System.Windows.Forms.GroupBox()
    Me.ckbIntervaloFixo = New System.Windows.Forms.CheckBox()
    Me.txtIntervaloFixo = New System.Windows.Forms.MaskedTextBox()
    Me.gpbCargaHoraria = New System.Windows.Forms.GroupBox()
    Me.rdbOutra = New System.Windows.Forms.RadioButton()
    Me.rdb500 = New System.Windows.Forms.RadioButton()
    Me.rdb440 = New System.Windows.Forms.RadioButton()
    Me.txtCargaHorariaOutra = New System.Windows.Forms.MaskedTextBox()
    Me.GroupBox1.SuspendLayout()
    Me.grbEntradaOuSaida.SuspendLayout()
    Me.gpbIntervalo.SuspendLayout()
    Me.gpbCargaHoraria.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 14)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(47, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Entrada:"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtSaida)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.txtEntrada)
    Me.GroupBox1.Location = New System.Drawing.Point(245, 6)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(74, 120)
    Me.GroupBox1.TabIndex = 3
    Me.GroupBox1.TabStop = False
    '
    'txtSaida
    '
    Me.txtSaida.Location = New System.Drawing.Point(19, 85)
    Me.txtSaida.Mask = "00:00"
    Me.txtSaida.Name = "txtSaida"
    Me.txtSaida.Size = New System.Drawing.Size(34, 20)
    Me.txtSaida.TabIndex = 11
    Me.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtSaida.ValidatingType = GetType(Date)
    '
    'txtSaidaIntervalo
    '
    Me.txtSaidaIntervalo.Location = New System.Drawing.Point(193, 22)
    Me.txtSaidaIntervalo.Mask = "00:00"
    Me.txtSaidaIntervalo.Name = "txtSaidaIntervalo"
    Me.txtSaidaIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtSaidaIntervalo.Size = New System.Drawing.Size(34, 20)
    Me.txtSaidaIntervalo.TabIndex = 4
    Me.txtSaidaIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtSaidaIntervalo.ValidatingType = GetType(Date)
    '
    'txtEntIntervalo
    '
    Me.txtEntIntervalo.Location = New System.Drawing.Point(118, 22)
    Me.txtEntIntervalo.Mask = "00:00"
    Me.txtEntIntervalo.Name = "txtEntIntervalo"
    Me.txtEntIntervalo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtEntIntervalo.Size = New System.Drawing.Size(34, 20)
    Me.txtEntIntervalo.TabIndex = 3
    Me.txtEntIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtEntIntervalo.ValidatingType = GetType(Date)
    '
    'txtEntrada
    '
    Me.txtEntrada.Location = New System.Drawing.Point(19, 30)
    Me.txtEntrada.Mask = "00:00"
    Me.txtEntrada.Name = "txtEntrada"
    Me.txtEntrada.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtEntrada.Size = New System.Drawing.Size(34, 20)
    Me.txtEntrada.TabIndex = 1
    Me.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtEntrada.ValidatingType = GetType(Date)
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 69)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(39, 13)
    Me.Label4.TabIndex = 3
    Me.Label4.Text = "Saída:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(158, 25)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(31, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Volta"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(94, 25)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(22, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Ída"
    '
    'bntCalular
    '
    Me.bntCalular.Location = New System.Drawing.Point(6, 132)
    Me.bntCalular.Name = "bntCalular"
    Me.bntCalular.Size = New System.Drawing.Size(87, 22)
    Me.bntCalular.TabIndex = 5
    Me.bntCalular.Text = "Calcular"
    Me.bntCalular.UseVisualStyleBackColor = True
    '
    'grbEntradaOuSaida
    '
    Me.grbEntradaOuSaida.Controls.Add(Me.rdbEntrada)
    Me.grbEntradaOuSaida.Controls.Add(Me.rdbSaida)
    Me.grbEntradaOuSaida.Location = New System.Drawing.Point(146, 6)
    Me.grbEntradaOuSaida.Name = "grbEntradaOuSaida"
    Me.grbEntradaOuSaida.Size = New System.Drawing.Size(93, 57)
    Me.grbEntradaOuSaida.TabIndex = 2
    Me.grbEntradaOuSaida.TabStop = False
    Me.grbEntradaOuSaida.Text = "Calcular"
    '
    'rdbEntrada
    '
    Me.rdbEntrada.AutoSize = True
    Me.rdbEntrada.Location = New System.Drawing.Point(6, 36)
    Me.rdbEntrada.Name = "rdbEntrada"
    Me.rdbEntrada.Size = New System.Drawing.Size(62, 17)
    Me.rdbEntrada.TabIndex = 2
    Me.rdbEntrada.TabStop = True
    Me.rdbEntrada.Text = "Entrada"
    Me.rdbEntrada.UseVisualStyleBackColor = True
    '
    'rdbSaida
    '
    Me.rdbSaida.AutoSize = True
    Me.rdbSaida.Location = New System.Drawing.Point(6, 16)
    Me.rdbSaida.Name = "rdbSaida"
    Me.rdbSaida.Size = New System.Drawing.Size(54, 17)
    Me.rdbSaida.TabIndex = 1
    Me.rdbSaida.TabStop = True
    Me.rdbSaida.Text = "Saída"
    Me.rdbSaida.UseVisualStyleBackColor = True
    '
    'gpbIntervalo
    '
    Me.gpbIntervalo.Controls.Add(Me.ckbIntervaloFixo)
    Me.gpbIntervalo.Controls.Add(Me.txtSaidaIntervalo)
    Me.gpbIntervalo.Controls.Add(Me.txtIntervaloFixo)
    Me.gpbIntervalo.Controls.Add(Me.txtEntIntervalo)
    Me.gpbIntervalo.Controls.Add(Me.Label3)
    Me.gpbIntervalo.Controls.Add(Me.Label2)
    Me.gpbIntervalo.Location = New System.Drawing.Point(6, 69)
    Me.gpbIntervalo.Name = "gpbIntervalo"
    Me.gpbIntervalo.Size = New System.Drawing.Size(233, 57)
    Me.gpbIntervalo.TabIndex = 4
    Me.gpbIntervalo.TabStop = False
    Me.gpbIntervalo.Text = "Tempo de Intervalo"
    '
    'ckbIntervaloFixo
    '
    Me.ckbIntervaloFixo.AutoSize = True
    Me.ckbIntervaloFixo.Location = New System.Drawing.Point(6, 24)
    Me.ckbIntervaloFixo.Name = "ckbIntervaloFixo"
    Me.ckbIntervaloFixo.Size = New System.Drawing.Size(45, 17)
    Me.ckbIntervaloFixo.TabIndex = 1
    Me.ckbIntervaloFixo.Text = "Fixo"
    Me.ckbIntervaloFixo.UseVisualStyleBackColor = True
    '
    'txtIntervaloFixo
    '
    Me.txtIntervaloFixo.Location = New System.Drawing.Point(54, 22)
    Me.txtIntervaloFixo.Mask = "00:00"
    Me.txtIntervaloFixo.Name = "txtIntervaloFixo"
    Me.txtIntervaloFixo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtIntervaloFixo.Size = New System.Drawing.Size(34, 20)
    Me.txtIntervaloFixo.TabIndex = 2
    Me.txtIntervaloFixo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtIntervaloFixo.ValidatingType = GetType(Date)
    '
    'gpbCargaHoraria
    '
    Me.gpbCargaHoraria.Controls.Add(Me.rdbOutra)
    Me.gpbCargaHoraria.Controls.Add(Me.rdb500)
    Me.gpbCargaHoraria.Controls.Add(Me.rdb440)
    Me.gpbCargaHoraria.Controls.Add(Me.txtCargaHorariaOutra)
    Me.gpbCargaHoraria.Location = New System.Drawing.Point(6, 6)
    Me.gpbCargaHoraria.Name = "gpbCargaHoraria"
    Me.gpbCargaHoraria.Size = New System.Drawing.Size(134, 57)
    Me.gpbCargaHoraria.TabIndex = 1
    Me.gpbCargaHoraria.TabStop = False
    Me.gpbCargaHoraria.Text = "Carga Horária"
    '
    'rdbOutra
    '
    Me.rdbOutra.AutoSize = True
    Me.rdbOutra.Location = New System.Drawing.Point(58, 18)
    Me.rdbOutra.Name = "rdbOutra"
    Me.rdbOutra.Size = New System.Drawing.Size(14, 13)
    Me.rdbOutra.TabIndex = 3
    Me.rdbOutra.TabStop = True
    Me.rdbOutra.UseVisualStyleBackColor = True
    '
    'rdb500
    '
    Me.rdb500.AutoSize = True
    Me.rdb500.Location = New System.Drawing.Point(6, 36)
    Me.rdb500.Name = "rdb500"
    Me.rdb500.Size = New System.Drawing.Size(46, 17)
    Me.rdb500.TabIndex = 2
    Me.rdb500.TabStop = True
    Me.rdb500.Text = "8:20"
    Me.rdb500.UseVisualStyleBackColor = True
    '
    'rdb440
    '
    Me.rdb440.AutoSize = True
    Me.rdb440.Location = New System.Drawing.Point(6, 16)
    Me.rdb440.Name = "rdb440"
    Me.rdb440.Size = New System.Drawing.Size(46, 17)
    Me.rdb440.TabIndex = 1
    Me.rdb440.TabStop = True
    Me.rdb440.Text = "7:20"
    Me.rdb440.UseVisualStyleBackColor = True
    '
    'txtCargaHorariaOutra
    '
    Me.txtCargaHorariaOutra.Location = New System.Drawing.Point(78, 15)
    Me.txtCargaHorariaOutra.Mask = "00:00"
    Me.txtCargaHorariaOutra.Name = "txtCargaHorariaOutra"
    Me.txtCargaHorariaOutra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
    Me.txtCargaHorariaOutra.Size = New System.Drawing.Size(34, 20)
    Me.txtCargaHorariaOutra.TabIndex = 4
    Me.txtCargaHorariaOutra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.txtCargaHorariaOutra.ValidatingType = GetType(Date)
    '
    'frmCalcularCargaHoraria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoSize = True
    Me.ClientSize = New System.Drawing.Size(326, 159)
    Me.Controls.Add(Me.gpbCargaHoraria)
    Me.Controls.Add(Me.gpbIntervalo)
    Me.Controls.Add(Me.grbEntradaOuSaida)
    Me.Controls.Add(Me.bntCalular)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.Name = "frmCalcularCargaHoraria"
    Me.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Cálculo de Carga Horária"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.grbEntradaOuSaida.ResumeLayout(False)
    Me.grbEntradaOuSaida.PerformLayout()
    Me.gpbIntervalo.ResumeLayout(False)
    Me.gpbIntervalo.PerformLayout()
    Me.gpbCargaHoraria.ResumeLayout(False)
    Me.gpbCargaHoraria.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents bntCalular As Button
  Friend WithEvents grbEntradaOuSaida As GroupBox
  Friend WithEvents rdbEntrada As RadioButton
  Friend WithEvents rdbSaida As RadioButton
  Friend WithEvents gpbIntervalo As GroupBox
  Friend WithEvents gpbCargaHoraria As GroupBox
  Friend WithEvents rdbOutra As RadioButton
  Friend WithEvents rdb500 As RadioButton
  Friend WithEvents rdb440 As RadioButton
  Friend WithEvents ckbIntervaloFixo As CheckBox
  Friend WithEvents txtIntervaloFixo As MaskedTextBox
  Friend WithEvents txtCargaHorariaOutra As MaskedTextBox
  Friend WithEvents txtEntrada As MaskedTextBox
  Friend WithEvents txtEntIntervalo As MaskedTextBox
  Friend WithEvents txtSaidaIntervalo As MaskedTextBox
  Friend WithEvents txtSaida As MaskedTextBox
End Class

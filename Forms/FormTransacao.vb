Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class FormTransacao

    Private transacao As Transacao

    Public Sub New(Optional transacao As Transacao = Nothing)
        InitializeComponent()
        Me.transacao = transacao
    End Sub

    Private Sub frmTransacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.cmbCliente.DisplayMember = "nome"
            Me.cmbCliente.ValueMember = "id_cliente"
            Me.cmbCliente.DataSource = TransacaoDAO.GetClientes()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Falha ao carregar clientes!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

        If (Me.transacao Is Nothing) Then
            Me.btnSalvarAtualizar.Text = "Salvar"
        Else
            Me.txtNumeroCartao.Text = Me.transacao.NumeroCartao.ToString()
            Me.txtValor.Text = transacao.ValorTransacao
            Me.txtDescricao.Text = transacao.Descricao
            Me.cmbCliente.SelectedValue = transacao.Id_Cliente
            Me.btnSalvarAtualizar.Text = "Atualizar"
        End If
    End Sub

    Private Sub btnSalvarAtualizar_Click(sender As Object, e As EventArgs) Handles btnSalvarAtualizar.Click
        Try

            If validarCampos() Then Exit Sub

            If (Me.transacao Is Nothing) Then
                Dim transacao As New Transacao()
                transacao.NumeroCartao = Convert.ToInt32(Me.txtNumeroCartao.Text)
                transacao.ValorTransacao = Convert.ToDecimal(Me.txtValor.Text)
                transacao.Descricao = Me.txtDescricao.Text
                transacao.Id_Cliente = Me.cmbCliente.SelectedValue
                TransacaoDAO.Inserir(transacao)
                MessageBox.Show("Transação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.LimparCampos()
            Else
                Me.transacao.NumeroCartao = Convert.ToInt32(Me.txtNumeroCartao.Text)
                Me.transacao.ValorTransacao = Convert.ToDecimal(Me.txtValor.Text)
                Me.transacao.Descricao = Me.txtDescricao.Text
                Me.transacao.Id_Cliente = Me.cmbCliente.SelectedValue
                TransacaoDAO.Atualizar(Me.transacao)
                MessageBox.Show("Transação atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Falha ao salvar transação!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub TxtNumeroCartao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroCartao.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True 'calcela
        End If
    End Sub

    Private Sub LimparCampos()
        If MessageBox.Show("Deseja limpar os campos?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.txtNumeroCartao.Text = ""
            Me.txtValor.Text = ""
            Me.cmbCliente.SelectedIndex = 0
            Me.txtDescricao.Text = ""
        End If
    End Sub

    Private Function validarCampos()
        If String.IsNullOrEmpty(Me.txtNumeroCartao.Text) Then
            MessageBox.Show("Preencha o numero do cartão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf String.IsNullOrEmpty(Me.txtValor.Text) Then
            MessageBox.Show("Preencha o valor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        ElseIf String.IsNullOrEmpty(Me.txtDescricao.Text) Then
            MessageBox.Show("Preencha a descriçao!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub txtValor_Validated(sender As Object, e As EventArgs) Handles txtValor.Validated
        Dim valorTxt As String = txtValor.Text
        Dim valorNum As Decimal

        If Decimal.TryParse(valorTxt, valorNum) Then
            valorTxt = valorNum.ToString("F2")
        Else
            MessageBox.Show("Por favor, insira um número válido.")
            txtValor.Focus()
        End If

        txtValor.Text = valorTxt
    End Sub

End Class
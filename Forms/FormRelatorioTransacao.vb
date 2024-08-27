Public Class FormRelatorioTransacao
    Private Sub frmRelatorioTransacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grid.RowHeadersVisible = False
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Me.grid.DataSource = TransacaoDAO.GetRelatorioTransacoes(dtInicio:=Me.dtInicio.Text, dtFinal:=Me.dtFinal.Text)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Falha ao consultar transações!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.EMMA
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class FormInicio

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmbFiltro.SelectedIndex = 0
        Me.dataFiltro.Visible = False
        Me.txtFiltro.Visible = False
        Me.grid.RowHeadersVisible = False
        CarregarGrid()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Dim form As FormTransacao = New FormTransacao()
        form.ShowDialog()
        Me.CarregarGrid()
    End Sub

    Private Sub grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellClick
        If (grid.Columns(e.ColumnIndex).Name = "editar") Then
            Dim transacao As New Transacao()
            transacao.Id = grid.Rows(e.RowIndex).Cells("id_transacao").Value
            transacao.NumeroCartao = grid.Rows(e.RowIndex).Cells("numeroCartao").Value
            transacao.ValorTransacao = grid.Rows(e.RowIndex).Cells("valorTransacao").Value
            transacao.Descricao = grid.Rows(e.RowIndex).Cells("descricao").Value
            transacao.Id_Cliente = grid.Rows(e.RowIndex).Cells("id_cliente").Value
            Dim form As FormTransacao = New FormTransacao(transacao)
            form.ShowDialog()
            Me.CarregarGrid()
        ElseIf (grid.Columns(e.ColumnIndex).Name = "remover") Then
            Try
                TransacaoDAO.Remover(grid.Rows(e.RowIndex).Cells("id_transacao").Value)
                MessageBox.Show("Transação removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CarregarGrid()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MessageBox.Show("Falha ao remover transação!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If (Me.cmbFiltro.SelectedItem.ToString = "Todos") Then
            Me.dataFiltro.Visible = False
            Me.txtFiltro.Visible = False
        ElseIf (Me.cmbFiltro.SelectedItem.ToString = "Numero" Or Me.cmbFiltro.SelectedItem.ToString = "Valor") Then
            Me.dataFiltro.Visible = False
            Me.txtFiltro.Text = ""
            Me.txtFiltro.Visible = True
        ElseIf (Me.cmbFiltro.SelectedItem.ToString = "Data") Then
            Me.dataFiltro.Visible = True
            Me.txtFiltro.Visible = False
        End If
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        If validarFiltro() Then Exit Sub
        Me.CarregarGrid()
    End Sub

    Private Sub grid_CellMouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellMouseEnter
        If grid.Columns(e.ColumnIndex).Name = "editar" Or grid.Columns(e.ColumnIndex).Name = "remover" Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = System.Drawing.Color.LightBlue
            End If
        End If
    End Sub

    Private Sub grid_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellMouseLeave
        If (grid.Columns(e.ColumnIndex).Name <> "editar" Or grid.Columns(e.ColumnIndex).Name <> "remover") Then
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
                grid.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = System.Drawing.Color.White
            End If
        End If
    End Sub

    Private Sub btnRelatorioTransacoes_Click(sender As Object, e As EventArgs) Handles btnRelatorioTransacoes.Click
        Dim form As FormRelatorioTransacao = New FormRelatorioTransacao()
        form.ShowDialog()
        Me.CarregarGrid()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Try
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog.FilterIndex = 1
            saveFileDialog.FileName = "Relatório.xlsx"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim workbook As New XLWorkbook()
                Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Dados")

                Me.grid.DataSource = TransacaoDAO.GetExportarPlanilha()

                Dim colunaPlanilha As Integer = 1
                Dim linhaPlanilha As Integer = 2

                For coluna As Integer = 0 To Me.grid.Columns.Count - 1
                    If Me.grid.Columns(coluna).HeaderText <> "" Then
                        worksheet.Cell(1, colunaPlanilha).Value = Me.grid.Columns(coluna).HeaderText
                        colunaPlanilha += 1
                    End If
                Next
                colunaPlanilha = 1

                For Each linha As DataGridViewRow In grid.Rows
                    For Each coluna As DataGridViewColumn In grid.Columns
                        If TypeOf linha.Cells(coluna.Index).Value IsNot Bitmap Then
                            worksheet.Cell(linhaPlanilha, colunaPlanilha).Value = linha.Cells(coluna.Index).Value.ToString()
                            colunaPlanilha += 1
                        End If
                    Next
                    linhaPlanilha += 1
                    colunaPlanilha = 1
                Next

                workbook.SaveAs(saveFileDialog.FileName)
                MessageBox.Show("Arquivo exportado com sucesso!", "Exportar para Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.CarregarGrid()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Falha ao exportar planilha!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub CarregarGrid()
        If (Me.cmbFiltro.SelectedItem.ToString = "Todos") Then
            Me.grid.DataSource = TransacaoDAO.GetTransacoes()
        ElseIf (Me.cmbFiltro.SelectedItem.ToString = "Numero") Then
            Me.grid.DataSource = TransacaoDAO.GetTransacoes(numeroCartao:=txtFiltro.Text)
        ElseIf (Me.cmbFiltro.SelectedItem.ToString = "Data") Then
            Me.grid.DataSource = TransacaoDAO.GetTransacoes(dataTransacao:=dataFiltro.Text)
        ElseIf (Me.cmbFiltro.SelectedItem.ToString = "Valor") Then
            Me.grid.DataSource = TransacaoDAO.GetTransacoes(valorTransacao:=txtFiltro.Text)
        End If

        Me.grid.Columns("id_cliente").Visible = False
        Me.grid.Columns("id_transacao").Visible = False
        Me.grid.Columns("editar").DisplayIndex = Me.grid.Columns.Count - 2
        Me.grid.Columns("remover").DisplayIndex = Me.grid.Columns.Count - 1

    End Sub

    Private Function validarFiltro()
        If (Me.txtFiltro.Visible = True And String.IsNullOrEmpty(Me.txtFiltro.Text)) Then
            MessageBox.Show("Preencha o campo de filtro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            Return False
        End If
    End Function

End Class

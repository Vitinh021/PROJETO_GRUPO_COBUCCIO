<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelatorioTransacao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        grPeriodo = New GroupBox()
        Label1 = New Label()
        dtFinal = New DateTimePicker()
        dtInicio = New DateTimePicker()
        btnConsultar = New Button()
        grid = New DataGridView()
        numeroCartao = New DataGridViewTextBoxColumn()
        valorTotal = New DataGridViewTextBoxColumn()
        qtdTransacoes = New DataGridViewTextBoxColumn()
        grPeriodo.SuspendLayout()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grPeriodo
        ' 
        grPeriodo.Controls.Add(Label1)
        grPeriodo.Controls.Add(dtFinal)
        grPeriodo.Controls.Add(dtInicio)
        grPeriodo.Controls.Add(btnConsultar)
        grPeriodo.Location = New Point(12, 12)
        grPeriodo.Name = "grPeriodo"
        grPeriodo.Size = New Size(375, 54)
        grPeriodo.TabIndex = 0
        grPeriodo.TabStop = False
        grPeriodo.Text = "Período"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(108, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 5
        Label1.Text = "A"
        ' 
        ' dtFinal
        ' 
        dtFinal.Format = DateTimePickerFormat.Custom
        dtFinal.Location = New Point(129, 22)
        dtFinal.Name = "dtFinal"
        dtFinal.Size = New Size(96, 23)
        dtFinal.TabIndex = 2
        ' 
        ' dtInicio
        ' 
        dtInicio.Format = DateTimePickerFormat.Custom
        dtInicio.Location = New Point(6, 22)
        dtInicio.Name = "dtInicio"
        dtInicio.Size = New Size(96, 23)
        dtInicio.TabIndex = 1
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(294, 22)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(75, 23)
        btnConsultar.TabIndex = 3
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' grid
        ' 
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid.Columns.AddRange(New DataGridViewColumn() {numeroCartao, valorTotal, qtdTransacoes})
        grid.Location = New Point(12, 72)
        grid.Name = "grid"
        grid.ReadOnly = True
        grid.Size = New Size(375, 287)
        grid.TabIndex = 1
        ' 
        ' numeroCartao
        ' 
        numeroCartao.DataPropertyName = "numeroCartao"
        numeroCartao.HeaderText = "Numero Cartão"
        numeroCartao.Name = "numeroCartao"
        numeroCartao.ReadOnly = True
        numeroCartao.Width = 150
        ' 
        ' valorTotal
        ' 
        valorTotal.DataPropertyName = "valorTotal"
        valorTotal.HeaderText = "Total das transações"
        valorTotal.Name = "valorTotal"
        valorTotal.ReadOnly = True
        ' 
        ' qtdTransacoes
        ' 
        qtdTransacoes.DataPropertyName = "qtdTransacoes"
        qtdTransacoes.HeaderText = "QTD Transações"
        qtdTransacoes.Name = "qtdTransacoes"
        qtdTransacoes.ReadOnly = True
        ' 
        ' frmRelatorioTransacao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 371)
        Controls.Add(grid)
        Controls.Add(grPeriodo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmRelatorioTransacao"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Relatório de Transações"
        grPeriodo.ResumeLayout(False)
        grPeriodo.PerformLayout()
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grPeriodo As GroupBox
    Friend WithEvents dtFinal As DateTimePicker
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents btnConsultar As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents numeroCartao As DataGridViewTextBoxColumn
    Friend WithEvents valorTotal As DataGridViewTextBoxColumn
    Friend WithEvents qtdTransacoes As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicio))
        Filtros = New GroupBox()
        txtFiltro = New TextBox()
        dataFiltro = New DateTimePicker()
        cmbFiltro = New ComboBox()
        btnFiltrar = New Button()
        grid = New DataGridView()
        btnInserir = New Button()
        btnRelatorioTransacoes = New Button()
        btnExportar = New Button()
        nome = New DataGridViewTextBoxColumn()
        id_cliente = New DataGridViewTextBoxColumn()
        numeroCartao = New DataGridViewTextBoxColumn()
        valorTransacao = New DataGridViewTextBoxColumn()
        dataTransacao = New DataGridViewTextBoxColumn()
        descricao = New DataGridViewTextBoxColumn()
        categoria = New DataGridViewTextBoxColumn()
        editar = New DataGridViewImageColumn()
        remover = New DataGridViewImageColumn()
        id_transacao = New DataGridViewTextBoxColumn()
        Filtros.SuspendLayout()
        CType(grid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Filtros
        ' 
        Filtros.Controls.Add(txtFiltro)
        Filtros.Controls.Add(dataFiltro)
        Filtros.Controls.Add(cmbFiltro)
        Filtros.Controls.Add(btnFiltrar)
        Filtros.Location = New Point(12, 12)
        Filtros.Name = "Filtros"
        Filtros.Size = New Size(725, 54)
        Filtros.TabIndex = 0
        Filtros.TabStop = False
        Filtros.Text = "Filtros"
        ' 
        ' txtFiltro
        ' 
        txtFiltro.Location = New Point(85, 21)
        txtFiltro.Name = "txtFiltro"
        txtFiltro.Size = New Size(100, 23)
        txtFiltro.TabIndex = 2
        ' 
        ' dataFiltro
        ' 
        dataFiltro.Format = DateTimePickerFormat.Custom
        dataFiltro.Location = New Point(85, 21)
        dataFiltro.Name = "dataFiltro"
        dataFiltro.Size = New Size(96, 23)
        dataFiltro.TabIndex = 1
        ' 
        ' cmbFiltro
        ' 
        cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFiltro.FormattingEnabled = True
        cmbFiltro.Items.AddRange(New Object() {"Todos", "Numero", "Data", "Valor"})
        cmbFiltro.Location = New Point(6, 22)
        cmbFiltro.Name = "cmbFiltro"
        cmbFiltro.Size = New Size(73, 23)
        cmbFiltro.TabIndex = 0
        ' 
        ' btnFiltrar
        ' 
        btnFiltrar.Location = New Point(644, 21)
        btnFiltrar.Name = "btnFiltrar"
        btnFiltrar.Size = New Size(75, 23)
        btnFiltrar.TabIndex = 3
        btnFiltrar.Text = "Filtrar"
        btnFiltrar.UseVisualStyleBackColor = True
        ' 
        ' grid
        ' 
        grid.AllowUserToAddRows = False
        grid.AllowUserToDeleteRows = False
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grid.Columns.AddRange(New DataGridViewColumn() {nome, id_cliente, numeroCartao, valorTransacao, dataTransacao, descricao, categoria, editar, remover, id_transacao})
        grid.Location = New Point(12, 72)
        grid.Name = "grid"
        grid.ReadOnly = True
        grid.Size = New Size(725, 322)
        grid.TabIndex = 1
        ' 
        ' btnInserir
        ' 
        btnInserir.Location = New Point(662, 400)
        btnInserir.Name = "btnInserir"
        btnInserir.Size = New Size(75, 23)
        btnInserir.TabIndex = 2
        btnInserir.Text = "Inserir"
        btnInserir.UseVisualStyleBackColor = True
        ' 
        ' btnRelatorioTransacoes
        ' 
        btnRelatorioTransacoes.Location = New Point(12, 400)
        btnRelatorioTransacoes.Name = "btnRelatorioTransacoes"
        btnRelatorioTransacoes.Size = New Size(145, 23)
        btnRelatorioTransacoes.TabIndex = 3
        btnRelatorioTransacoes.Text = "Relatório de transações"
        btnRelatorioTransacoes.UseVisualStyleBackColor = True
        ' 
        ' btnExportar
        ' 
        btnExportar.Location = New Point(163, 400)
        btnExportar.Name = "btnExportar"
        btnExportar.Size = New Size(136, 23)
        btnExportar.TabIndex = 4
        btnExportar.Text = "Exportar Excel"
        btnExportar.UseVisualStyleBackColor = True
        ' 
        ' nome
        ' 
        nome.DataPropertyName = "nome"
        nome.HeaderText = "Cliente"
        nome.Name = "nome"
        nome.ReadOnly = True
        ' 
        ' id_cliente
        ' 
        id_cliente.DataPropertyName = "id_cliente"
        id_cliente.HeaderText = "id_cliente"
        id_cliente.Name = "id_cliente"
        id_cliente.ReadOnly = True
        id_cliente.Visible = False
        ' 
        ' numeroCartao
        ' 
        numeroCartao.DataPropertyName = "numeroCartao"
        numeroCartao.HeaderText = "Numero Cartão"
        numeroCartao.Name = "numeroCartao"
        numeroCartao.ReadOnly = True
        numeroCartao.Width = 120
        ' 
        ' valorTransacao
        ' 
        valorTransacao.DataPropertyName = "valorTransacao"
        valorTransacao.HeaderText = "Valor"
        valorTransacao.Name = "valorTransacao"
        valorTransacao.ReadOnly = True
        ' 
        ' dataTransacao
        ' 
        dataTransacao.DataPropertyName = "dataTransacao"
        dataTransacao.HeaderText = "Data/Hora"
        dataTransacao.Name = "dataTransacao"
        dataTransacao.ReadOnly = True
        ' 
        ' descricao
        ' 
        descricao.DataPropertyName = "descricao"
        descricao.HeaderText = "Descrição"
        descricao.Name = "descricao"
        descricao.ReadOnly = True
        ' 
        ' categoria
        ' 
        categoria.DataPropertyName = "categoria"
        categoria.HeaderText = "Categoria"
        categoria.Name = "categoria"
        categoria.ReadOnly = True
        ' 
        ' editar
        ' 
        editar.HeaderText = ""
        editar.Image = CType(resources.GetObject("editar.Image"), Image)
        editar.Name = "editar"
        editar.ReadOnly = True
        editar.Width = 50
        ' 
        ' remover
        ' 
        remover.HeaderText = ""
        remover.Image = CType(resources.GetObject("remover.Image"), Image)
        remover.Name = "remover"
        remover.ReadOnly = True
        remover.Width = 50
        ' 
        ' id_transacao
        ' 
        id_transacao.DataPropertyName = "id_transacao"
        id_transacao.HeaderText = "ID"
        id_transacao.Name = "id_transacao"
        id_transacao.ReadOnly = True
        id_transacao.Visible = False
        ' 
        ' frmInicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(749, 429)
        Controls.Add(btnExportar)
        Controls.Add(btnRelatorioTransacoes)
        Controls.Add(btnInserir)
        Controls.Add(grid)
        Controls.Add(Filtros)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmInicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transações"
        Filtros.ResumeLayout(False)
        Filtros.PerformLayout()
        CType(grid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Filtros As GroupBox
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents grid As DataGridView
    Friend WithEvents btnInserir As Button
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents dataFiltro As DateTimePicker
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnRelatorioTransacoes As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents id_cliente As DataGridViewTextBoxColumn
    Friend WithEvents numeroCartao As DataGridViewTextBoxColumn
    Friend WithEvents valorTransacao As DataGridViewTextBoxColumn
    Friend WithEvents dataTransacao As DataGridViewTextBoxColumn
    Friend WithEvents descricao As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents editar As DataGridViewImageColumn
    Friend WithEvents remover As DataGridViewImageColumn
    Friend WithEvents id_transacao As DataGridViewTextBoxColumn

End Class

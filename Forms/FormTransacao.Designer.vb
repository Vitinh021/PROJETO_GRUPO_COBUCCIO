<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransacao
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
        txtNumeroCartao = New TextBox()
        GroupBox1 = New GroupBox()
        grValor = New GroupBox()
        txtValor = New TextBox()
        GroupBox4 = New GroupBox()
        txtDescricao = New RichTextBox()
        btnSalvarAtualizar = New Button()
        GroupBox2 = New GroupBox()
        cmbCliente = New ComboBox()
        GroupBox1.SuspendLayout()
        grValor.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNumeroCartao
        ' 
        txtNumeroCartao.Location = New Point(6, 22)
        txtNumeroCartao.Name = "txtNumeroCartao"
        txtNumeroCartao.Size = New Size(142, 23)
        txtNumeroCartao.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtNumeroCartao)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(157, 55)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Numero cartão"
        ' 
        ' grValor
        ' 
        grValor.Controls.Add(txtValor)
        grValor.Location = New Point(175, 12)
        grValor.Name = "grValor"
        grValor.Size = New Size(157, 55)
        grValor.TabIndex = 1
        grValor.TabStop = False
        grValor.Text = "Valor"
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(6, 22)
        txtValor.Name = "txtValor"
        txtValor.Size = New Size(142, 23)
        txtValor.TabIndex = 0
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txtDescricao)
        GroupBox4.Location = New Point(12, 73)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(483, 98)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Descrição"
        ' 
        ' txtDescricao
        ' 
        txtDescricao.Location = New Point(6, 22)
        txtDescricao.Name = "txtDescricao"
        txtDescricao.Size = New Size(471, 68)
        txtDescricao.TabIndex = 0
        txtDescricao.Text = ""
        ' 
        ' btnSalvarAtualizar
        ' 
        btnSalvarAtualizar.Location = New Point(420, 177)
        btnSalvarAtualizar.Name = "btnSalvarAtualizar"
        btnSalvarAtualizar.Size = New Size(75, 23)
        btnSalvarAtualizar.TabIndex = 4
        btnSalvarAtualizar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(cmbCliente)
        GroupBox2.Location = New Point(338, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(157, 55)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cliente"
        ' 
        ' cmbCliente
        ' 
        cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCliente.FormattingEnabled = True
        cmbCliente.Items.AddRange(New Object() {"João", "José", "Marcos", "Julio", "Maicon", "Arthur", "Pedro"})
        cmbCliente.Location = New Point(6, 22)
        cmbCliente.Name = "cmbCliente"
        cmbCliente.Size = New Size(145, 23)
        cmbCliente.TabIndex = 0
        ' 
        ' FormTransacao
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(509, 207)
        Controls.Add(GroupBox2)
        Controls.Add(btnSalvarAtualizar)
        Controls.Add(GroupBox4)
        Controls.Add(grValor)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FormTransacao"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transação"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grValor.ResumeLayout(False)
        grValor.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtNumeroCartao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grValor As GroupBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDescricao As RichTextBox
    Friend WithEvents btnSalvarAtualizar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCliente As ComboBox
End Class

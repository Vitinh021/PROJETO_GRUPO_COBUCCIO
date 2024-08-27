Imports System.Data.SqlClient

Public Class TransacaoDAO

    Public Shared Function GetTransacoes(Optional numeroCartao As Integer = 0, Optional dataTransacao As Date = Nothing, Optional valorTransacao As Decimal = 0) As DataTable
        Try
            Dim dataTable As New DataTable
            Using cmd As New SqlCommand("sp_ConsultarTransacoes", Conexao.Conectar())
                If numeroCartao <> 0 Then cmd.Parameters.AddWithValue("@numeroCartao", numeroCartao)
                If dataTransacao <> Nothing Then cmd.Parameters.AddWithValue("@dataTransacao", dataTransacao)
                If valorTransacao <> 0 Then cmd.Parameters.AddWithValue("@valorTransacao", valorTransacao)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dataTable)
                End Using
            End Using
            Return dataTable

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Sub Inserir(transacao As Transacao)

        Try
            Using cmd As New SqlCommand("sp_InsTransacao", Conexao.Conectar())

                cmd.Parameters.AddWithValue("@numeroCartao", transacao.NumeroCartao)
                cmd.Parameters.AddWithValue("@valorTransacao", transacao.ValorTransacao)
                cmd.Parameters.AddWithValue("@descricao", transacao.Descricao)
                cmd.Parameters.AddWithValue("@idCliente", transacao.Id_Cliente)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Sub Atualizar(transacao As Transacao)

        Try
            Using cmd As New SqlCommand("sp_UpdTransacao", Conexao.Conectar())

                cmd.Parameters.AddWithValue("@id_transacao", transacao.Id)
                cmd.Parameters.AddWithValue("@numeroCartao", transacao.NumeroCartao)
                cmd.Parameters.AddWithValue("@valorTransacao", transacao.ValorTransacao)
                cmd.Parameters.AddWithValue("@descricao", transacao.Descricao)
                cmd.Parameters.AddWithValue("@idCliente", transacao.Id_Cliente)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Sub Remover(id_transacao As Integer)

        Try
            Using cmd As New SqlCommand("sp_DelTransacao", Conexao.Conectar())

                cmd.Parameters.AddWithValue("@id_transacao", id_transacao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()

            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Shared Function GetClientes() As DataTable
        Try
            Dim dataTable As New DataTable
            Using cmd As New SqlCommand("sp_ConsultarClientes", Conexao.Conectar())
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dataTable)
                End Using
            End Using
            Return dataTable

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Shared Function GetRelatorioTransacoes(Optional dtInicio As Date = Nothing, Optional dtFinal As Date = Nothing) As DataTable
        Try
            Dim dataTable As New DataTable
            Using cmd As New SqlCommand("sp_RelatorioTransacoes", Conexao.Conectar())
                cmd.Parameters.AddWithValue("@dtInicio", dtInicio)
                cmd.Parameters.AddWithValue("@dtFinal", dtFinal)
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dataTable)
                End Using
            End Using
            Return dataTable

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Shared Function GetExportarPlanilha() As DataTable
        Try
            Dim dataTable As New DataTable
            Using cmd As New SqlCommand("sp_ExportarPlanilha", Conexao.Conectar())
                cmd.CommandType = CommandType.StoredProcedure
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dataTable)
                End Using
            End Using
            Return dataTable

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

End Class

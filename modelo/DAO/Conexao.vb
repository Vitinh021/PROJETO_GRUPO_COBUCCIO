Public Class Conexao
    Private Shared conexao As SqlClient.SqlConnection
    Public Shared Function Conectar()
        Try
            conexao = New SqlClient.SqlConnection("Data Source=MARCOS-VICTOR\SQLSERVER;Initial Catalog=Transacao; Integrated Security=True")
            conexao.Open()
            Return conexao
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Sub Fechar()
        Try
            If Not IsNothing(conexao) AndAlso conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

-- BANCO
CREATE DATABASE Transacao;
GO

USE Transacao;
GO
-- TABELAS
CREATE TABLE cliente (
    id_cliente INT IDENTITY(1,1) PRIMARY KEY,
    nome VARCHAR(100) NOT NULL
)
GO

INSERT INTO Cliente (Nome)
VALUES 
('João Silva'),
('Maria Oliveira'),
('Pedro Santos'),
('Ana Souza'),
('Carlos Lima'),
('Fernanda Costa'),
('Rafael Alves'),
('Juliana Pereira'),
('Marcos Ribeiro'),
('Patrícia Mendes');
GO

CREATE TABLE transacao(
	id_transacao INT IDENTITY(1,1) PRIMARY KEY,
	numeroCartao INT NOT NULL,
	valorTransacao DECIMAL(10, 2) NOT NULL,
	dataTransacao DATETIME DEFAULT GETDATE(),
	descricao VARCHAR(255) NOT NULL,
	id_cliente INT NOT NULL,
	FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);
GO

-- PROCEDURES

IF OBJECT_ID('sp_InsTransacao', 'P') IS NOT NULL
    DROP PROCEDURE sp_InsTransacao;
GO
CREATE PROCEDURE sp_InsTransacao
    @numeroCartao VARCHAR(50),
    @valorTransacao DECIMAL(18, 2),
    @descricao NVARCHAR(255),
	@idCliente INT
AS
BEGIN
	INSERT INTO Transacao (numeroCartao, valorTransacao, descricao, id_cliente)
    VALUES (@numeroCartao, @valorTransacao, @descricao, @idCliente);
END
GO

IF OBJECT_ID('sp_UpdTransacao', 'P') IS NOT NULL
    DROP PROCEDURE sp_UpdTransacao;
GO
CREATE PROCEDURE sp_UpdTransacao
	@id_transacao INT,
    @numeroCartao VARCHAR(50),
    @valorTransacao DECIMAL(18, 2),
    @descricao NVARCHAR(255),
	@idCliente INT
AS
BEGIN

    UPDATE transacao
    SET numeroCartao = @numeroCartao,
        valorTransacao = @valorTransacao,
        descricao = @descricao,
		dataTransacao = GETDATE(),
		id_cliente = @idCliente
    WHERE id_transacao = @id_transacao;
END
GO

IF OBJECT_ID('sp_DelTransacao', 'P') IS NOT NULL
    DROP PROCEDURE sp_DelTransacao;
GO
CREATE PROCEDURE sp_DelTransacao
	@id_transacao INT
AS
BEGIN
    DELETE FROM transacao
    WHERE id_transacao = @id_transacao;
END
GO

IF OBJECT_ID('sp_ConsultarTransacoes', 'P') IS NOT NULL
    DROP PROCEDURE sp_ConsultarTransacoes;
GO
CREATE PROCEDURE sp_ConsultarTransacoes
    @numeroCartao VARCHAR(50) = NULL,
    @dataTransacao DATE = NULL,
    @valorTransacao DECIMAL(18, 2) = NULL
AS
BEGIN
    SELECT * FROM vw_Transacoes
    WHERE
        (@NumeroCartao IS NULL OR NumeroCartao = @NumeroCartao)
        AND (@DataTransacao IS NULL OR CAST(dataTransacao AS DATE) = @DataTransacao)
        AND (@ValorTransacao IS NULL OR ValorTransacao = @ValorTransacao);
END
GO

IF OBJECT_ID('sp_ConsultarClientes', 'P') IS NOT NULL
    DROP PROCEDURE sp_ConsultarClientes;
GO
CREATE PROCEDURE sp_ConsultarClientes
AS
BEGIN
    SELECT * FROM cliente
END
GO

IF OBJECT_ID('sp_RelatorioTransacoes', 'P') IS NOT NULL
    DROP PROCEDURE sp_RelatorioTransacoes;
GO
CREATE PROCEDURE sp_RelatorioTransacoes
    @dtInicio DATE,
    @dtFinal DATE
AS
BEGIN
    SELECT 
        numeroCartao,
        SUM(valorTransacao) AS valorTotal,
        COUNT(*) AS qtdTransacoes
    FROM 
        transacao
    WHERE 
        CAST(dataTransacao AS DATE) BETWEEN @dtInicio AND @dtFinal
    GROUP BY 
        numeroCartao
END
GO

IF OBJECT_ID('sp_ExportarPlanilha', 'P') IS NOT NULL
    DROP PROCEDURE sp_ExportarPlanilha;
GO
CREATE PROCEDURE sp_ExportarPlanilha
AS
BEGIN
	SELECT 
    numerocartao,
    valorTransacao,
    dataTransacao,
    descricao,
    dbo.fn_CategorizaTransacao(valorTransacao) AS categoria
	FROM 
		transacao
	WHERE 
		dataTransacao >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) - 1, 0)
		AND dataTransacao < DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)
END
GO

-- VIEW
IF OBJECT_ID('vw_Transacoes', 'V') IS NOT NULL
    DROP VIEW vw_Transacoes;
GO
CREATE VIEW vw_Transacoes
AS
SELECT 
	cl.id_cliente,
	cl.nome,
	tr.id_transacao,
    tr.numeroCartao, 
    tr.valorTransacao, 
    tr.dataTransacao, 
    tr.descricao, 
    dbo.fn_CategorizaTransacao(tr.valorTransacao) AS categoria
FROM 
    transacao tr
	JOIN cliente cl ON tr.id_cliente = cl.id_cliente;
GO

CREATE TABLE [dbo].[Fornecedores]
(
	[idfornecedor] BIGINT NOT NULL PRIMARY KEY, 
    [idcidade] BIGINT NOT NULL, 
    [nome] NVARCHAR(50) NOT NULL, 
    [cnpj] NCHAR(14) NOT NULL, 
    CONSTRAINT [FK_Fornecedores_ToCidades]
	FOREIGN KEY ([idcidade]) REFERENCES [Cidades]([idcidade])
)

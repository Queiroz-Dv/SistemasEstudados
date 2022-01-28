CREATE TABLE [dbo].[Produtos]
(
	[idproduto] BIGINT NOT NULL PRIMARY KEY, 
    [idgrupo] BIGINT NOT NULL, 
    [descricao] NVARCHAR(50) NOT NULL, 
    [precodecompra] NUMERIC(18, 2) NOT NULL, 
    [precodevenda] NUMERIC(18, 2) NOT NULL, 
    [quantidadeestoque] NUMERIC(18, 3) NOT NULL, 
    CONSTRAINT [FK_Produtos_Grupos]
	FOREIGN KEY ([idgrupo]) REFERENCES [dbo].[Grupos]([idgrupo])
)

CREATE TABLE [dbo].[ProdutoNotaEntrada]
(
	[ID] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [IDNotaEntrada] BIGINT NOT NULL, 
    [IDProduto] INT NOT NULL, 
    [PrecoCompra] NUMERIC(18, 2) NOT NULL, 
    [QuandidadeCompra] NUMERIC(18, 3) NOT NULL, 
    CONSTRAINT [FK_ProdutoNotaEntrada_ToNotaEntrada]
	FOREIGN KEY ([IDNotaEntrada]) REFERENCES [NotaEntrada]([ID]),

	CONSTRAINT [FK_ProdutoNotaEntrada_ToProdutos]
	FOREIGN KEY ([IDProduto]) REFERENCES [Produtos]([ID])
)

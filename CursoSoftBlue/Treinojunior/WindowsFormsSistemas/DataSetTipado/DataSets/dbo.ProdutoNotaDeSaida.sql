CREATE TABLE [dbo].[ProdutosNotaDeSaida]
(
	[idprodutonotadesaida] BIGINT NOT NULL PRIMARY KEY, 
    [idnotadevenda] BIGINT NOT NULL, 
    [idproduto] BIGINT NOT NULL, 
    [precodevenda] NUMERIC(18, 2) NOT NULL, 
    [quantidade] NUMERIC(18, 3) NOT NULL, 
    CONSTRAINT [FK_ProdutosNotaDeSaida_NotasDeVenda]
	FOREIGN KEY ([idnotadevenda]) REFERENCES [NotasDeVenda]([idnotadevenda]), 
    CONSTRAINT [FK_ProdutosNotaDeSaida_Produtos]
	FOREIGN KEY ([idproduto]) REFERENCES [Produtos]([idproduto])

)

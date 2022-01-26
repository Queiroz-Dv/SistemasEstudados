CREATE TABLE [dbo].[Produtos]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Descricao] NVARCHAR(20) NOT NULL, 
    [PrecoCusto] NUMERIC(18, 2) NOT NULL, 
    [PrecoVenda] NUMERIC(18, 2) NOT NULL, 
    [Estoque] NUMERIC(18, 3) NOT NULL,
	
)

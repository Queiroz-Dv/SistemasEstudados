CREATE TABLE [dbo].[NotasDeVenda]
(
	[idnotadevenda] BIGINT NOT NULL PRIMARY KEY, 
    [idcliente] BIGINT NOT NULL, 
    [numerodanota] NVARCHAR(50) NOT NULL, 
    [datavenda] DATE NOT NULL, 
    [notafechada] CHAR(1) NOT NULL DEFAULT 'N', 
    CONSTRAINT [FK_NotasDeVenda_Clientes]
	FOREIGN KEY ([idcliente]) REFERENCES [Clientes]([idcliente])
)

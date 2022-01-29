CREATE TABLE [dbo].[NotadeEntrada]
(
	[idnotaentrada] BIGINT NOT NULL PRIMARY KEY, 
    [idfornecedor] BIGINT NOT NULL, 
    [numerodanota] NVARCHAR(15) NOT NULL, 
    [dataemissao] DATE NOT NULL, 
    [dataentrada] DATE NOT NULL, 
    CONSTRAINT [FK_NotadeEntrada_Fornecedores]
	FOREIGN KEY ([idfornecedor]) REFERENCES [Fornecedores]([idfornecedor])
)

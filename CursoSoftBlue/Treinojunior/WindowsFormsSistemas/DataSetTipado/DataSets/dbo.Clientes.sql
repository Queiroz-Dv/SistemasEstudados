CREATE TABLE [dbo].[Clientes]
(
	[idcliente] BIGINT NOT NULL PRIMARY KEY, 
    [idcidade] BIGINT NOT NULL, 
    [nome] VARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Clientes_Cidades]
	FOREIGN KEY ([idcidade]) REFERENCES [Cidades]([idcidade])
)

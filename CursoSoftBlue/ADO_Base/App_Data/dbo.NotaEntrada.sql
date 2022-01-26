CREATE TABLE [dbo].[NotaEntrada]
(
	[ID] BIGINT NOT NULL PRIMARY KEY,
	[IDFornecedor] BIGINT NOT NULL, 
    [Numero] NVARCHAR(20) NOT NULL,
	[DataEmissao] DATE NOT NULL,
	[DataEntrada] DATE NOT NULL, 
    CONSTRAINT [FK_NotaEntrada_ToFornecedores]
	FOREIGN KEY ([IdFornecedor]) REFERENCES [Fornecedores]([ID])
)

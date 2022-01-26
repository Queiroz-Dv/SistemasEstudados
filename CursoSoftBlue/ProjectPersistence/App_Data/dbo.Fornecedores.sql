CREATE TABLE [dbo].[Fornecedores] (
    [ID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [Cnpj] NCHAR (14)    NOT NULL,
    [Nome] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


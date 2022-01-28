CREATE TABLE [dbo].[Cidades] (
    [idcidade] BIGINT        NOT NULL,
    [idestado] BIGINT        NOT NULL,
    [nome]     NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Cidades] PRIMARY KEY CLUSTERED ([idcidade] ASC),
    CONSTRAINT [FK_Cidades_Estados] FOREIGN KEY ([idcidade]) REFERENCES [dbo].[Estados] ([idestado])
);


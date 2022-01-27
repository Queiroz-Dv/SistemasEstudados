CREATE TABLE [dbo].[Estados] (
    [idestado] BIGINT        IDENTITY (1, 1) NOT NULL,
    [uf]       NCHAR (2)     NOT NULL,
    [nome]     NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED ([idestado] ASC)
);


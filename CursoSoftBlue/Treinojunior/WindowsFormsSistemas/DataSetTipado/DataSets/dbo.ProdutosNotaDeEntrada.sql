CREATE TABLE [dbo].[ProdutosNotaDeEntrada] (
    [idprodutonotaentrada] BIGINT          NOT NULL,
    [idnotadeentrada]      BIGINT          NOT NULL,
    [idproduto]            BIGINT          NOT NULL,
    [precocustocompra]     NUMERIC (18, 2) NOT NULL,
    [quantidadecomprada]   NUMERIC (18, 3) NOT NULL,
    PRIMARY KEY CLUSTERED ([idprodutonotaentrada] ASC),
    CONSTRAINT [FK_ProdutosNotaDeEntrada_NotadeEntrada] FOREIGN KEY ([idnotadeentrada]) REFERENCES [dbo].[NotadeEntrada] ([idnotaentrada]), 
    CONSTRAINT [FK_ProdutosNotaDeEntrada_Produtos] FOREIGN KEY ([idproduto]) REFERENCES [Produtos]([idproduto])
);


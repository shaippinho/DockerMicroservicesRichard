IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Estoque')
BEGIN
    CREATE DATABASE Estoque
END
go

USE Estoque
IF NOT EXISTS(SELECT * FROM information_schema.tables WHERE table_name = 'Produtos')
BEGIN
   CREATE TABLE [Produtos] (
    [idproduto] INTEGER IDENTITY(1,1) NOT NULL,
    [nmproduto] VARCHAR(200) NOT NULL,
    [nuvalor] DECIMAL (16,2) NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([idproduto])
)
END
go




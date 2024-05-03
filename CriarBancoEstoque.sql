IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'Estoque')
BEGIN
    CREATE DATABASE Estoque
END
go

USE Estoque
IF NOT EXISTS(SELECT * FROM information_schema.tables WHERE table_name = 'Produtos')
BEGIN
   CREATE TABLE [Produtos] (
    [id_produto] INTEGER IDENTITY(0,1) NOT NULL,
    [nm_produto] VARCHAR(200) NOT NULL,
    [nu_valor] NUMERIC NOT NULL,
    CONSTRAINT [PK_Produtos] PRIMARY KEY ([id_produto]))
END
go




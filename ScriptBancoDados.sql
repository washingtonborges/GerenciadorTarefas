USE [master]
GO
CREATE DATABASE [GerenciadorTarefas]
GO 
USE [GerenciadorTarefas]
GO
CREATE TABLE [dbo].[Tarefa](
	[TarefaId] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](max) NULL,
	[Concluida] [bit] NULL)

GO

CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](300) NULL,
	[Email] [varchar](300) NULL,
	[Permissao] [varchar](50) NULL,
	[Senha] [varchar](100) NULL)

GO

ALTER TABLE [Tarefa]
ADD CONSTRAINT [PK_Tarefa] PRIMARY KEY ([TarefaId])

GO

ALTER TABLE [Usuario]
ADD CONSTRAINT [PK_Usuario] PRIMARY KEY ([UsuarioId])
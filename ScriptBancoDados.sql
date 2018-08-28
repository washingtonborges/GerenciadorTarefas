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

CREATE TABLE [dbo].[Perfil](
	[PerfilId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NULL)

GO

CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](300) NULL,
	[Email] [varchar](300) NULL,
	[Permissao] [varchar](50) NULL,
	[Senha] [varchar](100) NULL,
	[PerfilId] [int] NOT NULL)

GO

ALTER TABLE [Tarefa]
ADD CONSTRAINT [PK_Tarefa] PRIMARY KEY ([TarefaId])

GO

ALTER TABLE [Perfil]
ADD CONSTRAINT [PK_Perfil] PRIMARY KEY ([PerfilId])

GO

ALTER TABLE [Usuario]
ADD CONSTRAINT [PK_Usuario] PRIMARY KEY ([UsuarioId]) 

GO

ALTER TABLE [Usuario]
ADD CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY ([PerfilId])     
    REFERENCES [Perfil] ([PerfilId])
	    
GO    
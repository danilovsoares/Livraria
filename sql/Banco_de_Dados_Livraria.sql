USE [master]
GO
CREATE DATABASE [Livraria]
GO 
USE [Livraria]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livro](
	[LivroId] [uniqueidentifier] NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Descricao] [varchar](255) NOT NULL,
	[Autor] [varchar](50) NOT NULL,
	[Editora] [varchar](50) NOT NULL,
	[NumeroEdicao] [int] NOT NULL,
	[AnoEdicao] [int] NOT NULL,
	[ISBN] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Livro] PRIMARY KEY CLUSTERED 
(
	[LivroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

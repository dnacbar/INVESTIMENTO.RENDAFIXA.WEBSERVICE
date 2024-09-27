USE [DBRENDAFIXA]
GO

INSERT INTO [dbo].[IMPOSTO]
           ([ID_IMPOSTO]
           ,[TX_NOME]
           ,[TX_DESCRICAO]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
           (1
			,'IRRF'
			,'IMPOSTO DE RENDA RETIDO NA FONTE'
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[IMPOSTO]
           ([ID_IMPOSTO]
           ,[TX_NOME]
           ,[TX_DESCRICAO]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
			(2
			,'IOF'
			,'IMPOSTO SOBRE OPERAÇÃO FINANCEIRA'
			,'DN'
			,GETDATE())
GO
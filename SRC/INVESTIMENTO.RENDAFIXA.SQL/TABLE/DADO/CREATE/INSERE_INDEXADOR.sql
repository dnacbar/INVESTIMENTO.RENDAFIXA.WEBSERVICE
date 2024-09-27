USE [DBRENDAFIXA]
GO

INSERT INTO [dbo].[INDEXADOR]
           ([ID_INDEXADOR]
           ,[TX_NOME]
           ,[TX_DESCRICAO]
           ,[NM_RENDIMENTO]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
           (NEWID()
			,'CDI'
			,'CERTIFICADO DE DEPÓSITO INTERBANCÁRIO'
			,10.65
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[INDEXADOR]
           ([ID_INDEXADOR]
           ,[TX_NOME]
           ,[TX_DESCRICAO]
           ,[NM_RENDIMENTO]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
           (NEWID()
			,'IPCA'
			,'ÍNDICE NACIONAL DE PREÇOS AO CONSUMIDOR AMPLO'
			,4.50
			,'DN'
			,GETDATE())
GO
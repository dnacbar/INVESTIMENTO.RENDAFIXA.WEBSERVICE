USE [DBRENDAFIXA]
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[TX_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
			(1
			,1
			,22.5
			,180
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[TX_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
			(1
			,2
			,20
			,360
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[TX_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
			(1
			,3
			,17.5
			,720
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[TX_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
			(1
			,4
			,15
			,0
			,'DN'
			,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[TX_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,1
           ,96
           ,30
           ,'DN'
           ,GETDATE())
GO
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

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
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
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,1
           ,96
           ,1
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,2
           ,93
           ,2
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,3
           ,90
           ,3
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,4
           ,86
           ,4
           ,'DN'
           ,GETDATE())
GO
INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,5
           ,83
           ,5
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,6
           ,80
           ,6
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,7
           ,76
           ,7
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,8
           ,73
           ,8
           ,'DN'
           ,GETDATE())
GO
INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,9
           ,70
           ,9
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,10
           ,66
           ,10
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,11
           ,63
           ,11
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,12
           ,60
           ,12
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,13
           ,56
           ,13
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,14
           ,53
           ,14
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,15
           ,50
           ,15
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,16
           ,46
           ,16
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,17
           ,43
           ,17
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,18
           ,40
           ,18
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,19
           ,36
           ,19
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,20
           ,33
           ,20
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,21
           ,30
           ,21
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,22
           ,26
           ,22
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,23
           ,23
           ,23
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,24
           ,20
           ,24
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,25
           ,16
           ,25
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,26
           ,13
           ,26
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,27
           ,10
           ,27
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,28
           ,6
           ,28
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,29
           ,3
           ,29
           ,'DN'
           ,GETDATE())
GO

INSERT INTO [dbo].[CONFIGURACAOIMPOSTO]
           ([ID_IMPOSTO]
           ,[ID_CONFIGURACAOIMPOSTO]
           ,[NM_RENDIMENTO]
           ,[NM_DIASUTEIS]
           ,[TX_USUARIOCRIACAO]
           ,[DT_CRIACAO])
     VALUES
		   (2
           ,30
           ,0
           ,30
           ,'DN'
           ,GETDATE())
GO
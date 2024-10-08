USE [DBRENDAFIXA]

    INSERT INTO [dbo].[INVESTIMENTO]
               ([ID_INVESTIMENTO]
               ,[ID_INVESTIDOR]
               ,[TX_DOCUMENTOFEDERAL]
               ,[NM_VALORINICIAL]
               ,[NM_VALORFINAL]
               ,[NM_VALORIMPOSTO]
               ,[NM_TAXARENDIMENTO]
               ,[NM_TAXAADICIONAL]
               ,[DT_INICIAL]
               ,[DT_FINAL]
               ,[ID_INDEXADOR]
               ,[BO_LIQUIDADO]
               ,[BO_ISENTOIMPOSTO]
               ,[TX_USUARIO]
               ,[DT_CRIACAO]
               ,[TX_USUARIOATUALIZACAO]
               ,[DT_ATUALIZACAO])
         VALUES
               ('2FC9D09E-F6CF-4DF0-B99A-D29AE291AEF5'
    			,NEWID()
    			,'41841060801'
    			,990
    			,1000
    			,0
    			,10.65
    			,0
    			,'2024-09-28'
    			,'2025-09-28'
    			,2
    			,0
    			,0
    			,'DN'
    			,'2024-09-28 23:30:49.323'
    			,NULL
    			,NULL)
    
    INSERT INTO [dbo].[MOVIMENTACAO]
               ([ID_INVESTIMENTO]
               ,[ID_MOVIMENTACAO]
               ,[DT_MOVIMENTACAO]
               ,[NM_VALORBRUTOTOTAL]
               ,[NM_VALORLIQUIDOTOTAL]
               ,[NM_VALORBRUTO]
               ,[NM_VALORLIQUIDO]
               ,[TX_USUARIO]
               ,[DT_CRIACAO]
               ,[TX_USUARIOATUALIZACAO]
               ,[DT_ATUALIZACAO])
         VALUES
               ('2FC9D09E-F6CF-4DF0-B99A-D29AE291AEF5'
               ,1
               ,'2024-09-28'
               ,1010	
               ,1000
               ,0
    		   ,0
               ,'DN'
               ,'2024-09-28 23:30:49.323'
               ,NULL
               ,NULL)

    INSERT INTO [dbo].[MOVIMENTACAOIMPOSTO]
           ([ID_INVESTIMENTO]
           ,[ID_MOVIMENTACAO]
           ,[ID_IMPOSTO]
           ,[NM_VALORIMPOSTO])
     VALUES
           ('2FC9D09E-F6CF-4DF0-B99A-D29AE291AEF5'
           ,1
           ,1
           ,0.10)

    INSERT INTO [dbo].[MOVIMENTACAOIMPOSTO]
           ([ID_INVESTIMENTO]
           ,[ID_MOVIMENTACAO]
           ,[ID_IMPOSTO]
           ,[NM_VALORIMPOSTO])
     VALUES
           ('2FC9D09E-F6CF-4DF0-B99A-D29AE291AEF5'
           ,1
           ,2
           ,10)
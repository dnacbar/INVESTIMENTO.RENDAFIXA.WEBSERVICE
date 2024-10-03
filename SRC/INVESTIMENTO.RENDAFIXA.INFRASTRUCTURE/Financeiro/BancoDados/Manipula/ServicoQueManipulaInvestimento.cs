using Dapper;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using System.Data;

namespace INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Manipula;

public class ServicoQueManipulaInvestimento(IDbConnection dbConnection) : IServicoQueManipulaInvestimento
{
    private readonly IDbConnection _dbConnection = dbConnection;

    public Task Adiciona(Investimento investimento)
    {
        var listaDeParametro = new
        {
            investimento.IdInvestimento,
            investimento.IdInvestidor,
            investimento.TxDocumentoFederal,
            investimento.NmValorInicial,
            investimento.NmValorFinal,
            investimento.NmValorImposto,
            investimento.NmTaxaRendimento,
            investimento.NmTaxaAdicional,
            investimento.DtInicial,
            investimento.DtFinal,
            investimento.IdIndexador,
            BoLiquidado = false,
            investimento.Movimentacao.IdMovimentacao,
            investimento.Movimentacao.DtMovimentacao,
            investimento.Movimentacao.NmValorBrutoTotal,
            investimento.Movimentacao.NmValorLiquidoTotal,
            investimento.Movimentacao.NmValorBruto,
            investimento.Movimentacao.NmValorLiquido,
            BoIsentoimposto = false,
            investimento.TxUsuario
        };

        var sql = @"
        USE [DBRENDAFIXA]

        INSERT INTO [dbo].[INVESTIMENTO]
        (
            [ID_INVESTIMENTO],
            [ID_INVESTIDOR],
            [TX_DOCUMENTOFEDERAL],
            [NM_VALORINICIAL],
            [NM_VALORFINAL],
            [NM_VALORIMPOSTO],
            [NM_TAXARENDIMENTO],
            [NM_TAXAADICIONAL],
            [DT_INICIAL],
            [DT_FINAL],
            [ID_INDEXADOR],
            [BO_LIQUIDADO],
            [BO_ISENTOIMPOSTO],
            [TX_USUARIO]
        )
        VALUES 
        (
            @IdInvestimento,
            @IdInvestidor,
            @TxDocumentoFederal,
            @NmValorInicial,
            @NmValorFinal,
            @NmValorImposto,
            @NmTaxaRendimento,
            @NmTaxaAdicional,
            @DtInicial,
            @DtFinal,
            @IdIndexador,
            @BoLiquidado,
            @BoIsentoimposto,
            @TxUsuario
        )
        
        INSERT INTO[dbo].[MOVIMENTACAO]
        ([ID_INVESTIMENTO]
           , [ID_MOVIMENTACAO]
           , [DT_MOVIMENTACAO]
           , [NM_VALORBRUTOTOTAL]
           , [NM_VALORLIQUIDOTOTAL]
           , [NM_VALORBRUTO]
           , [NM_VALORLIQUIDO]
           , [TX_USUARIO])
     VALUES
           (@IdInvestimento
           ,@IdMovimentacao
           ,@DtMovimentacao
           ,@NmValorBrutoTotal
           ,@NmValorLiquidoTotal
           ,@NmValorBruto
           ,@NmValorLiquido
           ,@TxUsuario)";

        return _dbConnection.ExecuteAsync(sql, listaDeParametro);
    }
}

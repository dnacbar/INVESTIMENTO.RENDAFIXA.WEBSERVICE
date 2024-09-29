using Dapper;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using System.Data;

namespace INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Manipula;

public class ServicoDeInvestimento(IDbConnection dbConnection) : IServicoDeInvestimento
{
    private readonly IDbConnection _dbConnection = dbConnection;

    public Task Adiciona(Investimento investimento)
    {
        var listaDeParametro = new
        {
            IdInvestimento = investimento.IdInvestimento,
            IdInvestidor = investimento.IdInvestidor,
            TxDocumentofederal = investimento.TxDocumentoFederal,
            NmValorinicial = investimento.NmValorInicial,
            NmValorfinal = investimento.NmValorFinal,
            NmValorimposto = investimento.NmValorImposto,
            NmTaxaRendimento = investimento.NmTaxaRendimento,
            NmTaxaAdicional = investimento.NmTaxaAdicional,
            DtInicial = investimento.DtInicial,
            DtFinal = investimento.DtFinal,
            IdIndexador = investimento.IdIndexador,
            BoLiquidado = false,
            IdMovimentacao = investimento.Movimentacao.IdMovimentacao,
            DtMovimentacao = investimento.Movimentacao.DtMovimentacao,
            NmValorBrutoTotal = investimento.Movimentacao.NmValorBrutoTotal, 
            NmValorLiquidoTotal = investimento.Movimentacao.NmValorLiquidoTotal,
            NmValorBruto = investimento.Movimentacao.NmValorBruto,
            NmValorLiquido = investimento.Movimentacao.NmValorLiquido,
            BoIsentoimposto = false,
            TxUsuario = investimento.TxUsuario
        };

        var sql = @$"
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
            @TxDocumentofederal,
            @NmValorinicial,
            @NmValorfinal,
            @NmValorimposto,
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

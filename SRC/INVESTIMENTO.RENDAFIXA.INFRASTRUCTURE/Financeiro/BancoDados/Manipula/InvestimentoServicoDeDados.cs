using Dapper;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;
using System.Data;

namespace INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Manipula;

public class InvestimentoServicoDeDados(IDbConnection dbConnection) : IInvestimentoServicoDeDados
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
            NmTaxarendimento = investimento.NmTaxaRendimento,
            NmTaxaadiional = investimento.NmTaxaAdicional,
            DtInicial = investimento.DtInicial,
            DtFinal = investimento.DtFinal,
            IdIndexador = investimento.IdIndexador,
            BoLiquidado = false,
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
            [NM_TAXAADIIONAL],
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
            @NmTaxarendimento,
            @NmTaxaadicional,
            @DtInicial,
            @DtFinal,
            @IdIndexador,
            @BoLiquidado,
            @BoIsentoimposto,
            @TxUsuario
        )";

        return _dbConnection.ExecuteAsync(sql, listaDeParametro);
    }
}

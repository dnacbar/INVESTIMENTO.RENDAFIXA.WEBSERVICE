using Dapper;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Consulta;
using System.Data;

namespace INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Consulta;

public class ServicoQueConsultaInvestimentoDaPessoa(IDbConnection dbConnection) : IServicoQueConsultaInvestimentoDaPessoa
{
    private readonly IDbConnection _dbConnection = dbConnection;

    public Task<IEnumerable<Investimento>> ListaInvestimentoQueNaoEstaLiquidadoOuBloqueado(Investimento investimento)
    {
        var listaDeParametro = new
        {
            investimento.IdInvestimento,
            investimento.IdInvestidor,
            investimento.TxDocumentoFederal
        };

        var sql = @"USE [DBRENDAFIXA]

                    SELECT [ID_INVESTIMENTO]
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
                      FROM [dbo].[INVESTIMENTO]
                     WHERE [ID_INVESTIMENTO] = @IdInvestimento
                       AND [ID_INVESTIDOR] = @IdInvestidor
                       AND [TX_DOCUMENTOFEDERAL] = @TxDocumentoFederal
                       AND [BO_LIQUIDADO] = 0";

        return Task.Factory.StartNew<IEnumerable<Investimento>>(() =>
        {
            var retorno = new List<Investimento>();
        
            var dReader = _dbConnection.ExecuteReader(sql, listaDeParametro);
        
            while (dReader.Read())
            {
                retorno.Add(new Investimento(
                    Guid.Parse(dReader["ID_INVESTIMENTO"].ToString()),
                    Guid.Parse(dReader["ID_INVESTIDOR"].ToString()),
                    dReader["TX_DOCUMENTOFEDERAL"].ToString(),
                    Convert.ToDecimal(dReader["NM_VALORINICIAL"]),
                    Convert.ToDecimal(dReader["NM_VALORFINAL"]),
                    Convert.ToDecimal(dReader["NM_VALORIMPOSTO"]),
                    Convert.ToDecimal(dReader["NM_TAXARENDIMENTO"]),
                    Convert.ToDecimal(dReader["NM_TAXAADICIONAL"]),
                    Convert.ToDateTime(dReader["DT_INICIAL"]),
                    Convert.ToDateTime(dReader["DT_FINAL"]),
                    Convert.ToByte(dReader["ID_INDEXADOR"]),
                    Convert.ToBoolean(dReader["BO_LIQUIDADO"]),
                    Convert.ToBoolean(dReader["BO_ISENTOIMPOSTO"])));
            }
            dReader.Close();
        
            return retorno;
        });
    }
}

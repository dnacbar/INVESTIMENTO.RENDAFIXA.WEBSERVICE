using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Consulta;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;
using INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Consulta;
using INVESTIMENTO.RENDAFIXA.INFRASTRUCTURE.Financeiro.BancoDados.Manipula;
using System.Data;
using System.Data.SqlClient;

namespace INVESTIMENTO.RENDAFIXA.WEBAPI;

public static class ServicoInjecaoDeDependencia
{
    public static void AddServiceCollection(WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IDbConnection>(x => new SqlConnection(builder.Configuration.GetConnectionString("DBRENDAFIXA")));

        ApplicationService(builder.Services);
        DatabaseService(builder.Services);
    }


    private static void ApplicationService(IServiceCollection services)
    {
     
    }

    private static void DatabaseService(IServiceCollection services)
    {
        services.AddSingleton<IServicoQueConsultaInvestimentoDaPessoa, ServicoQueConsultaInvestimentoDaPessoa>();
        services.AddSingleton<IServicoQueManipulaInvestimento, ServicoQueManipulaInvestimento>();
    }
}

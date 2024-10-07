namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Consulta;

public interface IServicoQueConsultaInvestimentoDaPessoa
{
    Task<Investimento> ConsultaInvestimentoQueNaoEstaBloqueado(Investimento investimento);
    Task<IEnumerable<Investimento>> ListaInvestimentoQueNaoEstaLiquidadoNemBloqueado(Investimento investimento);
}

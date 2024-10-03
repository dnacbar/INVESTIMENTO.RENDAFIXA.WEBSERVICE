namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Consulta;

public interface IServicoQueConsultaInvestimentoDaPessoa
{
    Task<IEnumerable<Investimento>> ListaInvestimentoQueNaoEstaLiquidadoOuBloqueado(Investimento investimento);
}

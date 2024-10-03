namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;

public interface IServicoQueManipulaInvestimento
{
    Task Adiciona(Investimento investimento);
}

using INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro.BancoDados.Manipula;

public interface IInvestimentoServicoDeDados
{
    Task Adiciona(Investimento investimento);
}

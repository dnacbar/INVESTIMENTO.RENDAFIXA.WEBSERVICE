namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;

public class MovimentacaoImposto
{
    public MovimentacaoImposto(Guid idInvestimento, short idMovimentacao, short idImposto, decimal nmValorimposto)
    {
        IdInvestimento = idInvestimento;
        IdMovimentacao = idMovimentacao;
        IdImposto = idImposto;
        NmValorimposto = nmValorimposto;
    }

    public Guid IdInvestimento { get; }
    public short IdMovimentacao { get; }
    public short IdImposto { get; }
    public decimal NmValorimposto { get; }
}

namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;

public class Movimentacao
{
    private const int PrimeiroRegistroMovimentacao = 1;
    public Movimentacao(Investimento investimento)
    {
        IdInvestimento = investimento.IdInvestimento;
        IdMovimentacao = PrimeiroRegistroMovimentacao;
        DtMovimentacao = DateTime.Today;
        NmValorBrutoTotal = investimento.NmValorInicial;
        NmValorLiquidoTotal = NmValorBrutoTotal;
        NmValorBruto = decimal.Zero;
        NmValorLiquido = decimal.Zero;
        TxUsuario = investimento.TxUsuario;
        DtCriacao = DateTime.Now;
    }

    public MovimentacaoImposto? MovimentacaoImposto { get; } = null;
    public Guid IdInvestimento { get; }
    public short IdMovimentacao { get; }
    public DateTime DtMovimentacao { get; }
    public decimal NmValorBrutoTotal { get; }
    public decimal NmValorLiquidoTotal { get; }
    public decimal NmValorBruto { get; }
    public decimal NmValorLiquido { get; }
    public string TxUsuario { get; } = string.Empty;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public DateTime? DtAtualizacao { get; }
}

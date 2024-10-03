using DN.LOG.LIBRARY.MODEL.EXCEPTION;

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

    public Movimentacao(Guid idInvestimento, short idMovimentacao, DateTime dtMovimentacao, decimal nmValorBrutoTotal,
        decimal nmValorLiquidoTotal, decimal nmValorBruto, decimal nmValorLiquido)
    {
        IdInvestimento = idInvestimento;
        IdMovimentacao = idMovimentacao;
        DtMovimentacao = dtMovimentacao;
        NmValorBrutoTotal = nmValorBrutoTotal;
        NmValorLiquidoTotal = nmValorLiquidoTotal;
        NmValorBruto = nmValorBruto;
        NmValorLiquido = nmValorLiquido;

        ValidaMovimentacao();
    }

    public virtual IEnumerable<MovimentacaoImposto>? ListaDeMovimentacaoImposto { get; } = [];

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

    public bool VerificaSeValorLiquidoTotalEstaZerado() => NmValorLiquidoTotal == decimal.Zero;

    private void ValidaMovimentacao()
    {
        if (!VerificaSeValorBrutoTotalEhMaiorQueOValorLiquidoTotal())
            throw new BadRequestException($"Valor bruto total tem que ser maior que o valor líquido total! Valor bruto total:[{NmValorBruto}] Valor líquido total:[{NmValorLiquido}]");

        if (!VerificaSeValorBrutoTotalEhMaiorQueOValorBruto())
            throw new BadRequestException($"Valor bruto total tem que ser maior que o valor bruto! Valor bruto total:[{NmValorBrutoTotal}] Valor bruto:[{NmValorBruto}]");

        if (!VerificaSeValorLiquidoTotalEhMaiorQueOValorLiquido())
            throw new BadRequestException($"Valor líquido total tem que ser maior que o valor líquido! Valor líquido total:[{NmValorLiquidoTotal}] Valor líquido:[{NmValorLiquido}]");

        if (!VerificaSeValorBrutoEhMaiorQueOValorLiquido())
            throw new BadRequestException($"Valor bruto tem que ser maior que o valor líquido! Valor bruto:[{NmValorBruto}] Valor líquido:[{NmValorLiquido}]");
    }

    private bool VerificaSeValorBrutoEhMaiorQueOValorLiquido() => NmValorBruto > NmValorLiquido;
    private bool VerificaSeValorBrutoTotalEhMaiorQueOValorBruto() => NmValorBrutoTotal > NmValorBruto;
    private bool VerificaSeValorBrutoTotalEhMaiorQueOValorLiquidoTotal() => NmValorBrutoTotal > NmValorLiquidoTotal;
    private bool VerificaSeValorLiquidoTotalEhMaiorQueOValorLiquido() => NmValorLiquidoTotal > NmValorLiquido;
}

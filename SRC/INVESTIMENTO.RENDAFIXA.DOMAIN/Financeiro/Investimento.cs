namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public class Investimento
{
    public Investimento(Guid idInvestidor, string txDocumentoFederal, decimal nmValorInicial,
        decimal nmTaxarendimento, decimal nmTaxaAdicional, Guid idIndexador, bool boIsentoImposto)
    {
        IdInvestimento = new Guid();
        IdInvestidor = idInvestidor;
        TxDocumentoFederal = txDocumentoFederal;
        NmValorInicial = nmValorInicial;
        NmTaxaRendimento = nmTaxarendimento;
        NmTaxaAdicional = nmTaxaAdicional;
        IdIndexador = idIndexador;
        BoIsentoImposto = boIsentoImposto;
    }

    public Guid IdInvestimento { get; }
    public Guid IdInvestidor { get; }
    public string TxDocumentoFederal { get; } = string.Empty;
    public decimal NmValorInicial { get; }
    public decimal NmValorFinal { get; }
    public decimal NmValorImposto { get; }
    public decimal NmTaxaRendimento { get; }
    public decimal NmTaxaAdicional { get; private set; }
    public DateTime DtInicial { get; }
    public DateTime DtFinal { get; }
    public Guid IdIndexador
    {
        get
        {
            NmTaxaAdicional = _idIndexador == Guid.Empty ? decimal.Zero : NmTaxaAdicional;
            return _idIndexador;
        }
        private set { _idIndexador = value; }
    }
    public bool BoLiquidado { get; }
    public bool BoIsentoImposto { get; }
    public string TxUsuario { get; } = string.Empty;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public DateTime? DtAtualizacao { get; }

    public bool VerificaSeEhPreFixado() => IdIndexador == Guid.Empty;


    private Guid _idIndexador;
}

using INVESTIMENTO.RENDAFIXA.DOMAIN.Indice.Enum;

namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;

public class Investimento
{
    public Investimento(Guid idInvestidor, string txDocumentoFederal, decimal nmValorInicial, decimal nmTaxarendimento,
        decimal nmTaxaAdicional, DateTime dtInicial, DateTime dtFinal, byte idIndexador, bool boIsentoImposto, string txUsuario)
    {
        IdInvestimento = Guid.NewGuid();
        IdInvestidor = idInvestidor;
        TxDocumentoFederal = txDocumentoFederal;
        NmValorInicial = nmValorInicial;
        NmValorFinal = NmValorInicial;
        NmTaxaRendimento = nmTaxarendimento;
        NmTaxaAdicional = nmTaxaAdicional;
        DtInicial = dtInicial;
        DtFinal = dtFinal;
        IdIndexador = (EnumIndexador)idIndexador;
        BoIsentoImposto = boIsentoImposto;

        TxUsuario = txUsuario;

        Movimentacao = new Movimentacao(this);
    }

    public virtual Movimentacao Movimentacao { get; }

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
    public EnumIndexador IdIndexador
    {
        get
        {
            NmTaxaAdicional = _idIndexador == EnumIndexador.Pre ? decimal.Zero : NmTaxaAdicional;
            return _idIndexador;
        }
        private set { _idIndexador = value; }
    }
    public bool BoLiquidado { get; }
    public bool BoIsentoImposto { get; }
    public string TxUsuario
    {
        get { return string.IsNullOrEmpty(_txUsuario) ? "DN" : _txUsuario; }
        private set { _txUsuario = value; }
    }
    public DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public DateTime? DtAtualizacao { get; }

    public bool VerificaSeEhPreFixado() => IdIndexador == EnumIndexador.Pre;

    private string _txUsuario;
    private EnumIndexador _idIndexador;
}

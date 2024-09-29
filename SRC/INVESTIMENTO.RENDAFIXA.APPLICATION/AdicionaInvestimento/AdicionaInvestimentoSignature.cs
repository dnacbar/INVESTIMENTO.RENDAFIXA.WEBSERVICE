namespace INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;

public class AdicionaInvestimentoSignature
{
    public Guid Investidor { get; set; }
    public string DocumentoFederal { get; set; } = string.Empty;
    public decimal ValorInicial { get; set; }
    public decimal TaxaRendimento { get; set; }
    public decimal TaxaAdicional { get; set; }
    public DateTime DataInicial { get; set; }
    public DateTime DataFinal { get; set; }
    public byte Indexador { get; set; }
    public bool IsentoImposto { get; set; }
    public string Usuario { get; set; } = string.Empty;

    public bool VerificaSePossuiIndexador() => Investidor != Guid.Empty;

    public void Validate() => new AdicionaInvestimentoValidator().Validate(this);
}
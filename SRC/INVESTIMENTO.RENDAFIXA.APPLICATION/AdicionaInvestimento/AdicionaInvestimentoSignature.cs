namespace INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;

public class AdicionaInvestimentoSignature
{
    public Guid Investidor { get; set; }
    public string DocumentoFederal { get; set; } = string.Empty;
    public decimal ValorInicial { get; set; }
    public decimal TaxaRendimento { get; set; }
    public decimal TaxaAdicional { get; set; }
    public Guid Indexador { get; set; }
    public bool IsentoImposto { get; set; }

    public bool VerificaSePossuiIndexador() => Investidor != Guid.Empty;

    public void Validate() => new AdicionaInvestimentoValidator().Validate(this);
}
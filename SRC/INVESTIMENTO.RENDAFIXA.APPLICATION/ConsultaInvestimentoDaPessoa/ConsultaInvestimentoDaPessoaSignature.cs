namespace INVESTIMENTO.RENDAFIXA.APPLICATION.ConsultaInvestimentoDaPessoa;

public class ConsultaInvestimentoDaPessoaSignature
{
    public Guid Investimento { get; set; }
    public Guid Investidor { get; set; }
    public string DocumentoFederal { get; set; } = string.Empty;
}

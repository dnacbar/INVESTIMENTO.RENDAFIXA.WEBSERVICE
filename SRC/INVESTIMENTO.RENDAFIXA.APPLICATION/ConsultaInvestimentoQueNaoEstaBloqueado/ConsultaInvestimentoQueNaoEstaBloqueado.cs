namespace INVESTIMENTO.RENDAFIXA.APPLICATION.ConsultaInvestimentoDaPessoaQueNaoEstaBloqueado;

public class ConsultaInvestimentoQueNaoEstaBloqueado
{
    public Guid Investimento { get; set; }
    public Guid Investidor { get; set; }
    public short Movimentacao { get; set; }
    public string DocumentoFederal { get; set; } = string.Empty;
}
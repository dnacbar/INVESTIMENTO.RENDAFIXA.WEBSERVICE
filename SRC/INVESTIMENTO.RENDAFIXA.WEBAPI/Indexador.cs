namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public class Indexador
{
    public Guid IdIndexador { get; }
    public string TxNome { get; } = null!;
    public string? TxDescricao { get; }
    public decimal NmRendimento { get; }
    public string TxUsuarioCriacao { get; } = null!;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public DateTime? DtAtualizacao { get; }
}
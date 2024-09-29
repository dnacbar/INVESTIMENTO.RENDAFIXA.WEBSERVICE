namespace INVESTIMENTO.RENDAFIXA.DOMAIN;

public partial class Indexador
{
    public byte IdIndexador { get; }
    public string TxNome { get; } = null!;
    public string? TxDescricao { get; }
    public decimal NmRendimento { get; }
    public string TxUsuariocriacao { get; } = null!;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioatualizacao { get; }
    public DateTime? DtAtualizacao { get; }
}

namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Imposto;

public abstract class Imposto
{
    public byte IdImposto { get; }
    public string TxNome { get; } = null!;
    public string TxDescricao { get; } = null!;
    public string TxUsuariocriacao { get; } = null!;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioatualizacao { get; }
    public DateTime? DtAtualizacao { get; }
}
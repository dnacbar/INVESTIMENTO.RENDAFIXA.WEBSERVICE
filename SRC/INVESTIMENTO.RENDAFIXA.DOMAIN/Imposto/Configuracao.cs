namespace INVESTIMENTO.RENDAFIXA.DOMAIN;

public abstract class Configuracao : Imposto.Imposto
{
    public new short IdImposto { get; }
    public byte IdConfiguracaoImposto { get; }
    public decimal NmRendimento { get; }
    public short NmDiasUteis { get; }
    public string TxUsuarioCriacao { get; } = null!;
    public new DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public new DateTime? DtAtualizacao { get; }
}

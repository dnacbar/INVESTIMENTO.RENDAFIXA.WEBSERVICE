namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;

public partial class Resgate
{
    public Guid IdInvestimento { get; }
    public short IdResgate { get; }
    public Guid IdInvestidor { get; }
    public Guid IdProduto { get; }
    public decimal NmValor { get; }
    public decimal NmImposto { get; }
    public DateOnly DtResgate { get; }
    public string TxUsuario { get; } = null!;
    public DateTime DtCriacao { get; }
    public string? TxUsuarioAtualizacao { get; }
    public DateTime? DtAtualizacao { get; }
}

using System;
using System.Collections.Generic;

namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public partial class Movimentacao
{
    public Guid IdInvestimento { get; }

    public short IdMovimentacao { get; }

    public DateOnly DtMovimentacao { get; }

    public decimal NmValorbrutototal { get; }

    public decimal NmValorliquidototal { get; }

    public decimal NmValorbruto { get; }

    public decimal NmValorliquido { get; }

    public string TxUsuario { get; } = null!;

    public DateTime DtCriacao { get; }

    public string? TxUsuarioatualizacao { get; }

    public DateTime? DtAtualizacao { get; }

    public virtual Investimento IdInvestimentoNavigation { get; } = null!;

    public virtual ICollection<Movimentacaoimposto> Movimentacaoimpostos { get; } = new List<Movimentacaoimposto>();
}

using System;
using System.Collections.Generic;

namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public partial class Imposto
{
    public short IdImposto { get; }

    public string TxNome { get; } = null!;

    public string TxDescricao { get; } = null!;

    public string TxUsuariocriacao { get; } = null!;

    public DateTime DtCriacao { get; }

    public string? TxUsuarioatualizacao { get; }

    public DateTime? DtAtualizacao { get; }

    public virtual ICollection<Configuracaoimposto> Configuracaoimpostos { get; } = new List<Configuracaoimposto>();

    public virtual ICollection<Movimentacaoimposto> Movimentacaoimpostos { get; } = new List<Movimentacaoimposto>();
}

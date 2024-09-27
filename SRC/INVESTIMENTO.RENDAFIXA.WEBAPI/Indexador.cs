using System;
using System.Collections.Generic;

namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public partial class Indexador
{
    public Guid IdIndexador { get; }

    public string TxNome { get; } = null!;

    public string? TxDescricao { get; }

    public decimal NmRendimento { get; }

    public string TxUsuariocriacao { get; } = null!;

    public DateTime DtCriacao { get; }

    public string? TxUsuarioatualizacao { get; }

    public DateTime? DtAtualizacao { get; }

    public virtual ICollection<Investimento> Investimentos { get; } = new List<Investimento>();
}

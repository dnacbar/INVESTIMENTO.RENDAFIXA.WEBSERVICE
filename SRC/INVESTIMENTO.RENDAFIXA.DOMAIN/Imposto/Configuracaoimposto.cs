using System;
using System.Collections.Generic;

namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public partial class Configuracaoimposto
{
    public short IdImposto { get; }

    public byte IdConfiguracaoimposto { get; }

    public decimal TxRendimento { get; }

    public short NmDiasuteis { get; }

    public string TxUsuariocriacao { get; } = null!;

    public DateTime DtCriacao { get; }

    public string? TxUsuarioatualizacao { get; }

    public DateTime? DtAtualizacao { get; }

    public virtual Imposto IdImpostoNavigation { get; } = null!;
}

using System;
using System.Collections.Generic;

namespace INVESTIMENTO.RENDAFIXA.TEST.DBRENDAFIXAMODEL;

public partial class Movimentacaoimposto
{
    public Guid IdInvestimento { get; }

    public short IdMovimentacao { get; }

    public short IdImposto { get; }

    public decimal NmValorimposto { get; }

    public virtual Imposto IdImpostoNavigation { get; } = null!;

    public virtual Movimentacao Movimentacao { get; } = null!;
}

using DN.LOG.LIBRARY.MODEL.EXCEPTION;
using INVESTIMENTO.RENDAFIXA.DOMAIN.Imposto.Enum;

namespace INVESTIMENTO.RENDAFIXA.DOMAIN.Financeiro;

public class MovimentacaoImposto
{
    public MovimentacaoImposto(Guid idInvestimento, short idMovimentacao, EnumTipoImposto enumTipoImposto, decimal nmValorImposto)
    {
        IdInvestimento = idInvestimento;
        IdMovimentacao = idMovimentacao;
        IdImposto = enumTipoImposto;
        NmValorImposto = nmValorImposto;
    }

    public MovimentacaoImposto(Guid idInvestimento, short idMovimentacao, short idImposto, decimal nmValorImposto)
    {
        IdInvestimento = idInvestimento;
        IdMovimentacao = idMovimentacao;
        IdImposto = (EnumTipoImposto)idImposto;
        NmValorImposto = nmValorImposto;

        ValidaMovimentacaoImposto();
    }

    public Guid IdInvestimento { get; }
    public short IdMovimentacao { get; }
    public EnumTipoImposto IdImposto { get; }
    public decimal NmValorImposto { get; }

    private void ValidaMovimentacaoImposto()
    {
        if (!VerificaSeValorImpostoEhPositivo())
            throw new BadRequestException($"Valor imposto tem que ser positivo! Valor imposto:[{NmValorImposto}]");
    }

    private bool VerificaSeValorImpostoEhPositivo() => NmValorImposto > decimal.Zero;
}

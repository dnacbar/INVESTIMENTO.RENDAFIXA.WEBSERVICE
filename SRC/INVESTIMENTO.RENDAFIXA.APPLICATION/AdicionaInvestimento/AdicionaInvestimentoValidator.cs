using FluentValidation;

namespace INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;

public class AdicionaInvestimentoValidator : AbstractValidator<AdicionaInvestimentoSignature>
{
    private const int ValorMinimoDeInvestimento = 1000;
    public AdicionaInvestimentoValidator()
    {
        RuleFor(x => x.Investidor).IsInEnum().NotEmpty().WithMessage(x => $"Investidor tem que ser informado! Investidor: [{x.Investidor}]");

        RuleFor(x => x.DocumentoFederal).NotEmpty().WithMessage(x => $"Documento federal tem que ser informado! Documento federal: [{x.DocumentoFederal}]")
            .MinimumLength(11).MaximumLength(14).WithMessage(x => $"Documento federal tem que ser válido! Documento federal: [{x.DocumentoFederal}]");

        RuleFor(x => x.ValorInicial).GreaterThanOrEqualTo(1000).WithMessage(x => $"Valor do investimento tem que maior ou igual a 1000! Valor Inicial: [{x.ValorInicial}]");

        When(x => !x.VerificaSePossuiIndexador(),
        () => RuleFor(x => x.TaxaRendimento).GreaterThan(0).WithMessage(x => $"Taxa de rendimento tem que maior zero! Taxa de rendimento: [{x.TaxaRendimento}]"));
    }
}
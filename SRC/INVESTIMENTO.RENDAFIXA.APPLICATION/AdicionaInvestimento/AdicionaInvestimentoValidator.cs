using FluentValidation;

namespace INVESTIMENTO.RENDAFIXA.APPLICATION.AdicionaInvestimento;

public class AdicionaInvestimentoValidator : AbstractValidator<AdicionaInvestimentoSignature>
{
    public AdicionaInvestimentoValidator()
    {
        RuleFor(x => x.Investidor).NotEmpty().WithMessage(x => $"Investidor tem que ser informado! Investidor: [{x.Investidor}]");

        When(x => x.DocumentoFederal.Length < 14,
            () => RuleFor(x => x.DocumentoFederal).NotEmpty().WithMessage(x => $"Documento federal tem que ser informado! Documento federal: [{x.DocumentoFederal}]")
                                                  .Length(11).WithMessage(x => $"Documento federal tem que ser válido! Documento federal: [{x.DocumentoFederal}]"));

        When(x => x.DocumentoFederal.Length > 11,
        () => RuleFor(x => x.DocumentoFederal).NotEmpty().WithMessage(x => $"Documento federal tem que ser informado! Documento federal: [{x.DocumentoFederal}]")
                                                  .Length(14).WithMessage(x => $"Documento federal tem que ser válido! Documento federal: [{x.DocumentoFederal}]"));

        RuleFor(x => x.DocumentoFederal).Must(x => ulong.TryParse(x, out _)).WithMessage(x => $"Documento federal tem que ser somente números! Documento federal: [{x.DocumentoFederal}]");

        RuleFor(x => x.ValorInicial).GreaterThan(0).WithMessage(x => $"Valor do investimento tem que ser maior do que zero! Valor Inicial: [{x.ValorInicial}]");

        RuleFor(x => x.DataInicial).GreaterThanOrEqualTo(DateTime.Today).WithMessage(x => $"Data inicial tem que ser maior ou igual a data de hoje! Data inicial: [{x.DataInicial}]")
            .LessThan(x => x.DataFinal).WithMessage(x => $"Data inicial tem que ser menor do que a data final! Data inicial: [{x.DataInicial}] Data final: [{x.DataFinal}]");

        RuleFor(x => x.DataFinal).GreaterThan(DateTime.Today).WithMessage(x => $"Data final tem que maior do que a data de hoje! Data final: [{x.DataFinal}]");

        When(x => !x.VerificaSePossuiIndexador(),
        () => RuleFor(x => x.TaxaRendimento).GreaterThan(0).WithMessage(x => $"Taxa de rendimento tem que ser maior do que zero! Taxa de rendimento: [{x.TaxaRendimento}]"));
    }
}
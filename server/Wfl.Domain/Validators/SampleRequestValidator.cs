using FluentValidation;
using Wfl.Domain.Entities.Payloads;

namespace Wfl.Domain.Validators
{
    internal class SampleRequestValidator : AbstractValidator<SampleRequest>
    {
        public SampleRequestValidator()
        {
            RuleFor(x => x.GetHashCode())
                .NotEmpty();
        }
    }
}

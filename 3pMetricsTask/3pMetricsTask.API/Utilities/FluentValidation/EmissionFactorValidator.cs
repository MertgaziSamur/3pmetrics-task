using _3pMetricsTask.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Utilities.FluentValidation
{
    public sealed class EmissionFactorValidator : AbstractValidator<EmissionFactor>
    {
        public EmissionFactorValidator()
        {
            RuleFor(ef => ef.EmissionFactorTitle).NotEmpty().WithMessage("Emisyon faktör alanı boş olamaz");
            RuleFor(ef => ef.EmissionFactorValue).NotEmpty().WithMessage("Emisyon faktörü değeri boş olamaz");
        }
    }
}

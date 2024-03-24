using _3pMetricsTask.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Utilities.FluentValidation
{
    public sealed class EmissionSourcesUnitValidator : AbstractValidator<EmissionSourcesUnit>
    {
        public EmissionSourcesUnitValidator()
        {
            RuleFor(esu => esu.UnitTitle).NotEmpty().WithMessage("Emisyon kaynağı birimi alanı boş geçilemez");
            RuleFor(esu => esu.UnitSymbol).NotEmpty().WithMessage("Emisyon Kaynağı birimi sembolü alanı boş geçilemez");
        }
    }
}

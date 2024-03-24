using _3pMetricsTask.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Utilities.FluentValidation
{
    public sealed class CatalogValidator : AbstractValidator<Catalog>
    {
        public CatalogValidator()
        {
            RuleFor(c=>c.CatalogName).NotEmpty().WithMessage("Katalog adı boş geçilemez.");
            RuleFor(c => c.CatalogName).MinimumLength(3).WithMessage("Katalog adı alanı en az 3 karakter olmalıdır.");
        }
    }
}

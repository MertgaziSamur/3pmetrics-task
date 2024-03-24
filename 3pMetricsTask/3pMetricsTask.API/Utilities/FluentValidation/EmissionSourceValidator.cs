using _3pMetricsTask.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Utilities.FluentValidation
{
    public sealed class EmissionSourceValidator : AbstractValidator<EmissionSource>
    {
        public EmissionSourceValidator()
        {
            RuleFor(es => es.SourceName).NotEmpty().WithMessage("Emisyon kaynağı alanı boş olamaz");
            RuleFor(es => es.SourceIcon).Must(EndsWithPng).WithMessage("Resim formatı .png formatında olmalıdır.");
        }
        private bool EndsWithPng(string input)
        {
            return !string.IsNullOrEmpty(input) && input.EndsWith(".png", StringComparison.OrdinalIgnoreCase);
        }
    }
}

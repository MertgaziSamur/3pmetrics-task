using _3pMetricsTask.Entities.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Utilities.FluentValidation
{
    public sealed class EmissionPointValidator : AbstractValidator<EmissionPoint>
    {
        public EmissionPointValidator()
        {
            RuleFor(ep => ep.EmissionSourcesUnitId).NotEmpty().WithMessage("Emisyon Kaynağı ünit id değeri boş olamaz");
            RuleFor(ep => ep.PointDescription).MinimumLength(10).WithMessage("Emisyon noktası açıklaması minimum 10 karakter olabilir.");
            RuleFor(ep => ep.PointDescription).MaximumLength(500).WithMessage("Emisyon noktası açıklaması maksimum 500 karakter olabilir.");
            RuleFor(ep => ep.PointName).NotEmpty().WithMessage("Emisyon noktası adı boş olamaz");
            RuleFor(ep => ep.PointIcon).Must(EndsWithPng).WithMessage("Resim formatı .png formatında olmalıdır");
        }

        private bool EndsWithPng(string input)
        {
            return !string.IsNullOrEmpty(input) && input.EndsWith(".png", StringComparison.OrdinalIgnoreCase);
        }
    }
}

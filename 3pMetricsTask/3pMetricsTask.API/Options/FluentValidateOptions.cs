﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3pMetricsTask.Services.Options
{
    public class FluentValidateOptions<TOptions>
        : IValidateOptions<TOptions>
        where TOptions : class
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly string? _name;

        public FluentValidateOptions(IServiceProvider serviceProvider, string? name)
        {
            _serviceProvider = serviceProvider;
            _name = name;
        }

        public ValidateOptionsResult Validate(string name, TOptions options)
        {
            if (_name is not null && _name != name)
            {
                return ValidateOptionsResult.Skip;
            }

            ArgumentNullException.ThrowIfNull(options);

            using var scope = _serviceProvider.CreateScope();

            var validator = scope.ServiceProvider.GetRequiredService<IValidator<TOptions>>();

            var result = validator.Validate(options);

            if (result.IsValid)
            {
                return ValidateOptionsResult.Success;
            }

            var type = options.GetType().Name;
            var errors = new List<string>();

            foreach (var error in result.Errors)
            {
                errors.Add($"Validation failed for {type}.{error.PropertyName} with the error: {error.ErrorMessage}");
            }

            return ValidateOptionsResult.Fail(errors);
        }
    }
}

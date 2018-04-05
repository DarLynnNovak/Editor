using App.ACSDependencyResolution;
using FluentValidation.Mvc;
using System.Web.Mvc;

namespace App
{
    public class ValidationConfig
    {
        public static void Config()
        {
            ModelValidatorProviders.Providers.Clear();
            FluentValidationModelValidatorProvider.Configure();
            var fluentProvider = new FluentValidationModelValidatorProvider(new StructureMapValidatorFactory()) { AddImplicitRequiredValidator = false };
            ModelValidatorProviders.Providers.Add(fluentProvider);
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }
    }
}
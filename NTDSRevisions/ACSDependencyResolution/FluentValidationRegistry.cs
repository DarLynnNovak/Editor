using StructureMap;
using StructureMap.Configuration.DSL;

namespace App.ACSDependencyResolution
{
    public class FluentValidationRegistry : Registry
    {
        public FluentValidationRegistry()
        {
            FluentValidation.AssemblyScanner.FindValidatorsInAssembly(System.Reflection.Assembly.GetExecutingAssembly())
                .ForEach(result => For(result.InterfaceType)
                    .Singleton()
                    .Use(result.ValidatorType));
        }
    }
}
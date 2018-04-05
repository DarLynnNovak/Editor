using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Mappers;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Web;


namespace App.ACSDependencyResolution
{
    /// <summary>
    /// Registry class responsible for registering automapper types in the IoC container.
    /// </summary>
    public class AutomapperRegistry : Registry
    {
        public AutomapperRegistry()
        {
            Mapper.AddProfile<MappingProfiles>();
            For<ConfigurationStore>().Singleton().Use<ConfigurationStore>().Ctor<IEnumerable<IObjectMapper>>().Is(MapperRegistry.Mappers);
            For<IConfigurationProvider>().Use(ctx => ctx.GetInstance<ConfigurationStore>());
            For<IConfiguration>().Use(ctx => ctx.GetInstance<ConfigurationStore>());
            For<ITypeMapFactory>().Use<TypeMapFactory>();
            For<IMappingEngine>().Singleton().Use(() => Mapper.Engine);

            Scan(scanner =>
            {
                //first decide which assemblies you want to scan
                scanner.TheCallingAssembly();
                scanner.ConnectImplementationsToTypesClosing(typeof(ITypeConverter<,>)).OnAddedPluginTypes(t => t.HybridHttpOrThreadLocalScoped());
                scanner.ConnectImplementationsToTypesClosing(typeof(ValueResolver<,>)).OnAddedPluginTypes(t => t.HybridHttpOrThreadLocalScoped());
            });
        }
    }
}
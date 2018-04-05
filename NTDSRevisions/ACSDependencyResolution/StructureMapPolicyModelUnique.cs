using System;
using StructureMap;
using StructureMap.Pipeline;

namespace App.ACSDependencyResolution
{
    public class StructureMapPolicyModelUnique : IInstancePolicy
    {
        public void Apply(Type pluginType, Instance instance)
        {
            if (pluginType.Namespace != null && pluginType.Namespace.Contains(".Models."))
            {
                instance.SetLifecycleTo<UniquePerRequestLifecycle>();
            }
        }
    }
}
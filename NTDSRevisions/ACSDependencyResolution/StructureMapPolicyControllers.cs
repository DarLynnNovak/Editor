using System;
using System.Web.Mvc;
using StructureMap;
using StructureMap.Pipeline;
using StructureMap.TypeRules;

namespace App.ACSDependencyResolution
{
    public class StructureMapPolicyControllers : IInstancePolicy
    {
        public void Apply(Type pluginType, Instance instance)
        {
            if (pluginType.CanBeCastTo<Controller>() && !pluginType.IsAbstract)
            {
                instance.SetLifecycleTo<UniquePerRequestLifecycle>();
            }
        }
    }
}
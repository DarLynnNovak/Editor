// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IoC.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using AcsCore;
using AcsCore.Logging;
using App.ACSDependencyResolution;
using App.Infrastructure;
using StructureMap;

namespace App.DependencyResolution
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            var container = new Container(c => c.AddRegistry<DefaultRegistry>());
            container.Configure(x =>
            {
                x.AddRegistry<AutomapperRegistry>();
                x.AddRegistry(new FluentValidationRegistry());
                x.For<ILogger>().Use<ElmahLogger>();
                x.For<ISessionVariables>()
                    .Use<SessionVariables>()
                    .SelectConstructor(() => SessionVariablesFactory.GetSessionVariables());
                x.Policies.Add(new StructureMapPolicyControllers());
                x.Policies.Add(new StructureMapPolicyModelUnique());
            });

            //container.AssertConfigurationIsValid();
            return container;

        }
    }
}
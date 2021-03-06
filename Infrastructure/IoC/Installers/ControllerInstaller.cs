﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace Yara.Blog.Infrastructure.IoC.Installers
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromAssemblyNamed("Yara.Blog.Web.FrontEnd")
                                       .Where(t => t.Namespace != null && t.Namespace.EndsWith("Controllers"))
                                       .Configure(c => c.LifestyleTransient())
                                       .WithService.Self());

            container.Register(AllTypes.FromAssemblyNamed("Yara.Blog.Web.Administration")
                                           .Where(t => t.Namespace != null && t.Namespace.EndsWith("Controllers"))
                                           .Configure(c => c.LifestyleTransient())
                                           .WithService.Self());
        }
    }
}

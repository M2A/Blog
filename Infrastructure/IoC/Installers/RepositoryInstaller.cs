using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yara.Blog.Domain;
using System.Data.Entity;

namespace Yara.Blog.Infrastructure.IoC.Installers
{
    public class RepositoryInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container,IConfigurationStore store)
        {
            container.Register(Component.For<DbContext>().ImplementedBy<BlogDBEntities>().LifeStyle.PerWebRequest);
        }
    }
}

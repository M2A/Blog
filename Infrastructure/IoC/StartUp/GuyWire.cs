using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Yara.Blog.Infrastructure.IoC.StartUp
{
    class GuyWire
    {
        private IWindsorContainer _container;

        public GuyWire()
            :this(CreateContainer())
        {

        }

        public GuyWire(IWindsorContainer container)
        {
            _container = container;
        }

        private static IWindsorContainer CreateContainer() 
        {
            return new WindsorContainer();
        }

        public void Wire()
        {
            _container.Install(FromAssembly.Named("Yara.Blog.Infrastructure"));
        }
        public void RegisterRoot() 
        {
        
        }
    }
}

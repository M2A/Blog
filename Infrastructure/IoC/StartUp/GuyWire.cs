using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System.Web.Mvc;
using Yara.Blog.Infrastructure.IoC.Installers;

namespace Yara.Blog.Infrastructure.IoC.StartUp
{
    public class GuyWire
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
            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory(_container));
        }

        public void DeWire() 
        {
            if (_container != null)
            {
                _container.Dispose();
            }
            _container = null;
        }
    }
}

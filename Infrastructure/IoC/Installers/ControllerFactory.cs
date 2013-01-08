using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Yara.Blog.Infrastructure.IoC.Installers
{
    class ControllerFactory : DefaultControllerFactory
    {
        private IWindsorContainer _container;

        public ControllerFactory(IWindsorContainer container)
        {
            _container = container;
        }
    }
}

using Castle.Windsor;
using System;
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

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {

            if (controllerType == null || !typeof(IController).IsAssignableFrom(controllerType))
            {
                requestContext.HttpContext.Response.Redirect("~/error?message=The page you are looking for not found.", true);
            }
            return (IController)_container.Resolve(controllerType);
        }

        public override void ReleaseController(IController controller)
        {
            _container.Release(controller);
        }
    }
}

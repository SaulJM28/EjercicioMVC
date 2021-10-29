using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc4;
using EjercicioMVC.Controllers;
using EjercioMVC.BAL;
using EjercicioMVC.DAL;

namespace EjercicioMVC
{
    public static class Bootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductosBo, ProductosBo>();
            container.RegisterType<IProductosDao, ProductosDao>();
            container.RegisterType<IController, HomeController>("Home");

            return container;
        }

        //private static IUnityContainer BuildUnityContainer()
        //{
        //    var container = new UnityContainer();

        //    // register all your components with the container here
        //    // it is NOT necessary to register your controllers

        //    // e.g. container.RegisterType<ITestService, TestService>();    
        //    RegisterTypes(container);

        //    return container;
        //}

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
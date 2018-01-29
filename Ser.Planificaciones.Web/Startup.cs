using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using Ser.Planificaciones.Web.App_Start;
using System.Web.Optimization;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Ser.Planificaciones.Web.Startup))]
namespace Ser.Planificaciones.Web
{
    public partial class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
        }
    }
}
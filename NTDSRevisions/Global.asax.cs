using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AcsCore.Filters;
using AcsCore.ModelBinders;

namespace App
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            AntiforgeryTokens.Configure();
            DataConfig.ConfigureData();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());
            ValidationConfig.Config();
            ValueProviderFactories.Factories.Add(new CookieValueProviderFactory());
            ValueProviderFactories.Factories.Add(new SessionValueProviderFactory());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ModelBinders.Binders.DefaultBinder = new ACSModelBinder();

        }
    }
}

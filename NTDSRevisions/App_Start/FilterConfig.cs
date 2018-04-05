using App.Infrastructure.Filters;
using System.Web.Mvc;
using AcsCore.Filters;

namespace App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new SessionVariablesActionFilter());
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AcsAuthorizationFilter());
            filters.Add(new RequireAntiForgeryTokenOnPostFilter());
        }
    }
}
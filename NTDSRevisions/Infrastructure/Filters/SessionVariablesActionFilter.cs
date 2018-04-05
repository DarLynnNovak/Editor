using System.Web.Mvc;
using ActionFilterAttribute = System.Web.Http.Filters.ActionFilterAttribute;

namespace App.Infrastructure.Filters
{
    public class SessionVariablesActionFilter : ActionFilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var context = filterContext.HttpContext;
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.LoadVariables(context);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var context = filterContext.HttpContext;
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.SaveVariables(context);
        }
    }
}
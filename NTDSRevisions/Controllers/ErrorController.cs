using AcsCore.Filters;
using App.Infrastructure;
using Elmah;
using System.Web.Mvc;

namespace App.Controllers
{
    public partial class ErrorController : Controller
    {
        [BypassAntiForgeryToken]
        public void LogJavaScriptError(string message)
        {
            ErrorSignal
                .FromCurrentContext()
                .Raise(new JavaScriptException(message));
        }
    }
}
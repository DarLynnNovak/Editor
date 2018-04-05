using System.Web.Helpers;

namespace App
{
    public static class AntiforgeryTokens
    {
        public static void Configure()
        {
            AntiForgeryConfig.CookieName = "a";
        }
    }
}
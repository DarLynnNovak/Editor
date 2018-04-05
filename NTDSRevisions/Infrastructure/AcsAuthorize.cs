using System;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;

namespace App.Infrastructure
{
    /// <summary>
    /// Sets and checks the roles current user has in system
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AcsAuthorize : AuthorizeAttribute
    {
        public new UserType Roles { get; set; }

        //private static readonly RepositoryReviewer LRepositoryReviewer = new RepositoryReviewer();
        [Serializable]
        [Flags]
        public enum UserType
        {
            Acs,
            Committee
        };

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw (new ArgumentNullException("httpContext"));
            }
            IPrincipal user = httpContext.User;
            if (!user.Identity.IsAuthenticated)
            {
                return false;
            }
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            UserRoles lRoles = sessionVariables.UserRoles;
            if (lRoles == null)
            {
                return false;
            }
            bool lResult = false;
            foreach (UserType item in lRoles.CurrentRoles)
            {
                if (item == Roles)
                {
                    lResult = true;
                }
            }
            return lResult;
        }

        public static UserRoles GetRoles()
        {
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            UserRoles lRoles = sessionVariables.UserRoles;
            return lRoles;
        }
    }
}
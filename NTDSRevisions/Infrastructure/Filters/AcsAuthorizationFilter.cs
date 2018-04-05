using AcsCore.WebService;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace App.Infrastructure.Filters
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AcsAuthorizationFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContextBase context = filterContext.HttpContext;
            RouteValueDictionary lRoute = default(RouteValueDictionary);
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.LoadVariables(context);
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            //
            // If not a valid token then log them out (in case they were logged in)
            //
            if (!IsAuthenticated(filterContext.HttpContext))
            {
                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.SignOut();
                    RemoveCookies(filterContext);
                    Logout(filterContext);
                }
            }
            //
            // If the token is different than the current user then log them out
            //
            string token = SsoUtility.GetToken(filterContext.HttpContext);
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (token != filterContext.HttpContext.User.Identity.Name)
                {
                    FormsAuthentication.SignOut();
                    Logout(filterContext);
                }
            }
            //
            // If not one is signed on then log them on if a valid token
            //
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                if (SsoUtility.IsTokenValid(token))
                {
                    FormsAuthentication.SetAuthCookie(token, false);
                    var identity = new GenericIdentity(token);
                    var principal = new GenericPrincipal(identity, null);
                    filterContext.HttpContext.User = principal;
                    Login(filterContext, token);
                }
            }
            bool allowAnonymous = (filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true) || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true));

            if (allowAnonymous)
            {
                return;
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result = new RedirectResult(SsoUtility.GetSsoUrl(filterContext.HttpContext));
            }

            else
            {
                bool lAllowed = false;
                UserRoles lRoles = sessionVariables.UserRoles;
                if (lRoles == null)
                {
                    filterContext.Result = new HttpUnauthorizedResult();
                    return;
                }
                //TODO Add check for role
                lAllowed = true;
                if (!lAllowed)
                {
                    lRoute = new RouteValueDictionary { { "Area", "" }, { "Controller", "Home" }, { "Action", "Unauthorized" } };
                    filterContext.Result = new RedirectToRouteResult(lRoute);
                }
            }
        }

        private static void ClearSessionData(AuthorizationContext filterContext)
        {
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.Clear(filterContext.HttpContext);
        }

        private static bool DateGreaterToday(DateTime? dateToCheck)
        {
            var datevalue = dateToCheck.GetValueOrDefault();
            bool lResult = datevalue.Date.Year < 1901 || datevalue.Date >= DateTime.Now;
            return lResult;
        }

        private static bool DateLessToday(DateTime dateToCheck)
        {
            bool lResult = dateToCheck <= DateTime.Now;
            if (dateToCheck.Year < 1901)
            {
                lResult = true;
            }
            return lResult;
        }

        private static void Login(AuthorizationContext filterContext, string token)
        {
            PersonWebServiceModel personWebServiceModel = SsoUtility.GetPerson(filterContext.HttpContext);
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.PersonId = personWebServiceModel.AcsFullId;
            sessionVariables.PersonName = personWebServiceModel.AcsMailName;
            SetRoles(personWebServiceModel.AcsFullId);
            sessionVariables.SaveVariables(filterContext.HttpContext);
        }

        private static void Logout(AuthorizationContext filterContext)
        {
            ClearSessionData(filterContext);
        }
        /// <summary>
        /// Removes cookies containing SSO token. This is necessary in case a user is logged in to test and production at the same time.
        /// </summary>
        /// <param name="filterContext"></param>
        private static void RemoveCookies(AuthorizationContext filterContext)
        {
            var cookie1 = filterContext.HttpContext.Request.Cookies["ACS_WebUser_AuthGUID"];
            var cookie2 = filterContext.HttpContext.Request.Cookies["ACS_WebUser_i_AuthGUID"];

            if (cookie1 != null)
            {
                cookie1.Domain = ".facs.org";
                cookie1.Expires = DateTime.Now.AddDays(-1d);
                filterContext.HttpContext.Response.Cookies.Set(cookie1);
            }

            if (cookie2 != null)
            {
                cookie2.Domain = ".facs.org";
                cookie2.Expires = DateTime.Now.AddDays(-1d);
                filterContext.HttpContext.Response.Cookies.Set(cookie2);
            }
        }

        private static void SetRoles(int personid)
        {
            //TODO
            UserRoles userRoles = new UserRoles();
            userRoles.CurrentRoles.Add(AcsAuthorize.UserType.Acs);
            ISessionVariables sessionVariables = (ISessionVariables)DependencyResolver.Current.GetService(typeof(ISessionVariables));
            sessionVariables.UserRoles = userRoles;
        }

        private bool IsAuthenticated(HttpContextBase httpContext)
        {
            string token = SsoUtility.GetToken(httpContext);
            return SsoUtility.IsTokenValid(token);
        }

    }
}
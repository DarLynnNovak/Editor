using App.ViewModels.Account;
using System;
using System.Web.Configuration;
using System.Web.Mvc;

namespace App.Controllers
{
    public partial class AccountController : Controller
    {
        public virtual ActionResult LogOut(LogOutViewModel formData)
        {
            formData.Load();
            string redirect = String.Format("{0}?Logout=1&ReturnToPage={1}", WebConfigurationManager.AppSettings["SsoUrl"], formData.LogOffReturnTOUrl);
            return Redirect(redirect);
        }

        public virtual ActionResult SendToNtdsPage()
        {
            string redirect = String.Format(WebConfigurationManager.AppSettings["LoadNtdsPage"]);
            return Redirect(redirect);
        }
    }
}
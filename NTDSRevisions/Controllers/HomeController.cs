using System.Web.Configuration;
using App.Infrastructure.Filters;
using System.Web.Mvc;
using AcsAptify;
using App.ViewModels.Home;

namespace App.Controllers
{
    [Authorize]
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index(UserIndexViewModel formData)
        {
            formData.Load();
            if (!formData.NewUser)
            {
                return RedirectToAction("Index", "PersonSuggestion");
            }
            return RedirectToAction("UserInfoEdit");
        }

        [AllowAnonymous]
        public virtual ActionResult LandingPage(IndexViewModel formData)
        {
            formData.Load();
            return View(formData.ViewName, formData);
        }

        public virtual ActionResult GoToRedirect(IndexViewModel formData)
        {
            string userUrl = string.Empty;
            //userUrl = WebConfigurationManager.AppSettings["SsoNewUserUrl"];
            
            return Redirect(WebConfigurationManager.AppSettings["SsoNewUserUrl"]);
        }
        
        [HttpGet]
        public virtual ActionResult UserInfoEdit(UserInfoEditViewModel formData)
        {
            formData.Load();
            return View(formData.ViewName, formData);
        }

        [HttpPost]
        public virtual ActionResult UserInfoSave(UserInfoEditViewModel formData)
        {
            bool lWasSaved = true;
            if (ModelState.IsValid)
            {
                formData.Save();
                foreach (SaveResults item in formData.SaveResults)
                {
                    if (item.WasSaved == false)
                    {
                        ModelState.AddModelError("", item.Message);
                        lWasSaved = false;
                    }
                }
            }
            else
            {
                lWasSaved = false;
            }
            if (lWasSaved == false)
            {
                formData.Load();
                return View(formData.ViewName, formData);
            }

            formData.UserInfoData = null;
            ModelState.Clear();
            ModelState.AddModelError("", "Your changes have been saved.");
            return RedirectToAction("Index", "PersonSuggestion");
        }

    }

}
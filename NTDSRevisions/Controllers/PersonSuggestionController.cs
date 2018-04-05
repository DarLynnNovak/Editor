using System.Web.Mvc;
using AcsAptify;
using App.ViewModels.PersonSuggestion;

namespace App.Controllers
{
    public partial class PersonSuggestionController : Controller
    {
        // GET: PersonSuggestion
        public virtual ActionResult Index(IndexViewModel formData)
        {
            formData.Load();
            return View(formData.ViewName, formData);
        }

        [HttpPost]
        public virtual ActionResult SuggestionNew(SuggestionNewViewModel formData)
        {
            formData.Load();
            return View(formData.ViewName, formData);
        }
        [HttpPost]
        public virtual ActionResult SuggestionNewSave(SuggestionNewViewModel formData)
        {
            bool lWasSaved = true;
            formData.Load();
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
                return View(formData.ViewName, formData);
            }
            formData.PersonSuggestionModels = null;
            ModelState.Clear();
            return RedirectToAction("Index");
        }

        public virtual ActionResult SuggestionEdit(SuggestionEditViewModel formData)
        {
            formData.Load();
            return View(formData.ViewName, formData);
        }

        [HttpPost]
        public virtual ActionResult SuggestionEditSave(SuggestionEditViewModel formData)
        {
            bool lWasSaved = true;
            formData.Load();
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
                return View(formData.ViewName, formData);
            }
            formData.PersonSuggestionModels = null;
            ModelState.Clear();
            return RedirectToAction("Index");
        }



        public virtual ActionResult SuggestionDelete(SuggestionDeleteViewModel formData)
        {
            formData.Load();
            formData.Save();
            return RedirectToAction("Index");
        }



    }
}

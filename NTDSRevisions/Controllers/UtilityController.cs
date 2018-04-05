using System.Collections.Generic;
using System.Web.Mvc;
using App.Infrastructure;

namespace App.Controllers
{
    public partial class UtilityController : Controller
    {
        [AllowAnonymous]
        public virtual JsonResult GetChapters(string versionId)
        {
            IEnumerable<SelectListItem> chapterList;
            var versionisnumeric = false;
            var getversion = 0;
            versionisnumeric = int.TryParse(versionId, out getversion);
            chapterList = LookupTableChoices.GetChaptersChoices(getversion);
            return Json(chapterList, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public virtual JsonResult GetFields(string chapterId)
        {
            IEnumerable<SelectListItem> fieldList;
            var chapterisnumeric = false;
            var getchapter = 0;
            chapterisnumeric = int.TryParse(chapterId, out getchapter);
            fieldList = LookupTableChoices.GetFieldChoices(getchapter);
            return Json(fieldList, JsonRequestBehavior.AllowGet);
        }

    }
}
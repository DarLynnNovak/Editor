using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper.Internal;
using DataRepository;

namespace App.Infrastructure
{
    public class LookupTableChoices
    {
        public static IEnumerable<SelectListItem> GetChaptersChoices(int versionId)
        {
            IList<SelectListItem> lResults = null;
            IRepositoryChapter respositoryChapter = (IRepositoryChapter)DependencyResolver.Current.GetService(typeof(IRepositoryChapter));
            lResults = (from x in respositoryChapter.GetByVersionId(versionId) select new SelectListItem { Value = x.ID.ToString(), Text = x.ChapterName }).ToList();
            lResults.Insert(0, new SelectListItem { Value = "0", Text = "- Select Chapter -" });
            return lResults.AsEnumerable();
        }

        public static IEnumerable<SelectListItem> GetFieldChoices(int chapterId)
        {
            IList<SelectListItem> lResults = null;
            IRepositoryField repositoryField = (IRepositoryField) DependencyResolver.Current.GetService(typeof (IRepositoryField));
            lResults = (from x in repositoryField.GetByChapterId(chapterId) select new SelectListItem {Value = x.ID.ToString(), Text = x.Name}).ToList();
            lResults.Insert(0, new SelectListItem {Value = "0", Text = "- Select Data Field -"});
            return lResults.AsEnumerable();
        }

    }
}
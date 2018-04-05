using System.Linq;
using Data;

namespace DataRepository
{
    static class RepositoryChapterExtensions
    {
        public static IQueryable<vwACSNtdsChapter> WithId(this IQueryable<vwACSNtdsChapter> qry, int id)
        {
            return qry.Where(x => x.ID == id);
        }

        public static IQueryable<vwACSNtdsChapter> WithVersionId(this IQueryable<vwACSNtdsChapter> qry, int versionid)
        {
            return qry.Where(x => x.NtdsVersionId == versionid).OrderBy(x => x.ChapterNumber);
        }

        public static IQueryable<vwACSNtdsChapter> WithChapterId(this IQueryable<vwACSNtdsChapter> qry, int id)
        {
            return qry.Where(x => x.ID == id);
        }
    }
}

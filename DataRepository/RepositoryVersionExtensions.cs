using System.Linq;
using Data;

namespace DataRepository
{
    static class RepositoryVersionExtensions
    {
        public static IQueryable<vwACSNtdsVersion> WithAcceptEdits(this IQueryable<vwACSNtdsVersion> qry)
        {
            return qry.Where(x => x.AcceptsEdits);
        }
    }
}

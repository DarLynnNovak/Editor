using System;
using System.Linq;
using Data;

namespace DataRepository
{
    static class RepositoryProgramExtensions
    {
        public static IQueryable<vwACSNtdsProgram> WithId(this IQueryable<vwACSNtdsProgram> qry, int id)
        {
            return qry.Where(x => x.ID == id);
        }

        public static IQueryable<vwACSNtdsProgram> WithActive(this IQueryable<vwACSNtdsProgram> qry)
        {
            return qry.Where(x => x.StartDate <= DateTime.Now && x.EndDate > DateTime.Now);
        }

    }
}

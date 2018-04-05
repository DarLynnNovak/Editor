using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataRepository
{
    static class RepositoryFieldExtensions
    {
        public static IQueryable<vwACSNtdsField> WithId(this IQueryable<vwACSNtdsField> qry, int id)
        {
            return qry.Where(x => x.NtdsChapterId == id).OrderBy(x => x.NtdsFieldSequence);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;


namespace DataRepository
{
    static class RepositoryUserInfoExtensions
    {
        public static IQueryable<vwACSNtdsUserInfo> WithPersonId(this IQueryable<vwACSNtdsUserInfo> qry, int personId)
        {
            return qry.Where(x => x.PersonId == personId);
        }
    }
}

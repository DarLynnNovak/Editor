using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataRepository
{
    static class RepositoryPersonSuggestionExtensions
    {
        //public static IQueryable<vwACSNtdsPersonSuggestions> WithPersonId(
        //    this IQueryable<vwACSNtdsPersonSuggestions> qry, int personId)
        //{
        //    return qry.Where(x => x.PersonId == personId);
        //}

        public static IQueryable<vwACSNtdsPersonSuggestions> WithPersonId(this IQueryable<vwACSNtdsPersonSuggestions> qry, int personId)
        {
            return qry.Where(x => x.PersonId == personId);
        }

        public static IQueryable<vwACSNtdsPersonSuggestions> WithId(this IQueryable<vwACSNtdsPersonSuggestions> qry, int id)
        {
            return qry.Where(x => x.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace DataRepository
{
    static class RepositorySuggestionExtensions
    {

        public static IQueryable<vwACSNtdsSuggestion> WithPersonId(this IQueryable<vwACSNtdsSuggestion> qry, int personId)
        {
            return qry.Where(x => x.PersonId == personId);
        }

        public static IQueryable<vwACSNtdsSuggestion> WithId(this IQueryable<vwACSNtdsSuggestion> qry, int id)
        {
            return qry.Where(x => x.ID == id);
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositorySuggestion
    {
        IList<vwACSNtdsSuggestion> GetByPersonId(int personId);
        IList<vwACSNtdsSuggestion> GetById(int id);
    }

    public class RepositorySuggestion : IRepositorySuggestion
    {
        private readonly APTIFYEntities _dataContext;

        public RepositorySuggestion(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<vwACSNtdsSuggestion> GetByPersonId(int personId)
        {
            return _dataContext.vwACSNtdsSuggestion
                .AsNoTracking()
                .WithPersonId(personId)
                .ToList();
        }

        public IList<vwACSNtdsSuggestion> GetById(int id)
        {
            return _dataContext.vwACSNtdsSuggestion
                .AsNoTracking()
                .WithId(id)
                .ToList();
        }
    }
}
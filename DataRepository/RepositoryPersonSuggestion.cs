using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositoryPersonSuggestion
    {
        IList<vwACSNtdsPersonSuggestions> GetByPersonId(int personId);
        IList<vwACSNtdsPersonSuggestions> GetById(int id);
    }

    public class RepositoryPersonSuggestion : IRepositoryPersonSuggestion
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryPersonSuggestion(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<vwACSNtdsPersonSuggestions> GetByPersonId(int personId)
        {
            return _dataContext.vwACSNtdsPersonSuggestions
                .AsNoTracking()
                .WithPersonId(personId)
                .OrderByDescending(x => x.DateCreated)
                .ToList();
        }

        public IList<vwACSNtdsPersonSuggestions> GetById(int id)
        {
            return _dataContext.vwACSNtdsPersonSuggestions
                .AsNoTracking()
                .WithId(id)
                .ToList();
        } 
    }
}
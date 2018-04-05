using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositoryVersion
    {
        IList<vwACSNtdsVersion> getByAcceptsEdits();

    }
    public class RepositoryVersion : IRepositoryVersion
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryVersion(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<vwACSNtdsVersion> getByAcceptsEdits()
        {
            return _dataContext.vwACSNtdsVersion
                .AsNoTracking()
                .WithAcceptEdits()
                .ToList();
        }
    }
}

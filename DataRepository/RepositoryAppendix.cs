using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositoryAppendix
    {
        IList<vwACSNtdsFieldType> GetAll();
    }
    public class RepositoryAppendix : IRepositoryAppendix
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryAppendix(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<vwACSNtdsFieldType> GetAll()
        {
            return _dataContext.vwACSNtdsFieldType
                .AsNoTracking()
                .OrderBy(x => x.ID)
                .ToList();
        }

    }
}

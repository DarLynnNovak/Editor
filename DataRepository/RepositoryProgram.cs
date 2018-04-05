using System.Collections.Generic;
using Data;
using System.Linq;

namespace DataRepository
{
    public interface IRepositoryProgram
    {
        vwACSNtdsProgram GetById(int id);
        vwACSNtdsProgram GetCurrentActive();
    }

    public class RepositoryProgram : IRepositoryProgram
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryProgram(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public vwACSNtdsProgram GetById(int id)
        {
            return _dataContext.vwACSNtdsProgram
                .AsNoTracking()
                .WithId(id)
                .FirstOrDefault();
        }

        public vwACSNtdsProgram GetCurrentActive()
        {
            return _dataContext.vwACSNtdsProgram
                .AsNoTracking()
                .WithActive()
                .FirstOrDefault();
        }
    }
}
using System;
using System.Collections.Generic;
using Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public interface IRepositoryField
    {
        IList<vwACSNtdsField> GetAll();
        IList<vwACSNtdsField> GetByChapterId(int chapterId);
    }
    public class RepositoryField : IRepositoryField
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryField(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public IList<vwACSNtdsField> GetAll()
        {
            return _dataContext.vwACSNtdsField
                .AsNoTracking()
                .ToList();
        }

        public IList<vwACSNtdsField> GetByChapterId(int chapterId)
        {
            return _dataContext.vwACSNtdsField
                .AsNoTracking()
                .WithId(chapterId)
                .ToList();
        }
    }
}

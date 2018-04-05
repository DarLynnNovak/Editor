using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositoryChapter
    {
        IList<vwACSNtdsChapter> GetAll();
        IList<vwACSNtdsChapter> GetById(int id);
        IList<vwACSNtdsChapter> GetByVersionId(int versionid);
        vwACSNtdsChapter GetByCurrentId(int Id);
        IList<vwACSNtdsChapter> GetByChapterId(int id);

    }
    public class RepositoryChapter : IRepositoryChapter
    {
        private readonly APTIFYEntities _dataContext;

        public RepositoryChapter(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }

       public IList<vwACSNtdsChapter> GetAll()
        {
            return _dataContext.vwACSNtdsChapter
                .AsNoTracking()
                .ToList();
        }

        public IList<vwACSNtdsChapter> GetById(int id)
        {
            return _dataContext.vwACSNtdsChapter
                .AsNoTracking()
                .WithId(id)
                .ToList();
        }

        public IList<vwACSNtdsChapter> GetByVersionId(int versionid)
        {
            return _dataContext.vwACSNtdsChapter
                .WithVersionId(versionid)
                .ToList();
        }

        public vwACSNtdsChapter GetByCurrentId(int id)
        {
            return _dataContext.vwACSNtdsChapter
                .AsNoTracking()
                .WithId(id)
                .FirstOrDefault();
        }

        public IList<vwACSNtdsChapter> GetByChapterId(int id)
        {
            return _dataContext.vwACSNtdsChapter
                .AsNoTracking()
                .WithChapterId(id)
                .ToList();
        }
    }
}

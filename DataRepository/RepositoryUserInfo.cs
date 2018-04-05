using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace DataRepository
{
    public interface IRepositoryUserInfo
    {
        vwACSNtdsUserInfo GetByPersonId(int personId);
    }

    public class RepositoryUserInfo : IRepositoryUserInfo
    {
         private readonly APTIFYEntities _dataContext;

         public RepositoryUserInfo(APTIFYEntities dataContext)
        {
            _dataContext = dataContext;
        }
         public vwACSNtdsUserInfo GetByPersonId(int personId)
         {
             return _dataContext.vwACSNtdsUserInfo
                 .AsNoTracking()
                 .WithPersonId(personId)
                 .FirstOrDefault();
         }
    }
}

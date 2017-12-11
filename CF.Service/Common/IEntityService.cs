using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Service.Common
{
    public interface IEntityService<T> : IService
     where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();      
        void Update(T entity);
    }
}

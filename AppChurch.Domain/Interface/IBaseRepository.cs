using AppChurch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseModel
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        IList<TEntity> GetAll();
        TEntity Get(Guid id);
    }
}

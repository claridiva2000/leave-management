using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindByID(int id);
        T Create(T entity);
        T Update(T entity);
        T Delete(T entity);
        bool Save();
    }
}

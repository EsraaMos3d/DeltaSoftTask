using System;
using System.Collections.Generic;
using System.Text;

namespace DeltaSoftTask.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
               
    }
}

using System.Collections.Generic;

namespace EStoreApp.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Update(T entity);
        int Insert(T entity);
        void DeleteById(int id);
    }
}

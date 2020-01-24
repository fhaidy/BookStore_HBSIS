using Bookstore.Domain.Entities;
using System.Collections.Generic;

namespace Bookstore.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Insert(T obj);

        T Update(T obj);

        T Delete(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}

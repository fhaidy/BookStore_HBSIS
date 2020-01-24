using Bookstore.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Bookstore.Domain.Interfaces
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T Post(T obj);

        T Put(T obj);
        T Delete(int id);

        T Get(int id);

        IEnumerable<T> Get();
    }
}

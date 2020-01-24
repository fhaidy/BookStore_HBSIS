using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;
using System.Collections.Generic;

namespace Bookstore.Service.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;
        public BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }
        public T Delete(int id)
        {
            return _repository.Delete(id);
        }

        public T Get(int id)
        {
            return _repository.Select(id);
        }

        public IEnumerable<T> Get()
        {
            return _repository.SelectAll();
        }

        public T Post(T obj)
        {
            return _repository.Insert(obj);
        }

        public T Put(T obj)
        {
            return _repository.Update(obj);
        }
    }
}

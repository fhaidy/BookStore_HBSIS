using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;

namespace Bookstore.Service.Service
{
    public class AuthorService : BaseService<Author>, IAuthorService
    {
        public AuthorService(IAuthorRepository rep) :base(rep)
        {

        }
    }
}

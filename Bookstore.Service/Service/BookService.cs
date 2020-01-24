using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;

namespace Bookstore.Service.Service
{
    public class BookService : BaseService<Book>, IBookService
    {
        public BookService(IBookRepository rep) :base(rep)
        {

        }
    }
}

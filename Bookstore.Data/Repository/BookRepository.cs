using Bookstore.Data.Context;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;

namespace Bookstore.Data.Repository
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(SqlContext context) :base(context) {}
    }
}

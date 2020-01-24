using System.Collections.Generic;

namespace Bookstore.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public IList<BookGenre> Genres { get; set; }
        public IList<BookAuthor> Authors { get; set; }
    }
}

using System.Collections.Generic;

namespace Bookstore.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public IList<BookAuthor> Books { get; set; }
    }
}

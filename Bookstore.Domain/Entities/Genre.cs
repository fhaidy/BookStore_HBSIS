using System.Collections.Generic;

namespace Bookstore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public IList<BookGenre> Books { get; set; }
    }
}

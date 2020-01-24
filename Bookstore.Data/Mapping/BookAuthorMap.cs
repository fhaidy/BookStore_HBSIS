using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Mapping
{
    class BookAuthorMap
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            builder.HasKey(ba => new { ba.AuthorId, ba.BookId });
            builder.HasOne<Book>(ba => ba.Book)
                .WithMany(b => b.Authors);
            builder.HasOne<Author>(ba => ba.Author)
                .WithMany(b => b.Books);
        }
    }
}

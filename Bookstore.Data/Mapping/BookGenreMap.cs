using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Mapping
{
    class BookGenreMap
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.ToTable("BookGenre");
            builder.HasKey(bookGenre => new { bookGenre.BookId, bookGenre.GenreId });
            builder.HasOne(bg => bg.Book)
                .WithMany(b => b.Genres);
            builder.HasOne(bg => bg.Genre)
                .WithMany(b => b.Books);
        }

    }
}

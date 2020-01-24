using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Mapping
{
    class BookMap
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
			builder.ToTable("Book");
			builder.HasKey(book => book.Id);
			builder.Property(book => book.Title)
				.IsRequired()
                .HasColumnType("varchar(120)");
		}
    }
}

using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Mapping
{
    class AuthorMap
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
			builder.ToTable("Author");
			builder.HasKey(author => author.Id);
			builder.Property(author => author.Name)
				.IsRequired()
                .HasColumnType("varchar(120)");
		}
    }
}

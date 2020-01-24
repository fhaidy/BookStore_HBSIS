using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookstore.Data.Mapping
{
    class GenreMap
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
			builder.ToTable("Genre");
			builder.HasKey(genre => genre.Id);
			builder.Property(genre => genre.Name)
				.IsRequired()
                .HasColumnType("varchar(60)");
        }
    }
}

using Bookstore.Data.Mapping;
using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Data.Context
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookAuthor> BookAuthor { get; set; }
        public DbSet<BookGenre> BookGenre { get; set; }
        public DbSet<Genre> Genre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=localhost,11433;Database=BookStore;Uid=sa;Pwd=DockerSql2017!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(new BookMap().Configure);
            modelBuilder.Entity<Author>(new AuthorMap().Configure);
            modelBuilder.Entity<Genre>(new GenreMap().Configure);
            modelBuilder.Entity<BookAuthor>(new BookAuthorMap().Configure);
            modelBuilder.Entity<BookGenre>(new BookGenreMap().Configure);
        }

    }
}

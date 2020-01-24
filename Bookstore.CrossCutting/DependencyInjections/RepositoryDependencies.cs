using Bookstore.Data.Context;
using Bookstore.Data.Repository;
using Bookstore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.CrossCutting.DependencyInjections
{
    public class RepositoryDependencies
    {
        public static void ConfigureRepositoryDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IAuthorRepository, AuthorRepository>();
            serviceCollection.AddScoped<IGenreRepository, GenreRepository>();
            serviceCollection.AddScoped<IBookRepository, BookRepository>();
            serviceCollection.AddDbContext<SqlContext>(
                options => options.UseSqlServer("Server=localhost,11433;Database=BookStore;Uid=SA;Pwd=DockerSql2017!;")
                );
        }
    }
}

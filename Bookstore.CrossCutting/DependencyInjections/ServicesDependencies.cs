using Bookstore.Domain.Interfaces;
using Bookstore.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.CrossCutting.DependencyInjections
{
    public class ServicesDependencies
    {
        public static void ConfigureServicesDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            serviceCollection.AddScoped<IAuthorService, AuthorService>();
            serviceCollection.AddScoped<IGenreService, GenreService>();
            serviceCollection.AddScoped<IBookService, BookService>();
        }
    }
}

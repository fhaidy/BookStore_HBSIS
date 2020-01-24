using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;

namespace Bookstore.Service.Service
{
    public class GenreService : BaseService<Genre>, IGenreService
    {
        public GenreService(IGenreRepository rep) :base(rep)
        {

        }
    }
}

using GigHub_BC5.Models;
using System.Collections.Generic;

namespace GigHub_BC5.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetGenres();
    }
}

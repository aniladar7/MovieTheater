using NetCoreMovieTheater.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMovieTheater.Models.Repository
{
    public interface IMovieGenderRepository
    {
        void MovieCategories(int movieId, List<int> categoriesId);

        List<MovieGenre> GetMovieGenres(int Id);
    }
}

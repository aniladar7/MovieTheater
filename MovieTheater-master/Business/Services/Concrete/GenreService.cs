using Business.Services.Abstract;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services.Concrete
{
    public class GenreService : BaseRepository<Genre>, IGenreService
    {
        public List<Genre> GetGenresByMovieId(int movieId)
        {
            using (var context = new ApplicationDbContext())
            {
                var list = context.MovieGenres.Where(x => x.MovieId == movieId).ToList();
                var genreList = new List<Genre>();
                foreach (var item in list)
                {
                    var genre = context.Genres.Find(item.GenreId);
                    genreList.Add(genre);
                }

                return genreList;
            }
        }
    }
}

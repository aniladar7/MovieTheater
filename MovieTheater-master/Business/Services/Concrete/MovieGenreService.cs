using Business.Services.Abstract;
using DataAccess.Context;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class MovieGenreService:BaseRepository<MovieGenre>,IMovieGenreService
    {
        public void AddMovieGenres(int movieId, List<int> categoriesId)
        {
            using var context = new ApplicationDbContext();
            foreach (var genreId in categoriesId)
            {
                context.MovieGenres.Add(new MovieGenre { MovieId = movieId, GenreId = genreId, CreatedDate = DateTime.Now });
                context.SaveChanges();
            }
        }
    }
}

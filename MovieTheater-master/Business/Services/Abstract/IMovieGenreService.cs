using Core.Repository;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Abstract
{
    public interface IMovieGenreService:IRepository<MovieGenre>
    {
        public void AddMovieGenres(int movieId, List<int> categoriesId);
    }
}

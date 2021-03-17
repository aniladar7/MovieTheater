using Business.Services.Abstract;
using DataAccess.Context;
using DataAccess.Entities;
using DataAccess.Entities.Dtos;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class MovieService : BaseRepository<Movie>, IMovieService
    {
        
    }
}

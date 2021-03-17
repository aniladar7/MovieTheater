using Core.Repository;
using DataAccess.Entities;
using DataAccess.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Abstract
{
    public interface IMovieService:IRepository<Movie>
    {
        
    }
}

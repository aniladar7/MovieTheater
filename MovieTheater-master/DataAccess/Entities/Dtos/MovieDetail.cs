using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities.Dtos
{
    public class MovieDetail
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public List<Genre> Genres { get; set; }
    }
}

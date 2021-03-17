using Business.Services.Abstract;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IMovieService movieService;
        private readonly IGenreService genreService;
        private readonly IMovieGenreService movieGenreService;

        public MovieController(IMovieService movieService, IGenreService genreService, IMovieGenreService movieGenreService)
        {
            this.movieService = movieService;
            this.genreService = genreService;
            this.movieGenreService = movieGenreService;
        }
        public IActionResult Index()
        {

            return View(movieService.GetAll());
        }

        public IActionResult AddMovie()
        {
            ViewBag.Genre = genreService.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie, List<int> genresId)
        {
            movieService.Add(movie);
            movieGenreService.AddMovieGenres(movie.Id, genresId);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveMovie(Movie movie)
        {
            movieService.Delete(movie);
            return RedirectToAction("Index");
        }

        public IActionResult GetMovie(int id)
        {
            var result = movieService.GetById(id);
            return View(result);
        }

        public IActionResult UpdateMovie(int id)
        {
            var selectedGenres = genreService.GetGenresByMovieId(id);
            var unSelectedGenres = genreService.GetListByFilter(x => !selectedGenres.Contains(x));
            var result = movieService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateMovie(Movie movie)
        {
            movieService.Update(movie);
            return RedirectToAction("Index");
        }
    }
}

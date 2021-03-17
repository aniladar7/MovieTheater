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
    public class GenreController : Controller
    {
        private readonly IGenreService genreService;

        public GenreController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        public IActionResult Index()
        {
            return View(genreService.GetAll());
        }

        public IActionResult AddGenre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddGenre(Genre genre)
        {
            genreService.Add(genre);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveGenre(int id)
        {
            var result = genreService.GetById(id);
            genreService.Delete(result);
            return RedirectToAction("Index");
        }

        public IActionResult GetGenre(Genre genre)
        {
            var result = genreService.GetById(genre.Id);
            return View(result);
        }

        public IActionResult UpdateGenre(int id)
        {
            var result = genreService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateGenre(Genre genre)
        {
            genreService.Update(genre);
            return RedirectToAction("Index");
        }
    }
}

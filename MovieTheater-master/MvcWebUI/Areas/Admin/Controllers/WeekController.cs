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
    public class WeekController : Controller
    {
        private readonly IWeekService weekService;

        public WeekController(IWeekService weekService )
        {
            this.weekService = weekService;
        }
        public IActionResult Index()
        {
            return View(weekService.GetAll());
        }

        public IActionResult AddWeek()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWeek(Week week)
        {
            weekService.Add(week);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveWeek(Week week)
        {
            weekService.Delete(week);
            return RedirectToAction("Index");
        }

        public IActionResult GetWeek(int id)
        {
            var result = weekService.GetById(id);
            return View(result);
        }

        public IActionResult UpdateWeek(int id)
        {
            var result = weekService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateWeek(Week week)
        {
            weekService.Update(week);
            return RedirectToAction("Index");
        }
    }
}

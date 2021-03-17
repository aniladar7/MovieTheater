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
    public class SalloonController : Controller
    {
        private readonly ISalloonService salloonService;

        public SalloonController(ISalloonService salloonService)
        {
            this.salloonService = salloonService;
        }
        public IActionResult Index()
        {
            return View(salloonService.GetAll());
        }

        public IActionResult AddSaloon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSaloon(Salloon salloon )
        {
            salloonService.Add(salloon);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveSaloon(Salloon salloon)
        {
            salloonService.Delete(salloon);
            return RedirectToAction("Index");
        }

        public IActionResult GetSaloon(int id)
        {
            var result = salloonService.GetById(id);
            return View(result);
        }

        public IActionResult UpdateSaloon(int id)
        {
            var result = salloonService.GetById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult UpdateSaloon(Salloon salloon)
        {
            salloonService.Update(salloon);
            return RedirectToAction("Index");
        }
    }
}

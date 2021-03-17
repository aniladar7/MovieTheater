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
    public class SessionController : Controller
    {
        private readonly ISessionService sessionService;

        public SessionController(ISessionService sessionService )
        {
            this.sessionService = sessionService;
        }
        public IActionResult Index()
        {
            return View(sessionService.GetAll());
        }

        public IActionResult AddSession()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSession(Session session )
        {
            sessionService.Add(session);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveSession(Session session)
        {
            sessionService.Delete(session);
            return RedirectToAction("Index");
        }

        public IActionResult GetSession(int id)
        {
            var result = sessionService.GetById(id);
            return View(result);
        }

        public IActionResult UpdateSession(int id)
        {
            var result = sessionService.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateSession(Session session)
        {
            sessionService.Update(session);
            return RedirectToAction("Index");
        }
    }
}

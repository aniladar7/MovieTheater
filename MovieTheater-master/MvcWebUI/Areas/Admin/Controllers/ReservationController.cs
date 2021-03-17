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
    public class ReservationController : Controller
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }
        public IActionResult Index()
        {
            return View(reservationService.GetAll());
        }

        public IActionResult AddReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            reservationService.Add(reservation);
            return RedirectToAction("Index");
        }

        public IActionResult RemoveReservation(Reservation reservation)
        {
            reservationService.Delete(reservation);
            return RedirectToAction("Index");
        }

        public IActionResult GetReservation(int id)
        {
            var result = reservationService.GetById(id);
            return View(result);
        }

        public IActionResult UpdateReservation(int id)
        {
            var result = reservationService.GetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateReservation(Reservation reservation)
        {
            reservationService.Update(reservation);
            return RedirectToAction("Index");
        }
    }
}

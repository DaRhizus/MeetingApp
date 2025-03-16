using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(){
            var saat = DateTime.Now.Hour;
            ViewData["Time"] = saat > 12 ? "İyi Günler" : "Günaydın";

            var meeting = new MeetingInfo();
            meeting.Id = 31;
            meeting.Name = "Oyunlarda cinsellik";
            meeting.Date = new DateTime(2025, 2, 25, 13, 0, 0);
            meeting.Location = "İstinye Park Avm";
            meeting.NumberOfPeople = (int?)TempData["Total"] != null ? (int?)TempData["Total"] : 0;
         return View(meeting); 
        }
    }
}
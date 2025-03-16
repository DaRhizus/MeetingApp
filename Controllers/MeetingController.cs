using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController:Controller
    {
        [HttpGet]
        public IActionResult Application(){
            return View();
        }

        [HttpGet]
        public IActionResult Participants(){
            var users = Repository.Users;
            return View(users);
        }

        [HttpPost]
        public IActionResult Application(UserInfo model){
            if(ModelState.IsValid){
                Repository.CreateUser(model);
                ViewBag.total = Repository._users.Where(x => x.Participate == true).Count();
                TempData["Total"] = ViewBag.total;
                return View("Thanks", model);
            } else{
                return View(model);
            }

        }

        public IActionResult Details(int? id){
            var user_1 = Repository.BringUserById(id);

            if(id == null){
                return RedirectToAction("Participants","Meeting");
            }

            return View(user_1);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            int hour = DateTime.Now.Hour;

            string message;

            if (hour >= 7 && hour < 12) {
                message = "Good Morning";
            } else if (hour >= 12 && hour < 20) {
                message = "Good Afternoon";
            } else {
                message = "Good Evening";
            }

            ViewBag.Message = message;

            return View();
        }

        //
        // GET: /Home/Rsvp
        [HttpGet]
        public ViewResult Rsvp() {
            return View();
        }

        //
        // POST: /Home/Rsvp
        [HttpPost]
        public ViewResult Rsvp(GuestResponse response) {
            if (ModelState.IsValid) {
                Repository.AddResponse(response);
                return View("Thanks", response);
            } else {
                // There are validation errors
                return View();
            }
        }

        public ViewResult GuestList() {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error() {
            return View();
        }
    }
}

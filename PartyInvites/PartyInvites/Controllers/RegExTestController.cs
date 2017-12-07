using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers {
    public class RegExTestController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return View();
        }

        [HttpPost]
        public ViewResult Index(RegExTestData model) {
            if (ModelState.IsValid) {
                return View("RegExOk");
            } else {
                // There are validation errors
                return View();
            }
        }

    }
}
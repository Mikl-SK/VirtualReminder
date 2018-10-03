using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VirtualReminder.Controllers
{
    public class ReminderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
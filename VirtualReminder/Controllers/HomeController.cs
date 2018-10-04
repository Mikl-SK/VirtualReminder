using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using VirtualReminder.Models;

namespace VirtualReminder.Controllers
{

	public class HomeController : Controller
	{
		[ViewData]
		public string PatientName { get; set; }


		public IActionResult Index(int id = 10000)
		{
			MockDatabase database = new MockDatabase();
			PatientName = database.GetPatient(id).ToString();
			var reminders = database.RetrieveAllReminders(id);
			return View(reminders);
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace VirtualReminder.Controllers
{
    public class UserProfileController : Controller
    {
        #region Properties
        private static UserProfileController _ControllerInstance { get; set; }

        #endregion


        #region Public Methods

        public static UserProfileController GetInstance()
        {
            if (_ControllerInstance == null)
            {
                _ControllerInstance = new UserProfileController();
            }

            return _ControllerInstance;
        }

        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
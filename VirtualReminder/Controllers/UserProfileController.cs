using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VirtualReminder.Models;

namespace VirtualReminder.Controllers
{
    public class UserProfileController : Controller
    {
        #region Properties
        private static UserProfileController _ControllerInstance { get; set; }

        #endregion

        #region Mock Data (Will be deleted later)

        string UserName = "Jens";
        string Password = "1234";

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


        public string CheckLogin(string UserName, string Password)
        {
            if (UserName == "Jens" && Password == "1234")
            {
                return "succes"; //More will be added later 
            }
            else
            {
                return "error"; //More will be added later 
            }
        }



        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
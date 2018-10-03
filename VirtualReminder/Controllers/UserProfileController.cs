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


        public void CheckLogin(string UserName, string Password)
        {
            if (UserName == "Jens") //Skal tjekke om username er i systemet
            {
                if (Password == "1234") //Skal tjekker om password matcher det username
                {
                    
                }
            }
            else
            {
                
            }
        }



        public IActionResult Index()
        {
            return View();
        }
        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
    public class UserProfile
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PatientName { get; set; }
        public string PatientFamilyName { get; set; }
        public int PatientAge { get; set; }
        #endregion
    }
}

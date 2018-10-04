using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
	public class Doctor : Person
	{
		public Doctor(string firstName, string lastName, string phoneNumber, string email) : 
			base(firstName, lastName, phoneNumber, email)
		{

		}

		public Doctor(int Id, string firstName, string lastName, string phoneNumber, string email) :
			base(Id, firstName, lastName, phoneNumber, email)
		{

		}

		public override string ToString()
		{
			return "Dr. " + base.ToString();
		}
	}
}

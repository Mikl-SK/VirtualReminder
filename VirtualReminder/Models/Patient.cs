using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
	public class Patient : Person
	{
		public Patient(string firstName, string lastName, string phoneNumber, string email) : 
			base(firstName, lastName, phoneNumber, email)
		{

		}

		public Patient(int Id, string firstName, string lastName, string phoneNumber, string email) :
			base(Id, firstName, lastName, phoneNumber, email)
		{

		}
	}
}

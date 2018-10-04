using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
	public abstract class Person : RepositoryElement
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public Person(string firstName, string lastName, string phoneNumber, string email)
		{
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;
		}

		public Person(int Id, string firstName, string lastName, string phoneNumber, string email)
		{
			ID = Id;
			FirstName = firstName;
			LastName = lastName;
			PhoneNumber = phoneNumber;
			Email = email;
		}

		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}
}

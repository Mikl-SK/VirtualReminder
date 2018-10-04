using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
	public class FamilyMember : Person
	{
		public FamilyMember(string firstName, string lastName, string phoneNumber, string email) :
			base(firstName, lastName, phoneNumber, email)
		{

		}

		public FamilyMember(int Id, string firstName, string lastName, string phoneNumber, string email) :
			base(Id, firstName, lastName, phoneNumber, email)
		{

		}
	}
}

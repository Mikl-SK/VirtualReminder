using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualReminder.Models
{
	public class MockDatabase
	{
		private int _universalId = 10000;
		private List<Reminder> _reminders = new List<Reminder>();
		private List<FamilyMember> _familyMembers = new List<FamilyMember>();
		private List<Doctor> _doctors = new List<Doctor>();
		private List<Patient> _patients = new List<Patient>();

		public MockDatabase()
		{
			Patient patient01 = new Patient(GenerateId(), "Timmy", "Nator", "21023025", "Terminator@mail.com");
			Patient patient02 = new Patient(GenerateId(), "Doug", "Bark", "99887766", "Wuff@mail.com");
			_patients.Add(patient01);
			_patients.Add(patient02);

			Doctor doctor01 = new Doctor(GenerateId(), "Phil", "McGraw", "43331708", "DrPhil@mail.com");
			Doctor doctor02 = new Doctor(GenerateId(), "John", "Dolittle", "12345678", "DrDolittle@mail.com");
			_doctors.Add(doctor01);
			_doctors.Add(doctor02);

			FamilyMember familyMember01 = new FamilyMember(GenerateId(), "Sarah", "Conner", "21523725", "Conner@mail.com");
			FamilyMember familyMember02 = new FamilyMember(GenerateId(), "Diane", "Bark", "99443322", "BarkBark@mail.com");
			_familyMembers.Add(familyMember01);
			_familyMembers.Add(familyMember02);


			Reminder reminder01a = new Reminder("Hey Tim! This is a reminder for your Doctor appointment with me today.",
				DateTime.Today, new TimeSpan(9, 30, 0), new TimeSpan(12, 0, 0), "Doctor Appointment", doctor01, patient01);
			Reminder reminder01b = new Reminder("Hi Dad, we will be visiting you for dinner. Can't wait to see you!",
				DateTime.Today, new TimeSpan(17, 30, 0), new TimeSpan(21, 0, 0), "Dinner with family", familyMember01, patient01);
			Reminder reminder02a = new Reminder("Hey Doug! This is a reminder for your Doctor appointment with me today.",
				DateTime.Today, new TimeSpan(8, 0, 0), new TimeSpan(11, 0, 0), "Doctor Appointment", doctor02, patient02);
			Reminder reminder02b = new Reminder("Hello Dad, at 7pm some news about Micheal from the office will be on!",
				DateTime.Today, new TimeSpan(19, 0, 0), new TimeSpan(20, 0, 0), "TV show - News", familyMember02, patient02);
			Reminder reminder02c = new Reminder("Hello Dad, at 9pm your favorite show will be on!",
				DateTime.Today, new TimeSpan(21, 0, 0), new TimeSpan(22, 0, 0), "TV show - NCIS", familyMember02, patient02);
			_reminders.Add(reminder01a);
			_reminders.Add(reminder01b);
			_reminders.Add(reminder02a);
			_reminders.Add(reminder02b);
			_reminders.Add(reminder02c);
			_reminders.Add(reminder02c);
			_reminders.Add(reminder02c);
			_reminders.Add(reminder02c);
			_reminders.Add(reminder02c);
			_reminders.Add(reminder02c);
		}

		public List<Reminder> RetrieveAllReminders(int userId)
		{
			List<Reminder> reminders = new List<Reminder>();
			Patient patient = GetPatient(userId);

			if (patient != null)
			{
				foreach(var reminder in _reminders)
				{
					if(reminder.CreatedFor == patient)
					{
						reminders.Add(reminder);
					}
				}
			}

			return reminders;
		}

		public Patient GetPatient(int userId)
		{
			return _patients.First(p => p.ID == userId);
		}


		private int GenerateId()
		{
			return _universalId++;
		}
	}
}

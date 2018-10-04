using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VirtualReminder.Models
{
	public class Reminder : RepositoryElement
	{
		public string Content { get; set; }

		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }

		[DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
		public TimeSpan StartTime { get; set; }

		[DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
		public TimeSpan EndTime { get; set; }
		public string Title { get; set; }
		public Person CreatedBy { get; set; }
		public Person CreatedFor { get; set; }

		public Reminder(string content, DateTime date, TimeSpan startTime, TimeSpan endTime, string title, Person createdBy, Person createdFor)
		{
			Content = content;
			Date = date;
			StartTime = startTime;
			EndTime = endTime;
			Title = title;
			CreatedBy = createdBy;
			CreatedFor = createdFor;
		}
	}
}

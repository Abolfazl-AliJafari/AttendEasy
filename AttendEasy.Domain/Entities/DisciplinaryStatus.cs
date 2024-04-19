using System;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities  
{
	public class DisciplinaryStatus : Entity<Guid>
	{
		public DisciplinaryStatus(DateTime date,
			DisciplinaryType type,
			DisciplinaryReason reason,
			Student student,
			string description = "")
		{

			Date = date;
			Type = type;
			Reason = reason;
			Student = student;
			Description = description;
		}

		public DateTime Date { get; init; }
		public DisciplinaryType Type { get; init; }
		public DisciplinaryReason Reason { get; private set; }
		public Student Student { get; init; }
		public string Description { get; private set; }



		public void ChangeReason(DisciplinaryReason reason)
		{
			Reason = reason;
		}
	}
}


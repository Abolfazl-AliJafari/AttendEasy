using System;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities
{
	public class AttendAndAbsenceStatus : Entity<Guid>
	{
		public AttendAndAbsenceStatus(DateTime date,
			DateTime time,
			Student student,
            AttendAndAbsenceType type,

			string description = ""
            ) :base(Guid.NewGuid())
		{
			Date = date;
			Time = time;
			Student = student;
			Type = type;
			Description = description;
		}

		public DateTime Date { get; init; }
		public DateTime Time { get; init; }
		public Student Student { get; init; }
        public AttendAndAbsenceType Type { get; private set; }
		public AttendAndAbsenceReason Reason { get; private set; }
		public string? Description { get; private set; }

		public void ChangeType(AttendAndAbsenceType type)
		{
			Type = type;
		}

		public void ChangeReason(AttendAndAbsenceReason reason)
		{
			Reason = reason;
		}

		public void ChangeDescription(string description)
		{
			Description = description;
		}
	}
}


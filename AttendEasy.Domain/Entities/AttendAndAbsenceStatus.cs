using System;
using System.ComponentModel.DataAnnotations.Schema;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities
{
	public class AttendAndAbsenceStatus : Entity<Guid>
	{
		public AttendAndAbsenceStatus(DateTime date,
			TimeSpan time,
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

		[Column(TypeName = "Date")]
		public DateTime Date { get; init; }
		[Column(TypeName = "Time(0)")]
		public TimeSpan Time { get; init; }
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


using System;
using System.ComponentModel.DataAnnotations.Schema;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities
{
	public class AttendAndAbsenceTraffic : Entity<Guid>
	{
		public AttendAndAbsenceTraffic(Student student,
			TrafficType type):
			base(Guid.NewGuid())
		{
			Student = student;
			Type = type;

		}

		[Column(TypeName = "Date")]
		public DateTime Date { get; init; }
		[Column(TypeName = "Time(0)")]
		public TimeSpan Time { get; set; }
		public Student Student { get; init; }
		public TrafficType Type { get; init; }
	}
}


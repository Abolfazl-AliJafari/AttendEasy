using System;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities
{
	public class AttendAndAbsenceReason : Entity<int>
	{
		public AttendAndAbsenceReason(int id,
			string title,
			float score,
			AttendAndAbsenceType type,
			string description = "") : base(id)
		{
			Title = title;
			Score = score;
			Type = type;
			Description = description;
		}

		public string Title { get; private set; }
		public float Score { get; private set; }
		public string? Description { get; private set; }
		public AttendAndAbsenceType Type { get; private set; }
		public IReadOnlyCollection<AttendAndAbsenceStatus> Statuses { get; }

		public void ChangeTitle(string title)
		{
			Title = title;
		}

		public void ChangeScore(float score)
		{
			Score = score;
		}

		public void ChangeDescription(string desccription)
		{
			Description = desccription;
		}
	}
}


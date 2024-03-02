using System;
using AttendEasy.Domain.Enumerations;

namespace AttendEasy.Domain.Entities
{
	public class DisciplinaryReason : Entity<int>
	{
		public DisciplinaryReason(int id,
			string title,
			float score,
			DisciplinaryType type,
			string description = "") :base(id)
		{
			Title = title;
			Score = score;
			Type = type;
			Description = description;
		}

		public string Title { get; private set; }
		public float Score { get; private set; }
		public string? Description { get; private set; }
		public DisciplinaryType Type { get; init; }
		public ICollection<DisciplinaryStatus> Statuses { get; }



		public void ChangeTitle(string title)
		{
			Title = title;
		}

		public void ChangeScore(float score)
		{
			Score = score;
		}

		public void ChangeDescription(string description)
		{
			Description = description;
		}
	}
}


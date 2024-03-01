using System;
namespace AttendEasy.Domain.Entities
{
	public class Role : Entity<int>
	{
		private readonly List<User> _users = new();
		public Role(int id,
			string title) : base(id)
		{
			Title = title;
		}

		public string Title { get; private set; }
		public IReadOnlyCollection<User> Users => _users;


		public void AddUser(User user)
		{
			_users.Add(user);
		}

		public void RemoveUser(User user)
		{
			_users.Remove(user);
		}
	}
}


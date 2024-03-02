using System;
namespace AttendEasy.Domain.Entities
{
	public class User : Entity<int>
	{
		public User(int id,
			string firstName,
			string lastName,
			string userName,
			string passWord) : base(id)
		{
			FirstName = firstName;
			LastName = lastName;
			UserName = userName;
			PassWord = passWord;
		}

		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string UserName { get; private set; }
		public string PassWord { get; private set; }


		public void ChangeFirstName(string firstName)
		{
			FirstName = firstName;
		}
        public void ChangeLastName(string lastName)
        {
            LastName = lastName;
        }
        public void ChangeUseName(string userName)
        {
            UserName = userName;
        }
        public void ChangePassWord(string newPassWord)
        {
            PassWord = newPassWord;
        }
    }
}


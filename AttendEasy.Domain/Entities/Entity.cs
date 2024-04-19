using System;
namespace AttendEasy.Domain.Entities
{

	public abstract class Entity<T> 
	{
		public Entity()
		{
			
		}
        public T Id { get; init; }
    }
}

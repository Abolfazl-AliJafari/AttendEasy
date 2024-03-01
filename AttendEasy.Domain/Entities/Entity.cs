using System;
namespace AttendEasy.Domain.Entities
{
	public abstract class Entity<T> 
	{
		public Entity(T id)
		{
			Id = id;
		}
        public T Id { get; init; }
    }
}

using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AttendEasy.Persistence.Contexts
{
	public class AttendEasyDbContext : DbContext
	{
		public AttendEasyDbContext(DbContextOptions<AttendEasyDbContext> options)
			:base(options)
		{
		}


		public DbSet<Student> Students { set; get; }
		public DbSet<Class> Classes { set; get; }
		public DbSet<Tag> Tags { set; get; }
		public DbSet<Level> Levels { set; get; }
		public DbSet<Field> Fields { set; get; }
		public DbSet<Role> Roles { set; get; }
		public DbSet<AttendAndAbsenceReason> AttendAndAbsenceReasons { set; get; }
		public DbSet<AttendAndAbsenceStatus> AttendAndAbsenceStatuses { set; get; }
		public DbSet<AttendAndAbsenceTraffic> AttendAndAbsenceTraffics { set; get; }
		public DbSet<DisciplinaryReason> DisciplinaryReasons { set; get; }
		public DbSet<DisciplinaryStatus> DisciplinaryStatuses { set; get; }
		public DbSet<User> Users { set; get; }
		public DbSet<Setting> Settings { set; get; }
    }
}


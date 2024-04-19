using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public StudentConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Student> builder)
        {
			builder.HasKey(s => s.Id);

			builder.Property(s => s.FirstName)
			.HasMaxLength(60).
			IsRequired(true).
			IsUnicode(true);

            builder.Property(s => s.LastName)
            .HasMaxLength(75).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.MobileNumber)
            .HasMaxLength(11).
            IsRequired(true);

            builder.Property(s => s.HomeNumber)
            .HasMaxLength(11).
            IsRequired(true);
            
			builder.Property(s => s.FatherJob)
			.HasMaxLength(120).
			IsRequired(true).
			IsUnicode(true);

            builder.Property(s => s.FatherMobile).
            HasMaxLength(11).
            IsRequired(true);

            builder.Property(s => s.FatherName).
            HasMaxLength(60).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.MotherJob)
            .HasMaxLength(120).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.MotherMobile)
            .HasMaxLength(11).
            IsRequired(true);

            builder.Property(s => s.NationalCode)
            .HasMaxLength(10).
            IsRequired(true);

            builder.Property(s => s.StudentCode)
            .HasMaxLength(11).
            IsRequired(true);

            builder.Property(s => s.Address)
            .HasMaxLength(int.MaxValue).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.BirthDayDate)
            .HasMaxLength(10).
            IsRequired(true);
            builder.Property(s => s.Class)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.LeftParent).
            IsRequired(true);

            builder.Property(s => s.DeadParent)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.Religion)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.Nationality)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.Profile)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.Description)
            .HasMaxLength(100).
            IsRequired(true).
            IsUnicode(true);

            builder.Property(s => s.Score).
            HasColumnType("Number").
            IsRequired(true);

        }
    }
}


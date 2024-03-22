using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class AttendAndAbsenceStatusConfiguration : IEntityTypeConfiguration<AttendAndAbsenceStatus>
	{
		public AttendAndAbsenceStatusConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<AttendAndAbsenceStatus> builder)
        {
            throw new NotImplementedException();
        }
    }
}


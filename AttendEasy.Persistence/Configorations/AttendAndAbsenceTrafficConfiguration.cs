using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class AttendAndAbsenceTrafficConfiguration : IEntityTypeConfiguration<AttendAndAbsenceTraffic>
	{
		public AttendAndAbsenceTrafficConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<AttendAndAbsenceTraffic> builder)
        {
            throw new NotImplementedException();
        }
    }
}


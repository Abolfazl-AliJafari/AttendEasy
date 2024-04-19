using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class AttendAndAbsenceReasonConfiguration : IEntityTypeConfiguration<AttendAndAbsenceReason>
	{
		public AttendAndAbsenceReasonConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<AttendAndAbsenceReason> builder)
        {
			builder.HasKey(a => a.Id);

			
        }
    }
}


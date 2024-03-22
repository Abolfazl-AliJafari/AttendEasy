using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class DisciplinaryReasonConfiguration : IEntityTypeConfiguration<DisciplinaryReason>
	{
		public DisciplinaryReasonConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<DisciplinaryReason> builder)
        {
            throw new NotImplementedException();
        }
    }
}


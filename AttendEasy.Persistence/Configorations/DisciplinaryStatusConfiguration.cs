using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class DisciplinaryStatusConfiguration  : IEntityTypeConfiguration<DisciplinaryStatus>
	{
		public DisciplinaryStatusConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<DisciplinaryStatus> builder)
        {
            throw new NotImplementedException();
        }
    }
}


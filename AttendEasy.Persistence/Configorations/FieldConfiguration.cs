using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class FieldConfiguration : IEntityTypeConfiguration<Field>
	{
		public FieldConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Field> builder)
        {
            throw new NotImplementedException();
        }
    }
}


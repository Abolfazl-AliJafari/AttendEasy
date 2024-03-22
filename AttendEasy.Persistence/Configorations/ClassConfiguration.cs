using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
	{
		public ClassConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Class> builder)
        {
            throw new NotImplementedException();
        }
    }
}


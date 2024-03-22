using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class RoleConfiguration : IEntityTypeConfiguration<Role>
	{
		public RoleConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            throw new NotImplementedException();
        }
    }
}


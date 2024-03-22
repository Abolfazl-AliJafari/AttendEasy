using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class SettingConfiguration : IEntityTypeConfiguration<Setting>
	{
		public SettingConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            throw new NotImplementedException();
        }
    }
}


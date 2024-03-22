using System;
using AttendEasy.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AttendEasy.Persistence.Configorations
{
	public class LevelConfiguration : IEntityTypeConfiguration<Level>
	{
		public LevelConfiguration()
		{
		}

        public void Configure(EntityTypeBuilder<Level> builder)
        {
            throw new NotImplementedException();
        }
    }
}


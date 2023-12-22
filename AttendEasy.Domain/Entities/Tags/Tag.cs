using AttendEasy.Domain.Entities.Tags.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Tags
{
    public class Tag
    {
        public Tag(Title title)
        {
            Id = Guid.NewGuid();
            if (title is null)
            {
                throw new ArgumentNullException("Tag Title Can Not Null.");
            }
            Title = title;
        }

        public Guid Id { get; set; }
        public Title Title{ get; set; }
    }
}

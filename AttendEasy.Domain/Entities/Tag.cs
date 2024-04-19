using AttendEasy.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities
{
    public class Tag : Entity<int>
    {
        public Tag(Title title)
        {

            if (title is null)
            {
                throw new ArgumentNullException("Tag Title Can Not Null.");
            }
            Title = title;
        }
        public Title Title{ get; set; }
    }
}

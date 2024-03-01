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
        [Required]
        [DisplayName("عنوان")]
        public Title Title{ get; set; }
    }
}

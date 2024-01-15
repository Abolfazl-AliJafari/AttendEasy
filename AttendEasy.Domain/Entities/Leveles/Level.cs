using AttendEasy.Domain.Entities.Leveles.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Leveles
{
    public class Level
    {
        public Level(Title title , LevelNumber levelNumber)
        {
            Id = Guid.NewGuid();
            if(title is null)
            {
                throw new ArgumentNullException("Level Title Can Not Null.");
            }
            if(levelNumber is null)
            {
                throw new ArgumentNullException("Level Number Can Not Null.");
            }
            Title= title;
            LevelNumber= levelNumber;
        }
        public Guid Id { get; set; }
        [Required]
        [DisplayName("عنوان")]
        public Title Title { get; set; }
        [DisplayName("شماره پایه")]
        public LevelNumber LevelNumber { get; set; }

    }
}

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
    public class Level : Entity<int>
    {
        public Level(Title title , LevelNumber levelNumber)
        {
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

        public Title Title { get; set; }

        public LevelNumber LevelNumber { get; set; }
        

    }
}

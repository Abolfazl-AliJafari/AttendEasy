using AttendEasy.Domain.Entities.Leveles.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Leveles
{
    public class Level
    {
        public Level()
        {

        }
        public Guid Id { get; set; }
        public Title Title { get; set; }
        public LevelNumber LevelNumber { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Enumerations
{
    public enum DeadParentStatus
    {
        None,
        Father,
        Mother,
        Both
    }
    public enum ScoreUpdateType
    {
        Plus,
        Mines
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class Score
    {
        public Score(byte value)
        {
            if (Validate(value))
                Value = value;
        }
        public byte Value { get; private set; } = 20;
        private bool Validate(byte value)
        {
            if (!CheckNumber(value))
                return false;
            return true;
        }

        private bool CheckNumber(byte value)
        {
            if(value < 0 || value > 20) return false;
            return true;
        }

        public static implicit operator byte(Score Score)
            => Score.Value;
        public static implicit operator Score(byte Value)
             => new(Value);
    }
}

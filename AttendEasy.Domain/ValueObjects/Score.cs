using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEasy.Domain.Helpers;

namespace AttendEasy.Domain.ValueObjects
{
    public class Score
    {
        public Score(float value)
        {
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public float Value { get; private set; } = 20;
        private Result Validate(float value)
        {
            using (var result = CheckNumber(value))
            {
                if (!result.Success)
                    return new Result(false, result.Message);
            }
            return new Result(true);
        }

        private Result CheckNumber(float value)
        {
            if(value < 0 || value > 20) return new Result(false,"Not Valid Score");
            return new Result(true);
        }

        public static implicit operator float(Score Score)
            => Score.Value;
        public static implicit operator Score(float Value)
             => new(Value);
    }
}

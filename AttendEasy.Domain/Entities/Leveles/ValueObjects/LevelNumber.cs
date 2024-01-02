using AttendEasy.Domain.Entities.Studentes.ValueObjects;
using AttendEasy.Domain.Helpers;

namespace AttendEasy.Domain.Entities.Leveles.ValueObjects
{
    public class LevelNumber
    {
        public LevelNumber(byte value)
        {
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new Exception(result.Message);
            }
        }
        public byte Value { get; private set; }
        private Result Validate(byte value)
        {
            using (var result = CheckNumber(value))
            {
                if (!result.Success)
                    return new Result(false, result.Message);
            }
            return new Result(true);
        }

        private Result CheckNumber(byte value)
        {
            if (value < 1 || value > 12) return new Result(false, "Not Valid Level");
            return new Result(true);
        }

        public static implicit operator byte(LevelNumber Score)
            => Score.Value;
        public static implicit operator LevelNumber(byte Value)
             => new(Value);
    }
}
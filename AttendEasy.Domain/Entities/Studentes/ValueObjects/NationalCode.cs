using AttendEasy.Domain.Helpers;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class NationalCode
    {
        public NationalCode(string value)
        {
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public string Value { get; } = string.Empty;
        private Result Validate(string value)
        {
            using (var result = CheckFormat(value))
            {
                if (!result.Success)
                    return new Result(false, result.Message);
            }
            return new Result(true);
        }

        private Result CheckFormat(string value)
        {
            throw new NotImplementedException();
        }


        public static implicit operator string(NationalCode NationalCode)
            => NationalCode.Value;
        public static implicit operator NationalCode(string Value)
             => new(Value);
    }
}
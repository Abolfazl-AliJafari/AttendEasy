namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class StudentCode
    {
        public StudentCode(string value)
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

        public static implicit operator string(StudentCode StudentCode)
            => StudentCode.Value;
        public static implicit operator StudentCode(string Value)
             => new(Value);
    }
}
namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class LastName
    {
        public LastName(string value)
        {
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }

        }

        public string Value { get; set; } = string.Empty;
        private Result Validate(string value)
        {
            using (var result = CheckLanguage(value))
            {
                if (!result.Success)
                    return new Result(false, result.Message);
            }
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

        private Result CheckLanguage(string value)
        {
            throw new NotImplementedException();
        }

        public static implicit operator string(LastName LastName)
            => LastName.Value;
        public static implicit operator LastName(string Value)
             => new(Value);
    }
}

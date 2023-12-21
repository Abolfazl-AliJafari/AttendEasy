namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class FirstName
    {
        public FirstName(string value)
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
                    return new Result(false,result.Message);
            }
            using (var result = CheckFormat(value))
            {
                if (!result.Success)
                    return new Result(false,result.Message);
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

        public static implicit operator string(FirstName FirstName)
            => FirstName.Value;
        public static implicit operator FirstName(string Value)
             => new(Value);
    }
}

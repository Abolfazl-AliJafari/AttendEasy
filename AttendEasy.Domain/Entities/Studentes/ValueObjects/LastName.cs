namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class LastName
    {
        public LastName(string value)
        {
            if (Validate(value))
                Value = value;

        }

        public string Value { get; private set; } = string.Empty;
        private bool Validate(string value)
        {
            if (!CheckLanguage(value))
                return false;
            if (!CheckFormat(value))
                return false;
            return true;
        }

        private bool CheckFormat(string value)
        {
            throw new NotImplementedException();
        }

        private bool CheckLanguage(string value)
        {
            throw new NotImplementedException();
        }

        public static implicit operator string(LastName LastName)
            => LastName.Value;
        public static implicit operator LastName(string Value)
             => new(Value);
    }
}

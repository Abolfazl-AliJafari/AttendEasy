namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class NationalCode
    {
        public NationalCode(string value)
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

        public static implicit operator string(NationalCode NationalCode)
            => NationalCode.Value;
        public static implicit operator NationalCode(string Value)
             => new(Value);
    }
}
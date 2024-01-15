using AttendEasy.Domain.Helpers;
using AttendEasy.Domain.Utilities;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class NationalCode
    {
        public NationalCode(string value)
        {
            using (var result = Validations.CheckValidFormatNationalCode(nameof(NationalCode),value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public string Value { get; } = string.Empty;


        public static implicit operator string(NationalCode NationalCode)
            => NationalCode.Value;
        public static implicit operator NationalCode(string Value)
             => new(Value);
    }
}
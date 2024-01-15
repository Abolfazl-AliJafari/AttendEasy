using AttendEasy.Domain.Helpers;
using AttendEasy.Domain.Utilities;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class StudentCode
    {
        public StudentCode(string value)
        {
            using (var result = Validations.CheckValidFormatNationalCode(nameof(StudentCode),value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public string Value { get; } = string.Empty;

        public static implicit operator string(StudentCode StudentCode)
            => StudentCode.Value;
        public static implicit operator StudentCode(string Value)
             => new(Value);
    }
}
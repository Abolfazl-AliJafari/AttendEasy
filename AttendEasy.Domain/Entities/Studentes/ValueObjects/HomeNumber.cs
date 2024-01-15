using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEasy.Domain.Helpers;
using AttendEasy.Domain.Utilities;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class HomeNumber
    {
        public HomeNumber(string value)
        {
            using (var result = Validations.CheckValidFormatPhoneNumber(nameof(MobileNumber), value))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public string Value { get; set; } = string.Empty;

        public static implicit operator string(HomeNumber HomeNumber)
            => HomeNumber.Value;
        public static implicit operator HomeNumber(string Value)
             => new(Value);
    }
}

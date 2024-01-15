using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEasy.Domain.Helpers;
using AttendEasy.Domain.Utilities;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class MobileNumber
    {
        public MobileNumber(string value)
        {
            using (var result = Validations.CheckValidFormatPhoneNumber(nameof(MobileNumber),value,true))
            {
                if (result.Success)
                    Value = value;
                throw new ArgumentException(result.Message);
            }
        }
        public string Value { get; set; } = string.Empty;


        public static implicit operator string(MobileNumber MobileNumber)
            => MobileNumber.Value;
        public static implicit operator MobileNumber(string Value)
             => new(Value);
    }
}

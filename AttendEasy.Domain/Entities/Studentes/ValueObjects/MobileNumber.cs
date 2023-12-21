using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class MobileNumber
    {
        public MobileNumber(string value)
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
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new Exception(result.Message);
            }
        }

        private Result CheckFormat(string value)
        {
            throw new NotImplementedException();
        }


        public static implicit operator string(MobileNumber MobileNumber)
            => MobileNumber.Value;
        public static implicit operator MobileNumber(string Value)
             => new(Value);
    }
}

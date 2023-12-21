using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class HomeNumber
    {
        public HomeNumber(string value)
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

        public static implicit operator string(HomeNumber HomeNumber)
            => HomeNumber.Value;
        public static implicit operator HomeNumber(string Value)
             => new(Value);
    }
}

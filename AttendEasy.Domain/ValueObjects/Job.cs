using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEasy.Domain.Helpers;

namespace AttendEasy.Domain.ValueObjects
{
    public class Job
    {
        public Job(string value)
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

        public static implicit operator string(Job Job)
            => Job.Value;
        public static implicit operator Job(string Value)
             => new(Value);
    }
}

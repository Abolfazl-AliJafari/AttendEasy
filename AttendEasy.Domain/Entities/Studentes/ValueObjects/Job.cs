using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Entities.Studentes.ValueObjects
{
    public class Job
    {
        public Job(string value)
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

        public static implicit operator string(Job Job)
            => Job.Value;
        public static implicit operator Job(string Value)
             => new(Value);
    }
}

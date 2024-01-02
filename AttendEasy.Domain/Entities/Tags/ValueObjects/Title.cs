using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEasy.Domain.Helpers;

namespace AttendEasy.Domain.Entities.Tags.ValueObjects
{
    public class Title
    {
        public Title(string value)
        {
            using (var result = Validate(value))
            {
                if (result.Success)
                    Value = value;
                throw new Exception(result.Message);
            }
        }
        public string Value { get; private set; } = string.Empty;
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

        public static implicit operator string(Title Title)
            => Title.Value;
        public static implicit operator Title(string Value)
             => new(Value);
    }
}

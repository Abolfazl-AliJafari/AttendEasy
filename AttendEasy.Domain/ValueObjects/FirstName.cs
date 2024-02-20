using System.Text.RegularExpressions;
using AttendEasy.Domain.Helpers;
using AttendEasy.Domain.Utilities;

namespace AttendEasy.Domain.ValueObjects
{
    public class FirstName
    {
        public FirstName(string value)
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
            using (var result = Validations.CheckWhiteSpaceOrEmpty(nameof(FirstName),value))
            {
                if (!result.Success)
                    return new Result(false, result.Message);
            }
            //using (var result = CheckFormat(value))
            //{
            //    if (!result.Success)
            //        return new Result(false, result.Message);
            //}
            using (var result = Validations.CheckPersianLanguage(nameof(FirstName), value))
            {
                if (!result.Success)
                    return new Result(false,result.Message);
            }

            return new Result(true);
        }

        //private Result CheckFormat(string value)
        //{
        //    foreach (char @char in value)
        //    {
        //        if(@char is ' ')
        //        {

        //        }
        //    }
        //}

      

        public static implicit operator string(FirstName FirstName)
            => FirstName.Value;
        public static implicit operator FirstName(string Value)
             => new(Value);
    }
}

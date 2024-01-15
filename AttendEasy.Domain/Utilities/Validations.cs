using AttendEasy.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Utilities
{
    public static class Validations
    {
        public static Result CheckPersianLanguage(string fieldName,string value)
        {
            if (!Regex.IsMatch(value, @"^[\u0600-\u06FF\s]+$"))
            {
                return new Result(false, $"{ fieldName } Language Just Can Persian.");
            }
            return new Result(true);
        }
        public static Result CheckWhiteSpaceOrEmpty(string fieldName, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new Result(false, $"{ fieldName } Can Not Be Null Or Empty.");
            }
            if (string.IsNullOrWhiteSpace(value))
            {
                return new Result(false, $"{ fieldName }Name Can Not Be Null Or WhiteSpace.");
            }
            return new Result(true);
        }
        public static Result CheckLengthNumber(string fieldName,int length,string value)
        {
            if(value.Length != length)
            {
                return new Result(false,$"The {fieldName} Must Be Entered With The Correct Length; Correct Length : {length} .");
            }
            return new Result(true);
        }
        public static Result CheckValidDigitNumber(string fieldName, string value)
        {
            if (!long.TryParse(value, out long num))
            {
                return new Result(false, $"The {fieldName} Just Can Number.");
            }
            return new Result(true);
        }
        public static Result CheckValidFormatPhoneNumber(string fieldName, string value, bool isMobile = false)
        {
            if (isMobile)
            {
                if (!Regex.IsMatch(value, ("^09[0-9]{9}$")))
                {
                    return new Result(false, $"Pleaze Enter {fieldName} With Correct Format.");
                }
            }
            else
            {
                if (!Regex.IsMatch(value, ("^0[0-9]{10}$")))
                {
                    return new Result(false, $"Pleaze Enter {fieldName} With Correct Format.");
                }
            }
            return new Result(true);
        }
        public static Result CheckValidFormatNationalCode(string fieldName,string value)
        {
            if (!Regex.IsMatch(value, "^[0-9]{10}$"))
            {
                return new Result(false, $"Pleaze Enter {fieldName} With Correct Format.");
            }
            return new Result(true);
        }
    }
}

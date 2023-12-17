using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain
{
    public class Result
    {
        public Result(bool success, string? message = "")
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string? Message { get; set; }
    }
    public class Result<Generic> : Result
    {
        public Result(bool success, Generic data, string? message = "") : base(success, message)
        {
            Data= data;
        }
        public Generic Data{ get; set; }
    }
}

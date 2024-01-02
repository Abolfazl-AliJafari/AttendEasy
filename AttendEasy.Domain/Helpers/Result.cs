using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Domain.Helpers
{
    public class Result : IDisposable
    {
        public Result(bool success, string? message = "")
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string? Message { get; set; }

        public void Dispose()
        {
            Success = false;
            Message = null;
        }
    }
    public class Result<Generic> : Result
    {
        public Result(bool success, Generic data, string? message = "") : base(success, message)
        {
            Data = data;
        }
        public Generic Data { get; set; }
    }
}

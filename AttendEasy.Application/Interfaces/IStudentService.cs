using AttendEasy.Domain.Entities.Studentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Application.Interfaces
{
    public interface IStudentService
    {
        List<Student> GetList();
    }
}

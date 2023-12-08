using AttendEasy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Application.Interfaces
{
    public interface IStudentRepository
    {
        List<Student> GetList();
    }
}

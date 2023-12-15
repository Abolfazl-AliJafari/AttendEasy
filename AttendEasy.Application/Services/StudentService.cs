using AttendEasy.Application.Interfaces;
using AttendEasy.Domain.Entities.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEasy.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository StudentRepository)
        {
            _studentRepository = StudentRepository;
        }
        public List<Student> GetList()
        {
            return _studentRepository.GetList();
        }

    }
}
